---
title: DWF Çizimleri
type: docs
weight: 20
url: /tr/net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **DWF Çizimlerini PDF'ye Aktarma**

Aspose.CAD, AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) çizim varlıklarını yükleme ve bunları bir bütün olarak [PDF](https://docs.fileformat.com/pdf/) formatında render etme özelliği sağlar. [DWF](https://docs.fileformat.com/cad/dwf/) to [PDF](https://docs.fileformat.com/pdf/) dönüşüm yaklaşımı şu şekilde çalışır:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) fabrika metodunu kullanarak [DWF](https://docs.fileformat.com/cad/dwf/) çizim dosyasını yükleyin.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) sınıfının bir nesnesini oluşturun ve [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) özelliklerini ayarlayın.
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) sınıfının bir nesnesini oluşturun ve [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) özelliğini ayarlayın.
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metodunu çağırarak ikinci parametre olarak bir [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) nesnesi geçirin.

### Örnek Kod

Aşağıdaki kod örneği varsayılan ayarlarla bir dosyayı nasıl dönüştüreceğinizi göstermektedir.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **DWF Çiziminden Katmanları Çıkarma**

Aspose.CAD, AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) çizim varlıklarını yükleme ve bunları bir bütün olarak [JPEG](https://docs.fileformat.com/image/jpeg/) formatında render etme özelliği sağlar.

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) fabrika metodunu kullanarak [DWF](https://docs.fileformat.com/cad/dwf/) çizim dosyasını yükleyin.
1. [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) sınıfının bir nesnesini oluşturun.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) sınıfının bir nesnesini oluşturun.
1. [JPEG](https://docs.fileformat.com/image/jpeg/) nesnesini kullanarak katman adlarını çıkarın.
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metodunu çağırarak ikinci parametre olarak bir [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) nesnesi geçirin.

### Örnek Kod

Aşağıdaki kod örneği varsayılan ayarlarla bir dosyayı nasıl dönüştüreceğinizi göstermektedir.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **DWF'de Katman Desteği**

Aspose.CAD, AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) çizim varlıklarını yükleme ve bunları bir bütün olarak [JPEG](https://docs.fileformat.com/image/jpeg/) formatında render etme özelliği sağlar.

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) fabrika metodunu kullanarak [DWF](https://docs.fileformat.com/cad/dwf/) çizim dosyasını yükleyin.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) sınıfının bir nesnesini oluşturun.
1. İstenilen katmanları ekleyin.
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metodunu çağırarak ikinci parametre olarak bir [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) nesnesi geçirin.

### Örnek Kod

Aşağıdaki kod örneği varsayılan ayarlarla bir dosyayı nasıl dönüştüreceğinizi göstermektedir.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWF-Drawings-SupportOfLayers-SupportOfLayers.cs" >}}

## **DWF Çizimlerini BMP'ye Aktarma**

Aspose.CAD, AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) çizim varlıklarını yükleme ve bunları bir bütün olarak [BMP](https://docs.fileformat.com/image/bmp/) formatında render etme özelliği sağlar. [DWF](https://docs.fileformat.com/cad/dwf/) to [BMP](https://docs.fileformat.com/image/bmp/) dönüşüm yaklaşımı şu şekilde çalışır:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) fabrika metodunu kullanarak [DWF](https://docs.fileformat.com/cad/dwf/) çizim dosyasını yükleyin.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) sınıfının bir nesnesini oluşturun ve [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) özelliklerini ayarlayın.
1. [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) sınıfının bir nesnesini oluşturun ve [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) özelliğini ayarlayın.
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metodunu çağırarak ikinci parametre olarak bir [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) nesnesi geçirin.

### Örnek Kod

Aşağıdaki kod örneği varsayılan ayarlarla bir [DWF](https://docs.fileformat.com/cad/dwf/) dosyasını [BMP](https://docs.fileformat.com/image/bmp/) olarak nasıl dönüştüreceğinizi göstermektedir.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}
