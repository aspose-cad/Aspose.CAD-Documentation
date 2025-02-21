---
title: 3DS Çizimleri
type: docs
weight: 70
url: /tr/net/developer-guide/cad-and-bim-drawings/3ds-drawings/
---

## **3DS Formatını PDF'ye Aktarma**

Aspose.CAD for .NET, geliştiricilerin bir [3DS](https://docs.fileformat.com/3d/3ds/) dosyasını [PDF](https://docs.fileformat.com/pdf/) formatına aktarmasına olanak tanır. [3DS](https://docs.fileformat.com/3d/3ds/) ile [PDF](https://docs.fileformat.com/pdf/) dönüşüm yaklaşımı şu şekilde çalışır:

1. [3DS](https://docs.fileformat.com/3d/3ds/) çizim dosyasını [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) fabrika metodunu kullanarak yükleyin.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) sınıfının bir nesnesini oluşturun ve [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) özelliklerini ayarlayın.
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) sınıfının bir nesnesini oluşturun ve [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) özelliğini ayarlayın.
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) metodunu çağırın ve ikinci parametre olarak bir [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) nesnesi geçirin.

## Örnek Kod

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-3DS-to-PDF-Export.cs" >}}
