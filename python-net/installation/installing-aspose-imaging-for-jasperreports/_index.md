---
title: Installing Aspose.CAD for Pythons
type: docs
weight: 20
url: /pythons/installing-aspose-cad-for-pythons/
---

To use **Aspose.CAD for Pythons** from your application, install aspose.cad from [PYPI](https://pypi.org/project/aspose-cad/) in your project. After that, you can access the exporters programmatically.

The following example shows the typical code needed to export a report to PDF from a TIFF fileusing Aspose.CAD for Pythons. More examples can be found in the demo reports included in the product archive.

**Python**

{{< highlight python >}}
import aspose.cad as cad;

if name == 'main': 
    cadImage = cad.Image.load("file.tiff");

rasterizationOptions = cad.imageoptions.CadRasterizationOptions()
rasterizationOptions.page_width = 1200
rasterizationOptions.page_height = 1200

pdfOptions = cad.imageoptions.PdfOptions()
pdfOptions.vector_rasterization_options = rasterizationOptions

cadImage.save("result.pdf", pdfOptions)
{{< /highlight >}}
