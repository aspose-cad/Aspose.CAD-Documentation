---
title: DGN AutoCAD Exporteren
type: docs
weight: 50
url: /nl/java/developer-guide/exporting-dgn-autocad/
---

## **DGN AutoCAD-indeling naar PDF exporteren**

Aspose.CAD voor Java API heeft de functionaliteit geïntroduceerd om een [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD-bestand te laden en om te zetten naar [PDF](https://docs.fileformat.com/pdf/) indeling. De [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) klasse vervult dit doel.

Je moet een bestaand DGN-bestand laden als [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage). Maak een instantie van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) klasse en stel verschillende eigenschappen in. Maak een instantie van de [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/pdfoptions) klasse en geef de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) instantie door. Roep nu de [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) methode van de [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) klasse-instantie aan.

### Voorbeeldcode

Hieronder staat de code om DGN naar PDF-indeling te converteren/exporteren.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToPDF-ExportingDGNAutoCADFormatToPDF.java" >}}

## **DGN AutoCAD-indeling naar rasterafbeeldingsindeling exporteren**

Aspose.CAD voor Java API heeft de functionaliteit geïntroduceerd om een [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD-bestand te laden en om te zetten naar een rasterafbeelding. De [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) klasse vervult dit doel.

Je moet een bestaand DGN-bestand laden als [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage). Maak een instantie van de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) klasse en stel verschillende eigenschappen in. Maak een instantie van de [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) klasse en geef de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) instantie door. Roep nu de [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) methode van de [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) klasse-instantie aan.

### Voorbeeldcode

Hieronder staat de code om [DGN](https://docs.fileformat.com/cad/dgn/) naar [JPEG](https://docs.fileformat.com/image/jpeg/) afbeelding te converteren/exporteren.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToRasterImageFormat-ExportingDGNAutoCADFormatToRasterImageFormat.java" >}}
