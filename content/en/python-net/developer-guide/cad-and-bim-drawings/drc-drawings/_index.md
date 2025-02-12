---
title: DRC Drawings
type: docs
weight: 40
url: /python-net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **Exporting DRC Format To PDF**

Aspose.CAD for Python allows developers to export an [DRC](https://docs.fileformat.com/3d/drc/) file to [PDF](https://docs.fileformat.com/pdf/) format. [DRC](https://docs.fileformat.com/3d/drc/) to [PDF](https://docs.fileformat.com/pdf/) conversion approach works as follows:

1. Load DRC drawing file using the **Image.load** factory method.
1. Create an object of the **CadRasterizationOptions** class and set the **page_height** & **page_width** properties.
1. Create an object of the **PdfOptions** class and set the **VectorRasterizationOptions** property.
1. Call **Image.save** while passing an object of **PdfOptions** as the second parameter.

## Sample Code


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "convert-drc-to-pdf.py" >}}
