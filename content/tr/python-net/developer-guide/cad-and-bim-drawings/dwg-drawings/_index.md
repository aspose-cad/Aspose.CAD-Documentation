---
title: DWG Çizimleri
type: docs
weight: 70
url: /tr/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **DWG Çizimlerini PDF'ye Aktarma**

Aspose.CAD for Python API, AutoCAD çizimlerini [DWG](https://docs.fileformat.com/cad/dwg/) formatında yükleyebilir ve bunları [PDF](https://docs.fileformat.com/pdf/) formatına dönüştürebilir. Bu konu, DWG'nin PDF formatına dönüştürülmesi için Aspose.CAD API'sinin kullanımını basit adımlarla açıklamaktadır.

{{% alert color="primary" %}}

API aşağıdaki AutoCAD DWG revizyonlarını desteklemektedir:

- DWG 2004 sürüm 16.0, yayın 18
- DWG 2005 sürüm 16.1
- DWG 2010 sürüm 18.0
- DWG 2013 sürüm 19.0

{{% /alert %}}

### **DWG Dosya Formatı**

Bir [DWG](https://docs.fileformat.com/cad/dwg/) binary dosyasıdır ve vektör görüntü verisi ile meta verileri içerir. Vektör görüntü verisi, CAD uygulamasına DWG'yi nasıl görüntüleyeceği hakkında talimatlar sağlar; meta veriler, dosya hakkında konuma özgü veriler ve ayrıca müşteri verileri de dahil olmak üzere çeşitli bilgileri içerebilir. DWG dosya formatı için Açık Spesifikasyonlar [bu PDF'de](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf) bulunabilir.

### **DWG Dosyalarını PDF'ye Dönüştürme**

[DWG](https://docs.fileformat.com/cad/dwg/) formatını [PDF](https://docs.fileformat.com/pdf/) formatına dönüştürmek için aşağıdaki basit adımlar gereklidir.

1. DWG dosyasını **Image** örneğine yükleyin.
1. **CadRasterizationOptions** sınıfının bir nesnesini oluşturun ve **page_height** & **page_width** özelliklerini ayarlayın.
1. **PdfOptions** sınıfının bir nesnesini oluşturun ve **VectorRasterizationOptions** özelliğini ayarlayın.
1. **Image.save** çağrısını yaparken **PdfOptions** nesnesini ikinci parametre olarak geçirin.

Aşağıdaki kod örneği, DWG Çizimlerini PDF'ye nasıl aktaracağınızı göstermektedir.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-PDF-Export.py" >}}

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

## **Belirli Bir DWG Düzenini PDF'ye Aktarma**

Bu yaklaşım şu şekilde çalışmaktadır:

1. **Aspose.CAD.Image.load** fabrika yöntemini kullanarak bir DWG dosyasını yükleyin.
1. **CadRasterizationOptions** sınıfının bir örneğini oluşturun ve sonuç sayfa yüksekliğini ve genişliğini ayarlayın.
1. **CadRasterizationOptions** nesnesi için **Layouts** özelliğini ayarlayın.
1. **PdfOptions** sınıfının bir örneğini oluşturun ve **VectorRasterizationOptions** özelliğini ayarlayın.
1. **Image.save()** yöntemini kullanarak resmi PDF'ye aktarın.

Aşağıdaki kod örneği, bir DWG'nin belirli bir düzenini PDF'ye nasıl dönüştüreceğinizi göstermektedir.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-ExportSpecificLayoutToPDF.py" >}}

## **DWG'yi PDF/A ve PDF/E'ye Aktarma**

Bu yaklaşım şu şekilde çalışmaktadır:

1. **Image.load** fabrika yöntemini kullanarak bir DWG dosyasını yükleyin.
1. **CadRasterizationOptions** sınıfının bir örneğini oluşturun.
1. **PdfOptions** sınıfının bir örneğini oluşturun ve **VectorRasterizationOptions** özelliğini ayarlayın.
1. PDF uyumluluk özelliğini ayarlayın ve kaydedin.
1. **Image.save()** yöntemini kullanarak resmi PDF'ye aktarın.

Aşağıdaki kod örneği, bir DWG dosyasını PDF/A ve PDF/E'ye nasıl dönüştüreceğinizi göstermektedir.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-to-Compliance-PDF.py" >}}

## **DWG Çizimlerini DXF'ye Dönüştürme**

Aspose.CAD, AutoCAD DWG dosyasını yükleme ve DXF formatına aktarma özelliği sunmaktadır. DWG'den DXF'ye dönüşüm yaklaşımı şu şekildedir:

1. **Image.load** fabrika yöntemini kullanarak DWG çizim dosyasını yükleyin.
1. DWG çizimini DXF formatına aktarmak için **Image.save()** yöntemini kullanın.

Aşağıdaki kod örneği, bir DWG dosyasını DXF formatına nasıl dönüştüreceğinizi göstermektedir.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-DXF.py" >}}

## **DWG Çizimlerini SVG'ye Dönüştürme**

Aspose.CAD for Python API, AutoCAD çizimlerini DWG formatında yükleyebilir ve bunları SVG'ye dönüştürebilir. Bu konu, DWG'yi SVG formatına dönüştürmek için Aspose.CAD API'sinin kullanımını basit adımlarla açıklamaktadır.

1. DWG dosyasını **Image** örneğine yükleyin.
1. **SvgOptions** sınıfının bir nesnesini oluşturun ve gerekli özellikleri ayarlayın.
1. DWG çizimini SVG'ye aktarın, **Image.save()** yöntemini kullanarak.

Aşağıdaki kod örneği, bir DWG dosyasını SVG formatına nasıl dönüştüreceğinizi göstermektedir.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-SVG.py" >}}
