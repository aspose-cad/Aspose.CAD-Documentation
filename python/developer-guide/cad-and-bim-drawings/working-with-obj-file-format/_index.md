---
title: Working with OBJ File Format
type: docs
weight: 120
url: /python/working-with-obj-file-format/
---

{{% alert color="primary" %}}

Aspose.CAD now supports the OBJ file format. The OBJ file format is a 3D geometry that contains texture maps, 3D coordinates, polygonal faces, and other object information.

{{% /alert %}}

## **Convert OBJ to PDF**

Using Aspose.CAD for Python you can convert the OBJ file to PDF. Please use the following code snippets to convert OBJ to PDF.

import aspose.cad as cad;

if name == 'main': 
    cadImage = cad.Image.load("file.ifc");

rasterizationOptions = cad.imageoptions.CadRasterizationOptions()
rasterizationOptions.page_width = 1200
rasterizationOptions.page_height = 1200

pdfOptions = cad.imageoptions.PdfOptions()
pdfOptions.vector_rasterization_options = rasterizationOptions

cadImage.save("result.pdf", pdfOptions)

Convert-OBJ-to-PDF-Export.cs
{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-OBJ-Drawings-SupportOfOBJ-SupportOfOBJ.cs" >}}
