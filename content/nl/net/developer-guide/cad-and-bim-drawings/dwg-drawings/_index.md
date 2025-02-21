---
title: DWG-tekeningen
type: docs
weight: 40
url: /nl/net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **DWG-tekeningen exporteren naar PDF**

Aspose.CAD voor .NET API kan AutoCAD-tekeningen in [DWG](https://docs.fileformat.com/cad/dwg/) formaat laden en converteren naar [PDF](https://docs.fileformat.com/pdf/). Dit onderwerp legt het gebruik van de Aspose.CAD API uit om de conversie van DWG naar PDF-formaat te bereiken via eenvoudige stappen zoals hieronder gedefinieerd.

{{% alert color="primary" %}}

De API ondersteunt de volgende AutoCAD DWG-revisies:

- DWG 2004 versie 16.0 release 18
- DWG 2005 versie 16.1
- DWG 2010 versie 18.0
- DWG 2013 versie 19.0

{{% /alert %}}

### **DWG-bestandsindeling**

Een [DWG](https://docs.fileformat.com/cad/dwg/) is een binair bestand dat vectorafbeeldingsgegevens en metadata bevat. De vectorafbeeldingsgegevens geven instructies aan de CAD-toepassing over hoe de DWG moet worden weergegeven; de metadata kan verschillende informatie over het bestand bevatten, waaronder locatiegebonden gegevens en ook klantgegevens. Open Specificaties voor DWG-bestandsindeling zijn te vinden [in deze PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **DWG-bestanden naar PDF converteren**

De volgende eenvoudige stappen zijn nodig om [DWG](https://docs.fileformat.com/cad/dwg/) naar [PDF](https://docs.fileformat.com/pdf/) te converteren.

1. Laad het DWG-bestand in een instantie van [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Maak een object van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) klasse en stel de eigenschappen [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) en [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) in.
1. Maak een object van de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) klasse en stel de [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) eigenschap in.
1. Roep [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) aan terwijl je een object van [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) als tweede parameter doorgeeft.

Het onderstaande codevoorbeeld toont hoe je DWG-tekeningen naar PDF kunt exporteren.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToPDF-ExportToPDF.cs" >}}

### **Een enkele PDF met verschillende lay-outformaten maken**

Aspose.CAD voor .NET stelt je in staat om een DWG-bestand naar een enkele PDF met verschillende lay-outformaten te converteren. Deze aanpak werkt als volgt:

1. Laad een DWG-bestand met behulp van de [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) fabrieksmethode.
1. Maak een instantie van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) klasse en stel de resulterende paginahoogte en -breedte in.
1. Voeg de vereiste [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/layoutpagesizes) toe voor het [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) object.
1. Maak een instantie van de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) klasse en stel de [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) eigenschap in.
1. Exporteer de afbeelding naar PDF met behulp van de [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) methode.

Het onderstaande codevoorbeeld toont hoe je een enkele [PDF](https://docs.fileformat.com/pdf/) met verschillende lay-outs kunt maken.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.cs" >}}

### **Ondersteunde AutoCAD-primitieven**

De volgende AutoCAD-primitieven worden ondersteund.

- TEKST
- MTEXT
- ATTDEF
- ATTRIB
- BOOG
- ELLIPSE
- HATCH
- LEIDER
- PUNT
- VERTEX 2D
- VERTEX 3D
- POLYLINE 2D
- LWPOLYLINE
- RAY
- CIRCLES
- DIMENSION ORDINATE
- DIMENSION LINEAR
- DIMENSION ALIGNED
- DIMENSION ANG 3Pt
- DIMENSION ANG 2Ln
- DIMENSION RADIUS
- DIMENSION DIAMETER
- VORM
- SOLIDE
- SPLINE
- MLINE
- LIJN
- XLIJN
- STIJL
- DIMSTYLE
- LTYPE
- MLINESTYLE
- LAAG
- VIEWPORT
- LAYOUT

## **Exporteren van specifieke DWG-layout naar PDF**

Deze aanpak werkt als volgt:

1. Laad een DWG-bestand met behulp van de [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) fabrieksmethode.
1. Maak een instantie van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) klasse en stel de resulterende paginahoogte en -breedte in.
1. Stel de [**Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) eigenschap in voor het [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) object.
1. Maak een instantie van de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) klasse en stel de [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) eigenschap in.
1. Exporteer de afbeelding naar PDF met behulp van de [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) methode.

Het onderstaande codevoorbeeld toont hoe je een specifieke lay-out van DWG naar PDF kunt converteren.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **DWG-document renderen door coördinaten op te geven**

Aspose.CAD voor .NET API biedt nu een functie om DWG-documenten te renderen door de coördinaten van de breedte en hoogte van het document op te geven.

Het onderstaande codevoorbeeld toont hoe je een DWG-document kunt renderen.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-RenderDWGDocument-RenderDWGDocument.cs" >}}

## **DWG exporteren naar Raster of PDF met een vaste grootte**

Aspose.CAD voor .NET API kan AutoCAD-tekeningen in DWG-formaat laden en converteren naar PDF of Raster met een vaste grootte.

Het onderstaande codevoorbeeld toont hoe je deze functie kunt implementeren.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.cs" >}}

## **DWG exporteren naar PDF/A en PDF/E**

Deze aanpak werkt als volgt:

1. Laad een DWG-bestand met behulp van de [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) fabrieksmethode.
1. Maak een instantie van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) klasse.
1. Maak een instantie van de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) klasse en stel de [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) eigenschap in.
1. Stel de PDF-nalevingseigenschap in en sla deze op.
1. Exporteer de afbeelding naar PDF met behulp van de [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) methode.

Het onderstaande codevoorbeeld toont hoe je een DWG-bestand naar PDF/A en PDF/E kunt converteren.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-DWGToCompliancePDF-DWGToCompliancePDF.cs" >}}

## **Ondersteuning voor afgeronde verborgen lijnen bij het exporteren van DWG/DXF naar BMP en PDF**

Deze aanpak werkt als volgt:

1. Laad een DWG-bestand met behulp van de [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) fabrieksmethode.
1. Maak een instantie van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) klasse en stel de resulterende paginahoogte en -breedte in.
1. Maak een instantie van de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) klasse en stel de [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) eigenschap in.
1. Exporteer de afbeelding naar PDF met behulp van de [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) methode.

Het onderstaande codevoorbeeld toont hoe je deze functie kunt implementeren.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-SupportForHiddenLines-SupportForHiddenLines.cs" >}}

## **Ondersteuning voor het instellen van de afdrukzone voor DWG-afbeeldingen in geëxporteerde PDF**

Aspose.CAD voor .NET API kan AutoCAD-tekeningen in DWG-formaat laden en converteren naar PDF. Dit onderwerp legt het gebruik van de Aspose.CAD API uit om ondersteuning te bieden voor het instellen van een afdrukzone voor de DWG-afbeelding in de geëxporteerde PDF.

Het onderstaande codevoorbeeld toont hoe je deze functie kunt implementeren.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Ondersteuning voor het lezen van XREF-metadata voor DWG-bestand**

1. Laad een DWG-bestand met behulp van de [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) fabrieksmethode.
1. Loop door elke afbeeldingsentiteit.
1. Als een entiteit CadUnderlay is, dan is het een XREF-entiteit met metadata.

Het onderstaande codevoorbeeld toont hoe je deze functie kunt bereiken.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ReadXREEFMetaData-ReadXREEFMetaData.cs" >}}

De eigenschap [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) is van het type string-array, zodat je meerdere lay-outs tegelijk kunt opgeven voor mogelijke conversie naar PDF-formaat. Bij het opgeven van meerdere lay-outs voor de [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) eigenschap, zou de resulterende PDF meerdere pagina's hebben, waarbij elke pagina een individuele AutoCAD-lay-out vertegenwoordigt.

### **Alle lay-outs opsommen**

Je kunt alle lay-outs die aanwezig zijn in een AutoCAD-tekening opsommen met behulp van het volgende codevoorbeeld.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-ListLayouts-ListLayouts.cs" >}}

### **Toegang tot onderlagelementvlaggen voor DWG-indeling**

Aspose.CAD voor .NET heeft de onderlagelementvlaggen voor DWG-indeling geïmplementeerd en stelt ontwikkelaars in staat deze te benaderen. Hieronder is een eenvoudige code-illustratie.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.cs" >}}

## **Ondersteuning voor DWG-entiteiten**

Aspose.CAD voor .NET API kan AutoCAD-tekeningen in DWG-indeling laden en ondersteunt verschillende entiteiten om mee te werken.

### **Ondersteuning voor MLeader-entiteit**

Een DWG is een binair bestand dat vectorafbeeldingsgegevens en metadata bevat. Er zijn verschillende entiteiten in een DWG-bestand. Het volgende gedeelte beschrijft een voorbeeld van het werken met de MLeader-entiteit binnen het DWG-bestand.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.cs" >}}

### **Ondersteuning voor het exporteren van DWG-entiteit naar afbeelding**

Een DWG is een binair bestand dat vectorafbeeldingsgegevens en metadata bevat. Er zijn verschillende entiteiten in een DWG-bestand. Het volgende gedeelte beschrijft een voorbeeld van het exporteren van een bepaalde DWG-entiteit naar de afbeelding.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ParticularDWGToImage-ParticularDWGToImage.cs" >}}

## **Ondersteuning voor het toevoegen van tekst in DWG**

Aspose.CAD voor .NET API kan AutoCAD-tekeningen in DWG-indeling laden en ondersteunt verschillende entiteiten om mee te werken. Een DWG is een binair bestand dat vectorafbeeldingsgegevens en metadata bevat. Er zijn verschillende entiteiten in een DWG-bestand. Het volgende gedeelte beschrijft hoe we tekst kunnen toevoegen binnen het DWG-bestand.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-AddTextInDWG-AddTextInDWG.cs" >}}

## **Ondersteuning voor het importeren van afbeeldingen naar DWG-bestand**

Aspose.CAD voor .NET API kan AutoCAD-tekeningen in DWG-indeling laden en ondersteunt verschillende entiteiten om mee te werken. Een DWG is een binair bestand dat vectorafbeeldingsgegevens en metadata bevat. Er zijn verschillende entiteiten in een DWG-bestand. Het volgende gedeelte beschrijft hoe we afbeeldingen kunnen importeren binnen het DWG-bestand.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DWG-Drawings-ImportImageToDWG-ImportImageToDWG.cs" >}}

## **Ondersteuning voor mesh in DWG**

Aspose.CAD voor .NET API kan nu de entiteiten met mesh-ondersteuning benaderen, waaronder [**CadPolyFaceMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolyfacemesh) en [**CadPolygonMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolygonmesh) typen. Het volgende voorbeeld beschrijft hoe we de mesh-typen kunnen benaderen.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-MeshSupportForDWG-MeshSupportForDWG.cs" >}}

## **DWG-tekeningen naar DXF converteren**

Aspose.CAD biedt de mogelijkheid om een AutoCAD DWG-bestand te laden en het naar DXF-formaat te exporteren. De methode voor DWG naar DXF-conversie werkt als volgt:

1. Laad het DWG-tekeningbestand met de [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) fabrieksmethode.
1. Exporteer de DWG-tekening naar DXF met behulp van de [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) methode.

Het onderstaande codevoorbeeld toont hoe je een DWG-bestand naar DXF-formaat kunt converteren.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-DWGToDXF-DWGToDXF.cs" >}}

## **DWG-tekeningen naar SVG converteren**

Aspose.CAD voor .NET API kan AutoCAD-tekeningen in DWG-formaat laden en converteren naar SVG. Dit onderwerp legt het gebruik van de Aspose.CAD API uit om de conversie van DWG naar SVG-formaat te bereiken via eenvoudige stappen zoals hieronder gedefinieerd.

1. Laad het DWG-bestand in een instantie van [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Maak een object van de [**SvgOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/svgoptions) klasse en stel de vereiste eigenschappen in.
1. Exporteer de DWG-tekening naar SVG met behulp van de [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) methode.

Het onderstaande codevoorbeeld toont hoe je een DWG-bestand naar SVG-formaat kunt converteren.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToSVG-ExportToSVG.cs" >}}

## **Groot DWG-bestand laden**

Aspose.CAD voor .NET biedt de mogelijkheid om zeer grote DWG-bestanden te openen met de [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image) klasse. Nu kun je eenvoudig grote bestanden openen met behulp van de onderstaande voorbeeldcode.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-LargeDWGToPDF-LargeDWGToPDF.cs" >}}
