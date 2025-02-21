---
title: Ч drawings STP
type: docs
weight: 70
url: /uk/net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **Експорт формату STP у PDF**

Aspose.CAD для .NET дозволяє розробникам експортувати файл [STP](https://docs.fileformat.com/3d/stp/) у формат [PDF](https://docs.fileformat.com/pdf/). Підхід конвертації [STP](https://docs.fileformat.com/3d/stp/) у [PDF](https://docs.fileformat.com/pdf/) працює наступним чином:

1. Завантажте файл креслення [STP](https://docs.fileformat.com/3d/stp/) за допомогою фабричного методу [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Створіть об'єкт класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) і встановіть властивості [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) та [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Створіть об'єкт класу [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) і встановіть властивість [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Викликайте [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), передаючи об'єкт [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) як другий параметр.

## Приклад коду

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-STP-to-PDF-Export.cs" >}}
