---
title: COLLADA Drawings
type: docs
weight: 70
url: /python/collada-drawings/
---

## **Exporting COLLADA Format To PDF**

Aspose.CAD for Python allows developers to export an [COLLADA](https://docs.fileformat.com/3d/dae/) file to [PDF](https://docs.fileformat.com/pdf/) format. [COLLADA](https://docs.fileformat.com/3d/dae/) to [PDF](https://docs.fileformat.com/pdf/) conversion approach works as follows:

1. Load [COLLADA](https://docs.fileformat.com/3d/dae/) drawing file using the **Image.load** factory method.
1. Create an object of the **CadRasterizationOptions** class and set the **page_height** & **page_width** properties.
1. Create an object of the **PdfOptions** class and set the **vector_rasterization_options** property.
1. Call **Image.save** while passing an object of **PdfOptions** as the second parameter.

## Sample Code

import aspose.cad as cad;

if name == 'main': 
    cadImage = cad.Image.load("file.dae");

rasterizationOptions = cad.imageoptions.CadRasterizationOptions()
rasterizationOptions.page_width = 1200
rasterizationOptions.page_height = 1200

pdfOptions = cad.imageoptions.PdfOptions()
pdfOptions.vector_rasterization_options = rasterizationOptions

cadImage.save("result.pdf", pdfOptions)

Convert-COLLADA-to-PDF-Export.cs

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-COLLADA-to-PDF-Export.cs" >}}
