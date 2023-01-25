---
title: SVG Drawings
type: docs
weight: 70
url: /python/svg-drawings/
---

## **Exporting SVG Format To PDF**

Aspose.CAD for Python allows developers to export an [SVG](https://docs.fileformat.com/page-description-language/svg/) file to [PDF](https://docs.fileformat.com/pdf/) format. [SVG](https://docs.fileformat.com/page-description-language/svg/) to [PDF](https://docs.fileformat.com/pdf/) conversion approach works as follows:

1. Load SVG drawing file using the **Image.load** factory method.
1. Create an object of the **CadRasterizationOptions** class and set the **page_height** & **page_width** properties.
1. Create an object of the **PdfOptions** class and set the **VectorRasterizationOptions** property.
1. Call **Image.save** while passing an object of **PdfOptions** as the second parameter.

## Sample Code

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-SVG-to-PDF-Export.py" >}}
