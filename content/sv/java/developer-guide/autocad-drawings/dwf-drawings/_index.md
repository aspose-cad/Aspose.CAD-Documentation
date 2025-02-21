---
title: DWF-ritningar
type: docs
weight: 20
url: /sv/java/developer-guide/autocad-drawings/dwf-drawings/
---

## **Exportera DWF-ritningar till PDF**

Aspose.CAD för Java API kan läsa AutoCAD-ritningar i DWF-format och konvertera dem till PDF. Detta ämne förklarar användningen av Aspose.CAD API för att uppnå konverteringen av DWF till PDF-format genom enkla steg som definieras nedan.

### **Konvertera DWF-filer till PDF**

Följande enkla steg krävs för att konvertera DWF till PDF.

1. Ladda DWF-filen i en instans av [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Skapa ett objekt av klassen [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) och ställ in egenskaperna [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Skapa ett objekt av klassen [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) och ställ in egenskapen [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Anropa [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) medan du passar ett objekt av [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) som andra parameter.

Kodsnapplet nedan visar hur man exporterar en DWF-ritning till PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToPDF-ExportToPDF.java" >}}

### **Stöd för lager i DWF**

Aspose.CAD erbjuder funktionen att ladda AutoCAD DWF-ritningsenheter och rendera dem som en hel ritning i JPG-format.

1. Ladda DWF-ritningsfilen med hjälp av den [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabriksmetoden.
1. Skapa ett objekt av klassen [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Lägg till önskade lager.
1. Anropa [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) medan du passar ett objekt av [**JPEGOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) som andra parameter.

Kodsnapplet nedan visar hur man konverterar en fil med standardinställningar.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWFDrawings-SupportOfLayers-SupportOfLayers.java" >}}
