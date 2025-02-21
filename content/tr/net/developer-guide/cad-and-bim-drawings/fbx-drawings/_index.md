---
title: FBX Çizimleri
type: docs
weight: 70
url: /tr/net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **FBX Formatını PDF'ye Aktarma**

Aspose.CAD for .NET, geliştiricilerin bir [FBX](https://docs.fileformat.com/3d/fbx/) dosyasını [PDF](https://docs.fileformat.com/pdf/) formatına aktarmasına olanak tanır. [FBX](https://docs.fileformat.com/3d/fbx/) de [PDF](https://docs.fileformat.com/pdf/) dönüştürme yaklaşımı aşağıdaki gibi çalışır:

1. [FBX](https://docs.fileformat.com/3d/fbx/) çizim dosyasını [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) fabrika yöntemi ile yükleyin.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) sınıfından bir nesne oluşturun ve [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) ve [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) özelliklerini ayarlayın.
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) sınıfından bir nesne oluşturun ve [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) özelliğini ayarlayın.
1. Bir [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) nesnesini ikinci parametre olarak geçirerek [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) çağrısını yapın.

## Örnek Kod

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-FBX-to-PDF-Export.cs" >}}
