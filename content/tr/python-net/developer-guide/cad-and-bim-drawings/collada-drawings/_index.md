---
title: COLLADA Çizimleri
type: docs
weight: 20
url: /tr/python-net/developer-guide/cad-and-bim-drawings/collada-drawings/
---

## **COLLADA Formatını PDF'ye Aktarma**

Aspose.CAD for Python, geliştiricilerin bir [COLLADA](https://docs.fileformat.com/3d/dae/) dosyasını [PDF](https://docs.fileformat.com/pdf/) formatına aktarmasına olanak tanır. [COLLADA](https://docs.fileformat.com/3d/dae/) ile [PDF](https://docs.fileformat.com/pdf/) dönüşüm yöntemi aşağıdaki gibi çalışır:

1. **Image.load** fabrika metodunu kullanarak bir [COLLADA](https://docs.fileformat.com/3d/dae/) çizim dosyasını yükleyin.
1. **CadRasterizationOptions** sınıfının bir nesnesini oluşturun ve **page_height** & **page_width** özelliklerini ayarlayın.
1. **PdfOptions** sınıfının bir nesnesini oluşturun ve **vector_rasterization_options** özelliğini ayarlayın.
1. İkinci parametre olarak **PdfOptions** nesnesini geçirerek **Image.save** çağrısını yapın.

## Örnek Kod

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-COLLADA-to-PDF-Export.py" >}}
