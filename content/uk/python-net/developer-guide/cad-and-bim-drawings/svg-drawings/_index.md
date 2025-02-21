---
title: SVG Малюнки
type: docs
weight: 170
url: /uk/python-net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **Експорт формату SVG до PDF**

Aspose.CAD для Python дозволяє розробникам експортувати файл [SVG](https://docs.fileformat.com/page-description-language/svg/) у формат [PDF](https://docs.fileformat.com/pdf/). Підхід до конвертації [SVG](https://docs.fileformat.com/page-description-language/svg/) у [PDF](https://docs.fileformat.com/pdf/) працює наступним чином:

1. Завантажте файл малюнка SVG, використовуючи фабричний метод **Image.load**.
1. Створіть об'єкт класу **CadRasterizationOptions** та встановіть властивості **page_height** та **page_width**.
1. Створіть об'єкт класу **PdfOptions** та встановіть властивість **VectorRasterizationOptions**.
1. Викликайте **Image.save**, передаючи об'єкт **PdfOptions** як другий параметр.

## Приклад коду

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-SVG-to-PDF-Export.py" >}}
