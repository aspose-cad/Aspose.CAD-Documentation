---
title: Exportieren von DGN AutoCAD
type: docs
weight: 50
url: /de/java/developer-guide/exporting-dgn-autocad/
---

## **Exportieren des DGN AutoCAD-Formats als PDF**

Aspose.CAD für die Java-API hat die Funktionalität eingeführt, um eine [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD-Datei zu laden und in das [PDF](https://docs.fileformat.com/pdf/)-Format zu konvertieren. Die Klasse [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) dient diesem Zweck.

Sie müssen eine vorhandene DGN-Datei als [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) laden. Erstellen Sie eine Instanz der Klasse [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) und setzen Sie verschiedene Eigenschaften. Erstellen Sie eine Instanz der Klasse [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/pdfoptions) und übergeben Sie die Instanz von [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). Rufen Sie nun die Methode [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) der Klasseninstanz [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) auf.

### Beispielscode

Im Folgenden wird die Code-Demonstration zur Konvertierung/Export von DGN in das PDF-Format gezeigt.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Beispiele-src-main-java-com-aspose-cad-Beispiele-ExportingDGN-ExportierenDGNAutoCADFormatZuPDF-ExportierenDGNAutoCADFormatZuPDF.java" >}}

## **Exportieren des DGN AutoCAD-Formats als Rasterbildformat**

Aspose.CAD für die Java-API hat die Funktionalität eingeführt, um eine [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD-Datei zu laden und in ein Rasterbild zu konvertieren. Die Klasse [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) dient diesem Zweck.

Sie müssen eine vorhandene DGN-Datei als [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) laden. Erstellen Sie eine Instanz der Klasse [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) und setzen Sie verschiedene Eigenschaften. Erstellen Sie eine Instanz der Klasse [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) und übergeben Sie die [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) Instanz. Rufen Sie nun die [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) Methode der Klasseninstanz [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) auf.

### Beispielscode

Im Folgenden wird die Code-Demonstration zur Konvertierung/Export von [DGN](https://docs.fileformat.com/cad/dgn/) in ein [JPEG](https://docs.fileformat.com/image/jpeg/)-Bild gezeigt.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Beispiele-src-main-java-com-aspose-cad-Beispiele-ExportingDGN-ExportierenDGNAutoCADFormatZuRasterbildformat-ExportierenDGNAutoCADFormatZuRasterbildformat.java" >}}
