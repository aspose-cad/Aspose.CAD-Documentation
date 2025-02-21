---
title: DGN-tekening
type: docs
weight: 10
url: /nl/java/developer-guide/autocad-drawings/dgn-drawing/
---

## **Tekenen DGN-formaat als onderdeel van DWG**

Aspose.CAD voor Java stelt ontwikkelaars in staat om een DWG-bestand met een ingebedde DGN-overlay te exporteren. Hieronder staat de code die laat zien hoe je de DGN-overlay in een DWG-bestand kunt benaderen tijdens het exporteren van het DWG-bestand.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportDGNAsPartofDWG-ExportDGNAsPartofDWG.java" >}}

## **3D-objectondersteuning voor DGN v7**

Aspose.CAD voor Java API heeft de functionaliteit geïntroduceerd om een DGN AutoCAD-bestand te laden en 3D-objecten voor DGN v7 te ondersteunen. De [**CadImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadImage) klasse dient hiervoor. Elke DGN-afbeelding ondersteunt 9 vooraf gedefinieerde weergaven. Het is genummerd van 1 tot 9. Als er geen weergave is gedefinieerd bij export, worden voor multi-pagina uitvoerformaten (zoals PDF) alle weergaven geëxporteerd, elk op een aparte pagina. 3D-objecten worden ondersteund in het DGN-bestandsformaat, evenals 2D.
VectorRasterizationOptions.TypeOfEntities wordt niet meer gebruikt voor het DGN-formaat (zowel 2D als 3D worden gelijktijdig ondersteund).

Voorbeeldcode om te kijken naar de ondersteunde DGN-elementen.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportForDGNV7-SupportForDGNV7.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportedDGNElements-SupportedDGNElements.java" >}}
