---
title: DXB Tekeningen
type: docs
weight: 70
url: /nl/net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **Exporteren van DXB-formaat naar PDF**

Aspose.CAD voor .NET stelt ontwikkelaars in staat om een DXB-bestand te exporteren naar [PDF](https://docs.fileformat.com/pdf/) formaat. De DXB naar [PDF](https://docs.fileformat.com/pdf/) conversie werkt als volgt:

1. Laad het DXB-tekeningbestand met de [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) fabrieksmethode.
1. Maak een object van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) klasse en stel de eigenschappen [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) in.
1. Maak een object van de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) klasse en stel de [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) property in.
1. Roep [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) aan en geef een object van [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) door als tweede parameter.

## Voorbeeldcode

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DXB-to-PDF-Export.cs" >}}
