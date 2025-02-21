---
title: ДВК креслення
type: docs
weight: 15
url: /uk/net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **Експорт креслень ДВК у PDF**

Aspose.CAD надає можливість завантажувати сутності креслень AutoCAD [ДВК](https://docs.fileformat.com/3d/drc/) та відобразити їх як ціле креслення у форматі [PDF](https://docs.fileformat.com/pdf/). Підхід до конвертації [ДВК](https://docs.fileformat.com/3d/drc/) у [PDF](https://docs.fileformat.com/pdf/) працює наступним чином:

1. Завантажте файл креслення [ДВК](https://docs.fileformat.com/3d/drc/) за допомогою методу фабрики [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Створіть об'єкт класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) і встановіть властивості [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) та [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Створіть об'єкт класу [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) і встановіть властивість [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Викликайте [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), передаючи об'єкт [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) як другий параметр.

### Приклад коду

Приклад коду нижче показує, як конвертувати файл, використовуючи налаштування за замовчуванням.


{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DRC-to-PDF-Export.cs" >}}
