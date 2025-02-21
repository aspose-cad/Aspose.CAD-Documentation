---
title: SVG Çizimleri
type: docs
weight: 170
url: /tr/python-net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **SVG Formatını PDF'ye Aktarma**

Aspose.CAD for Python, geliştiricilere bir [SVG](https://docs.fileformat.com/page-description-language/svg/) dosyasını [PDF](https://docs.fileformat.com/pdf/) formatına dışa aktarma olanağı sağlar. [SVG](https://docs.fileformat.com/page-description-language/svg/) den [PDF](https://docs.fileformat.com/pdf/) dönüşüm yaklaşımı şu şekilde çalışır:

1. **Image.load** fabrika yöntemini kullanarak SVG çizim dosyasını yükleyin.
1. **CadRasterizationOptions** sınıfının bir nesnesini oluşturun ve **page_height** & **page_width** özelliklerini ayarlayın.
1. **PdfOptions** sınıfının bir nesnesini oluşturun ve **VectorRasterizationOptions** özelliğini ayarlayın.
1. İkinci parametre olarak **PdfOptions** nesnesini geçirerek **Image.save** çağırın.

## Örnek Kod

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-SVG-to-PDF-Export.py" >}}
