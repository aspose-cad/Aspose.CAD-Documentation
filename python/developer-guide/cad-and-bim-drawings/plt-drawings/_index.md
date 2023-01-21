---
title: PLT Drawings
type: docs
weight: 90
url: /python/plt-drawings/
---

## **Export PLT to Image**

Aspose.CAD for Python allows developers to render PLT files to JPEG. Following is the code demonstrating how to access the PLT file and convert that to JPEG using **CadRasterizationOption** and **JpegOptions**.

import aspose.cad as cad;

if name == 'main': 
    cadImage = cad.Image.load("file.plt");

rasterizationOptions = cad.imageoptions.CadRasterizationOptions()
rasterizationOptions.page_width = 1200
rasterizationOptions.page_height = 1200

jpegOptions = cad.imageoptions.JpegOptions()
jpegOptions.vector_rasterization_options = rasterizationOptions

cadImage.save("result.pdf", jpegOptions)

Convert-PLT-to-JPEG.cs

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-PLT-Drawings-ExportPLTtoImage-ExportPLTtoImage.cs" >}}

## **Export PLT to PDF**

Aspose.CAD for Python allows developers to render PLT files to PDF. Following is the code demonstrating how to access the PLT file and convert that to PDF using **CadRasterizationOption** and **PdfOptions**.

import aspose.cad as cad;

if name == 'main': 
    cadImage = cad.Image.load("file.plt");

rasterizationOptions = cad.imageoptions.CadRasterizationOptions()
rasterizationOptions.page_width = 1200
rasterizationOptions.page_height = 1200

pdfOptions = cad.imageoptions.PdfOptions()
pdfOptions.vector_rasterization_options = rasterizationOptions

cadImage.save("result.pdf", pdfOptions)

Convert-PLT-to-PDF.cs
{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-PLT-Drawings-ExportPLTtoPDF-ExportPLTtoPDF.cs" >}}
