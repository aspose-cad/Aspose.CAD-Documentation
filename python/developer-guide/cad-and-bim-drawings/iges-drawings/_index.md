---
title: IGES Drawings
type: docs
weight: 80
url: /python/iges-drawings/
---

## **Export IGES to PDF**

Aspose.CAD for Python allows developers to render IGES files to PDF. Following is the code demonstrating how to access the IGES file and convert that to PDF using **CadRasterizationOption** and **PdfOptions**.

## Sample Code

import aspose.cad as cad;

if name == ‘main’: 
	cadImage = cad.Image.load("file.igs");

rasterizationOptions = cad.imageoptions.CadRasterizationOptions()
rasterizationOptions.page_width = 1200
rasterizationOptions.page_height = 1200

pdfOptions = cad.imageoptions.PdfOptions()
pdfOptions.vector_rasterization_options = rasterizationOptions

cadImage.save("result.pdf", pdfOptions)

Convert-IGES-to-PDF-Export.cs

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-IGES-Drawings-ExportIGEStoPDF-ExportIGEStoPDF.cs" >}}
