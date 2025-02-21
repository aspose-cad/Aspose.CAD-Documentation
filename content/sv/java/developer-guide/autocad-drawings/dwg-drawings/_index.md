---
title: DWG Ritningar
type: docs
weight: 40
url: /sv/java/developer-guide/autocad-drawings/dwg-drawings/
---

## **Exportera DWG Ritningar till PDF**

Aspose.CAD för Java API kan ladda AutoCAD-ritningar i DWG-format och konvertera dem till PDF. Detta ämne förklarar användningen av Aspose.CAD API för att uppnå konverteringen från DWG till PDF-format genom enkla steg som definieras nedan.

{{% alert color="primary" %}}

API:et stöder följande AutoCAD DWG-versioner:

- DWG 2004 version 16.0 release 18
- DWG 2005 version 16.1
- DWG 2010 version 18.0
- DWG 2013 version 19.0

{{% /alert %}}

### **DWG Filformat**

En DWG är en binär fil som innehåller vektorbilddata och metadata. Vektorbilddata ger instruktioner till CAD-applikationen om hur DWG:n ska visas; metadata kan innehålla en mängd information om filen inklusive plats-specifik data och även kunddata. Öppna specifikationer för DWG filformat kan hittas [i denna PDF](https://www.opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Konvertera DWG Filer till PDF**

Följande enkla steg krävs för att konvertera DWG till PDF.

1. Ladda DWG-filen i en instans av [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Skapa ett objekt av klassen [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) och ställ in egenskaperna [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) och [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Skapa ett objekt av klassen [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) och ställ in egenskapen [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Anropa metoden [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) och skicka objektet av [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) som det andra parametern.

Kodsamples nedan visar hur man exporterar DWG Ritningar till PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ConvertDWGFileToPDF-ConvertDWGFileToPDF.java" >}}

### **Skapa en enskild PDF med olika layoutstorlekar**

Aspose.CAD för Java tillåter dig att konvertera DWG-filen till en enskild PDF med olika layoutstorlekar. Denna metod fungerar på följande sätt:

1. Ladda en DWG-fil med metoden [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Skapa en instans av klassen [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) och ställ in resultatets sidhöjd och bredd.
1. Lägg till nödvändiga [**LayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setLayoutPageSizes-com.aspose.ms.System.Collections.Generic.Dictionary-) för objektet [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Skapa en instans av klassen [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) och ställ in dess [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) egenskap.
1. Exportera bilden till PDF med metoden [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metoden.

Kodsamples nedan visar hur man skapar en enskild PDF med olika layouter.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.java" >}}

### **Exportera DWG till PDF/A och PDF/E**

Följande enkla steg krävs för att konvertera DWG till PDF.

1. Ladda DWG-filen i en instans av [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Skapa ett objekt av klassen [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) och ställ in [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) och [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) egenskaper.
1. Skapa ett objekt av klassen [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) och ställ in egenskapen [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Anropa [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metoden och skicka objektet av [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) som det andra parametern.

Kodsamples nedan visar hur man exporterar DWG Ritningar till PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToCompliancePDF-DWGToCompliancePDF.java" >}}

### **Stödda AutoCAD Primitiver**

Följande AutoCAD-primitiver stöds.

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

## **Exportera specifik DWG-layout till PDF**

Denna metod fungerar på följande sätt:

1. Ladda en DWG-fil med metoden [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabriksmetoden.
1. Skapa en instans av klassen [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) och ställ in den resulterande sidhöjden och bredden.
1. Ställ in [**Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) egenskapen för objektet [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Skapa en instans av klassen [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) och ställ in dess [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) egenskap.
1. Exportera bilden till PDF med metoden [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metoden.

Kodsamples nedan visar hur man konverterar en specifik layout av DWG till PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportSpecificDWGLayoutToPDF-ExportSpecificDWGLayoutToPDF.java" >}}

## **Exportera DWG till Raster eller PDF med fast storlek**

Aspose.CAD för Java API kan ladda AutoCAD-ritningar i DWG-format och konvertera dem till PDF eller Raster med fast storlek.

Kodsamples nedan visar hur man implementerar denna funktion.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.java" >}}

## **Stöd för rundade dolda linjer vid export av DWG/DXF till BMP och PDF**

Denna metod fungerar på följande sätt:

1. Ladda en DWG-fil med [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabriksmetoden.
1. Skapa en instans av klassen [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Skapa en instans av klassen [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) och ställ in resultatets sidhöjd och bredd.
1. Skapa en instans av klassen [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) och ställ in dess [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) egenskap.
1. Exportera bilden till PDF med metoden [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metoden.

Kodsamples nedan visar hur man implementerar denna funktion.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportForHiddenLines-SupportForHiddenLines.java" >}}

## **Stöd för att ställa in utskriftsområde för DWG-bild i exporterad PDF**

Aspose.CAD för Java API kan ladda AutoCAD-ritningar i DWG-format och konvertera dem till PDF. Detta ämne förklarar användningen av Aspose.CAD API för att uppnå stöd för att ställa in ett utskriftsområde för DWG-bild i exporterad PDF.

Kodsamples nedan visar hur man implementerar denna funktion.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Stöd för att läsa XREF metadata för DWG-fil**

1. Ladda en DWG-fil med [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabriksmetoden.
1. Traversera genom varje bilduppgift.
1. Om enheten är [**CadUnderlay**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadUnderlay) så är det XREF-enhet med metadata.

Kodsamples nedan visar hur man uppnår denna funktion.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ReadXREEFMetaData-ReadXREEFMetaData.java" >}}

## **DWG-dokument genom att specificera koordinater**

Aspose.CAD för Java API erbjuder nu en funktion att rendera DWG-dokument genom att ange koordinater för bredd och höjd av dokumentet.

Kodsamples nedan visar hur man renderar ett DWG-dokument.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-RenderDWGDocument-RenderDWGDocument.java" >}}

Egenskapen [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#getLayouts--) är av typ string-array så du kan specificera mer än en layout åt gången för möjlig konvertering till PDF-format. När du specificerar flera layouter för [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) egenskapen, skulle den resulterande PDF:en ha flera sidor, där varje sida representerar en individuel AutoCAD-layout.

### **Lista alla layouter**

Du kan lista alla layouter som finns i en AutoCAD-ritning med följande kodsnutt.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ListAllLayoutsInAnAutoCADDrawing-ListAllLayoutsInAnAutoCADDrawing.java" >}}

## **Hämta blockattributvärde av extern referens**

Aspose.CAD för Java API tillåter dig att hämta en extern referens av ett blockattribut. Aspose.CAD API exponerar egenskapen [**getXRefPathName()**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity#getXRefPathName--) för att få den externa referensen av ett blockattribut i en [**CadBlockDictionary**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadBlockDictionary) samling.

Följande kod demonstrerar hur man får en extern referens av ett blockattribut.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-GetBlockAttributeValueOfExternalReference-GetBlockAttributeValueOfExternalReference.java" >}}

## **Sök text i DWG AutoCAD-fil**

Aspose.CAD för Java API tillåter dig att söka efter text i en DWG AutoCAD-fil. Aspose.CAD API exponerar [**CadText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadText) klassen som representerar textelement i DWG AutoCAD-filen. Klassen [**CadMText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadMText) ingår också i Aspose.CAD API eftersom andra element också kan innehålla text.

Följande kod demonstrerar hur man söker efter text i DWG AutoCAD-filen.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchTextInDWGAutoCADFile.java" >}}

### **Sök efter text i specifik layout**

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchForTextInSpecificLayout.java" >}}

### **Åtkomst till underlagets flaggor för DWG-format**

Aspose.CAD för Java har implementerat underlagsflaggar för DWG-format och tillåter utvecklare att komma åt dem. Nedan är en enkel koddemonstration.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.java" >}}

## **Stöd för DWG-enheter**

Aspose.CAD för Java API kan ladda AutoCAD-ritningar i DWG-format och stödja olika enheter att arbeta med.

### **Stöd för MLeader-enhet**

En DWG är en binär fil som innehåller vektorbilddata och metadata. Det finns olika enheter i en DWG-fil. Följande avsnitt beskriver ett exempel på att arbeta med MLeader-enheten inuti DWG-filen.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.java" >}}

### **Stöd för att exportera DWG-enhet till bild**

En DWG är en binär fil som innehåller vektorbilddata och metadata. Det finns olika enheter i en DWG-fil. Följande avsnitt beskriver ett exempel på att exportera en viss DWG-enhet till bilden.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ParticularDWGToImage-ParticularDWGToImage.java" >}}

## **Stöd för att importera bild till DWG-fil**

Aspose.CAD för Java API kan ladda AutoCAD-ritningar i DWG-format och stödja olika enheter att arbeta med. En DWG är en binär fil som innehåller vektorbilddata och metadata. Det finns olika enheter i en DWG-fil. Följande avsnitt beskriver hur vi kan importera bilder i DWG-filen.

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ImportImageToDWG-ImportImageToDWG.java" >}}

## **Stöd för att lägga till text i DWG**

Aspose.CAD för Java API kan ladda AutoCAD-ritningar i DWG-format och stödja olika enheter att arbeta med. En DWG är en binär fil som innehåller vektorbilddata och metadata. Det finns olika enheter i en DWG-fil. Följande avsnitt beskriver hur vi kan lägga till text inuti DWG-filen.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-AddTextInDWG-AddTextInDWG.java" >}}

## **Stöd för mesh i DWG**

Aspose.CAD för Java API kan nu få åtkomst till enheterna som stödjer mesh, vilka inkluderar [**CadPolyFaceMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolyFaceMesh) och [**CadPolygonMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolygonMesh) typer. Det följande exemplet beskriver hur vi kan få åtkomst till meshtyper.

## **Konvertera DWG Ritningar till DXF**

Aspose.CAD tillhandahåller funktionen att ladda AutoCAD DWG-fil och exportera den till DXF-format. Metoden för konvertering från DWG till DXF fungerar på följande sätt:

1. Ladda DWG-ritningsfilen med metoden [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabriksmetoden.
1. Exportera DWG-ritningen till DXF med metoden [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metoden.

Kodsamples nedan visar hur man konverterar en DWG-fil till DXF-format.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToDXF-DWGToDXF.java" >}}

## **Konvertera DWG Ritningar till SVG**

Aspose.CAD API kan ladda AutoCAD-ritningar i DWG-format och konvertera dem till SVG. Detta ämne förklarar användningen av Aspose.CAD API för att uppnå konverteringen från DWG till SVG-format genom enkla steg som definieras nedan.

1. Ladda DWG-filen i en instans av [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Skapa ett objekt av klassen [**SvgOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/SvgOptions) och ställ in de nödvändiga egenskaperna.
1. Exportera DWG-ritningen till SVG med metoden [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metoden.

Kodsamples nedan visar hur man konverterar en DWG-fil till SVG-format.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportToSVG-ExportToSVG.java" >}}
