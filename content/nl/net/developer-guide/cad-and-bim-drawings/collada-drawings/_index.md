---
title: COLLADA-tekeningen
type: docs
weight: 70
url: /nl/net/developer-guide/cad-and-bim-drawings/collada-drawings/
---

## **COLLADA-indeling exporteren naar PDF**

Aspose.CAD voor .NET stelt ontwikkelaars in staat om een [COLLADA](https://docs.fileformat.com/3d/dae/) bestand naar [PDF](https://docs.fileformat.com/pdf/) indeling te exporteren. De conversie van [COLLADA](https://docs.fileformat.com/3d/dae/) naar [PDF](https://docs.fileformat.com/pdf/) werkt als volgt:

1. Laad het [COLLADA](https://docs.fileformat.com/3d/dae/) tekenbestand met behulp van de [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) fabrieksmethode.
1. Maak een object van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) klasse en stel de [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) eigenschappen in.
1. Maak een object van de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) klasse en stel de [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) eigenschap in.
1. Bel [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) terwijl je een object van [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) als tweede parameter doorgeeft.

## Voorbeeldcode

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-COLLADA-to-PDF-Export.cs" >}}
