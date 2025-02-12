---
title: Exporting SHX fonts
type: docs
weight: 40
url: /net/developer-guide/export-shx-fonts/
---

## **Export SHX fonts for DXF/DWG drawings**

Some drawings may contain fonts in special SHX format, that stores symbols of the font in a form of shapes. This format requires additional
loading procedure for each font used in the drawing. Apose.CAD can export drawings with text written in SHX and has different options to do this. The simplest way to do it just use 
[**ShxFonts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/shxfonts/) property of 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) object.
				

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts example.cs">}}


It is possible to avoid setting up all paths to multiple SHX fonts with the following example:

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts with folder example.cs">}}
	
Each SHX font comes with the proper codepage associated to it. These associations are known and partially embedded into the Aspose.CAD for known SHX fonts.
In the case some custom SHX font is used it is possible to apply ShxCodePages property and set up path to SHX file and corresponding code page. 
	
{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxCodePages example.cs">}}

