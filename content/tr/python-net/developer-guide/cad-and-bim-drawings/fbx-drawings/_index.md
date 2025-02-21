---
title: FBX Çizimleri
type: docs
weight: 110
url: /tr/python-net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **FBX Formatını PDF'ye Aktarma**

Aspose.CAD for Python, geliştiricilerin bir [FBX](https://docs.fileformat.com/3d/fbx/) dosyasını [PDF](https://docs.fileformat.com/pdf/) formatına aktarmasına olanak tanır. [FBX](https://docs.fileformat.com/3d/fbx/) ile [PDF](https://docs.fileformat.com/pdf/) dönüşüm yöntemi aşağıdaki gibi çalışır:

1. **Image.load** fabrika yöntemini kullanarak [FBX](https://docs.fileformat.com/3d/fbx/) çizim dosyasını yükleyin.
1. **CadRasterizationOptions** sınıfından bir nesne oluşturun ve **PageHeight** & **PageWidth** özelliklerini ayarlayın.
1. **PdfOptions** sınıfından bir nesne oluşturun ve **vector_rasterization_options** özelliğini ayarlayın.
1. İkinci parametre olarak **PdfOptions** nesnesini geçirerek **Image.save** metodunu çağırın.

## Örnek Kod

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-FBX-to-PDF-Export.py" >}}
