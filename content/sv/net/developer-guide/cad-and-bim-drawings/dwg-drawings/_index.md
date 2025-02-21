---
title: DWG Ritningar
type: docs
weight: 40
url: /sv/net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **Exportera DWG Ritningar till PDF**

Aspose.CAD för .NET API kan läsa in AutoCAD-ritningar i [DWG](https://docs.fileformat.com/cad/dwg/) format och konvertera dem till [PDF](https://docs.fileformat.com/pdf/). Detta ämne förklarar användningen av Aspose.CAD API för att uppnå konverteringen av DWG till PDF-format genom enkla steg som definieras nedan.

{{% alert color="primary" %}}

API:et stöder följande AutoCAD DWG-versioner:

- DWG 2004 version 16.0 release 18
- DWG 2005 version 16.1
- DWG 2010 version 18.0
- DWG 2013 version 19.0

{{% /alert %}}

### **DWG Filformat**

En [DWG](https://docs.fileformat.com/cad/dwg/) är en binär fil som innehåller vektorbilddata och metadata. Vektorbilddata ger instruktioner till CAD-applikationen om hur man ska visa DWG; metadata kan innehålla en mängd olika information om filen, inklusive plats-specifik data och även klientdata. Öppna specifikationer för DWG filformat kan hittas [i denna PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Konvertera DWG Filer till PDF**

Följande enkla steg krävs för att konvertera [DWG](https://docs.fileformat.com/cad/dwg/) till [PDF](https://docs.fileformat.com/pdf/).

1. Läs in DWG-filen i en instans av [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Skapa ett objekt av klassen [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) och ställ in egenskaperna [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Skapa ett objekt av klassen [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) och ställ in egenskapen [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Anropa [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) medan du skickar ett objekt av [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) som det andra parametern.

Kodexemplet nedan visar hur man exporterar DWG Ritningar till PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToPDF-ExportToPDF.cs" >}}

### **Skapa en Enskild PDF med Olika Layoutstorlekar**

Aspose.CAD för .NET tillåter dig att konvertera DWG-fil till en enskild PDF med olika layoutstorlekar. Denna metod fungerar som följer:

1. Läs in en DWG-fil med hjälp av metoden [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Skapa en instans av klassen [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) och ställ in resultatens sidhöjd och bredd.
1. Lägg till nödvändiga [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/layoutpagesizes) för objektet [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Skapa en instans av klassen [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) och ställ in dess egenskap [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Exportera bilden till PDF med hjälp av metoden [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Kodexemplet nedan visar hur man skapar en enskild [PDF](https://docs.fileformat.com/pdf/) med olika layouter.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.cs" >}}

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

## **Exportera Specifik DWG Layout till PDF**

Denna metod fungerar som följer:

1. Läs in en DWG-fil med hjälp av metoden [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Skapa en instans av klassen [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) och ställ in resultatens sidhöjd och bredd.
1. Ställ in egenskapen [**Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) för objektet [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Skapa en instans av klassen [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) och ställ in dess egenskap [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Exportera bilden till PDF med hjälp av metoden [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Kodexemplet nedan visar hur man konverterar en specifik layout av DWG till PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Rendera DWG-dokument genom att specificera koordinater**

Aspose.CAD för .NET API erbjuder nu en funktion för att rendera DWG-dokument genom att ange koordinater för dokumentets bredd och höjd.

Kodexemplet nedan visar hur du renderar ett DWG-dokument.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-RenderDWGDocument-RenderDWGDocument.cs" >}}

## **Exportera DWG till Raster eller PDF med Fixerad Storlek**

Aspose.CAD för .NET API kan läsa in AutoCAD-ritningar i DWG-format och konvertera dem till PDF eller Raster med fixerad storlek.

Kodexemplet nedan visar hur man implementerar denna funktion.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.cs" >}}

## **Exportera DWG till PDF/A och PDF/E**

Denna metod fungerar som följer:

1. Läs in en DWG-fil med hjälp av metoden [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Skapa en instans av klassen [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Skapa en instans av klassen [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) och ställ in dess egenskap [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Ställ in egenskapen för PDF-kompatibilitet och spara den.
1. Exportera bilden till PDF med hjälp av metoden [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Kodexemplet nedan visar hur man konverterar en DWG-fil till PDF/A och PDF/E.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-DWGToCompliancePDF-DWGToCompliancePDF.cs" >}}

## **Stöd för rundade dolda linjer vid export av DWG/DXF till BMP och PDF**

Denna metod fungerar som följer:

1. Läs in en DWG-fil med hjälp av metoden [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Skapa en instans av klassen [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) och ställ in resultatens sidhöjd och bredd.
1. Skapa en instans av klassen [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) och ställ in dess egenskap [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Exportera bilden till PDF med hjälp av metoden [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Kodexemplet nedan visar hur man implementerar denna funktion.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-SupportForHiddenLines-SupportForHiddenLines.cs" >}}

## **Stöd för att ställa in utskriftsområde för DWG-bild i exporterad PDF**

Aspose.CAD för .NET API kan läsa in AutoCAD-ritningar i DWG-format och konvertera dem till PDF. Detta ämne förklarar användningen av Aspose.CAD API för att uppnå stöd för att ställa in ett utskriftsområde för DWG-bilden i den exporterade PDF:en.

Kodexemplet nedan visar hur man implementerar denna funktion.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Stöd för att läsa XREF metadata för DWG-fil**

1. Läs in en DWG-fil med hjälp av metoden [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Traversera varje bildentitet.
1. Om en entitet är CadUnderlay så XREF-entitet med metadata.

Kodexemplet nedan visar hur man uppnår denna funktion.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ReadXREEFMetaData-ReadXREEFMetaData.cs" >}}

Egenskapen [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) är av typ string-array så du kan specificera mer än en layout åt gången för möjlig konvertering till PDF-format. När du specificerar flera layouter för egenskapen [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) kommer den resulterande PDF:en att ha flera sidor där varje sida representerar en individuell AutoCAD-layout.

### **Lista Alla Layouter**

Du kan lista alla layouter som finns i en AutoCAD-ritning med följande kodsnutt.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-ListLayouts-ListLayouts.cs" >}}

### **Åtkomst till underlagets Flaggor för DWG-format**

Aspose.CAD för .NET har implementerat underlagets flaggor för DWG-format och tillåter utvecklare att få åtkomst till dem. Följande är den enkla koddemonstrationen.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.cs" >}}

## **Stöd för DWG Entiteter**

Aspose.CAD för .NET API kan läsa in AutoCAD-ritningar i DWG-format och stödja olika entiteter att arbeta med.

### **Stöd för MLeader Entitet**

En DWG är en binär fil som innehåller vektorbilddata och metadata. Det finns olika entiteter i en DWG-fil. Följande avsnitt beskriver ett exempel på att arbeta med MLeader-entiteten inuti DWG-filen.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.cs" >}}

### **Stöd för Export av DWG Entitet till Bild**

En DWG är en binär fil som innehåller vektorbilddata och metadata. Det finns olika entiteter i en DWG-fil. Följande avsnitt beskriver ett exempel på att exportera en viss DWG-entitet till bilden.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ParticularDWGToImage-ParticularDWGToImage.cs" >}}

## **Stöd för Att Lägga till text i DWG**

Aspose.CAD för .NET API kan läsa in AutoCAD-ritningar i DWG-format och stödja olika entiteter att arbeta med. En DWG är en binär fil som innehåller vektorbilddata och metadata. Det finns olika entiteter i en DWG-fil. Följande avsnitt beskriver hur vi kan lägga till text i DWG-filen.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-AddTextInDWG-AddTextInDWG.cs" >}}

## **Stöd för Import av Bild till DWG Fil**

Aspose.CAD för .NET API kan läsa in AutoCAD-ritningar i DWG-format och stödja olika entiteter att arbeta med. En DWG är en binär fil som innehåller vektorbilddata och metadata. Det finns olika entiteter i en DWG-fil. Följande avsnitt beskriver hur vi kan importera bilder i DWG-filen.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DWG-Drawings-ImportImageToDWG-ImportImageToDWG.cs" >}}

## **Stöd för Mesh i DWG**

Aspose.CAD för .NET API kan nu få tillgång till entiteter som stöder mesh, inklusive [**CadPolyFaceMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolyfacemesh) och [**CadPolygonMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolygonmesh) typer. Följande exempel beskriver hur vi kan få tillgång till mesh-typer.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-MeshSupportForDWG-MeshSupportForDWG.cs" >}}

## **Konvertera DWG Ritningar till DXF**

Aspose.CAD erbjuder funktionen att läsa in AutoCAD DWG-fil och exportera den till DXF-format. DWG till DXF-konverteringsmetoden fungerar som följer:

1. Läs DWG-ritningsfilen med hjälp av metoden [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Exportera DWG-ritningen till DXF med hjälp av metoden [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Kodexemplet nedan visar hur man konverterar en DWG-fil till DXF-format.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-DWGToDXF-DWGToDXF.cs" >}}

## **Konvertera DWG Ritningar till SVG**

Aspose.CAD för .NET API kan läsa in AutoCAD-ritningar i DWG-format och konvertera dem till SVG. Detta ämne förklarar användningen av Aspose.CAD API för att uppnå konverteringen av DWG till SVG-format genom enkla steg som definieras nedan.

1. Läsa in DWG-filen i en instans av [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Skapa ett objekt av klassen [**SvgOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/svgoptions) och ställ in nödvändiga egenskaper.
1. Exportera DWG-ritningen till SVG med hjälp av metoden [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Kodexemplet nedan visar hur man konverterar en DWG-fil till SVG-format.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToSVG-ExportToSVG.cs" >}}

## **Ladda Stora DWG-filer**

Aspose.CAD för .NET erbjuder möjligheten att öppna mycket stora DWG-filer med hjälp av klassen [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image). Nu kan du enkelt öppna stora filer med hjälp av det provkod som ges nedan.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-LargeDWGToPDF-LargeDWGToPDF.cs" >}}
