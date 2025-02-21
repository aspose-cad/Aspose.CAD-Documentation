---
title: DRC Çizimleri
type: docs
weight: 15
url: /tr/net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **DRC Çizimlerini PDF'ye Aktarma**

Aspose.CAD, AutoCAD [DRC](https://docs.fileformat.com/3d/drc/) çizim varlıklarını yükleme ve bunları tam bir çizim olarak [PDF](https://docs.fileformat.com/pdf/) formatında render etme özelliğini sağlar. [DRC](https://docs.fileformat.com/3d/drc/) den [PDF](https://docs.fileformat.com/pdf/) dönüşüm yaklaşımı aşağıdaki gibi çalışır:

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) fabrika metodunu kullanarak [DRC](https://docs.fileformat.com/3d/drc/) çizim dosyasını yükleyin.
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) sınıfının bir nesnesini oluşturun ve [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) ve [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) özelliklerini ayarlayın.
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) sınıfının bir nesnesini oluşturun ve [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) özelliğini ayarlayın.
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) yöntemini çağırarak [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) nesnesini ikinci parametre olarak geçin.

### Örnek Kod

Aşağıdaki kod örneği, varsayılan ayarları kullanarak bir dosyayı nasıl dönüştüreceğinizi göstermektedir.

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DRC-to-PDF-Export.cs" >}}
