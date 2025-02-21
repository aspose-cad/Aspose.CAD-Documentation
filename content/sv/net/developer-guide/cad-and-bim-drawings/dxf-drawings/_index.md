---
title: DXF Ritningar
type: docs
weight: 60
url: /sv/net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **Exportera DXF Ritningar till PDF**

Aspose.CAD tillhandahåller funktionen att ladda AutoCAD DXF ritningsentiteter och rendera dem som en hel ritning i PDF-format. DXF till PDF omvandlingsmetoden fungerar som följer:

1. Ladda DXF ritningsfilen med hjälp av metoden [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Skapa ett objekt av klassen [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) och ställ in egenskaperna [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Skapa ett objekt av klassen [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) och ställ in egenskapen [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Anropa [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) medan du skickar ett objekt av [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) som den andra parametern.

Kodexemplet nedan visar hur man konverterar en fil med standardinställningar.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFToPDF-ExportDXFToPDF.cs" >}}

### **Stödda Format**

För tillfället stöder vi fullt ut AutoCAD DXF 2010 filformat. De tidigare DXF-versionerna garanteras inte vara 100% giltiga. Vi planerar att inkludera fler format och funktioner i framtida versioner av Aspose.CAD.

### **Stödda Enheter**

För tillfället stödjer vi alla utbredda 2D-enheter och deras grundläggande standardparametrar som följer:

1. Justerad Dimension
1. Vinkeldimension
1. Böj
1. Attribut
1. Blockreferens
1. Cirkeln
1. Diameterdimension
1. Ellips
1. Fyllning
1. Linje
1. Flera rader text
1. Ordinate Dimension
1. Punkt
1. Polyline
1. Radialdimension
1. Stråle
1. Rotated Dimension
1. Tabell
1. Text
1. X-line

{{% alert color="primary" %}}

Om vi under analysen stöter på en enhet eller egenskap som vi inte stöder, kommer enheten eller egenskapen att tyst ignoreras.

{{% /alert %}}

### **Minnehushantering**

Egenskapen [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) av klassen [**Cache**](https://reference.aspose.com/cad/net/aspose.cad/cache) kan användas för att kontrollera minnesomfördelning. Omfördelning är mest sannolikt att inträffa för förhandsallokerade cachar. Det kan hända när systemet inser att det allokerade utrymmet inte kommer att vara tillräckligt.

- Om [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) är inställt på standardvärdet, **False**, så omfördelas utrymmet till samma medium.
- När det är inställt på **True**, kan omfördelning inte överstiga det maximala angivna utrymmet. I detta fall frigörs den befintliga allokerade cachen i minnet (som kräver omfördelning) och ett utökat utrymme allokeras på disk.

## **Exportera Specifik Lager av DXF Ritningar till PDF**

Denna metod fungerar som följer:

1. Öppna en DXF ritningsfil med hjälp av metoden [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Skapa en instans av [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) och specificera egenskaperna [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) & [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Lägg till lager till objektet av [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Skapa en instans av [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) & ställ in dess egenskap [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Anropa metoden [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) och skicka objektet av [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) som den andra parametern.

Kodexemplet nedan visar hur man konverterar ett specifikt lager av DXF till PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayerToPDF-ExportDXFSpecificLayerToPDF.cs" >}}

## **Rendera PDF-filer som en del av DXF ritningar**

Denna metod fungerar så här:

1. Ladda DXF ritningsfilen med hjälp av metoden [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Skapa ett objekt av klassen [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) och ladda PDF-filer.
1. Ställ in egenskaperna [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Anropa [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) och spara filen.

Kodexemplet nedan visar hur man renderar PDF-filer som en del av DXF ritningar.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

## **Exportera inbäddad DGN underlag för DXF-format**

Aspose.CAD tillhandahåller funktionen att ladda AutoCAD DXF-filer och exportera inbäddat DGN-underlag för DXF-format.

Kodexemplet nedan visar hur man uppnår angivna krav.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **Stöd för att Spara DXF-filer**

Aspose.CAD tillhandahåller funktionen att ladda AutoCAD DXF-filer och göra ändringar i dem och spara dem igen som en DXF-fil.

Kodexemplet nedan visar hur man uppnår angivna krav.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-SaveDXFFiles-SaveDXFFiles.cs" >}}

## **Exportera DXF till WMF**

Denna metod fungerar så här:

1. Ladda DXF ritningsfilen med hjälp av metoden [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Skapa ett objekt av klassen [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) och ladda PDF-filer.
1. Ställ in egenskaperna [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Anropa [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) och spara filen.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportDXFToWMF-ExportDXFToWMF.cs" >}}

## **Exportera Specifik DXF Layout till PDF**

Denna metod fungerar så här:

1. Öppna en DXF ritningsfil med hjälp av metoden [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Skapa en instans av [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) och specificera egenskaperna [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) & [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Specificera de önskade layoutnamnen med egenskapen [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts).
1. Skapa en instans av [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) & ställ in dess egenskap [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Exportera ritningen till PDF genom att anropa metoden [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) och skicka objektet av [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) som den andra parametern.

Kodexemplet nedan visar hur man konverterar en specifik layout av DXF till PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

{{% alert color="primary" %}}

Egenskapen [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) är av typen string-array så att du kan specificera mer än en layout samtidigt för möjlig konvertering till PDF-format. När flera layouter specificeras för egenskapen [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts), kommer den resulterande PDF:en att ha flera sidor, där varje sida representerar en individuell AutoCAD-layouter.

{{% /alert %}}

## **Stöd för Block Klippning**

Aspose.CAD tillhandahåller funktionen för Block Klippning. Block Klippning metod fungerar så här:

1. Ladda DXF ritningsfilen med hjälp av metoden [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Skapa ett objekt av klassen [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) och ladda PDF-filer.
1. Ställ in önskade egenskaper för [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Anropa [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) medan du skickar ett objekt av [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) som andra parameter och spara filen.

Kodexemplet nedan visar hur Block Klippning fungerar.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DXF-Drawings-SupportOfBlockClipping-SupportOfBlockClipping.cs" >}}

## **Exportera Bilder till DXF**

Med hjälp av Aspose.CAD kan du exportera bilder till DXF-format. Genom att använda denna metod kan du utföra följande åtgärder:

1. Ställ in ny font
1. Dölj enheter
1. Uppdatera text

Kodsnutten nedan visar hur man utför de ovan listade åtgärder.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportImagesToDXF-ExportImagesToDXF.cs" >}}

## **Exportera Specifik Lager av DXF Ritningar till Bild**

Denna metod fungerar som följer:

1. Öppna en DXF ritningsfil med hjälp av metoden [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Skapa en instans av [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) och specificera egenskaperna [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) och [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Lägg till lager till objektet av [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Skapa en instans av [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) och ställ in dess egenskap [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Exportera ritningen till PDF med hjälp av metoden [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Kodexemplet nedan visar hur man konverterar ett specifikt lager av DXF till Bild.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.cs" >}}
