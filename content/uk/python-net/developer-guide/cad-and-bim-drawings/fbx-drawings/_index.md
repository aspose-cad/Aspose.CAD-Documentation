---
title: FBX креслення
type: docs
weight: 110
url: /uk/python-net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **Експорт формату FBX у PDF**

Aspose.CAD для Python дозволяє розробникам експортувати файл [FBX](https://docs.fileformat.com/3d/fbx/) у формат [PDF](https://docs.fileformat.com/pdf/). Підхід до конверсії [FBX](https://docs.fileformat.com/3d/fbx/) в [PDF](https://docs.fileformat.com/pdf/) працює наступним чином:

1. Завантажте файл креслення [FBX](https://docs.fileformat.com/3d/fbx/) за допомогою фабричного методу **Image.load**.
1. Створіть об'єкт класу **CadRasterizationOptions** та встановіть властивості **PageHeight** та **PageWidth**.
1. Створіть об'єкт класу **PdfOptions** та встановіть властивість **vector_rasterization_options**.
1. Викликайте **Image.save**, передаючи об'єкт **PdfOptions** як другий параметр.

## Приклад коду

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-FBX-to-PDF-Export.py" >}}
