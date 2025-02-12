---
title: FBX Drawings
type: docs
weight: 70
url: /net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **Exporting FBX Format To PDF**

Aspose.CAD for .NET allows developers to export an [FBX](https://docs.fileformat.com/3d/fbx/) file to [PDF](https://docs.fileformat.com/pdf/) format. [FBX](https://docs.fileformat.com/3d/fbx/) to [PDF](https://docs.fileformat.com/pdf/) conversion approach works as follows:

1. Load [FBX](https://docs.fileformat.com/3d/fbx/) drawing file using the [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) factory method.
1. Create an object of the [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) class and set the [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) properties.
1. Create an object of the [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) class and set the [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) property.
1. Call [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) while passing an object of [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) as the second parameter.

## Sample Code

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-FBX-to-PDF-Export.cs" >}}
