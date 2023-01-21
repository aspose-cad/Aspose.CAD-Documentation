---
title: FBX Drawings
type: docs
weight: 70
url: /python/fbx-drawings/
---

## **Exporting FBX Format To PDF**

Aspose.CAD for Python allows developers to export an [FBX](https://docs.fileformat.com/3d/fbx/) file to [PDF](https://docs.fileformat.com/pdf/) format. [FBX](https://docs.fileformat.com/3d/fbx/) to [PDF](https://docs.fileformat.com/pdf/) conversion approach works as follows:

1. Load [FBX](https://docs.fileformat.com/3d/fbx/) drawing file using the **Image.load** factory method.
1. Create an object of the **CadRasterizationOptions** class and set the **PageHeight** & **PageWidth** properties.
1. Create an object of the **PdfOptions** class and set the **vector_rasterization_options** property.
1. Call **Image.save** while passing an object of **PdfOptions** as the second parameter.

## Sample Code

import aspose.cad as cad;

if name == 'main': 
    cadImage = cad.Image.load("file.fbx");

rasterizationOptions = cad.imageoptions.CadRasterizationOptions()
rasterizationOptions.page_width = 1200
rasterizationOptions.page_height = 1200

pdfOptions = cad.imageoptions.PdfOptions()
pdfOptions.vector_rasterization_options = rasterizationOptions

cadImage.save("result.pdf", pdfOptions)

Convert-FBX-to-PDF-Export.cs

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-FBX-to-PDF-Export.cs" >}}
