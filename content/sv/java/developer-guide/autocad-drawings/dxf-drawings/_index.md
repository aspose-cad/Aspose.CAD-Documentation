---
title: DXF Ritningar
type: docs
weight: 60
url: /sv/java/developer-guide/autocad-drawings/dxf-drawings/
---

## **Exportera DXF Ritningar till PDF**

Aspose.CAD tillhandahåller funktionen att ladda AutoCAD DXF ritningselement och rendera dem som en hel ritning till PDF-format. DXF till PDF-konverteringsmetoden fungerar som följer:

1. Ladda DXF ritningsfilen med hjälp av metoden [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) .
1. Skapa ett objekt av klassen [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) och ställ in egenskaperna [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) .
1. Skapa ett objekt av klassen [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) och ställ in egenskapen [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Anropa Image.Save medan du skickar ett objekt av [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) som den andra parametern.

Kodexemplet nedan visar hur man konverterar en fil med standardinställningar.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFDrawingToPDF-.java" >}}

### **Stödda format**

För tillfället stödjer vi fullt ut AutoCAD DXF 2010 filformat. De tidigare DXF-versionerna garanteras inte vara 100 % giltiga. Vi planerar att inkludera fler format och funktioner i framtida versioner av Aspose.CAD.

### **Stödda enheter**

För tillfället stödjer vi alla allmänt förekommande 2D-enheter och deras grundläggande standardparametrar som följer:

1. Justerad dimension
1. Vinkelmått
1. Båge
1. Attribut
1. Blockreferens
1. Cirkel
1. Diameter
1. Ellips
1. Fyllning
1. Linje
1. Multilinjär text
1. Ordinatdimension
1. Punkt
1. Polyline
1. Radialdimension
1. Stråle
1. Rotationsdimension
1. Bord
1. Text
1. Xlinje

{{% alert color="primary" %}}

Om vi under analys stöter på en enhet eller egenskap som vi inte stödjer kommer enheten eller egenskapen att tyst ignoreras.

{{% /alert %}}

### **Minneshantering**

Egenskapen [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) kan användas för att kontrollera minnesomallokering. Ommallokering är mest troligt att förekomma för förallokerade cacher. Det kan hända när systemet inser att det allokerade utrymmet inte kommer att vara tillräckligt.

- Om [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) är inställt på standardvärdet, **False**, omallokeras utrymmet till samma medium.
- När det är inställt på **True** kan omallokeringen inte överskrida det maximala angivna utrymmet. I det här fallet frigörs den befintligt allokerade minnescache (som kräver omallokering) och utökat utrymme allokeras på disk.

## **Exportera specifik lager av DXF Ritningar till PDF**

Denna metod fungerar som följer:

1. Öppna en DXF ritningsfil med hjälp av metoden [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) .
1. Skapa en instans av [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) och specificera [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) & [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) egenskaper.
1. Lägg till lager till objektet av [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Skapa en instans av [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) & ställ in dess [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) egenskap.
1. Exportera ritningen till PDF med hjälp av metoden [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Kodexemplet nedan visar hur man konverterar ett specifikt lager av DXF till PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificLayerOfDXFDrawingToPDF-.java" >}}

## **Exportera specifik lager av DXF Ritningar till bild**

Denna metod fungerar som följer:

1. Öppna en DXF ritningsfil med hjälp av metoden [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) .
1. Skapa en instans av [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) och specificera [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) & [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) egenskaper.
1. Lägg till lager till objektet av [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions)
1. Skapa en instans av [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) & ställ in dess [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) egenskap.
1. Exportera ritningen till PDF med hjälp av metoden [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Kodexemplet nedan visar hur man konverterar ett specifikt lager av DXF till bild.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.java" >}}

## **Rendera PDF-filer som en del av DXF ritningar**

Denna metod fungerar som följer:

1. Ladda DXF ritningsfilen med hjälp av metoden [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) .
1. Skapa ett objekt av klassen [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) och ladda PDF-filer.
1. ställ in egenskaperna [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) .
1. Anropa [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) och spara filen.

Kodexemplet nedan visar hur man renderar PDF-filer som en del av DXF ritningar.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-RenderDXFAsPDF-RenderDXFAsPDF.java" >}}

## **Exportera DXF till WMF**

Denna metod fungerar som följer:

1. Ladda DXF ritningsfilen med hjälp av metoden [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) .
1. Skapa ett objekt av klassen [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) och ladda PDF-filer.
1. ställ in egenskaperna [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) .
1. Anropa [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) och spara filen.

Kodexemplet nedan visar hur man exporterar DXF till WMF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFToWMF-ExportDXFToWMF.java" >}}

## **Support för att spara DXF-filer**

Aspose.CAD tillhandahåller funktionen att ladda AutoCAD DXF-filer, göra ändringar i dem och spara dem igen som en DXF-fil. Kodexemplet nedan visar hur man uppfyller angivna krav

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SaveDXFFiles-SaveDXFFiles.java" >}}

## **Exportera inbäddad DGN-underlag för DXF-format**

Aspose.CAD tillhandahåller funktionen att ladda AutoCAD DXF-filer och exportera inbäddad DGN-underlag för DXF-format.

Kodexemplet nedan visar hur man uppfyller angivna krav.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportEmbeddedDGN-ExportEmbeddedDGN.java" >}}

## **Exportera specifik DXF-layout till PDF**

Denna metod fungerar som följer:

1. Öppna en DXF ritningsfil med hjälp av metoden [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) .
1. Skapa en instans av [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) och specificera [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) & [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) egenskaper.
1. Specificera de önskade layoutnamnen med hjälp av egenskapen [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) .
1. Skapa en instans av [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) & ställ in dess [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions)egenskap.
1. Exportera ritningen till PDF med hjälp av metoden [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Kodexemplet nedan visar hur man konverterar en specifik layout av DXF till PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToPDF-.java" >}}

{{% alert color="primary" %}}

Egenskapen [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) är av typ strängarray så att du kan specificera mer än en layout åt gången för möjlig konvertering till PDF-format. När du specificerar flera layouter för [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) egenskapen, skulle den resulterande PDF-filen ha flera sidor, där varje sida representerar en individuell AutoCAD-layout.

{{% /alert %}}

## **Åtkomst till ATTRIB och MTEXT-objekt**

Denna metod fungerar som följer:

1. Öppna en DXF ritningsfil med hjälp av metoden [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) .
1. Åtkomst till enheterna inuti CAD-filen.
1. Kontrollera för [**CadEntityTypeName.MTEXT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#MTEXT) och [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT) enheter.
1. Lägg till i temporär lista för vidare behandling

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-AddAttribMText-AddAttribMText.java" >}}

## **Dekomponera CAD-insertobjekt**

Denna metod fungerar som följer:

1. Öppna en **DXF** ritningsfil med hjälp av metoden [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) .
1. Åtkomst till enheterna inuti CAD-filen.
1. Kontrollera för [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT) enheter.
1. kontrollera för [**CadBlockEntity**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity) typ lista
1. Bearbeta enheterna

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-DecomposeCadInsertObject-DecomposeCadInsertObject.java" >}}

## **Stöd för blockklippning**

Aspose.CAD tillhandahåller funktionen för blockklippning. Blockklippning fungerar som följer:

1. Ladda DXF ritningsfilen med hjälp av metoden [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) .
1. Skapa ett objekt av klassen [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) och ladda PDF-filer.
1. Ställ in önskade egenskaper för [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Anropa [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) och skicka ett objekt av [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) som den andra parametern och spara filen.

Kodexemplet nedan visar hur blockklippning fungerar.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SupportOfBlockClipping-SupportOfBlockClipping.java" >}}

## **Exportera bilder till DXF**

Med Aspose.CAD kan du exportera bilder till DXF-formatet. Med denna metod kan du utföra följande åtgärder:

1. Ställ in nytt teckensnitt
1. Dölja enheter
1. Uppdatera text

Det följande kodexemplet visar hur du utför ovanstående åtgärder.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-ExportImagesToDXF.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-GetFileExtension.java" >}}
