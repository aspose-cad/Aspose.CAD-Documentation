---
title: ЧDrawings DRC
type: docs
weight: 40
url: /uk/python-net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **Експорт формату DRC у PDF**

Aspose.CAD для Python дозволяє розробникам експортувати файл [DRC](https://docs.fileformat.com/3d/drc/) у формат [PDF](https://docs.fileformat.com/pdf/). Підхід до конвертації [DRC](https://docs.fileformat.com/3d/drc/) у [PDF](https://docs.fileformat.com/pdf/) працює наступним чином:

1. Завантажте файл креслення DRC за допомогою фабричного методу **Image.load**.
1. Створіть об'єкт класу **CadRasterizationOptions** та задайте властивості **page_height** та **page_width**.
1. Створіть об'єкт класу **PdfOptions** та встановіть властивість **VectorRasterizationOptions**.
1. Викликайте **Image.save**, передаючи об'єкт **PdfOptions** як другий параметр.

## Приклад коду

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "convert-drc-to-pdf.py" >}}
