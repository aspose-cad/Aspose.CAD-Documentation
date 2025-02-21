---
title: DGN AutoCAD Exporteren
type: docs
weight: 50
url: /nl/python-net/developer-guide/exporting-dgn-autocad/
---

## **DGN AutoCAD-indeling Exporteer naar PDF**

Aspose.CAD voor Python API heeft de functionaliteit geïntroduceerd om een DGN AutoCAD-bestand te laden en te converteren naar PDF-indeling. De **CadImage** klasse dient hiervoor.

Je moet een bestaand DGN-bestand laden als **CadImage**. Maak een instantie van de **CadRasterizationOptions** klasse en stel verschillende eigenschappen in. Maak een instantie van de **PdfOptions** klasse en geef de **CadRasterizationOptions** instantie door. Roep nu de **save** methode van de instantie van de **CadImage** klasse aan.

### Voorbeeldcode

Hier volgt de code-demonstratie om [DGN](https://docs.fileformat.com/cad/dgn/) naar [PDF](https://docs.fileformat.com/pdf/) indeling te converteren/exporteren.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-PDF-Export.py" >}}


## **DGN AutoCAD-indeling Exporteer naar Rasterafbeelding-indeling**

Aspose.CAD voor Python API heeft de functionaliteit geïntroduceerd om een DGN AutoCAD-bestand te laden en te converteren naar een rasterafbeelding. De **CadImage** klasse dient hiervoor.

Je moet een bestaand DGN-bestand laden als **CadImage**. Maak een instantie van de **CadRasterizationOptions** klasse en stel verschillende eigenschappen in. Maak een instantie van de **JpegOptions** klasse en geef de **CadRasterizationOptions** instantie door. Roep nu de **save** methode van de instantie van de **CadImage** klasse aan.

### Voorbeeldcode

Hier volgt de code-demonstratie om [DGN](https://docs.fileformat.com/cad/dgn/) naar [JPEG](https://docs.fileformat.com/image/jpeg/) afbeelding te converteren/exporteren.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-JPEG-Export.py" >}}

## **3D-entiteiten ondersteuning voor DGN v7**

Aspose.CAD voor Python API heeft de functionaliteit geïntroduceerd om een [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD-bestand te laden en ondersteuning te bieden voor 3D-entiteiten voor DGN v7. De **CadImage** klasse dient hiervoor. Elke [DGN](https://docs.fileformat.com/cad/dgn/) afbeelding ondersteunt 9 vooraf gedefinieerde perspectieven. Dit is genummerd van 1 tot 9. Als het perspectief niet gedefinieerd is bij export, worden voor meerpagina-uitvoerindelingen (zoals PDF) alle perspectieven geëxporteerd, elk op een aparte pagina. 3D-entiteiten worden ondersteund in DGN-bestandindeling, evenals 2D. Hiervoor wordt **VectorRasterizationOptions** gebruikt, TypeOfEntities wordt niet meer gebruikt voor DGN-indeling (zowel 2D als 3D worden gelijktijdig ondersteund).

### Voorbeeldcode

Hier volgt de voorbeeldcode om te kijken naar ondersteunde DGN-elementen.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DGN-Drawings-SupportOf3DForDGNV7.py" >}}
