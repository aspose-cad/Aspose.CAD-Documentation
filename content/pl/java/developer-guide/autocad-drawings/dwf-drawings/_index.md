---
title: Rysunki DWF
type: docs
weight: 20
url: /pl/java/developer-guide/autocad-drawings/dwf-drawings/
---

## **Eksportowanie rysunków DWF do PDF**

Aspose.CAD dla Java API może ładować rysunki AutoCAD w formacie DWF i konwertować je na PDF. Ten temat wyjaśnia użycie API Aspose.CAD do osiągnięcia konwersji DWF na format PDF poprzez proste kroki opisane poniżej.

### **Konwersja plików DWF do PDF**

Poniżej przedstawione są proste kroki wymagane do konwersji DWF na PDF.

1. Załaduj plik DWF do instancji [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Utwórz obiekt klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) i ustaw właściwości [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) oraz [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Utwórz obiekt klasy [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) i ustaw właściwość [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Wywołaj [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) przekazując obiekt [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) jako drugi parametr.

Poniższy przykład kodu pokazuje, jak eksportować rysunki DWF do PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToPDF-ExportToPDF.java" >}}

### **Wsparcie warstw w DWF**

Aspose.CAD oferuje funkcję ładowania encji rysunków AutoCAD DWF i renderowania ich jako całego rysunku w formacie JPG.

1. Załaduj plik rysunku DWF używając metody fabrycznej [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Utwórz obiekt klasy [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Dodaj pożądane warstwy.
1. Wywołaj [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) przekazując obiekt [**JPEGOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) jako drugi parametr.

Poniższy przykład kodu pokazuje, jak konwertować plik, używając ustawień domyślnych.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWFDrawings-SupportOfLayers-SupportOfLayers.java" >}}
