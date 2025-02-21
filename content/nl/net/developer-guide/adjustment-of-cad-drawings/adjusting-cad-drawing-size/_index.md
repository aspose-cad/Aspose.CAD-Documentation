---
title: Het aanpassen van de grootte van CAD-tekeningen
type: docs
weight: 10
url: /nl/net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Door gebruik te maken van de Aspose.CAD voor .NET bibliotheek, kunnen ontwikkelaars de grootte van CAD-tekeningen aanpassen tijdens de conversie naar een ondersteund formaat. Dit onderwerp legt de aanpak uit om de grootte automatisch of handmatig aan te passen met behulp van de [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) enum van de [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions) klasse.

{{% /alert %}}

## **Het aanpassen van de grootte van CAD-tekeningen**

Aspose.CAD voor .NET biedt de [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) enumeratie om de grootte van de tekening aan te passen tijdens de conversie van het CAD-formaat. Er zijn twee manieren om de grootte van de tekening aan te passen.

1. Automatische grootteaanpassing.
1. Pas de grootte aan met behulp van de [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) enumeratie van de [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions) klasse.

Voor automatische grootte-aanpassing hoeven ontwikkelaars de Width- en Height-eigenschappen van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/index) klasse niet op te geven. Hieronder staat een codevoorbeeld van automatische sizing.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AutoAdjustingCADDrawingSize-AutoAdjustingCADDrawingSize.cs" >}}

De [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) enumeratie geeft de mogelijkheid om de schaling aan te passen wanneer de Width- en Height-eigenschappen niet zijn ingesteld. Hieronder staat een codevoorbeeld dat laat zien hoe je [**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype) kunt gebruiken.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.cs" >}}
