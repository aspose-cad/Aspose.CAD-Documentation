---
title: FBX креслення
type: docs
weight: 70
url: /uk/net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **Експорт формату FBX у PDF**

Aspose.CAD для .NET дозволяє розробникам експортувати файл [FBX](https://docs.fileformat.com/3d/fbx/) у формат [PDF](https://docs.fileformat.com/pdf/). Підхід до конвертації з [FBX](https://docs.fileformat.com/3d/fbx/) у [PDF](https://docs.fileformat.com/pdf/) працює наступним чином:

1. Завантажте файл креслення [FBX](https://docs.fileformat.com/3d/fbx/) за допомогою фабричного методу [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Створіть об'єкт класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) і задайте властивості [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) та [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Створіть об'єкт класу [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) і задайте властивість [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Викличте [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), передавши об'єкт [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) як другий параметр.

## Приклад коду

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-FBX-to-PDF-Export.cs" >}}
