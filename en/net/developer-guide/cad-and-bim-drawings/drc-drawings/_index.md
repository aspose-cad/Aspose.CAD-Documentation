---
title: DRC Drawings
type: docs
weight: 15
url: /net/drc-drawings/
---

## **Exporting DRC Drawings to PDF**

Aspose.CAD provides the feature to load AutoCAD [DRC](https://docs.fileformat.com/3d/drc/) drawing entities and render them as an entire drawing to [PDF](https://docs.fileformat.com/pdf/) format. [DRC](https://docs.fileformat.com/3d/drc/) to [PDF](https://docs.fileformat.com/pdf/) conversion approach works as follows:

1. Load [DRC](https://docs.fileformat.com/3d/drc/) drawing file using the [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) factory method.
1. Create an object of the [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) class and set the [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) properties.
1. Create an object of the [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) class and set the [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) property.
1. Call [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) while passing an object of [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) as the second parameter.

### Sample Code

The code sample below shows how to convert a file using default settings.


{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DRC-to-PDF-Export.cs" >}}
