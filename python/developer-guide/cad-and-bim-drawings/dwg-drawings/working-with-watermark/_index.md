---
title: Working with Watermark
type: docs
weight: 60
url: /python/working-with-watermark/
---

## **Add Watermark in a DWG**

Sometimes you want to add some watermarks to drawings to indicate what purpose of the drawings or who created them. Aspose.CAD for Python allows you to add a watermark in a DWG file.

## Sample Code

The code below shows how to achieve the same goal using Aspose.CAD for Python

import aspose.cad as cad;

if __name__ == '__main__':
	cadImage = cad.Image.load("file.dwg");
rasterizationOptions = cad.imageoptions.CadRasterizationOptions();

rasterizationOptions.page_width = 1200
rasterizationOptions.page_height = 1200

pdfOptions = cad.imageoptions.PdfOptions()

pdfOptions.vector_rasterization_options = rasterizationOptions

pdfOptions.user_watermark_text = "text";

cadImage.save("result.pdf", pdfOptions)

DWG-AddWatermark.cs

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-AddWatermark-AddWatermark.cs" >}}
