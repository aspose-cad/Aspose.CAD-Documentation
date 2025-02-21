---
title: DGN AutoCAD Exporteren
type: docs
weight: 50
url: /nl/net/developer-guide/exporting-dgn-autocad/
---

## **DGN AutoCAD-formaat naar PDF exporteren**

Aspose.CAD voor .NET API heeft de functionaliteit geïntroduceerd om een DGN AutoCAD-bestand te laden en het naar PDF-formaat te converteren. [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) klasse dient hiervoor.

Je moet een bestaand DGN-bestand laden als [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage). Maak een instantie van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) klasse en stel verschillende eigenschappen in. Maak een instantie van de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) klasse en geef de instantie van [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) door. Roep nu de [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) methode van de [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) klasse-instantie aan.

### Voorbeeldcode

Hieronder staat de code-demonstatie om [DGN](https://docs.fileformat.com/cad/dgn/) naar [PDF](https://docs.fileformat.com/pdf/) formaat te converteren/exporteren.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **DGN AutoCAD-format naar rasterafbeelding exporteren**

Aspose.CAD voor .NET API heeft de functionaliteit geïntroduceerd om een DGN AutoCAD-bestand te laden en het naar een rasterafbeelding te converteren. [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) klasse dient hiervoor.

Je moet een bestaand DGN-bestand laden als [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage). Maak een instantie van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) klasse en stel verschillende eigenschappen in. Maak een instantie van de [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) klasse en geef de instantie van [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) door. Roep nu de [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) methode van de [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) klasse-instantie aan.

### Voorbeeldcode

Hieronder staat de code-demonstatie om [DGN](https://docs.fileformat.com/cad/dgn/) naar [JPEG](https://docs.fileformat.com/image/jpeg/) afbeelding te converteren/exporteren.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-ExportDGNToRasterImage-ExportDGNToRasterImage.cs" >}}

## **3D-entiteiten ondersteuning voor DGN v7**

Aspose.CAD voor .NET API heeft de functionaliteit geïntroduceerd om een [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD-bestand te laden en 3D-entiteiten voor DGN v7 te ondersteunen. [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) klasse dient hiervoor. Elke [DGN](https://docs.fileformat.com/cad/dgn/) afbeelding ondersteunt 9 gedefinieerde weergaven. Deze zijn genummerd van 1 tot 9. Als de weergave niet gedefinieerd is bij export, worden voor multi-paged uitvoerformaten (zoals PDF) alle weergaven geëxporteerd, elke op een aparte pagina. 3D-entiteiten worden ondersteund op het DGN-bestandsformaat, evenals 2D. Hiervoor wordt [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) gebruikt, TypeOfEntities wordt niet meer gebruikt voor DGN-formaat (zowel 2D als 3D worden gelijktijdig ondersteund).

### Voorbeeldcode

Hieronder staat de voorbeeldcode om naar ondersteunde DGN-elementen te kijken.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-SupportOf3DForDGNV7-3DSupportForDGNV7.cs" >}}
