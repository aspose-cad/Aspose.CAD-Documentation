---
title: Exporting SHX fonts
type: docs
weight: 40
url: /java/export-shx-fonts/
---

## **Export SHX fonts for DXF/DWG drawings**

Some drawings may contain fonts in special SHX format, that stores symbols of the font in a form of shapes.
This format requires additional loading procedure for each font used in the drawing.
Apose.CAD can export drawings with text written in SHX and has different options to do this.
The simplest way to do it just use [**setShxFonts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setShxFonts-java.lang.String:A-)
property of [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) object.	

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxFonts-example.java">}}

Each SHX font comes with the proper codepage associated to it. These associations are known and partially embedded into the Aspose.CAD for known SHX fonts.
In the case some custom SHX font is used it is possible to apply **setShxCodePages** property and set up path to SHX file and corresponding code page.
	
{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxCodePages-example.java">}}

