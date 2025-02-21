---
title: DGN AutoCAD'ı Dışa Aktarma
type: docs
weight: 50
url: /tr/net/developer-guide/exporting-dgn-autocad/
---

## **DGN AutoCAD Formatını PDF'ye Dışa Aktarma**

Aspose.CAD for .NET API, bir DGN AutoCAD dosyasını yükleyip PDF formatına dönüştürme işlevselliğini tanıtmıştır. [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) sınıfı bu amaç için kullanılır.

Mevcut bir DGN dosyasını [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) olarak yüklemeniz gerekir. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) sınıfının bir örneğini oluşturun ve farklı özellikleri ayarlayın. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) sınıfının bir örneğini oluşturun ve [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) örneğini geçirin. Şimdi [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metodunu [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) sınıfı örneği üzerinde çağırın.

### Örnek Kod

Aşağıda [DGN](https://docs.fileformat.com/cad/dgn/) dosyasını [PDF](https://docs.fileformat.com/pdf/) formatına dönüştürmek/dışa aktarmak için kod örneği bulunmaktadır.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **DGN AutoCAD Formatını Raster Görüntü Formatına Dışa Aktarma**

Aspose.CAD for .NET API, bir DGN AutoCAD dosyasını yükleyip raster bir görüntüye dönüştürme işlevselliğini tanıtmıştır. [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) sınıfı bu amaç için kullanılır.

Mevcut bir DGN dosyasını [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) olarak yüklemeniz gerekir. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) sınıfının bir örneğini oluşturun ve farklı özellikleri ayarlayın. [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) sınıfının bir örneğini oluşturun ve [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) örneğini geçirin. Şimdi [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metodunu [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) sınıfı örneği üzerinde çağırın.

### Örnek Kod

Aşağıda [DGN](https://docs.fileformat.com/cad/dgn/) dosyasını [JPEG](https://docs.fileformat.com/image/jpeg/) görüntüsüne dönüştürmek/dışa aktarmak için kod örneği bulunmaktadır.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-ExportDGNToRasterImage-ExportDGNToRasterImage.cs" >}}

## **DGN v7 için 3D varlık desteği**

Aspose.CAD for .NET API, bir [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD dosyasını yükleyip DGN v7 için 3D varlık desteği tanımıştır. [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) sınıfı bu amaç için kullanılır. Her [DGN](https://docs.fileformat.com/cad/dgn/) görüntüsü 9 önceden tanımlı görünümü destekler. Bu, 1 ile 9 arasında numaralandırılmıştır. Eğer dışa aktarımda görünüm tanımlanmamışsa, çok sayfalı çıktı formatları (PDF gibi) için tüm görünümler dışa aktarılacak ve her biri ayrı bir sayfada yer alacaktır. 3D varlıklar DGN dosya formatında desteklenmektedir, aynı zamanda 2D de desteklenmektedir. Bunun için [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) kullanılır, TypeOfEntities artık DGN formatı için kullanılmamaktadır (hem 2D hem de 3D eşzamanlı olarak desteklenmektedir).

### Örnek Kod

Aşağıda desteklenen DGN öğelerini görmek için örnek kod bulunmaktadır.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-SupportOf3DForDGNV7-3DSupportForDGNV7.cs" >}}
