---
title: DXB Çizimleri
type: docs
weight: 90
url: /tr/python-net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **DXB Formatını PDF'ye Aktarma**

Aspose.CAD for Python, geliştiricilerin bir DXB dosyasını [PDF](https://docs.fileformat.com/pdf/) formatına aktarmasına olanak tanır. DXB'den [PDF](https://docs.fileformat.com/pdf/) dönüşüm yaklaşımı şu şekilde çalışır:

1. **Image.load** fabrika metodunu kullanarak DXB çizim dosyasını yükleyin.
1. **CadRasterizationOptions** sınıfının bir nesnesini oluşturun ve **page_height** ve **page_width** özelliklerini ayarlayın.
1. **PdfOptions** sınıfının bir nesnesini oluşturun ve **vector_rasterization_options** özelliğini ayarlayın.
1. **Image.save** çağrısını yaparak, **PdfOptions** nesnesini ikinci parametre olarak geçirin.

## Örnek Kod

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXB-to-PDF-Export.py" >}}
