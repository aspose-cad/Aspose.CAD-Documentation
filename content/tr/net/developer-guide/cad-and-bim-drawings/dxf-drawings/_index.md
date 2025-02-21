---
title: DXF Çizimleri
type: docs
weight: 60
url: /tr/net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **DXF Çizimlerini PDF'ye Aktarma**

Aspose.CAD, AutoCAD DXF çizim varlıklarını yükleme ve bunları PDF formatında tam bir çizim olarak render etme özelliği sunar. DXF'den PDF'ye dönüşüm yaklaşımı şu şekilde çalışır:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) fabrika metodunu kullanarak DXF çizim dosyasını yükleyin.
2. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) sınıfının bir nesnesini oluşturun ve [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) ve [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) özelliklerini ayarlayın.
3. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) sınıfının bir nesnesini oluşturun ve [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) özelliğini ayarlayın.
4. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metodunu çağırarak, [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) nesnesini ikinci parametre olarak geçin.

Aşağıdaki kod örneği varsayılan ayarlarla bir dosyanın nasıl dönüştürüleceğini gösterir.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFToPDF-ExportDXFToPDF.cs" >}}

### **Desteklenen Formatlar**

Şu anda AutoCAD DXF 2010 dosya formatlarını tamamen destekliyoruz. Önceki DXF sürümlerinin %100 geçerli olduğu garanti edilmez. Gelecekte daha fazla format ve özellik eklemeyi planlıyoruz.

### **Desteklenen Varlıklar**

Şu anda, tüm yaygın 2D varlıkları ve bunların temel varsayılan parametrelerini destekliyoruz:

1. Hizalanmış Boyut
2. Açısal Boyut
3. Yay
4. Nitelik
5. Blok Referansı
6. Çember
7. Çap Boyutu
8. Elips
9. Tarama
10. Hat
11. Çok Satırlı Metin
12. Ordinat Boyutu
13. Nokta
14. Poligon
15. Radyal Boyut
16. Işın
17. Döndürülmüş Boyut
18. Tablo
19. Metin
20. Xhat

{{% alert color="primary" %}}

Eğer ayrıştırma sırasında desteklemediğimiz bir varlık veya özellik ile karşılaşılırsa, o varlık veya özellik sessiz bir şekilde yok sayılacaktır.

{{% /alert %}}

### **Hafıza Yönetimi**

[**Cache**](https://reference.aspose.com/cad/net/aspose.cad/cache) sınıfının [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) özelliği, hafıza yeniden tahsisini kontrol etmek için kullanılabilir. Yeniden tahsis süreci, önceden tahsis edilmiş önbellekler için en olası durumdur. Tahsis edilen alanın yetersiz olduğu tespit edildiğinde bu durum meydana gelebilir.

- [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) varsayılan değer olan **False** olarak ayarlandığında, alan aynı ortamda yeniden tahsis edilir.
- **True** olarak ayarlandığında, yeniden tahsis maksimum belirtilen alanı aşamaz. Bu durumda mevcut bellek içinde tahsis edilmiş önbellek (yeniden tahsis gerektiren) serbest bırakılır ve genişletilmiş alan diske tahsis edilir.

## **DXF Çizimlerinin Belirli Katmanlarını PDF'ye Aktarma**

Bu yaklaşım şu şekilde çalışır:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) fabrika metodunu kullanarak bir DXF çizim dosyası açın.
2. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) örneğini oluşturun ve [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) ve [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) özelliklerini belirtin.
3. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) nesnesine katmanlar ekleyin.
4. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) örneğini oluşturun ve [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) özelliğini ayarlayın.
5. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metodunu çağırarak, [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) nesnesini ikinci parametre olarak geçin.

Aşağıdaki kod örneği, DXF'nin belirli bir katmanını PDF'ye nasıl dönüştüreceğinizi göstermektedir.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayerToPDF-ExportDXFSpecificLayerToPDF.cs" >}}

## **DXF Çizimlerinin Bir Parçası Olarak PDF Dosyalarını Render Etme**

Bu yaklaşım şu şekilde çalışır:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) fabrika metodunu kullanarak DXF çizim dosyasını yükleyin.
2. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) sınıfının bir nesnesini oluşturun ve PDF dosyalarını yükleyin.
3. [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) ve [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) özelliklerini ayarlayın.
4. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metodunu çağırın ve dosyayı kaydedin.

Aşağıdaki kod örneği, PDF dosyalarını DXF çizimlerinin bir parçası olarak nasıl render edeceğinizi göstermektedir.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

## **DXF Formatında Gömülü DGN Alt Katmanını Aktarma**

Aspose.CAD, AutoCAD DXF dosyalarını yükleme ve DXF formatı için gömülü DGN alt katmanını dışa aktarma özelliği sunar.

Aşağıdaki kod örneği, belirtilen gereksinimlerin nasıl karşılanacağını göstermektedir.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **DXF Dosyalarını Kaydetme Desteği**

Aspose.CAD, AutoCAD DXF dosyalarını yükleyip üzerinde değişiklik yapma ve ardından DXF dosyası olarak tekrar kaydetme özelliği sunar.

Aşağıdaki kod örneği, belirtilen gereksinimlerin nasıl karşılanacağını göstermektedir.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-SaveDXFFiles-SaveDXFFiles.cs" >}}

## **DXF'yi WMF'ye Aktarma**

Bu yaklaşım şu şekilde çalışır:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) fabrika metodunu kullanarak DXF çizim dosyasını yükleyin.
2. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) sınıfının bir nesnesini oluşturun ve PDF dosyalarını yükleyin.
3. [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) ve [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) özelliklerini ayarlayın.
4. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metodunu çağırın ve dosyayı kaydedin.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportDXFToWMF-ExportDXFToWMF.cs" >}}

## **Belirli Bir DXF Düzenini PDF'ye Aktarma**

Bu yaklaşım şu şekilde çalışır:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) fabrika metodunu kullanarak bir DXF çizim dosyası açın.
2. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) örneğini oluşturun ve [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) ve [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) özelliklerini ayarlayın.
3. İstenilen düzen adı(larını) [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) özelliğini kullanarak belirtin.
4. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) örneğini oluşturun ve [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) özelliğini ayarlayın.
5. Çizimi PDF formatında dışa aktarın, [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metodunu çağırarak ve [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) nesnesini ikinci parametre olarak geçirerek.

Aşağıdaki kod örneği, DXF'nin belirli bir düzenini PDF'ye nasıl dönüştüreceğinizi göstermektedir.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

{{% alert color="primary" %}}

[**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) özelliği string dizisi tipindedir, bu nedenle PDF formatına dönüştürme için bir defada birden fazla düzen belirtilebilir. [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) özelliği için birden fazla düzen belirtildiğinde, oluşan PDF birden fazla sayfaya sahip olacaktır; her sayfa, bireysel bir AutoCAD düzenini temsil eder.

{{% /alert %}}

## **Blok Kesme Desteği**

Aspose.CAD, Blok Kesme özelliği sunar. Blok Kesme yaklaşımı şu şekilde çalışır:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) fabrika metodunu kullanarak DXF çizim dosyasını yükleyin.
2. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) sınıfının bir nesnesini oluşturun ve PDF dosyalarını yükleyin.
3. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) özelliklerini ayarlayın.
4. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metodunu çağırarak [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) nesnesini ikinci parametre olarak geçirerek dosyayı kaydedin.

Aşağıdaki kod örneği, Blok Kesme özelliğinin nasıl çalıştığını göstermektedir.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DXF-Drawings-SupportOfBlockClipping-SupportOfBlockClipping.cs" >}}

## **Görüntüleri DXF'ye Aktarma**

Aspose.CAD kullanarak, görüntüleri DXF formatına aktarabilirsiniz. Bu yaklaşımı kullanarak aşağıdaki işlemleri gerçekleştirebilirsiniz:

1. Yeni font ayarlama
2. Varlıkları gizleme
3. Metin güncelleme

Aşağıdaki kod örneği, yukarıda belirtilen işlemleri nasıl gerçekleştireceğinizi göstermektedir.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportImagesToDXF-ExportImagesToDXF.cs" >}}

## **DXF Çizimlerinin Belirli Katmanlarını Görüntüye Aktarma**

Bu yaklaşım şu şekilde çalışır:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) fabrika metodunu kullanarak bir DXF çizim dosyası açın.
2. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) örneğini oluşturun ve [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) ve [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) özelliklerini belirtin.
3. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) nesnesine katmanlar ekleyin.
4. [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) örneğini oluşturun ve [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) özelliğini ayarlayın.
5. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metodunu kullanarak çizimi PDF formatında dışa aktarın.

Aşağıdaki kod örneği, DXF'nin belirli bir katmanını Görüntüye nasıl dönüştüreceğinizi göstermektedir.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.cs" >}}
