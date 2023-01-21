---
title: DGN Drawing
type: docs
weight: 10
url: /python/dgn-drawing/
---

## **Exporting DGN Drawings to PDF**

Aspose.CAD provides the feature to load AutoCAD [DGN](https://docs.fileformat.com/cad/dgn/) drawing entities and render them as an entire drawing to [PDF](https://docs.fileformat.com/pdf/) format. [DGN](https://docs.fileformat.com/cad/dgn/) to [PDF](https://docs.fileformat.com/pdf/) conversion approach works as follows:

## Sample Code

import aspose.cad as cad;

if __name__ == '__main__':
   cadImage = cad.Image.load("file.dgn");

rasterizationOptions = cad.imageoptions.CadRasterizationOptions();
rasterizationOptions.page_width = 1200
rasterizationOptions.page_height = 1200

pdfOptions = cad.imageoptions.PdfOptions();
pdfOptions.vector_rasterization_options = rasterizationOptions;

cadImage.save("result.pdf", pdfOptions)

Convert-DGN-to-PDF-Export.cs

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-GetSizeOfCADLayout-GetSizeOfCADLayout.cs" >}}
