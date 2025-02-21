---
title: DGN AutoCAD'ı Dışa Aktarma
type: docs
weight: 50
url: /tr/java/developer-guide/exporting-dgn-autocad/
---

## **DGN AutoCAD Formatını PDF'ye Dışa Aktarma**

Aspose.CAD for Java API, bir [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD dosyasını yükleme ve bunu [PDF](https://docs.fileformat.com/pdf/) formatına dönüştürme işlevselliğini tanıttı. [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) sınıfı bu amacı taşımaktadır.

Mevcut bir DGN dosyasını [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) olarak yüklemeniz gerekir. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) sınıfının bir örneğini oluşturun ve farklı özellikler ayarlayın. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/pdfoptions) sınıfının bir örneğini oluşturun ve [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) örneğini geçin. Şimdi [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) sınıfı örneğinin [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metodunu çağırın.

### Örnek Kod

Aşağıda DGN'yi PDF formatına dönüştürmek/dışa aktarmak için bir kod gösterimi bulunmaktadır.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToPDF-ExportingDGNAutoCADFormatToPDF.java" >}}

## **DGN AutoCAD Formatını Raster Görüntü Formatına Dışa Aktarma**

Aspose.CAD for Java API, bir [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD dosyasını yükleme ve bunu raster bir görüntüye dönüştürme işlevselliğini tanıttı. [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) sınıfı bu amacı taşımaktadır.

Mevcut bir DGN dosyasını [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) olarak yüklemeniz gerekir. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) sınıfının bir örneğini oluşturun ve farklı özellikler ayarlayın. [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) sınıfının bir örneğini oluşturun ve [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) örneğini geçin. Şimdi [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) sınıfı örneğinin [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metodunu çağırın.

### Örnek Kod

Aşağıda [DGN](https://docs.fileformat.com/cad/dgn/)’yi [JPEG](https://docs.fileformat.com/image/jpeg/) görüntüsüne dönüştürmek/dışa aktarmak için bir kod gösterimi bulunmaktadır.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToRasterImageFormat-ExportingDGNAutoCADFormatToRasterImageFormat.java" >}}
