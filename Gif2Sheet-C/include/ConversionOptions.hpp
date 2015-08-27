#ifndef _CONVERSION_OPTIONS_H_
#define _CONVERSION_OPTIONS_H_

#include "Color.hpp"

using namespace std;

class ConversionOptions {
public:
	ConversionOptions() : SourceTransparentColor(0,0,0,0), TargetTransparentColor(0,0,0,0), DeltaColor(0,0,0,0), DeltaX(0), DeltaY(0) { };
	Color SourceTransparentColor;
	Color TargetTransparentColor; 
	Color DeltaColor;
	int DeltaX;
	int DeltaY;
	int HorizontalTiles;
	vector<int> TransparentInferPos;
	bool hasSourceTransparentColor;
	string OutputFileName;
};

#endif