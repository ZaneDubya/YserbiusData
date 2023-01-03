This is an export of some of the resources distributed with the Imagination Network version 2.4 client.

Included:
- PIC: 320x190, 256 color backgrounds, in PNG format. Because the order of colors in the palette can be important, each PIC is accompanied by a palette file that displays the colors used in the picture in its original order.
- VIEW: Sprites used throughout the program, in PNG format, one PNG per VIEW. VIEW resources can include multiple sprites, comprised of animation loops, with each loop containing one or animation cels. The placement of these sub-sprites within the PNG are indicated in an accompanying txt file. If a VIEW had an internal palette, then the sprites have been exported in their original colors, and the palette is included as with PIC resources. If the VIEW did not have an internal palette, then the sprite has been exported with the default SCI palette, where the bottom 64 colors are shared with all PIC and VIEW palettes, and the remaining 192 colors are encoded as rgb=(42,69,index).
- FONT: monochrome sprite fonts, each composed of 128 characters, in PNG format, one PNG per FONT. The characters are rendered in original order. The placement of the characters within the PNG are indicated in an accompanying txt file.
- TEXT: Strings that are displayed by a LSCI script, in TXT format. The strings within the TXT files are enclosed within quote characters ("); internal quote characters are prefixed with a backslash (\").

Not included:
- SOUND/PATCH files: music, sound samples, and instrument definitions.
- VOCAB files: defines for scripts, possibly processing data for the VM's NLP prompt.
- SCRIPT files: the logic behind the game! Interpreted by the LSCI VM.