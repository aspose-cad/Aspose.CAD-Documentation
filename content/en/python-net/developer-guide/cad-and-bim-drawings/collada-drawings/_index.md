---
title: COLLADA Drawings
type: docs
weight: 20
url: /python-net/developer-guide/cad-and-bim-drawings/collada-drawings/
---

## **Exporting COLLADA Format To PDF**

Aspose.CAD for Python allows developers to export an [COLLADA](https://docs.fileformat.com/3d/dae/) file to [PDF](https://docs.fileformat.com/pdf/) format. [COLLADA](https://docs.fileformat.com/3d/dae/) to [PDF](https://docs.fileformat.com/pdf/) conversion approach works as follows:

1. Load [COLLADA](https://docs.fileformat.com/3d/dae/) drawing file using the **Image.load** factory method.
1. Create an object of the **CadRasterizationOptions** class and set the **page_height** & **page_width** properties.
1. Create an object of the **PdfOptions** class and set the **vector_rasterization_options** property.
1. Call **Image.save** while passing an object of **PdfOptions** as the second parameter.

## Sample Code

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-COLLADA-to-PDF-Export.py" >}}
