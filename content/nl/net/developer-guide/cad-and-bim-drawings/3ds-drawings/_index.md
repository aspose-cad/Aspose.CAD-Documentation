---
title: 3DS Tekeningen
type: docs
weight: 70
url: /nl/net/developer-guide/cad-and-bim-drawings/3ds-drawings/
---

## **3DS-formaat exporteren naar PDF**

Aspose.CAD voor .NET stelt ontwikkelaars in staat om een [3DS](https://docs.fileformat.com/3d/3ds/) bestand naar [PDF](https://docs.fileformat.com/pdf/) formaat te exporteren. De conversiebenadering van [3DS](https://docs.fileformat.com/3d/3ds/) naar [PDF](https://docs.fileformat.com/pdf/) werkt als volgt:

1. Laad het [3DS](https://docs.fileformat.com/3d/3ds/) tekenbestand met behulp van de [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) fabrieksmethode.
1. Maak een object van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) klasse en stel de eigenschappen [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) en [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) in.
1. Maak een object van de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) klasse en stel de eigenschap [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) in.
1. Roep [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) aan terwijl je een object van [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) als de tweede parameter doorgeeft.

## Voorbeeldcode

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-3DS-to-PDF-Export.cs" >}}
