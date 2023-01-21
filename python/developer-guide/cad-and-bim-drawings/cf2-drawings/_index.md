---
title: CF2 Drawings
type: docs
weight: 110
url: /python/cf2-drawings/
---

## **Convert CF2 to PDF**

Aspose.CAD for Python now supports Common File Format File (CF2). CF2 file contains 3D package designs or other model data. This article demonstrates how you can convert the CF2 file to PDF using **PdfOptions**.

## Sample Code

Please use the following code snippet to convert CF2 to PDF.

import aspose.cad as cad;

if __name__ == '__main__':
   cadImage = cad.Image.load("file.cf2");

rasterizationOptions = cad.imageoptions.CadRasterizationOptions();
rasterizationOptions.page_width = 1200
rasterizationOptions.page_height = 1200

pdfOptions = cad.imageoptions.PdfOptions();
pdfOptions.vector_rasterization_options = rasterizationOptions;

cadImage.save("result.pdf", pdfOptions)

Convert-CF2-to-PDF-Export.cs
{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-CFFToPDF-CFFToPDF.cs" >}}
