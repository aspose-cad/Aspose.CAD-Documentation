---
title: IFC Drawings
type: docs
weight: 70
url: /python/ifc-drawings/
---

## **Exporting IFC Format To PNG**

Aspose.CAD for Python allows developers to export an [IFC](https://docs.fileformat.com/cad/ifc/) file to [PNG](https://docs.fileformat.com/image/png/).
Following is the code demonstrating how to access the IFC file and convert that to PNG using **CadRasterizationOptions** and **PngOptions**.

## Sample Code

import aspose.cad as cad;

if name == 'main': 
    cadImage = cad.Image.load("file.ifc");

rasterizationOptions = cad.imageoptions.CadRasterizationOptions()
rasterizationOptions.page_width = 1200
rasterizationOptions.page_height = 1200

pdfOptions = cad.imageoptions.PdfOptions()
pdfOptions.vector_rasterization_options = rasterizationOptions

cadImage.save("result.pdf", pdfOptions)

Convert-IFC-to-PDF-Export.cs

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-IFC-Drawings-ExportingIFCtoPNG-ExportingIFCtoPNG.cs" >}}
