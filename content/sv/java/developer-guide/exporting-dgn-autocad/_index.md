---
title: Exportera DGN AutoCAD
type: docs
weight: 50
url: /sv/java/developer-guide/exporting-dgn-autocad/
---

## **Exportera DGN AutoCAD-format till PDF**

Aspose.CAD för Java API har introducerat funktionen att ladda en [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD-fil och konvertera den till [PDF](https://docs.fileformat.com/pdf/) format. [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) klassen tjänar ändamålet.

Du behöver ladda en befintlig DGN-fil som [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage). Skapa en instans av klassen [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) och ställ in olika egenskaper. Skapa en instans av klassen [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/pdfoptions) och skicka instansen av [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). Nu kan du anropa metoden [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) av instansen av klassen [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage).

### Exempel på kod

Följande är koddemonstrationen för att konvertera/exportera DGN till PDF-format.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToPDF-ExportingDGNAutoCADFormatToPDF.java" >}}

## **Exportera DGN AutoCAD-format till Raster Image Format**

Aspose.CAD för Java API har introducerat funktionen att ladda en [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD-fil och konvertera den till en rasterbild. Klassen [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) tjänar ändamålet.

Du behöver ladda en befintlig DGN-fil som [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage). Skapa en instans av klassen [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) och ställ in olika egenskaper. Skapa en instans av klassen [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) och skicka instansen av [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). Nu kan du anropa metoden [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) av instansen av klassen [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage).

### Exempel på kod

Följande är koddemonstrationen för att konvertera/exportera [DGN](https://docs.fileformat.com/cad/dgn/) till [JPEG](https://docs.fileformat.com/image/jpeg/) bild.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToRasterImageFormat-ExportingDGNAutoCADFormatToRasterImageFormat.java" >}}
