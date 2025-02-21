---
title: Eksportowanie formatu DGN AutoCAD
type: docs
weight: 50
url: /pl/java/developer-guide/exporting-dgn-autocad/
---

## **Eksportowanie formatu DGN AutoCAD do PDF**

Aspose.CAD dla Java API wprowadziło funkcjonalność ładowania pliku [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD i konwertowania go na format [PDF](https://docs.fileformat.com/pdf/). Klasa [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) służy temu celowi.

Musisz załadować istniejący plik DGN jako [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage). Utwórz instancję klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) i ustaw różne właściwości. Utwórz instancję klasy [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/pdfoptions) i przekaż instancję [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). Teraz wywołaj metodę [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) instancji klasy [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage).

### Przykładowy kod

Poniżej znajduje się demonstracja kodu do konwersji/eksportu DGN do formatu PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToPDF-ExportingDGNAutoCADFormatToPDF.java" >}}

## **Eksportowanie formatu DGN AutoCAD do formatu rastrowego**

Aspose.CAD dla Java API wprowadziło funkcjonalność ładowania pliku [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD i konwertowania go do obrazu rastrowego. Klasa [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) służy temu celowi.

Musisz załadować istniejący plik DGN jako [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage). Utwórz instancję klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) i ustaw różne właściwości. Utwórz instancję klasy [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) i przekaż instancję [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). Teraz wywołaj metodę [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) instancji klasy [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage).

### Przykładowy kod

Poniżej znajduje się demonstracja kodu do konwersji/eksportu [DGN](https://docs.fileformat.com/cad/dgn/) do obrazu [JPEG](https://docs.fileformat.com/image/jpeg/).

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToRasterImageFormat-ExportingDGNAutoCADFormatToRasterImageFormat.java" >}}
