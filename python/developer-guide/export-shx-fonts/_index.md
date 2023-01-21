---
title: Exporting SHX fonts
type: docs
weight: 40
url: /python/export-shx-fonts/
---

## **Export SHX fonts for DXF/DWG drawings**

Some drawings may contain fonts in special SHX format, that stores symbols of the font in a form of shapes. This format requires additional
loading procedure for each font used in the drawing. Apose.CAD can export drawings with text written in SHX and has different options to do this. The simplest way to do it just use 
**ShxFonts** property of 
**CadRasterizationOptions** object.
				
import aspose.cad as cad

image = cad.Image.load(...)
rasterizationOptions = cad.imageoptions.CadRasterizationOptions() 
rasterizationOptions.shx_fonts = ["txt.shx", "romans.shx"]

//export
{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts example.cs">}}
