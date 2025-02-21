---
title: FBX Ritningar
type: docs
weight: 70
url: /sv/net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **Exportera FBX-format till PDF**

Aspose.CAD för .NET gör det möjligt för utvecklare att exportera en [FBX](https://docs.fileformat.com/3d/fbx/) fil till [PDF](https://docs.fileformat.com/pdf/) format. [FBX](https://docs.fileformat.com/3d/fbx/) till [PDF](https://docs.fileformat.com/pdf/) konverteringsmetoden fungerar som följer:

1. Ladda [FBX](https://docs.fileformat.com/3d/fbx/) ritningsfilen med hjälp av [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) fabriksmetoden.
1. Skapa ett objekt av [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) klassen och ställ in [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) och [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) egenskaper.
1. Skapa ett objekt av [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) klassen och ställ in [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) egenskapen.
1. Anropa [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) medan du passerar ett objekt av [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) som andra parameter.

## Exempelkod

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-FBX-to-PDF-Export.cs" >}}
