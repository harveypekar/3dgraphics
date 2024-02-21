
import os
import sys
import cairo



if __name__ == '__main__':
    if not cairo.HAS_SVG_SURFACE:
        raise SystemExit('cairo was not compiled with SVG support')
    
    filename = "foo.svg"
    w = 256
    h = 256
    surface = cairo.SVGSurface(filename, w, h)
    