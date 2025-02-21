---
title: DWG Çizimleri
type: docs
weight: 40
url: /tr/net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **DWG Çizimlerini PDF'ye Aktarma**

Aspose.CAD for .NET API, [DWG](https://docs.fileformat.com/cad/dwg/) formatındaki AutoCAD çizimlerini yükleyebilir ve bunları [PDF](https://docs.fileformat.com/pdf/) formatına dönüştürebilir. Bu konu, DWG'den PDF formatına dönüşüm için Aspose.CAD API kullanımını tanımlanan basit adımlarla açıklar.

{{% alert color="primary" %}}

API, aşağıdaki AutoCAD DWG revizyonlarını destekler:

- DWG 2004 versiyon 16.0 sürüm 18
- DWG 2005 versiyon 16.1
- DWG 2010 versiyon 18.0
- DWG 2013 versiyon 19.0

{{% /alert %}}

### **DWG Dosya Formatı**

Bir [DWG](https://docs.fileformat.com/cad/dwg/) dosyası, vektör görüntü verileri ve meta verileri içeren bir ikili dosyadır. Vektör görüntü verileri, CAD uygulamasına DWG'yi nasıl görüntüleyeceğine dair talimatlar verir; meta veriler, dosya hakkında çeşitli bilgileri, yerel verileri ve ayrıca istemci verilerini içerebilir. DWG dosya formatı için Açık Şartlar [bu PDF'de](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf) bulunabilir.

### **DWG Dosyalarını PDF'ye Dönüştürme**

[DWG](https://docs.fileformat.com/cad/dwg/) dosyasını [PDF](https://docs.fileformat.com/pdf/) formatına dönüştürmek için aşağıdaki basit adımlar gereklidir.

1. DWG dosyasını bir [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image) örneğine yükleyin.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) sınıfından bir nesne oluşturun ve [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) ve [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) özelliklerini ayarlayın.
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) sınıfından bir nesne oluşturun ve [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) özelliğini ayarlayın.
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) yöntemini çağırarak [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) nesnesini ikinci parametre olarak geçin.

Aşağıdaki kod örneği, DWG Çizimlerini PDF'ye aktarmanın nasıl yapılacağını gösterir.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToPDF-ExportToPDF.cs" >}}

### **Farklı Düzen Boyutlarıyla Tek PDF Oluşturma**

Aspose.CAD for .NET, DWG dosyasını farklı düzen boyutlarıyla tek bir PDF'ye dönüştürmenize olanak tanır. Bu yaklaşım şu şekilde çalışır:

1. [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) fabrika yöntemini kullanarak bir DWG dosyası yükleyin.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) sınıfından bir örnek oluşturun ve elde edilen sayfa yüksekliğini ve genişliğini ayarlayın.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) nesnesi için gerekli [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/layoutpagesizes) değerlerini ekleyin.
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) sınıfından bir örnek oluşturun ve [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) özelliğini ayarlayın.
1. [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) yöntemini kullanarak resmi PDF'ye aktarın.

Aşağıdaki kod örneği, farklı düzenlerle tek bir [PDF](https://docs.fileformat.com/pdf/) oluşturmanın nasıl yapılacağını gösterir.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.cs" >}}

### **Desteklenen AutoCAD Temel Alanları**

Aşağıdaki AutoCAD temel alanları desteklenmektedir.

- METİN
- MTEXT
- ATTDEF
- ATTRIB
- YAY
- ELİPSE
- DOLDURMA
- LİDER
- NOKTA
- VERTEX 2D
- VERTEX 3D
- POLİLİNE 2D
- LWPOLYLINE
- IŞIN
- DİSK
- BOYUT ORDINAT
- BOYUT LINEAR
- BOYUT UYUMLU
- BOYUT AÇI 3Pt
- BOYUT AÇI 2Ln
- BOYUT YAŞ
- BOYUT ÇAP
- ŞEKİL
- KATI
- SPLİN
- MLINE
- ÇİZGİ
- XÇİZGİ
- STİL
- DIMSTYLE
- LTYPE
- MLINESTYLE
- KATMAN
- GÖRÜNTÜ ALANI
- DÜZEN

## **Belirli Bir DWG Düzenini PDF'ye Aktarma**

Bu yaklaşım şu şekilde çalışır:

1. [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) fabrika yöntemini kullanarak bir DWG dosyası yükleyin.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) sınıfından bir nesne oluşturun ve elde edilen sayfa yüksekliğini ve genişliğini ayarlayın.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) nesnesi için [**Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) özelliğini ayarlayın.
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) sınıfından bir nesne oluşturun ve [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) özelliğini ayarlayın.
1. [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) yöntemini kullanarak resmi PDF'ye aktarın.

Aşağıdaki kod örneği, belirli bir DWG düzenini PDF'ye dönüştürmenin nasıl yapılacağını gösterir.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Koordinatları Belirterek DWG Belgesini İşleme**

Aspose.CAD for .NET API, artık belge genişliği ve yüksekliği koordinatlarını sağlayarak DWG belgelerini işleme özelliği sunmaktadır.

Aşağıdaki kod örneği, bir DWG belgesini nasıl işleyebileceğinizi gösterir.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-RenderDWGDocument-RenderDWGDocument.cs" >}}

## **DWG'yi Sabit Boyutla Raster veya PDF'ye Aktarma**

Aspose.CAD for .NET API, AutoCAD çizimlerini DWG formatında yükleyebilir ve bunu sabit boyut kullanarak PDF veya Raster'a dönüştürebilir.

Aşağıdaki kod örneği, bu özelliği nasıl uygulayabileceğinizi gösterir.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.cs" >}}

## **DWG'yi PDF/A ve PDF/E'ye Aktarma**

Bu yaklaşım şu şekilde çalışır:

1. [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) fabrika yöntemini kullanarak bir DWG dosyası yükleyin.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) sınıfından bir nesne oluşturun.
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) sınıfından bir nesne oluşturun ve [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) özelliğini ayarlayın.
1. PDF uyumluluk özelliğini ayarlayın ve kaydedin.
1. [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) yöntemini kullanarak resmi PDF'ye aktarın.

Aşağıdaki kod örneği, bir DWG dosyasını PDF/A ve PDF/E'ye dönüştürmenin nasıl yapılacağını gösterir.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-DWGToCompliancePDF-DWGToCompliancePDF.cs" >}}

## **DWG/DXF'yi BMP ve PDF'ye Aktarırken Yuvarlak Gizli Hatların Desteklenmesi**

Bu yaklaşım şu şekilde çalışır:

1. [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) fabrika yöntemini kullanarak bir DWG dosyası yükleyin.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) sınıfından bir nesne oluşturun ve elde edilen sayfa yüksekliğini ve genişliğini ayarlayın.
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) sınıfından bir nesne oluşturun ve [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) özelliğini ayarlayın.
1. [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) yöntemini kullanarak resmi PDF'ye aktarın.

Aşağıdaki kod örneği, bu özelliği nasıl uygulayabileceğinizi gösterir.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-SupportForHiddenLines-SupportForHiddenLines.cs" >}}

## **DWG Görüntüsü için PDF'ye Aktarılan Yazdırma Alanının Ayarlanması Desteği**

Aspose.CAD for .NET API, DWG formatındaki AutoCAD çizimlerini yükleyebilir ve bunları PDF'ye dönüştürebilir. Bu konu, DWG görüntüsü için dışa aktarılan PDF'de bir yazdırma alanı ayarlama desteğinin nasıl sağlanacağını açıklar.

Aşağıdaki kod örneği, bu özelliği nasıl uygulayabileceğinizi gösterir.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **DWG Dosyası için XREF Meta Verilerini Okuma Desteği**

1. [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) fabrika yöntemini kullanarak bir DWG dosyası yükleyin.
1. Her bir görüntü varlığında geçiş yapın.
1. Eğer bir varlık CadUnderlay ise, XREF varlığı ile meta verileri alın.

Aşağıdaki kod örneği, bu özelliği nasıl elde edebileceğinizi gösterir.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ReadXREEFMetaData-ReadXREEFMetaData.cs" >}}

[**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) özelliği string dizisi türündedir, dolayısıyla PDF formatına dönüşüm için birden fazla düzen belirtilebilir. [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) özelliği için birden fazla düzen belirtildiğinde, elde edilen PDF birden fazla sayfaya sahip olacaktır; burada her sayfa bireysel bir AutoCAD düzenini temsil eder.

### **Tüm Düzenleri Listeleme**

Aşağıdaki kod parçasını kullanarak bir AutoCAD çiziminde bulunan tüm düzenleri listeleyebilirsiniz.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-ListLayouts-ListLayouts.cs" >}}

### **DWG Formatında Alt Katman Bayraklarına Erişim**

Aspose.CAD for .NET, DWG formatında alt katman bayraklarını uygulamıştır ve geliştiricilerin bunlara erişmesine olanak tanımaktadır. Aşağıda basit bir kod gösterimi bulunmaktadır.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.cs" >}}

## **DWG Varlıklarına Destek**

Aspose.CAD for .NET API, DWG formatındaki AutoCAD çizimlerini yükleyebilir ve çalışmak için farklı varlıkları destekler.

### **MLeader Varlığına Destek**

Bir DWG, vektör görüntü verileri ve meta verileri içeren bir ikili dosyadır. Bir DWG dosyasında farklı varlıklar vardır. Aşağıdaki bölüm, DWG dosyası içindeki MLeader varlığı ile çalışma örneğini açıklar.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.cs" >}}

### **DWG Varlığını Resme Aktarma Desteği**

Bir DWG, vektör görüntü verileri ve meta verileri içeren bir ikili dosyadır. Bir DWG dosyasında farklı varlıklar vardır. Aşağıdaki bölüm, belirli bir DWG varlığını resme aktarma örneğini açıklar.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ParticularDWGToImage-ParticularDWGToImage.cs" >}}

## **DWG İçine Metin Ekleme Desteği**

Aspose.CAD for .NET API, DWG formatındaki AutoCAD çizimlerini yükleyebilir ve çalışmak için farklı varlıkları destekler. Bir DWG, vektör görüntü verileri ve meta verileri içeren bir ikili dosyadır. Bir DWG dosyasında farklı varlıklar vardır. Aşağıdaki bölüm, DWG dosyasının içine nasıl metin ekleyebileceğimizi açıklar.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-AddTextInDWG-AddTextInDWG.cs" >}}

## **DWG Dosyasına Resim İçe Aktarma Desteği**

Aspose.CAD for .NET API, DWG formatındaki AutoCAD çizimlerini yükleyebilir ve çalışmak için farklı varlıkları destekler. Bir DWG, vektör görüntü verileri ve meta verileri içeren bir ikili dosyadır. Bir DWG dosyasında farklı varlıklar vardır. Aşağıdaki bölüm, DWG dosyasının içine nasıl resim aktarabileceğimizi açıklar.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DWG-Drawings-ImportImageToDWG-ImportImageToDWG.cs" >}}

## **DWG'de Mesh Desteği**

Aspose.CAD for .NET API, artık [**CadPolyFaceMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolyfacemesh) ve [**CadPolygonMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolygonmesh) türlerini içeren mesh destekleyen varlıklara erişim sağlamaktadır. Aşağıdaki örnek, mesh türlerine nasıl erişebileceğimizi açıklamaktadır.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-MeshSupportForDWG-MeshSupportForDWG.cs" >}}

## **DWG Çizimlerini DXF'ye Dönüştürme**

Aspose.CAD, AutoCAD DWG dosyasını yükleme ve DXF formatına aktarma özelliğini sunmaktadır. DWG'den DXF'ye dönüşüm yaklaşımı şu şekilde çalışır:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) fabrika yöntemini kullanarak DWG çizim dosyasını yükleyin.
1. DWG çizimini DXF'ye [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) yöntemini kullanarak aktarın.

Aşağıdaki kod örneği, bir DWG dosyasını DXF formatına dönüştürmenin nasıl yapılacağını gösterir.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-DWGToDXF-DWGToDXF.cs" >}}

## **DWG Çizimlerini SVG'ye Dönüştürme**

Aspose.CAD for .NET API, DWG formatındaki AutoCAD çizimlerini yükleyebilir ve bunları SVG'ye dönüştürebilir. Bu konu, DWG'den SVG formatına dönüşüm için Aspose.CAD API kullanımını tanımlanan basit adımlarla açıklar.

1. DWG dosyasını bir [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image) örneğine yükleyin.
1. [**SvgOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/svgoptions) sınıfından bir nesne oluşturun ve gerekli özellikleri ayarlayın.
1. DWG çizimini SVG'ye [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) yöntemi ile aktarın.

Aşağıdaki kod örneği, bir DWG dosyasını SVG formatına dönüştürmenin nasıl yapılacağını gösterir.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToSVG-ExportToSVG.cs" >}}

## **Büyük DWG Dosyası Yükleme**

Aspose.CAD for .NET, [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image) sınıfını kullanarak çok büyük DWG dosyalarını açma kolaylığı sağlamaktadır. Artık aşağıdaki örnek kod yardımıyla büyük dosyaları kolayca açabilirsiniz.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-LargeDWGToPDF-LargeDWGToPDF.cs" >}}
