---
title: DWG Ritningar
type: docs
weight: 70
url: /sv/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **Exportera DWG Ritningar till PDF**

Aspose.CAD för Python API kan ladda AutoCAD-ritningar i [DWG](https://docs.fileformat.com/cad/dwg/) format och konvertera dem till [PDF](https://docs.fileformat.com/pdf/). Det här ämnet förklarar användningen av Aspose.CAD API för att uppnå konvertering av DWG till PDF-format genom enkla steg som anges nedan.

{{% alert color="primary" %}}

API:et stöder följande AutoCAD DWG-revisioner:

- DWG 2004 version 16.0 release 18
- DWG 2005 version 16.1
- DWG 2010 version 18.0
- DWG 2013 version 19.0

{{% /alert %}}

### **DWG Filformat**

En [DWG](https://docs.fileformat.com/cad/dwg/) är en binär fil som innehåller vektorbilder och metadata. Vektorbilderna ger instruktioner till CAD-applikationen om hur DWG ska visas; metadata kan innehålla olika typer av information om filen inklusive plats-specifika data och även klientdata. Öppna specifikationer för DWG-filformatet kan hittas [i denna PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Konvertera DWG Filer till PDF**

Följande enkla steg krävs för att konvertera [DWG](https://docs.fileformat.com/cad/dwg/) till [PDF](https://docs.fileformat.com/pdf/).

1. Ladda DWG-filen i en instans av **Image**.
1. Skapa ett objekt av klassen **CadRasterizationOptions** och ställ in egenskaperna **page_height** & **page_width**.
1. Skapa ett objekt av klassen **PdfOptions** och ställ in egenskapen **VectorRasterizationOptions**.
1. Anropa **Image.save** medan du skickar ett objekt av **PdfOptions** som den andra parametern.

Kodexemplet nedan visar hur man exporterar DWG Ritningar till PDF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-PDF-Export.py" >}}


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

Denna metod fungerar på följande sätt:

1. Ladda en DWG-fil med hjälp av **Aspose.CAD.Image.load** fabriksmetod.
1. Skapa en instans av klassen **CadRasterizationOptions** och ställ in den resulterande sidans höjd och bredd.
1. Ställ in egenskapen **Layouts** för objektet **CadRasterizationOptions**.
1. Skapa en instans av klassen **PdfOptions** och ställ in dess egenskap **VectorRasterizationOptions**.
1. Exportera bilden till PDF med hjälp av **Image.save()** metoden.

Kodexemplet nedan visar hur man konverterar en specifik layout av DWG till PDF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-ExportSpecificLayoutToPDF.py" >}}


## **Exportera DWG till PDF/A och PDF/E**

Denna metod fungerar på följande sätt:

1. Ladda en DWG-fil med hjälp av **Image.load** fabriksmetod.
1. Skapa en instans av klassen **CadRasterizationOptions**.
1. Skapa en instans av klassen **PdfOptions** och ställ in dess **VectorRasterizationOptions** egenskap.
1. Ställ in PDF-kompatibilitetsegenskapen och spara den.
1. Exportera bilden till PDF med hjälp av **Image.save()** metoden.

Kodexemplet nedan visar hur man konverterar en DWG-fil till PDF/A och PDF/E.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-to-Compliance-PDF.py" >}}

## **Konvertera DWG Ritningar till DXF**

Aspose.CAD tillhandahåller funktionen att ladda AutoCAD DWG-filen och exportera den till DXF-format. Metoden för DWG till DXF-konvertering fungerar på följande sätt:

1. Ladda DWG-ritningsfilen med hjälp av **Image.load** fabriksmetod.
1. Exportera DWG-ritningen till DXF med hjälp av **Image.save()** metoden.

Kodexemplet nedan visar hur man konverterar en DWG-fil till DXF-format.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-DXF.py" >}}

## **Konvertera DWG Ritningar till SVG**

Aspose.CAD för Python API kan ladda AutoCAD-ritningar i DWG-format och konvertera dem till SVG. Det här ämnet förklarar användningen av Aspose.CAD API för att uppnå konvertering av DWG till SVG-format genom enkla steg som anges nedan.

1. Ladda DWG-filen i en instans av **Image**.
1. Skapa ett objekt av klassen **SvgOptions** och ställ in de nödvändiga egenskaperna.
1. Exportera DWG-ritningen till SVG med hjälp av **Image.save()** metoden.

Kodexemplet nedan visar hur man konverterar en DWG-fil till SVG-format.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-SVG.py" >}}
