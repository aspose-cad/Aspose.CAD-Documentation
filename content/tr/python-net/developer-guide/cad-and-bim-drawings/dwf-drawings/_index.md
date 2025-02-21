---
title: DWF Çizimleri
type: docs
weight: 50
url: /tr/python-net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **DWF Çizimlerini PDF'ye Aktarma**

Aspose.CAD, AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) çizim varlıklarını yükleme ve bunları [PDF](https://docs.fileformat.com/pdf/) formatında tam bir çizim olarak render etme özelliğini sunar. [DWF](https://docs.fileformat.com/cad/dwf/) 'den [PDF](https://docs.fileformat.com/pdf/) 'ye dönüşüm yaklaşımı şu şekilde çalışır:

1. **Image.load** fabrika yöntemini kullanarak [DWF](https://docs.fileformat.com/cad/dwf/) çizim dosyasını yükleyin.
1. **CadRasterizationOptions** sınıfının bir nesnesini oluşturun ve **page_height** & **page_width** özelliklerini ayarlayın.
1. **PdfOptions** sınıfının bir nesnesini oluşturun ve **vector_rasterization_options** özelliğini ayarlayın.
1. **Image.save** çağrısını yapın ve **PdfOptions** nesnesini ikinci parametre olarak geçin.

### Örnek Kod

Aşağıdaki kod örneği, varsayılan ayarları kullanarak bir dosyayı nasıl dönüştüreceğinizi gösterir.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-PDF-Export.py" >}}

## **DWF Çizimlerini BMP'ye Aktarma**

Aspose.CAD, AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) çizim varlıklarını yükleme ve bunları [BMP](https://docs.fileformat.com/image/bmp/) formatında tam bir çizim olarak render etme özelliğini sunar. [DWF](https://docs.fileformat.com/cad/dwf/) 'den [BMP](https://docs.fileformat.com/image/bmp/) 'ye dönüşüm yaklaşımı şu şekilde çalışır:

1. **Image.load** fabrika yöntemini kullanarak [DWF](https://docs.fileformat.com/cad/dwf/) çizim dosyasını yükleyin.
1. **CadRasterizationOptions** sınıfının bir nesnesini oluşturun ve **page_height** & **page_width** özelliklerini ayarlayın.
1. **BmpOptions** sınıfının bir nesnesini oluşturun ve **vector_rasterization_options** özelliğini ayarlayın.
1. **Image.save** çağrısını yapın ve **BmpOptions** nesnesini ikinci parametre olarak geçin.

### Örnek Kod

Aşağıdaki kod örneği, varsayılan ayarları kullanarak bir [DWF](https://docs.fileformat.com/cad/dwf/) dosyasını [BMP](https://docs.fileformat.com/image/bmp/) 'ye nasıl dönüştüreceğinizi gösterir.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-BMP-Export.py" >}}
