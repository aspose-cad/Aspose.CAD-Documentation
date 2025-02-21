---
title: COLLADA Çizimleri
type: docs
weight: 70
url: /tr/net/developer-guide/cad-and-bim-drawings/collada-drawings/
---

## **COLLADA Formatını PDF'ye Aktarma**

Aspose.CAD for .NET, geliştiricilerin bir [COLLADA](https://docs.fileformat.com/3d/dae/) dosyasını [PDF](https://docs.fileformat.com/pdf/) formatına aktarmasına olanak tanır. [COLLADA](https://docs.fileformat.com/3d/dae/) dosyasının [PDF](https://docs.fileformat.com/pdf/) formatına dönüştürülme süreci şu şekildedir:

1. [COLLADA](https://docs.fileformat.com/3d/dae/) çizim dosyasını [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) fabrika metodunu kullanarak yükleyin.
2. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) sınıfından bir nesne oluşturun ve [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) ve [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) özelliklerini ayarlayın.
3. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) sınıfından bir nesne oluşturun ve [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) özelliğini ayarlayın.
4. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) yöntemini çağırarak, ikinci parametre olarak bir [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) nesnesi geçirin.

## Örnek Kod

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-COLLADA-to-PDF-Export.cs" >}}
