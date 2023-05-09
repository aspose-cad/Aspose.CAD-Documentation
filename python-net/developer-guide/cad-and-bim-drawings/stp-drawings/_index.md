---
title: STP Drawings
type: docs
weight: 70
url: /python-net/stp-drawings/
---

## **Exporting STP Format To PDF**

Aspose.CAD for Python allows developers to export an [STP](https://docs.fileformat.com/3d/stp/) file to [PDF](https://docs.fileformat.com/pdf/) format. [STP](https://docs.fileformat.com/3d/stp/) to [PDF](https://docs.fileformat.com/pdf/) conversion approach works as follows:

1. Load [STP](https://docs.fileformat.com/3d/stp/) drawing file using the **Image.load** factory method.
1. Create an object of the **CadRasterizationOptions** class and set the **page_height** & **page_width** properties.
1. Create an object of the **PdfOptions** class and set the **vector_rasterization_options** property.
1. Call **Image.save** while passing an object of **PdfOptions** as the second parameter.

## Sample Code

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-STP-to-PDF-Export.py" >}}
