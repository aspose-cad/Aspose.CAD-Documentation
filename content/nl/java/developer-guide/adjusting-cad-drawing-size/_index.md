---
title: Het aanpassen van de CAD-tekeninggrootte
type: docs
weight: 10
url: /nl/java/developer-guide/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Met Aspose.CAD voor Java kunnen ontwikkelaars de grootte van tekeningen aanpassen tijdens de conversie van het CAD-formaat. Dit onderwerp legt de aanpak uit voor automatisch aanpassen of het aanpassen van de grootte met behulp van de [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) enum van de [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame) klasse.

{{% /alert %}}

## **Het aanpassen van de CAD-tekeninggrootte**

Aspose.CAD voor Java biedt de [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) enumeratie om de grootte van de tekening aan te passen tijdens de conversie van het CAD-formaat. Er zijn twee manieren om de tekeningsgrootte aan te passen.

1. Automatisch de grootte aanpassen
1. De grootte aanpassen met behulp van de [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) enumeratie van de [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame) klasse

Voor automatisch aanpassen van de grootte hoeven ontwikkelaars de eigenschappen Breedte en Hoogte van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) klasse niet op te geven. Hieronder staat een codefragment als voorbeeld van automatische sizing.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AutoAdjustingCADDrawingSize.java" >}}

De [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) enumeratie geeft de mogelijkheid om de schaal aan te passen wanneer de eigenschappen Breedte en Hoogte niet zijn ingesteld. Hieronder staat een codefragment dat demonstreert hoe u [**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) kunt gebruiken.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.java" >}}
