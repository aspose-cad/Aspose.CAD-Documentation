---
title: FBX Drawings
type: docs
weight: 110
url: /python-net/fbx-drawings/
---

## **Exporting FBX Format To PDF**

Aspose.CAD for Python allows developers to export an [FBX](https://docs.fileformat.com/3d/fbx/) file to [PDF](https://docs.fileformat.com/pdf/) format. [FBX](https://docs.fileformat.com/3d/fbx/) to [PDF](https://docs.fileformat.com/pdf/) conversion approach works as follows:

1. Load [FBX](https://docs.fileformat.com/3d/fbx/) drawing file using the **Image.load** factory method.
1. Create an object of the **CadRasterizationOptions** class and set the **PageHeight** & **PageWidth** properties.
1. Create an object of the **PdfOptions** class and set the **vector_rasterization_options** property.
1. Call **Image.save** while passing an object of **PdfOptions** as the second parameter.

## Sample Code

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-FBX-to-PDF-Export.py" >}}
