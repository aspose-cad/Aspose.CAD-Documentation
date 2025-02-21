---
title: DXB Малюнки
type: docs
weight: 90
url: /uk/python-net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **Експорт формату DXB у PDF**

Aspose.CAD для Python дозволяє розробникам експортувати файл DXB у формат [PDF](https://docs.fileformat.com/pdf/). Перетворення DXB у [PDF](https://docs.fileformat.com/pdf/) виконується наступним чином:

1. Завантажте файл малюнка DXB, використовуючи фабричний метод **Image.load**.
1. Створіть об'єкт класу **CadRasterizationOptions** та задайте властивості **page_height** та **page_width**.
1. Створіть об'єкт класу **PdfOptions** та задайте властивість **vector_rasterization_options**.
1. Викличте **Image.save**, передаючи об'єкт **PdfOptions** як другий параметр.

## Приклад коду

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXB-to-PDF-Export.py" >}}
