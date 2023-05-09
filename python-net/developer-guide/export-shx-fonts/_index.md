---
title: Exporting SHX fonts
type: docs
weight: 40
url: /python-net/export-shx-fonts/
---

## **Export SHX fonts for DXF/DWG drawings**

Some drawings may contain fonts in special SHX format, that stores symbols of the font in a form of shapes. This format requires additional
loading procedure for each font used in the drawing. Apose.CAD can export drawings with text written in SHX and has different options to do this. The simplest way to do it just use 
**ShxFonts** property of 
**CadRasterizationOptions** object.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ShxFonts.py" >}}
