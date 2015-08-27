#ifndef _IMG2CPC_H_
#define _IMG2CPC_H_

#include <iostream>
#include <string>
#include <FreeImage.h>
#include <json/json.h>
#include "ezOptionParser.hpp"
#include "ConversionOptions.hpp"

using namespace std;
using namespace ez;

int initializeParser(ezOptionParser &parser);
void showUsage(ezOptionParser &options);

Color extractColor(ezOptionParser &options, string flag);
int extractConversionOptions(ezOptionParser &options, ConversionOptions &convOptions);

int initializeImageLoader();
int cleanupImageLoader();
int processImage(const string& filename, ConversionOptions &options);

RGBQUAD RGBQUADfromColor(const Color &color);

int main(int argc, const char** argv);

#endif