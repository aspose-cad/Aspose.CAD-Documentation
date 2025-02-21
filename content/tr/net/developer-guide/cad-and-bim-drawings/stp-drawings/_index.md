---
title: STP Çizimleri
type: docs
weight: 70
url: /tr/net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **STP Formatını PDF'ye Aktarma**

Aspose.CAD for .NET, geliştiricilerin bir [STP](https://docs.fileformat.com/3d/stp/) dosyasını [PDF](https://docs.fileformat.com/pdf/) formatına aktarmasına olanak tanır. [STP](https://docs.fileformat.com/3d/stp/) dosyasının [PDF](https://docs.fileformat.com/pdf/) formatına dönüştürülmesi şu şekilde çalışır:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) fabrika yöntemini kullanarak [STP](https://docs.fileformat.com/3d/stp/) çizim dosyasını yükleyin.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) sınıfının bir nesnesini oluşturun ve [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) ve [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) özelliklerini ayarlayın.
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) sınıfının bir nesnesini oluşturun ve [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) özelliğini ayarlayın.
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) nesnesini ikinci parametre olarak geçirirken [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) çağrısında bulunun.

## Örnek Kod

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-STP-to-PDF-Export.cs" >}}
