---
title: Het aanpassen van de grootte van CAD-tekeningen
type: docs
weight: 10
url: /nl/python-net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Door gebruik te maken van de Aspose.CAD voor Python-bibliotheek, kunnen ontwikkelaars de grootte van CAD-tekeningen aanpassen tijdens de conversie naar elk ondersteund formaat. Dit onderwerp legt de aanpak uit om de grootte automatisch of handmatig aan te passen met behulp van de **UnitType** enum van de **ImageOptions** klasse.

{{% /alert %}}

## **De grootte van CAD-tekeningen aanpassen**

Aspose.CAD voor Python biedt de **UnitType** enumeratie om de grootte van de tekening aan te passen tijdens de conversie van het CAD-formaat. Er zijn twee manieren om de grootte van de tekening aan te passen.

1. Automatische grootte-aanpassing.
1. Pas de grootte aan met behulp van de **UnitType** enumeratie van de **ImageOptions** klasse

Voor automatische grootte-aanpassing hoeven ontwikkelaars de breedte- en hoogte-eigenschappen van de **CadRasterizationOptions** klasse niet op te geven. Hieronder is een voorbeeld van automatische grootte-aanpassing gegeven.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AutoAdjustingCADDrawingSize.py" >}}

De **UnitType** enumeratie geeft de mogelijkheid om de schaling aan te passen wanneer de breedte- en hoogte-eigenschappen niet zijn ingesteld. Hieronder is een codefragment gegeven dat laat zien hoe je **UnitType** kunt gebruiken.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AdjustingCADDrawingSizeUsingUnitType.py" >}}
