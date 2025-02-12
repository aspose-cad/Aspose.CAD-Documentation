---
title: DWF Drawings
type: docs
weight: 50
url: /python-net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **Exporting DWF Drawings to PDF**

Aspose.CAD provides the feature to load AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) drawing entities and render them as an entire drawing to [PDF](https://docs.fileformat.com/pdf/) format. [DWF](https://docs.fileformat.com/cad/dwf/) to [PDF](https://docs.fileformat.com/pdf/) conversion approach works as follows:

1. Load [DWF](https://docs.fileformat.com/cad/dwf/) drawing file using the **Image.load** factory method.
1. Create an object of the **CadRasterizationOptions** class and set the **page_height** & **page_width** properties.
1. Create an object of the **PdfOptions** class and set the **vector_rasterization_options** property.
1. Call **Image.save** while passing an object of **PdfOptions** as the second parameter.

### Sample Code

The code sample below shows how to convert a file using default settings.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-PDF-Export.py" >}}

## **Exporting DWF Drawings to BMP**

Aspose.CAD provides the feature to load AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) drawing entities and render them as an entire drawing to [BMP](https://docs.fileformat.com/image/bmp/) format. [DWF](https://docs.fileformat.com/cad/dwf/) to [BMP](https://docs.fileformat.com/image/bmp/) conversion approach works as follows:

1. Load [DWF](https://docs.fileformat.com/cad/dwf/) drawing file using the **Image.load** factory method.
1. Create an object of the **CadRasterizationOptions**class and set the **page_height** & **page_width** properties.
1. Create an object of the **BmpOptions** class and set the **vector_rasterization_options** property.
1. Call **Image.save** while passing an object of **BmpOptions** as the second parameter.

### Sample Code

The code sample below shows how to convert a [DWF](https://docs.fileformat.com/cad/dwf/) file to [BMP](https://docs.fileformat.com/image/bmp/) using default settings.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-BMP-Export.py" >}}
