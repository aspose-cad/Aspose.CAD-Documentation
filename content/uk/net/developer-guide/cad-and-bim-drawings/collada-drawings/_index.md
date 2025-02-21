---
title: Ескізи COLLADA
type: docs
weight: 70
url: /uk/net/developer-guide/cad-and-bim-drawings/collada-drawings/
---

## **Експорт формату COLLADA у PDF**

Aspose.CAD для .NET дозволяє розробникам експортувати файл [COLLADA](https://docs.fileformat.com/3d/dae/) у формат [PDF](https://docs.fileformat.com/pdf/). Підхід до конвертації [COLLADA](https://docs.fileformat.com/3d/dae/) у [PDF](https://docs.fileformat.com/pdf/) працює наступним чином:

1. Завантажте файл креслення [COLLADA](https://docs.fileformat.com/3d/dae/) за допомогою фабричного методу [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
2. Створіть об'єкт класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) та встановіть властивості [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) та [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
3. Створіть об'єкт класу [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) та встановіть властивість [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
4. Викличте [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), передаючи об'єкт [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) як другий параметр.

## Приклад коду

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-COLLADA-to-PDF-Export.cs" >}}
