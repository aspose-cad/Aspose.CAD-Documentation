---
title: DWG Çizimleri
type: docs
weight: 40
url: /tr/java/developer-guide/autocad-drawings/dwg-drawings/
---

## **DWG Çizimlerini PDF'ye Aktarmak**

Aspose.CAD for Java API, DWG formatındaki AutoCAD çizimlerini yükleyebilir ve bunları PDF'ye dönüştürebilir. Bu konu, basit adımlar ile DWG'yi PDF formatına dönüştürmek için Aspose.CAD API'sinin kullanımını açıklar.

{{% alert color="primary" %}}

API, aşağıdaki AutoCAD DWG revizyonlarını destekler:

- DWG 2004 sürüm 16.0 sürüm 18
- DWG 2005 sürüm 16.1
- DWG 2010 sürüm 18.0
- DWG 2013 sürüm 19.0

{{% /alert %}}

### **DWG Dosya Formatı**

DWG, vektör resim verileri ve meta veriler içeren bir ikili dosyadır. Vektör resim verileri, CAD uygulamasına DWG'yi nasıl görüntüleyeceği hakkında talimatlar verir; meta veriler ise dosya hakkında yerel verilere ve ayrıca istemci verilerine dair çeşitli bilgileri içerebilir. DWG dosya formatı için Açık Spesifikasyonlar [bu PDF'de](https://www.opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf) bulunabilir.

### **DWG Dosyalarını PDF'ye Dönüştürme**

DWG'yi PDF'ye dönüştürmek için aşağıdaki basit adımlar gereklidir.

1. DWG dosyasını [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image) sınıfından bir örneğe yükleyin.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) sınıfının bir nesnesini oluşturun ve [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) özelliklerini ayarlayın.
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) sınıfının bir nesnesini oluşturun ve [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) özelliğini ayarlayın.
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metodunu çağırın ve [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) nesnesini ikinci parametre olarak iletin.

Aşağıdaki kod örneği, DWG Çizimlerini PDF'ye aktarmanın nasıl yapılacağını göstermektedir.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ConvertDWGFileToPDF-ConvertDWGFileToPDF.java" >}}

### **Farklı Düzen Boyutları ile Tek PDF Oluşturma**

Aspose.CAD for Java, bir DWG dosyasını farklı düzen boyutlarıyla tek bir PDF'ye dönüştürmenizi sağlar. Bu yaklaşım şöyle çalışır:

1. [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabrika metodunu kullanarak bir DWG dosyasını yükleyin.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) sınıfının bir örneğini oluşturun ve elde edilen sayfa yüksekliğini ve genişliğini ayarlayın.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) nesnesi için gerekli [**LayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setLayoutPageSizes-com.aspose.ms.System.Collections.Generic.Dictionary-) ekleyin.
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) sınıfının bir örneğini oluşturun ve [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) özelliğini ayarlayın.
1. Görüntüyü [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metodunu kullanarak PDF'ye aktarın.

Aşağıdaki kod örneği, farklı düzenlerle tek bir PDF'nin nasıl oluşturulacağını göstermektedir.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.java" >}}

### **DWG'yi PDF/A ve PDF/E'ye Aktarmak**

DWG'yi PDF'ye dönüştürmek için aşağıdaki basit adımlar gereklidir.

1. DWG dosyasını [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image) sınıfından bir örneğe yükleyin.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) sınıfının bir nesnesini oluşturun ve [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) özelliklerini ayarlayın.
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) sınıfının bir nesnesini oluşturun ve [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) özelliğini ayarlayın.
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metodunu çağırın ve [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) nesnesini ikinci parametre olarak iletin.

Aşağıdaki kod örneği, DWG Çizimlerini PDF'ye aktarmanın nasıl yapılacağını göstermektedir.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToCompliancePDF-DWGToCompliancePDF.java" >}}

### **Desteklenen AutoCAD Primitifleri**

Aşağıdaki AutoCAD primitifleri desteklenmektedir.

- TEXT
- MTEXT
- ATTDEF
- ATTRIB
- ARC
- ELLIPSE
- HATCH
- LEADER
- POINT
- VERTEX 2D
- VERTEX 3D
- POLYLINE 2D
- LWPOLYLINE
- RAY
- CIRCLE
- DIMENSION ORDINATE
- DIMENSION LINEAR
- DIMENSION ALIGNED
- DIMENSION ANG 3Pt
- DIMENSION ANG 2Ln
- DIMENSION RADIUS
- DIMENSION DIAMETER
- SHAPE
- SOLID
- SPLINE
- MLINE
- LINE
- XLINE
- STYLE
- DIMSTYLE
- LTYPE
- MLINESTYLE
- LAYER
- VIEWPORT
- LAYOUT

## **Belirli DWG Düzenini PDF'ye Aktarmak**

Bu yaklaşım şu şekilde çalışır:

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabrika metodunu kullanarak bir DWG dosyasını yükleyin.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) sınıfının bir örneğini oluşturun ve elde edilen sayfa yüksekliğini ve genişliğini ayarlayın.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) nesnesi için [**Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) özelliğini ayarlayın.
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) sınıfının bir örneğini oluşturun ve [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) özelliğini ayarlayın.
1. Görüntüyü [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metodunu kullanarak PDF'ye aktarın.

Aşağıdaki kod örneği, DWG'nin belirli bir düzeninin nasıl PDF'ye dönüştürüleceğini göstermektedir.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportSpecificDWGLayoutToPDF-ExportSpecificDWGLayoutToPDF.java" >}}

## **DWG'yi Sabit Boyut Kullanarak Raster veya PDF'ye Aktarma**

Aspose.CAD for Java API, DWG formatındaki AutoCAD çizimlerini yükleyebilir ve bunları sabit boyut kullanarak PDF veya Raster'e dönüştürebilir.

Aşağıdaki kod örneği, bu özelliğin nasıl uygulanacağını göstermektedir.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.java" >}}

## **DWG/DXF'yi BMP ve PDF'ye aktarırken yuvarlak gizli çizgiler için destek**

Bu yaklaşım şöyle çalışır:

1. [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabrika metodunu kullanarak bir DWG dosyasını yükleyin.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) sınıfının bir örneğini oluşturun.
1. Elde edilen sayfa yüksekliğini ve genişliğini ayarlamak için [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) sınıfının bir başka örneğini oluşturun.
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) sınıfının bir örneğini oluşturun ve [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) özelliğini ayarlayın.
1. Görüntüyü [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metodunu kullanarak PDF'ye aktarın.

Aşağıdaki kod örneği, bu özelliğin nasıl uygulanacağını göstermektedir.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportForHiddenLines-SupportForHiddenLines.java" >}}

## **DWG görüntüsünün çıkarılan PDF'deki baskı alanını ayarlama desteği**

Aspose.CAD for Java API, DWG formatındaki AutoCAD çizimlerini yükleyebilir ve bunları PDF'ye dönüştürebilir. Bu konu, çıkarılan PDF'deki DWG görüntüsünün baskı alanını ayarlama desteğinin nasıl sağlandığını açıklar.

Aşağıdaki kod örneği, bu özelliğin nasıl uygulanacağını göstermektedir.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **DWG dosyası için XREF meta verilerini okuma desteği**

1. [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabrika metodunu kullanarak bir DWG dosyasını yükleyin.
1. Her resim varlığı üzerinden geçin.
1. Varlık [**CadUnderlay**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadUnderlay) ise XREF varlığı ile meta veri.

Aşağıdaki kod örneği, bu özelliğin nasıl sağlanacağını göstermektedir.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ReadXREEFMetaData-ReadXREEFMetaData.java" >}}

## **Koordinatları Belirterek DWG Belgesi**

Aspose.CAD for Java API, artık belgenin genişlik ve yükseklik koordinatlarını sağlayarak DWG belgelerini işler.

Aşağıdaki kod örneği, bir DWG belgesinin nasıl işleneceğini göstermektedir.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-RenderDWGDocument-RenderDWGDocument.java" >}}

[**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#getLayouts--) özelliği string dizisi türündedir, böylece PDF formatına olası dönüşüm için birden fazla düzen belirtebilirsiniz. [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) özelliği için birden fazla düzen belirtirken, elde edilen PDF birden fazla sayfa içerecek ve her sayfa bireysel bir AutoCAD düzenini temsil edecektir.

### **Tüm Düzenleri Listele**

Bir AutoCAD çiziminde bulunan tüm düzenleri aşağıdaki kod parçacığı ile listeleyebilirsiniz.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ListAllLayoutsInAnAutoCADDrawing-ListAllLayoutsInAnAutoCADDrawing.java" >}}

## **Dış Referansın Blok Attribut Değerini Alma**

Aspose.CAD for Java API, bir blok özellikinin dış referansını almanıza olanak tanır. Aspose.CAD API, [**getXRefPathName()**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity#getXRefPathName--) özelliğini, [**CadBlockDictionary**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadBlockDictionary) koleksiyonundaki bir blok özellikinin dış referansını almak için kullanır.

Aşağıdaki kod, bir blok özelliğinin dış referansını almayı gösterir.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-GetBlockAttributeValueOfExternalReference-GetBlockAttributeValueOfExternalReference.java" >}}

## **DWG AutoCAD Dosyasında Metin Arama**

Aspose.CAD for Java API, bir DWG AutoCAD dosyasında metin aramanıza olanak tanır. Aspose.CAD API, DWG AutoCAD dosyasındaki metin varlıklarını temsil eden [**CadText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadText) sınıfını ortaya koyar. [**CadMText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadMText) sınıfı da Aspose.CAD API'sinde dahil edilmiştir çünkü bazı diğer varlıklar da metin içerebilir.

Aşağıdaki kod, DWG AutoCAD dosyasında metin aramayı göstermektedir.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchTextInDWGAutoCADFile.java" >}}

### **Belirli Düzenlerde Metin Arama**

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchForTextInSpecificLayout.java" >}}

### **DWG Formatında Alt Katman Bayraklarına Erişim**

Aspose.CAD for Java, DWG formatı için alt katman bayraklarını uygulamıştır ve geliştiricilerin bunlara erişmesine olanak tanır. Aşağıda basit bir kod gösterimi bulunmaktadır.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.java" >}}

## **DWG Varlıkları için Destek**

Aspose.CAD for Java API, DWG formatındaki AutoCAD çizimlerini yükleyebilir ve çalışmak üzere farklı varlıkları destekler.

### **MLeader Varlığı için Destek**

DWG, vektör resim verileri ve meta verileri içeren bir ikili dosyadır. DWG dosyasında farklı varlıklar vardır. Aşağıdaki bölüm, DWG dosyası içinde MLeader varlığı ile çalışmaya bir örnek sunmaktadır.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.java" >}}

### **DWG Varlığını Görüntüye Aktarma Desteği**

DWG, vektör resim verileri ve meta verileri içeren bir ikili dosyadır. DWG dosyasında farklı varlıklar vardır. Aşağıdaki bölüm, belirli bir DWG varlığını görüntüye aktarmaya bir örnek sunmaktadır.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ParticularDWGToImage-ParticularDWGToImage.java" >}}

## **DWG Dosyasına Resim Ekleme Desteği**

Aspose.CAD for Java API, DWG formatındaki AutoCAD çizimlerini yükleyebilir ve çalışmak üzere farklı varlıkları destekler. DWG, vektör resim verileri ve meta verileri içeren bir ikili dosyadır. DWG dosyasında farklı varlıklar vardır. Aşağıdaki bölüm, DWG dosyasına nasıl resim ekleyeceğimizi açıklar.

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ImportImageToDWG-ImportImageToDWG.java" >}}

## **DWG'ye Metin Ekleme Desteği**

Aspose.CAD for Java API, DWG formatındaki AutoCAD çizimlerini yükleyebilir ve çalışmak üzere farklı varlıkları destekler. DWG, vektör resim verileri ve meta verileri içeren bir ikili dosyadır. DWG dosyasında farklı varlıklar vardır. Aşağıdaki bölüm, DWG dosyasına nasıl metin ekleyeceğimizi açıklar.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-AddTextInDWG-AddTextInDWG.java" >}}

## **DWG'de Mesh Desteği**

Aspose.CAD for Java API, artık [**CadPolyFaceMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolyFaceMesh) ve [**CadPolygonMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolygonMesh) türlerini içeren mesh'leri destekleyen varlıklara erişebilir. Aşağıdaki örnek, mesh türlerine nasıl erişeceğimizi açıklar.

## **DWG Çizimlerini DXF'ye Dönüştürme**

Aspose.CAD, AutoCAD DWG dosyasını yükleyip DXF formatına aktarma özelliği sunar. DWG'den DXF'ye dönüşüm yaklaşımı şöyle çalışır:

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) fabrika metodunu kullanarak DWG çizim dosyasını yükleyin.
1. DWG çizimini [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metodunu kullanarak DXF'ye aktarın.

Aşağıdaki kod örneği, bir DWG dosyasının nasıl DXF formatına dönüştürüleceğini göstermektedir.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToDXF-DWGToDXF.java" >}}

## **DWG Çizimlerini SVG'ye Dönüştürme**

Aspose.CAD API, DWG formatındaki AutoCAD çizimlerini yükleyebilir ve bunları SVG'ye dönüştürebilir. Bu konu, DWG'yi SVG formatına dönüştürmek için Aspose.CAD API'sinin kullanımını aşağıdaki basit adımlarla açıklar.

1. DWG dosyasını [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image) sınıfından bir örneğe yükleyin.
1. [**SvgOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/SvgOptions) sınıfının bir nesfesini oluşturun ve gerekli özellikleri ayarlayın.
1. DWG çizimini [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metodunu kullanarak SVG'ye aktarın.

Aşağıdaki kod örneği, bir DWG dosyasının SVG formatına nasıl dönüştürüleceğini göstermektedir.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportToSVG-ExportToSVG.java" >}}
