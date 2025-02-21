---
title: DXF Çizimleri
type: docs
weight: 60
url: /tr/java/developer-guide/autocad-drawings/dxf-drawings/
---

## **DXF Çizimlerini PDF'ye Aktarma**

Aspose.CAD, AutoCAD DXF çizim varlıklarını yükleme ve bunları PDF formatında bir bütün olarak render etme özelliği sağlar. DXF'den PDF'ye dönüşüm yaklaşımı şöyle çalışır:

1. **Image.load** [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabrika yöntemini kullanarak DXF çizim dosyasını yükleyin.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) sınıfının bir nesnesini oluşturun ve [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) ve [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) özelliklerini ayarlayın.
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) sınıfının bir nesnesini oluşturun ve [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) özelliğini ayarlayın.
1. İkinci parametre olarak [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) nesnesini geçirirken Image.Save metodunu çağırın.

Aşağıdaki kod örneği, bir dosyayı varsayılan ayarlarla nasıl dönüştüreceğinizi göstermektedir.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFDrawingToPDF-.java" >}}

### **Desteklenen Formatlar**

Şu anda AutoCAD DXF 2010 dosya formatlarını tamamen destekliyoruz. Önceki DXF sürümlerinin %100 geçerli olacağı garanti edilmemektedir. Gelecekte daha fazla format ve özellik eklemeyi planlıyoruz.

### **Desteklenen Varlıklar**

Şu anda tüm yaygın 2D varlıkları ve bunların temel varsayılan parametrelerini aşağıdaki gibi destekliyoruz:

1. Hizalanmış Boyut
1. Açı Boyutu
1. Yay
1. Atıf
1. Blok Referansı
1. Çember
1. Çap Boyutu
1. Elips
1. Tarama
1. Doğru
1. Çok Satırlı Metin
1. Yani Boyutu
1. Nokta
1. Poliline
1. Radyal Boyut
1. Işın
1. Döndürülmüş Boyut
1. Tablo
1. Metin
1. Xline

{{% alert color="primary" %}}

Eğer ayrıştırma sırasında desteklemediğimiz bir varlık veya özellik ile karşılaşır isek, o varlık veya özellik sessizce yok sayılacaktır.

{{% /alert %}}

### **Hafıza Yönetimi**

[**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) özelliği hafıza yeniden tahsisini kontrol etmek için kullanılabilir. Yeniden tahsis işlemi genellikle önceden tahsis edilmiş önbellekler için meydana gelir. Bu, tahsis edilen alanın yetersiz olduğu sisteme karşı belirlenirse gerçekleşebilir.

- **ExactReallocateOnly** varsayılan değeri **False** olarak ayarlandığında, alan aynı ortamda yeniden tahsis edilir.
- **True** olarak ayarlandığında, yeniden tahsis maksimum belirtilen alanı aşamaz. Bu durumda mevcut tahsis edilen bellek içi önbellek (yeniden tahsis gerektirir) serbest bırakılır ve disk üzerinde genişletilmiş alan tahsis edilir.

## **DXF Çizimlerinin Belirli Katmanlarını PDF'ye Aktarma**

Bu yaklaşım şöyle çalışır:

1. **Image.load** [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabrika yöntemini kullanarak bir DXF çizim dosyasını açın.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) nesnesini oluşturun ve [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) ve [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) özelliklerini belirleyin.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) nesnesine katmanlar ekleyin.
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) nesnesini oluşturun ve [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) özelliğini ayarlayın.
1. Çizimi PDF'ye aktarmak için [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) yöntemini kullanın.

Aşağıdaki kod örneği, DXF'nin belirli bir katmanını PDF'ye dönüştürmenin nasıl yapılacağını gösterir.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificLayerOfDXFDrawingToPDF-.java" >}}

## **DXF Çizimlerinin Belirli Katmanlarını Resme Aktarma**

Bu yaklaşım şöyle çalışır:

1. **Image.load** [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabrika yöntemini kullanarak bir DXF çizim dosyasını açın.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) nesnesini oluşturun ve [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) ve [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) özelliklerini belirleyin.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) nesnesine katmanlar ekleyin.
1. [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) nesnesini oluşturun ve [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) özelliğini ayarlayın.
1. Çizimi PDF'ye aktarmak için [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) yöntemini kullanın.

Aşağıdaki kod örneği, DXF'nin belirli bir katmanını resme dönüştürmenin nasıl yapılacağını gösterir.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.java" >}}

## **DXF Çizimlerinin Bir Parçası Olarak PDF Dosyalarını Render Etme**

Bu yaklaşım şöyle çalışır:

1. **Image.load** [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabrika yöntemini kullanarak DXF çizim dosyasını yükleyin.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) sınıfının bir nesesini oluşturun ve PDF dosyalarını yükleyin.
1. [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) ve [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) özelliklerini ayarlayın.
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metodunu çağırın ve dosyayı kaydedin.

Aşağıdaki kod örneği, PDF dosyalarını DXF çizimlerinin bir parçası olarak nasıl render edeceğinizi göstermektedir.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-RenderDXFAsPDF-RenderDXFAsPDF.java" >}}

## **DXF'yi WMF'ye Aktarma**

Bu yaklaşım şöyle çalışır:

1. **Image.load** [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabrika yöntemini kullanarak bir DXF çizim dosyasını yükleyin.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) sınıfının bir nesnesini oluşturun ve PDF dosyalarını yükleyin.
1. [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) ve [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) özelliklerini ayarlayın.
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metodunu çağırın ve dosyayı kaydedin.

Aşağıdaki kod örneği, DXF'yi WMF'ye aktarmanın nasıl yapılacağını göstermektedir.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFToWMF-ExportDXFToWMF.java" >}}

## **DXF Dosyalarını Kaydetme Desteği**

Aspose.CAD, AutoCAD DXF dosyalarını yükleme, üzerinde değişiklik yapma ve tekrar DXF dosyası olarak kaydetme özelliği sağlar. Aşağıdaki kod örneği, belirli gereksinimlere nasıl ulaşacağınızı gösterir.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SaveDXFFiles-SaveDXFFiles.java" >}}

## **DXF Formatı için Gömülü DGN Altlık Aktarma**

Aspose.CAD, AutoCAD DXF dosyalarını yükleme ve DXF formatı için gömülü DGN altlığı aktarma özelliği sağlar.

Aşağıdaki kod örneği, belirli gereksinimlere nasıl ulaşacağınızı göstermektedir.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportEmbeddedDGN-ExportEmbeddedDGN.java" >}}

## **DXF'nin Belirli Bir Düzenini PDF'ye Aktarma**

Bu yaklaşım şöyle çalışır:

1. **Image.load** [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabrika yöntemini kullanarak bir DXF çizim dosyasını açın.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) sınıfının bir nesesini oluşturun ve [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) ve [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) özelliklerini belirleyin.
1. İstenilen düzen adını [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) özelliğini kullanarak belirtin.
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) nesnesini oluşturun ve [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) özelliğini ayarlayın.
1. Çizimi PDF'ye aktarmak için [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metodunu kullanın.

Aşağıdaki kod örneği, DXF'nin belirli bir düzenini PDF'ye dönüştürmenin nasıl yapılacağını gösterir.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToPDF-.java" >}}

{{% alert color="primary" %}}

[**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) özelliği string dizisi tipindedir, böylece aynı anda birden fazla düzeni PDF formatına dönüştürmek için belirtebilirsiniz. [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) özelliği için birden fazla düzen belirttiğinizde, oluşan PDF birden fazla sayfaya sahip olacaktır; her sayfa bireysel bir AutoCAD düzenini temsil edecektir.

{{% /alert %}}

## **ATTRIB ve MTEXT Nesnelerine Erişim**

Bu yaklaşım şöyle çalışır:

1. **Image.load** [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabrika yöntemini kullanarak bir DXF çizim dosyasını açın.
1. CAD dosyasındaki varlıklara erişin.
1. [**CadEntityTypeName.MTEXT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#MTEXT) ve [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT) varlıklarını kontrol edin.
1. Geçici bir listeye ekleyin ve daha sonraki işlemler için saklayın.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-AddAttribMText-AddAttribMText.java" >}}

## **CAD Ekleme Nesnelerini Parçalama**

Bu yaklaşım şöyle çalışır:

1. **DXF** çizim dosyasını [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabrika yöntemini kullanarak açın.
1. CAD dosyasındaki varlıklara erişin.
1. [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT) varlıklarını kontrol edin.
1. [**CadBlockEntity**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity) tipi listesini kontrol edin.
1. Varlıkları işleyin.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-DecomposeCadInsertObject-DecomposeCadInsertObject.java" >}}

## **Blok Kırpma Desteği**

Aspose.CAD, Blok Kırpma özelliği sağlar. Blok Kırpma yaklaşımı şöyle çalışır:

1. **Image.load** [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabrika yöntemini kullanarak DXF çizim dosyasını yükleyin.
1. PDF dosyalarını yüklemek için [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) sınıfının bir nesnesini oluşturun.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) özelliklerini ayarlayın.
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) yöntemini çağırın ve [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) nesnesini ikinci parametre olarak geçirin ve dosyayı kaydedin.

Aşağıdaki kod örneği, Blok Kırpmanın nasıl çalıştığını göstermektedir.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SupportOfBlockClipping-SupportOfBlockClipping.java" >}}

## **Resimleri DXF'ye Aktarma**

Aspose.CAD kullanarak resimleri DXF formatına aktarabilirsiniz. Bu yaklaşımı kullanarak aşağıdaki işlemleri gerçekleştirebilirsiniz:

1. Yeni yazı tipi ayarlayın
1. Varlıkları gizleyin
1. Metni güncelleyin

Aşağıdaki kod parçacığı, yukarıda listelenen işlemleri nasıl gerçekleştireceğinizi gösterir.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-ExportImagesToDXF.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-GetFileExtension.java" >}}
