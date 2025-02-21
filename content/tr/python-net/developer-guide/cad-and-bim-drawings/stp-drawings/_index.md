---
title: STP Çizimleri
type: docs
weight: 160
url: /tr/python-net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **STP Formatını PDF'ye Aktarma**

Aspose.CAD for Python, geliştiricilerin bir [STP](https://docs.fileformat.com/3d/stp/) dosyasını [PDF](https://docs.fileformat.com/pdf/) formatına aktarmasına olanak tanır. [STP](https://docs.fileformat.com/3d/stp/) dosyasını [PDF](https://docs.fileformat.com/pdf/) formatına dönüştürme yaklaşımı şu şekildedir:

1. **Image.load** fabrika metodu kullanarak [STP](https://docs.fileformat.com/3d/stp/) çizim dosyasını yükleyin.
1. **CadRasterizationOptions** sınıfının bir nesnesini oluşturun ve **page_height** & **page_width** özelliklerini ayarlayın.
1. **PdfOptions** sınıfının bir nesnesini oluşturun ve **vector_rasterization_options** özelliğini ayarlayın.
1. İkinci parametre olarak **PdfOptions** nesnesini geçirerek **Image.save** fonksiyonunu çağırın.

## Örnek Kod

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-STP-to-PDF-Export.py" >}}
