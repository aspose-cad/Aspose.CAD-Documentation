---
title: DRC Tekeningen
type: docs
weight: 15
url: /nl/net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **Exporteren van DRC Tekeningen naar PDF**

Aspose.CAD biedt de functie om AutoCAD [DRC](https://docs.fileformat.com/3d/drc/) tekenentiteiten te laden en deze als een gehele tekening naar [PDF](https://docs.fileformat.com/pdf/) formaat te renderen. De conversiebenadering van [DRC](https://docs.fileformat.com/3d/drc/) naar [PDF](https://docs.fileformat.com/pdf/) werkt als volgt:

1. Laad het [DRC](https://docs.fileformat.com/3d/drc/) tekeningbestand met behulp van de [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) fabrieksmethode.
1. Maak een object van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) klasse en stel de eigenschappen [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) in.
1. Maak een object van de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) klasse en stel de eigenschap [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) in.
1. Roep [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) aan terwijl je een object van [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) als tweede parameter doorgeeft.

### Voorbeeldcode

De onderstaande codevoorbeelden tonen hoe je een bestand kunt converteren met standaardinstellingen.


{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DRC-to-PDF-Export.cs" >}}
