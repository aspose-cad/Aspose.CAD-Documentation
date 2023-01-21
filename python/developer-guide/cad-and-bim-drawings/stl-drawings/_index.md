---
title: STL Drawings
type: docs
weight: 100
url: /python/stl-drawings/
---

## **Exporting STL Format To PNG**

Aspose.CAD for Python allows developers to export an STL file to PNG. Following is the code demonstrating how to access the STL file and convert that to PNG using **CadRasterizationOption** and **PngOptions**.

## Sample Code

import aspose.cad as cad;

if name == 'main': 
    cadImage = cad.Image.load("file.stl");

rasterizationOptions = cad.imageoptions.CadRasterizationOptions()
rasterizationOptions.page_width = 1200
rasterizationOptions.page_height = 1200

pngOptions = cad.imageoptions.PngOptions()
pngOptions.vector_rasterization_options = rasterizationOptions

cadImage.save("result.png", pngOptions)

Convert-STL-to-PNG-Export.cs

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-STL-Drawings-ExportingSTLtoPNG-ExportingSTLtoPNG.cs" >}}
