---
title: DXF Çizimleri
type: docs
weight: 10
url: /tr/python-net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **PDF'e DXF Çizimlerini Aktarma**

Aspose.CAD, AutoCAD DXF çizim varlıklarını yükleme ve bunları PDF formatında tam bir çizim olarak render etme özelliği sunar. DXF'den PDF'ye dönüşüm yaklaşımı şu şekilde çalışır:

1. **Image.load** fabrika metodunu kullanarak DXF çizim dosyasını yükleyin.
1. **CadRasterizationOptions** sınıfının bir nesnesini oluşturun ve **page_height** & **page_width** özelliklerini ayarlayın.
1. **PdfOptions** sınıfının bir nesnesini oluşturun ve **VectorRasterizationOptions** özelliğini ayarlayın.
1. **Image.save** çağrısını yaparak ikinci parametre olarak **PdfOptions** nesnesini geçin.

Aşağıdaki kod örneği, varsayılan ayarları kullanarak bir dosyanın nasıl dönüştürüleceğini göstermektedir.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXF-to-PDF-Export.py" >}}

### **Desteklenen Formatlar**

Şu anda AutoCAD DXF 2010 dosya formatlarını tamamen destekliyoruz. Önceki DXF sürümlerinin %100 geçerli olacağı garanti edilmez. Gelecekte Aspose.CAD sürümlerinde daha fazla format ve özellik eklemeyi planlıyoruz.

### **Desteklenen Varlıklar**

Şu anda yaygın olarak kullanılan tüm 2D varlıkları ve bunların temel varsayılan parametrelerini aşağıdaki gibi destekliyoruz:

1. Hizalanmış Boyut
1. Açılı Boyut
1. Yay
1. Özellik
1. Blok Referansı
1. Daire
1. Çap Boyutu
1. Elips
1. Tarama
1. Çizgi
1. Çok Satırlı Metin
1. Koordinat Boyutu
1. Nokta
1. Poligon
1. Radial Boyut
1. Işın
1. Döndürülmüş Boyut
1. Tablo
1. Metin
1. Xline

{{% alert color="primary" %}}

Parse sırasında desteklemediğimiz bir varlık veya özellik ile karşılaşılırsa, varlık veya özellik sessizce yoksayılacaktır.

{{% /alert %}}

## **DXF Formatında Gömülü DGN Altlığı Aktarımı**

Aspose.CAD, AutoCAD DXF dosyalarını yükleme ve DXF formatı için gömülü DGN altlığı aktarma özelliği sunar.

Aşağıdaki kod örneği, belirtilen gereksinimlerin nasıl sağlanacağını göstermektedir.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ExportEmbeddedDGN.py" >}}

## **DXF Dosyalarını Kaydetme Desteği**

Aspose.CAD, AutoCAD DXF dosyalarını yükleme, içinde değişiklik yapma ve tekrar DXF dosyası olarak kaydetme özelliği sunar.

Aşağıdaki kod örneği, belirtilen gereksinimlerin nasıl sağlanacağını göstermektedir.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-Drawings-SaveDXFFiles.py" >}}

## **DXF'den WMF'ye Aktarma**

Bu yaklaşım şu şekilde çalışır:

1. **Image.load** fabrika metodunu kullanarak DXF çizim dosyasını yükleyin.
1. **CadRasterizationOptions** sınıfının bir nesnesini oluşturun ve PDF dosyalarını yükleyin.
1. **page_height** & **page_width** özelliklerini ayarlayın.
1. **Image.save** çağrısını yapın ve dosyayı kaydedin.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-to-WMF-Export.py" >}}
