---
title: DRC Çizimleri
type: docs
weight: 40
url: /tr/python-net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **DRC Formatını PDF Olarak Dışa Aktarma**

Aspose.CAD for Python, geliştiricilerin bir [DRC](https://docs.fileformat.com/3d/drc/) dosyasını [PDF](https://docs.fileformat.com/pdf/) formatına dışa aktarmalarına olanak tanır. [DRC](https://docs.fileformat.com/3d/drc/) ile [PDF](https://docs.fileformat.com/pdf/) dönüşüm yaklaşımı şu şekilde çalışır:

1. **Image.load** fabrikası yöntemini kullanarak DRC çizim dosyasını yükleyin.
1. **CadRasterizationOptions** sınıfının bir nesnesini oluşturun ve **page_height** & **page_width** özelliklerini ayarlayın.
1. **PdfOptions** sınıfının bir nesnesini oluşturun ve **VectorRasterizationOptions** özelliğini ayarlayın.
1. **Image.save** metodunu çağırın ve **PdfOptions** nesnesini ikinci parametre olarak geçirin.

## Örnek Kod

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "convert-drc-to-pdf.py" >}}
