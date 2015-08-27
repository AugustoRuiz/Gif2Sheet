# gif2sheet

**gif2Sheet** now as a command line tool! And now it's really *fast*, and *multi-platform*! 

gif2sheet - (c) 2008-2015 Retroworks.

## USAGE

gif2sheet [OPTIONS] fileName

## OPTIONS


Switch | Explanation |
-------|-------------|
-dC _or_ -dc _or_ --deltaColor ARG | Color to apply to whitespace. RGB values must be specified as 0xAARRGGBB, or as an int value.
-dX _or_ -dx _or_ --deltaX ARG | Specified whitespace to leave between frames horizontally. Defaults to zero.
-dY _or_ -dy _or_ --deltaY ARG | Specified whitespace to leave between frames vertically. Defaults to zero.
-hT _or_ -ht _or_ --horizontalTiles ARG | Number of frames to display horizontally. Defaults to zero (meaning all frames in one row).
-o _or_ --outputFileName ARG | Output file name. Default value is sheet.png.
-oT _or_ -ot _or_ --outputTransparentColor ARG | Specifies target transparent color. RGB values must be specified as 0xAARRGGBB, or as an int value.
-sT _or_ -st _or_ --sourceTransparentColor ARG | Specifies source transparent color. RGB values must be specified as 0xAARRGGBB, or as an int value.
-tI _or_ -ti _or_ --transparentInfer x,y | Use the color from the pixel at x,y to infer transparent color.
--help | Help. Show usage.

##EXAMPLES

gif2sheet -o animationSheet.png animation.gif

If you liked this program, drop an email at: augusto DOT ruiz AT gmail
