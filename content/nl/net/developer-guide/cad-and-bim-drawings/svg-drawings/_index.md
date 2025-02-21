---
title: SVG-illustraties
type: docs
weight: 70
url: /nl/net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **Exporteren van SVG-formaat naar PDF**

Aspose.CAD voor .NET geeft ontwikkelaars de mogelijkheid om een SVG-bestand naar [PDF](https://docs.fileformat.com/pdf/) formaat te exporteren. De conversie van SVG naar [PDF](https://docs.fileformat.com/pdf/) werkt als volgt:

1. Laad het SVG-tekeningbestand met behulp van de [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) fabrieksmethode.
1. Maak een object van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) klasse en stel de eigenschappen [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) en [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) in.
1. Maak een object van de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) klasse en stel de eigenschap [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) in.
1. Roep [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) aan terwijl je een object van [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) doorgeeft als de tweede parameter.

## Voorbeeldcode

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-SVG-to-PDF-Export.cs" >}}
