---
title: DWG-tekeningen
type: docs
weight: 70
url: /nl/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **DWG-tekeningen exporteren naar PDF**

Aspose.CAD voor Python API kan AutoCAD-tekeningen in [DWG](https://docs.fileformat.com/cad/dwg/) formaat laden en converteren naar [PDF](https://docs.fileformat.com/pdf/). Dit onderwerp legt het gebruik van de Aspose.CAD API uit om de conversie van DWG naar PDF-formaat te bereiken via eenvoudige stappen zoals hieronder gedefinieerd.

{{% alert color="primary" %}}

De API ondersteunt de volgende AutoCAD DWG-versies:

- DWG 2004 versie 16.0 release 18
- DWG 2005 versie 16.1
- DWG 2010 versie 18.0
- DWG 2013 versie 19.0

{{% /alert %}}

### **DWG-bestandformaat**

Een [DWG](https://docs.fileformat.com/cad/dwg/) is een binaire bestand dat vectorafbeeldingsgegevens en metadata bevat. De vectorafbeeldingsgegevens bieden instructies aan de CAD-toepassing over hoe de DWG moet worden weergegeven; de metadata kan verschillende informatie over het bestand bevatten, waaronder locatie specifieke gegevens en ook klantgegevens. Open specificaties voor het DWG-bestandformaat zijn te vinden [in deze PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **DWG-bestanden converteren naar PDF**

De volgende eenvoudige stappen zijn nodig om [DWG](https://docs.fileformat.com/cad/dwg/) naar [PDF](https://docs.fileformat.com/pdf/) te converteren.

1. Laad het DWG-bestand in een instantie van **Image**.
2. Maak een object van de **CadRasterizationOptions**-klasse en stel de eigenschappen **page_height** en **page_width** in.
3. Maak een object van de **PdfOptions**-klasse en stel de eigenschap **VectorRasterizationOptions** in.
4. Roep **Image.save** aan terwijl u een object van **PdfOptions** als tweede parameter doorgeeft.

Het onderstaande codevoorbeeld toont hoe u DWG-tekeningen naar PDF kunt exporteren.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-PDF-Export.py" >}}


### **Ondersteunde AutoCAD-primitieven**

De volgende AutoCAD-primitieven worden ondersteund.

- TEKST
- MTEXT
- ATTDEF
- ATTRIB
- BOOG
- ELIPS
- HATCH
- LEIDER
- PUNT
- VERTEX 2D
- VERTEX 3D
- POLYLIJN 2D
- LWPOLYLINE
- RAY
- CIRCLES
- DIMENSIE ORDINATE
- DIMENSIE LINEAIR
- DIMENSIE GECORRIGEERD
- DIMENSIE ANG 3Pt
- DIMENSIE ANG 2Ln
- DIMENSIE STRAAL
- DIMENSIE DIAMETER
- VORM
- SOLIDE
- SPLINE
- MLINE
- LIJN
- XLIJN
- STIJL
- DIMSTIJL
- LTYPE
- MLINESTYLE
- LAYER
- VIEWPORT
- LAYOUT

## **Specifieke DWG-indeling exporteren naar PDF**

Deze aanpak werkt als volgt:

1. Laad een DWG-bestand met behulp van de **Aspose.CAD.Image.load** fabrieksmethode.
2. Maak een instantie van de **CadRasterizationOptions**-klasse en stel de resulterende pagina hoogte en breedte in.
3. Stel de eigenschap **Layouts** in voor het object **CadRasterizationOptions**.
4. Maak een instantie van de **PdfOptions**-klasse en stel de eigenschap **VectorRasterizationOptions** in.
5. Exporteer de afbeelding naar PDF met behulp van de **Image.save()**-methode.

Het onderstaande codevoorbeeld toont hoe u een specifieke indeling van DWG naar PDF kunt converteren.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-ExportSpecificLayoutToPDF.py" >}}


## **DWG exporteren naar PDF/A en PDF/E**

Deze aanpak werkt als volgt:

1. Laad een DWG-bestand met behulp van de **Image.load** fabrieksmethode.
2. Maak een instantie van de **CadRasterizationOptions**-klasse.
3. Maak een instantie van de **PdfOptions**-klasse en stel de eigenschap **VectorRasterizationOptions** in.
4. Stel de PDF-nalevings eigenschap in en sla deze op.
5. Exporteer de afbeelding naar PDF met behulp van de **Image.save()**-methode.

Het onderstaande codevoorbeeld toont hoe u een DWG-bestand naar PDF/A en PDF/E kunt converteren.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-to-Compliance-PDF.py" >}}

## **DWG-tekeningen converteren naar DXF**

Aspose.CAD biedt de functie om een AutoCAD DWG-bestand te laden en het naar DXF-formaat te exporteren. De aanpak voor de conversie van DWG naar DXF werkt als volgt:

1. Laad het DWG-tekeningbestand met behulp van de **Image.load** fabrieksmethode.
2. Exporteer de DWG-tekening naar DXF met behulp van de **Image.save()**-methode.

Het onderstaande codevoorbeeld toont hoe u een DWG-bestand naar het DXF-formaat kunt converteren.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-DXF.py" >}}

## **DWG-tekeningen converteren naar SVG**

Aspose.CAD voor Python API kan AutoCAD-tekeningen in DWG-formaat laden en converteren naar SVG. Dit onderwerp legt het gebruik van de Aspose.CAD API uit om de conversie van DWG naar SVG-formaat te bereiken via eenvoudige stappen zoals hieronder gedefinieerd.

1. Laad het DWG-bestand in een instantie van **Image**.
2. Maak een object van de **SvgOptions**-klasse en stel de vereiste eigenschappen in.
3. Exporteer de DWG-tekening naar SVG met behulp van de **Image.save()**-methode.

Het onderstaande codevoorbeeld toont hoe u een DWG-bestand naar SVG-formaat kunt converteren.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-SVG.py" >}}
