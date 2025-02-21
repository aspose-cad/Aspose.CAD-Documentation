---
title: DWF Çizimleri
type: docs
weight: 20
url: /tr/java/developer-guide/autocad-drawings/dwf-drawings/
---

## **DWF Çizimlerini PDF'ye Aktarma**

Aspose.CAD for Java API, DWF formatındaki AutoCAD çizimlerini yükleyebilir ve bunları PDF'ye dönüştürebilir. Bu konu, DWF'nin PDF formatına dönüştürülmesi için Aspose.CAD API'sinin kullanımını basit adımlarla açıklar.

### **DWF Dosyalarını PDF'ye Dönüştürme**

DWF'yi PDF'ye dönüştürmek için aşağıdaki basit adımlar gereklidir.

1. DWF dosyasını [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image) nesnesine yükleyin.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) sınıfından bir nesne oluşturun ve [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) özelliklerini ayarlayın.
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) sınıfından bir nesne oluşturun ve [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) özelliğini ayarlayın.
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metodunu çağırırken [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) nesnesini ikinci parametre olarak geçin.

Aşağıdaki kod örneği, bir DWF Çizimini PDF'ye aktarmanın nasıl yapılacağını göstermektedir.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToPDF-ExportToPDF.java" >}}

### **DWF'de Katman Desteği**

Aspose.CAD, AutoCAD DWF çizim varlıklarını yükleme ve bunları JPG formatında tüm bir çizim olarak oluşturma özelliği sağlar.

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabrika metodunu kullanarak DWF çizim dosyasını yükleyin.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) sınıfından bir nesne oluşturun.
1. İstenilen katmanları ekleyin.
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metodunu çağırırken [**JPEGOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) nesnesini ikinci parametre olarak geçin.

Aşağıdaki kod örneği, varsayılan ayarlarla bir dosyanın nasıl dönüştürüleceğini göstermektedir.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWFDrawings-SupportOfLayers-SupportOfLayers.java" >}}
