---
title: DWG Tekeningen
type: docs
weight: 40
url: /nl/java/developer-guide/autocad-drawings/dwg-drawings/
---

## **Exporteren van DWG Tekeningen naar PDF**

Aspose.CAD voor Java API kan AutoCAD tekeningen in DWG-indeling laden en deze converteren naar PDF. Dit onderwerp leg uit hoe de Aspose.CAD API kan worden gebruikt om de conversie van DWG naar PDF-indeling te bereiken via eenvoudige stappen zoals hieronder gedefinieerd.

{{% alert color="primary" %}}

De API ondersteunt de volgende AutoCAD DWG-revisies:

- DWG 2004 versie 16.0 release 18
- DWG 2005 versie 16.1
- DWG 2010 versie 18.0
- DWG 2013 versie 19.0

{{% /alert %}}

### **DWG Bestandsformaat**

Een DWG is een binair bestand dat vectorafbeeldingsgegevens en metadata bevat. De vectorafbeeldingsgegevens bieden instructies aan de CAD-toepassing over hoe de DWG moet worden weergegeven; de metadata kan verschillende informatie over het bestand bevatten, inclusief locatie-specifieke gegevens en ook klantgegevens. Open specificaties voor het DWG-bestandsformaat zijn te vinden [in deze PDF](https://www.opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **DWG Bestanden naar PDF Converteren**

De volgende eenvoudige stappen zijn nodig om DWG naar PDF te converteren.

1. Laad het DWG-bestand in een instantie van [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Maak een object aan van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) klasse en stel de [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) eigenschappen in.
1. Maak een object aan van de [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) klasse en stel de [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) eigenschap in.
1. Roep de [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) methode aan en geef het object van [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) door als tweede parameter.

Het onderstaande codevoorbeeld laat zien hoe je DWG Tekeningen naar PDF kunt exporteren.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ConvertDWGFileToPDF-ConvertDWGFileToPDF.java" >}}

### **Een Enkel PDF Maken met Verschillende Lay-outformaten**

Aspose.CAD voor Java stelt je in staat om het DWG-bestand te converteren naar een enkele PDF met verschillende lay-outformaten. Deze benadering werkt als volgt:

1. Laad een DWG-bestand met behulp van de [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabrieksmethode.
1. Maak een instantie van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) klasse en stel de resulterende pagina hoogte en breedte in.
1. Voeg vereiste [**LayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setLayoutPageSizes-com.aspose.ms.System.Collections.Generic.Dictionary-) toe voor het [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) object.
1. Maak een instantie van de [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) klasse en stel de [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) eigenschap in.
1. Exporteer de afbeelding naar PDF met behulp van de [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) methode.

Het onderstaande codevoorbeeld laat zien hoe een enkele PDF met verschillende lay-outs kan worden gemaakt.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.java" >}}

### **Exporteren van DWG naar PDF/A en PDF/E**

De volgende eenvoudige stappen zijn nodig om DWG naar PDF te converteren.

1. Laad het DWG-bestand in een instantie van [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Maak een object aan van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) klasse en stel de [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) eigenschappen in.
1. Maak een object aan van de [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) klasse en stel de [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) eigenschap in.
1. Roep de [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) methode aan en geef het object van [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) door als tweede parameter.

Het onderstaande codevoorbeeld laat zien hoe je DWG Tekeningen naar PDF kunt exporteren.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToCompliancePDF-DWGToCompliancePDF.java" >}}

### **Ondersteunde AutoCAD Primitive**

De volgende AutoCAD primitive worden ondersteund.

- TEXT
- MTEXT
- ATTDEF
- ATTRIB
- ARC
- ELLIPSE
- HATCH
- LEADER
- POINT
- VERTEX 2D
- VERTEX 3D
- POLYLINE 2D
- LWPOLYLINE
- RAY
- CIRCLE
- DIMENSION ORDINATE
- DIMENSION LINEAR
- DIMENSION ALIGNED
- DIMENSION ANG 3Pt
- DIMENSION ANG 2Ln
- DIMENSION RADIUS
- DIMENSION DIAMETER
- SHAPE
- SOLID
- SPLINE
- MLINE
- LINE
- XLINE
- STYLE
- DIMSTYLE
- LTYPE
- MLINESTYLE
- LAYER
- VIEWPORT
- LAYOUT

## **Exporteren van Specifieke DWG Lay-out naar PDF**

Deze benadering werkt als volgt:

1. Laad een DWG-bestand met behulp van de [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabrieksmethode.
1. Maak een instantie van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) klasse en stel de resulterende pagina hoogte en breedte in.
1. Stel de [**Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) eigenschap in voor het [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) object.
1. Maak een instantie van de [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) klasse en stel de [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) eigenschap in.
1. Exporteer de afbeelding naar PDF met behulp van de [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) methode.

Het onderstaande codevoorbeeld laat zien hoe je een specifieke lay-out van DWG naar PDF kunt converteren.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportSpecificDWGLayoutToPDF-ExportSpecificDWGLayoutToPDF.java" >}}

## **Exporteren van DWG naar Raster of PDF met Vaste Grootte**

Aspose.CAD voor Java API kan AutoCAD tekeningen in DWG-indeling laden en deze converteren naar PDF of Raster met een vaste grootte.

Het onderstaande codevoorbeeld laat zien hoe je deze functie kunt implementeren.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.java" >}}

## **Ondersteuning voor afgeronde verborgen lijnen bij het exporteren van DWG/DXF naar BMP en PDF**

Deze benadering werkt als volgt:

1. Laad een DWG-bestand met behulp van de [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabrieksmethode.
1. Maak een instantie van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) klasse.
1. Maak een instantie van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) klasse en stel de resulterende pagina hoogte en breedte in.
1. Maak een instantie van de [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) klasse en stel de [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) eigenschap in.
1. Exporteer de afbeelding naar PDF met behulp van de [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) methode.

Het onderstaande codevoorbeeld laat zien hoe je deze functie kunt implementeren.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportForHiddenLines-SupportForHiddenLines.java" >}}

## **Ondersteuning voor het instellen van het afdrukgebied voor DWG-afbeeldingen in geëxporteerde PDF**

Aspose.CAD voor Java API kan AutoCAD tekeningen in DWG-indeling laden en deze converteren naar PDF. Dit onderwerp legt uit hoe de Aspose.CAD API kan worden gebruikt om ondersteuning te bieden voor het instellen van een afdrukgebied voor DWG-afbeeldingen in geëxporteerde PDF.

Het onderstaande codevoorbeeld laat zien hoe je deze functie kunt implementeren.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Ondersteuning voor het lezen van XREF-metadata voor DWG-bestand**

1. Laad een DWG-bestand met behulp van de [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabrieksmethode.
1. Traverseer door elke afbeeldingsentiteit.
1. Als de entiteit [**CadUnderlay**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadUnderlay) is, dan XREF-entiteit met metadata.

Het onderstaande codevoorbeeld laat zien hoe je deze functie kunt bereiken.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ReadXREEFMetaData-ReadXREEFMetaData.java" >}}

## **DWG-document door coördinaten op te geven**

Aspose.CAD voor Java API biedt nu een functie om DWG-documenten te renderen door de coördinaten van de breedte en hoogte van het document op te geven.

Het onderstaande codevoorbeeld laat zien hoe je een DWG-document kunt renderen.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-RenderDWGDocument-RenderDWGDocument.java" >}}

De eigenschap [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#getLayouts--) is van het type stringarray, zodat je meer dan één lay-out tegelijk kunt opgeven voor mogelijke conversie naar PDF-indeling. Bij het opgeven van meerdere lay-outs voor de [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) eigenschap, zou de resulterende PDF meerdere pagina's hebben, waarbij elke pagina een individuele AutoCAD-lay-out vertegenwoordigt.

### **Lijst Alle Lay-outs**

Je kunt alle lay-outs die aanwezig zijn in een AutoCAD-tekening opsommen met behulp van de volgende code-voorbeeld.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ListAllLayoutsInAnAutoCADDrawing-ListAllLayoutsInAnAutoCADDrawing.java" >}}

## **Blok Attribuutwaarde Van Externe Referentie Verkrijgen**

Aspose.CAD voor Java API stelt je in staat om een externe referentie van een blokattribuut te verkrijgen. Aspose.CAD API exposeert de [**getXRefPathName()**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity#getXRefPathName--) eigenschap om de externe referentie van een blokattribuut in een [**CadBlockDictionary**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadBlockDictionary) verzameling te verkrijgen.

Het volgende codevoorbeeld laat zien hoe je een externe referentie van een blokattribuut kunt verkrijgen.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-GetBlockAttributeValueOfExternalReference-GetBlockAttributeValueOfExternalReference.java" >}}

## **Zoeken naar Tekst in DWG AutoCAD-bestand**

Aspose.CAD voor Java API stelt je in staat om tekst te zoeken in een DWG AutoCAD-bestand. Aspose.CAD API exposeert de [**CadText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadText) klasse die tekstentiteiten in het DWG AutoCAD-bestand vertegenwoordigt. De klasse [**CadMText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadMText) is ook opgenomen in de Aspose.CAD API omdat sommige andere entiteiten ook tekst kunnen bevatten.

Het onderstaande codevoorbeeld laat zien hoe je tekst in het DWG AutoCAD-bestand kunt zoeken.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchTextInDWGAutoCADFile.java" >}}

### **Zoeken naar Tekst in een Specifieke Lay-out**

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchForTextInSpecificLayout.java" >}}

### **Toegang tot Underlay Vlaggen voor DWG-indeling**

Aspose.CAD voor Java heeft de underlay-vlaggen voor DWG-indeling geïmplementeerd en stelt ontwikkelaars in staat om toegang te krijgen tot hen. Hieronder volgt de simpele code-demonstratie.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.java" >}}

## **Ondersteuning voor DWG Entiteiten**

Aspose.CAD voor Java API kan AutoCAD tekeningen in DWG-indeling laden en verschillende entiteiten ondersteunen om mee te werken.

### **Ondersteuning voor MLeader Entiteit**

Een DWG is een binair bestand dat vectorafbeeldingsgegevens en metadata bevat. Er zijn verschillende entiteiten in een DWG-bestand. De volgende sectie beschrijft een voorbeeld van het werken met MLeader entiteit binnen het DWG-bestand.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.java" >}}

### **Ondersteuning voor het Exporteren van DWG Entiteit naar Afbeelding**

Een DWG is een binair bestand dat vectorafbeeldingsgegevens en metadata bevat. Er zijn verschillende entiteiten in een DWG-bestand. De volgende sectie beschrijft een voorbeeld van het exporteren van een bepaalde DWG-entiteit naar de afbeelding.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ParticularDWGToImage-ParticularDWGToImage.java" >}}

## **Ondersteuning voor het Importeren van Afbeeldingen naar DWG-bestand**

Aspose.CAD voor Java API kan AutoCAD tekeningen in DWG-indeling laden en verschillende entiteiten ondersteunen om mee te werken. Een DWG is een binair bestand dat vectorafbeeldingsgegevens en metadata bevat. Er zijn verschillende entiteiten in een DWG-bestand. De volgende sectie beschrijft hoe we afbeeldingen in het DWG-bestand kunnen importeren.

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ImportImageToDWG-ImportImageToDWG.java" >}}

## **Ondersteuning voor het Toevoegen van tekst in DWG**

Aspose.CAD voor Java API kan AutoCAD tekeningen in DWG-indeling laden en verschillende entiteiten ondersteunen om mee te werken. Een DWG is een binair bestand dat vectorafbeeldingsgegevens en metadata bevat. Er zijn verschillende entiteiten in een DWG-bestand. De volgende sectie beschrijft hoe we tekst binnen het DWG-bestand kunnen toevoegen.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-AddTextInDWG-AddTextInDWG.java" >}}

## **Ondersteuning voor Mesh in DWG**

Aspose.CAD voor Java API kan nu de entiteiten ondersteunen die mesh ondersteunen, waaronder [**CadPolyFaceMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolyFaceMesh) en [**CadPolygonMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolygonMesh) types. Het volgende voorbeeld beschrijft hoe we toegang kunnen krijgen tot de meshtypen.

## **Converteren van DWG Tekeningen naar DXF**

Aspose.CAD biedt de functie om AutoCAD DWG-bestand te laden en deze te exporteren naar DXF-indeling. Het benadering voor DWG naar DXF conversie werkt als volgt:

1. Laad het DWG-tekeningbestand met behulp van de [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabrieksmethode.
1. Exporteer de DWG-tekening naar DXF met behulp van de [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) methode.

Het onderstaande codevoorbeeld laat zien hoe je een DWG-bestand naar DXF-indeling kunt converteren.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToDXF-DWGToDXF.java" >}}

## **Converteren van DWG Tekeningen naar SVG**

Aspose.CAD API kan AutoCAD tekeningen in DWG-indeling laden en deze converteren naar SVG. Dit onderwerp legt uit hoe de Aspose.CAD API kan worden gebruikt om de conversie van DWG naar SVG-indeling te bereiken door middel van eenvoudige stappen zoals hieronder gedefinieerd.

1. Laad het DWG-bestand in een instantie van [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Maak een object aan van de [**SvgOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/SvgOptions) klasse en stel de vereiste eigenschappen in.
1. Exporteer de DWG-tekening naar SVG met behulp van de [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) methode.

Het onderstaande codevoorbeeld laat zien hoe je een DWG-bestand naar SVG-indeling kunt converteren.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportToSVG-ExportToSVG.java" >}}
