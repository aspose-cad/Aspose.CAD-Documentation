---
title: DWFx Drawing
type: docs
weight: 30
url: /python/dwfx-drawing/
---

## **DWFx Drawing**
DWFx is the newest version of the DWF file format. A DWFx file is a 2D or 3D drawing created with Autodesk CAD software. It is based on the XML Paper Specification (XPS), and hence can be viewed and printed with the Microsoft XPS Viewer.

Aspose.CAD for Python allows developers to open and export DWFx files to PDF format. Following is the code demonstrating how to open DWFx files and save them in PDF format.

import aspose.cad as cad;

if __name__ == '__main__':
   cadImage = cad.Image.load("file.dwfx");

rasterizationOptions = cad.imageoptions.CadRasterizationOptions();
rasterizationOptions.page_width = 1200
rasterizationOptions.page_height = 1200

pdfOptions = cad.imageoptions.PdfOptions();
pdfOptions.vector_rasterization_options = rasterizationOptions;

cadImage.save("result.pdf", pdfOptions)

Convert-DWFX-to-PDF-Export.cs
{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWFX-Drawings-OpenDwfxFile-1.cs" >}}


