#include "gif2sheet.hpp"

int initializeParser(ezOptionParser &parser) {
	parser.overview = "gif2sheet - (c) 2008-2015 Retroworks.";
	parser.syntax = "gif2sheet [OPTIONS] fileName";
	parser.example = "gif2sheet -o animationSheet.png animation.gif\n";
	parser.footer = "If you liked this program, drop an email at: augusto.ruiz@gmail.com\n";

	parser.add("sheet.png", 0, 1, 0, "Output file name. Default value is sheet.png.", "-o", "--outputFileName");
	parser.add("", 0, 1, 0, "Specifies source transparent color. RGB values must be specified as 0xAARRGGBB, or as an int value.", "-st", "-sT", "--sourceTransparentColor");
	parser.add("", 0, 1, 0, "Specifies target transparent color. RGB values must be specified as 0xAARRGGBB, or as an int value.", "-ot", "-oT", "--outputTransparentColor");
	parser.add("", 0, 1, ',', "Specifies coordinates to use to infer transparent color.", "-ti", "-tI", "--transparentInfer");
	parser.add("0", 0, 1, 0, "Specified whitespace to leave between frames horizontally. Defaults to zero.", "-dX", "-dx", "--deltaX");
	parser.add("0", 0, 1, 0, "Specified whitespace to leave between frames vertically. Defaults to zero.", "-dY", "-dy", "--deltaY");
	parser.add("0", 0, 1, 0, "Number of frames to display horizontally. Defaults to all.", "-ht", "-hT", "--horizontalTiles");
	parser.add("", 0, 1, 0, "Color to apply to whitespace. RGB values must be specified as 0xAARRGGBB, or as an int value.", "-dC", "-dc", "--deltaColor");
	parser.add("", 0, 0, 0, "Help. Show usage.", "--help");

	return 0;
}

void showUsage(ezOptionParser &options) {
	string usage;
	options.getUsage(usage);
	cout << usage << endl;
}

int initializeImageLoader() {
	FreeImage_Initialise();
	return 0;
}

int cleanupImageLoader() {
	FreeImage_DeInitialise();
	return 0;
}

Color extractColor(ezOptionParser &options, string flag) {
	Color result(0, 0, 0, 0);
	if (options.isSet(flag)) {
		string value;
		options.get(flag.c_str())->getString(value);
		unsigned long intValue = strtoul(value.c_str(), nullptr, 0);
		result = Color(
			(unsigned char)((intValue & 0xFF000000) >> 24), // A
			(unsigned char)((intValue & 0xFF0000) >> 16),   // R
			(unsigned char)((intValue & 0xFF00) >> 8),      // G
			(unsigned char)(intValue & 0xFF)                // B
			);
	}
	return result;
}

int extractConversionOptions(ezOptionParser &options, ConversionOptions &convOptions) {
	convOptions.DeltaColor = extractColor(options, "-dC");
	options.get("-o")->getString(convOptions.OutputFileName);
	options.get("-ht")->getInt(convOptions.HorizontalTiles);
	options.get("-dX")->getInt(convOptions.DeltaX);
	options.get("-dY")->getInt(convOptions.DeltaY);
	if (options.isSet("-st")) {
		convOptions.SourceTransparentColor = extractColor(options, "-st");
		convOptions.hasSourceTransparentColor = true;
	}
	else {
		if (options.isSet("-ti")) {
			options.get("-ti")->getInts(convOptions.TransparentInferPos);
			if (convOptions.TransparentInferPos.size() != 2) {
				cout << "Error: Couldn't parse (x,y) coordinate to infer transparent color." << endl;
				return -1;
			}
			convOptions.hasSourceTransparentColor = true;
		}
		else {
			cout << "Warning: No source transparency color defined.";
		}
	}
	convOptions.TargetTransparentColor = extractColor(options, "-ot");

	return 0;
}

int processImage(const string& filename, ConversionOptions &convOptions) {
	int result = 0;
	const char* fileNamePtr = filename.c_str();
	FREE_IMAGE_FORMAT fmt = FreeImage_GetFileType(fileNamePtr);
	FIMULTIBITMAP *sourceImg = NULL;
	int flags;
	if (fmt == FIF_GIF) {
		flags = GIF_PLAYBACK;
	}
	else if (fmt == FIF_ICO) {
		flags = ICO_MAKEALPHA;
	}
	else if ((fmt == FIF_TIFF) || (fmt == FIF_MNG)) {
		flags = 0;
	}
	else {
		cout << "Error! The file " << filename << " is not a valid image type. GIF, ICO, MNG and TIFF are supported." << endl;
		return -1;
	}
	sourceImg = sourceImg = FreeImage_OpenMultiBitmap(fmt, fileNamePtr, FALSE, TRUE, TRUE, flags);

	int count = FreeImage_GetPageCount(sourceImg);
	if (count == 0) {
		cout << "Error! The file " << filename << " has no frames." << endl;
		result = -1;
	}
	else {
		int tilesX = (convOptions.HorizontalTiles == 0) ? count : convOptions.HorizontalTiles;
		int tilesY = (int)ceil(count / (double)tilesX);

		FIBITMAP *currentFrame = FreeImage_LockPage(sourceImg, 0);

		if (convOptions.hasSourceTransparentColor && convOptions.TransparentInferPos.size() == 2) {
			RGBQUAD pixel;
			FreeImage_GetPixelColor(currentFrame, convOptions.TransparentInferPos[0], convOptions.TransparentInferPos[1], &pixel);
			convOptions.SourceTransparentColor = Color(pixel.rgbReserved, pixel.rgbRed, pixel.rgbGreen, pixel.rgbBlue);
		}

		int frameWidth = FreeImage_GetWidth(currentFrame);
		int frameHeight = FreeImage_GetHeight(currentFrame);
		int targetWidth = ((tilesX + 1) * convOptions.DeltaX) + (tilesX * frameWidth);
		int targetHeight = ((tilesY + 1) * convOptions.DeltaY) + (tilesY * frameHeight);

		FreeImage_UnlockPage(sourceImg, currentFrame, FALSE);

		FIBITMAP *target = FreeImage_AllocateExT(FIT_BITMAP, targetWidth, targetHeight, 32, 
			&RGBQUADfromColor(convOptions.DeltaColor), FI_COLOR_IS_RGBA_COLOR);

		int currentTile = 0;
		int posX = convOptions.DeltaX;
		int posY = convOptions.DeltaY;
		do {
			currentFrame = FreeImage_LockPage(sourceImg, currentTile);

			if (convOptions.hasSourceTransparentColor) {
				FreeImage_ApplyColorMapping(currentFrame,
					&RGBQUADfromColor(convOptions.SourceTransparentColor),
					&RGBQUADfromColor(convOptions.TargetTransparentColor),
					1, FALSE, FALSE);
			}

			FreeImage_Paste(target, currentFrame, posX, posY, 256);
			++currentTile;
			if (0 == (currentTile % tilesX)) {
				posX = convOptions.DeltaX;
				posY += frameHeight + convOptions.DeltaY;
			}
			else {
				posX += frameWidth + convOptions.DeltaX;
			}
			FreeImage_UnlockPage(sourceImg, currentFrame, FALSE);
		} while (currentTile < count);

		FreeImage_Save(FIF_PNG, target, convOptions.OutputFileName.c_str(), PNG_DEFAULT);

		FreeImage_Unload(target);
	}
	FreeImage_CloseMultiBitmap(sourceImg);
	return result;
}

RGBQUAD RGBQUADfromColor(const Color &col) {
	RGBQUAD result;
	result.rgbReserved = col.A;
	result.rgbRed = col.R;
	result.rgbGreen = col.G;
	result.rgbBlue = col.B;
	return result;
}

int main(int argc, const char** argv)
{
	if (initializeImageLoader()) {
		return -1;
	}
	ezOptionParser options;
	if (initializeParser(options)) {
		return -1;
	}

	options.parse(argc, argv);

	if (options.isSet("--help")) {
		showUsage(options);
		return 0;
	}

	ConversionOptions convOptions;
	if (extractConversionOptions(options, convOptions)) {
		return -1;
	}

	vector<string *> &lastArgs = options.lastArgs;
	for (long int i = 0, li = lastArgs.size(); i < li; ++i) {
		string filename = *lastArgs[i];
		int result = processImage(filename, convOptions);
		if (result) {
			cout << "Error processing image: " << filename << endl;
			return result;
		}
	}

	if (cleanupImageLoader()) {
		return -1;
	}

	return 0;
}