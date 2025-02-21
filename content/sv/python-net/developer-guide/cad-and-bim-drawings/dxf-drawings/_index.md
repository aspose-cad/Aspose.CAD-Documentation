---
title: DXF Ritningar
type: docs
weight: 10
url: /sv/python-net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **Exportera DXF Ritningar till PDF**

Aspose.CAD erbjuder funktionen att ladda AutoCAD DXF ritningsentiteter och rendera dem som en hel ritning till PDF-format. DXF till PDF konverteringsmetoden fungerar på följande sätt:

1. Ladda DXF ritningsfilen med hjälp av **Image.load** fabriksmetoden.
1. Skapa ett objekt av **CadRasterizationOptions** klassen och ställ in **page_height** & **page_width** egenskaperna.
1. Skapa ett objekt av **PdfOptions** klassen och ställ in **VectorRasterizationOptions** egenskapen.
1. Anropa **Image.save** medan du skickar ett objekt av **PdfOptions** som den andra parametern.

Kodexemplet nedan visar hur man konverterar en fil med standardinställningar.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXF-to-PDF-Export.py" >}}

### **Stödda Format**

För närvarande stöder vi helt AutoCAD DXF 2010 filformat. De tidigare DXF-versionerna garanterar inte att vara 100% giltiga. Vi planerar att inkludera fler format och funktioner i framtida Aspose.CAD versioner.

### **Stödda Enheter**

För närvarande stöder vi alla utbredda 2D-enheter och deras grundläggande standardparametrar som följer:

1. Justerad Dimension
1. Vinkeldimension
1. Båge
1. Attribut
1. Blockreferens
1. Cirkeln
1. Diameterdimension
1. Ellips
1. Fyllning
1. Linje
1. Månglinjig Text
1. Ordinate Dimension
1. Punkt
1. Polyline
1. Radial Dimension
1. Stråle
1. Vridning av dimension
1. Tabell
1. Text
1. Xlinje

{{% alert color="primary" %}}

Om vi under parsning stöter på någon enhet eller egenskap som vi inte stöder kommer enheten eller egenskapen att tyst ignoreras.

{{% /alert %}}

## **Exportera inbäddad DGN-underlag för DXF-format**

Aspose.CAD erbjuder funktionen att ladda AutoCAD DXF-filer och exportera inbäddad DGN-underlag för DXF-format.

Kodexemplet nedan visar hur man uppnår specificerade krav.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ExportEmbeddedDGN.py" >}}

## **Stöd för att Spara DXF-filer**

Aspose.CAD erbjuder funktionen att ladda AutoCAD DXF-filer, göra ändringar i dem och spara dem igen som en DXF-fil.

Kodexemplet nedan visar hur man uppnår specificerade krav.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-Drawings-SaveDXFFiles.py" >}}

## **Exportera DXF till WMF**

Denna metod fungerar på följande sätt:

1. Ladda DXF ritningsfilen med hjälp av **Image.load** fabriksmetoden.
1. Skapa ett objekt av **CadRasterizationOptions** klassen och ladda PDF-filer.
1. ställ in **page_height** & **page_width** egenskaperna.
1. Anropa **Image.save** och spara filen.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-to-WMF-Export.py" >}}
