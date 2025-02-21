---
title: 3DS Малюнки
type: docs
weight: 70
url: /uk/net/developer-guide/cad-and-bim-drawings/3ds-drawings/
---

## **Експорт формату 3DS у PDF**

Aspose.CAD для .NET дозволяє розробникам експортувати файл [3DS](https://docs.fileformat.com/3d/3ds/) у формат [PDF](https://docs.fileformat.com/pdf/). Підхід конвертації з [3DS](https://docs.fileformat.com/3d/3ds/) у [PDF](https://docs.fileformat.com/pdf/) працює наступним чином:

1. Завантажте файл малюнка [3DS](https://docs.fileformat.com/3d/3ds/) за допомогою фабричного методу [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Створіть об'єкт класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) та налаштуйте властивості [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) та [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Створіть об'єкт класу [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) та налаштуйте властивість [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Викличте [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), передаючи об'єкт [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) як другий параметр.

## Зразок коду

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-3DS-to-PDF-Export.cs" >}}
