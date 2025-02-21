---
title: Малюнки COLLADA
type: docs
weight: 20
url: /uk/python-net/developer-guide/cad-and-bim-drawings/collada-drawings/
---

## **Експорт формату COLLADA в PDF**

Aspose.CAD для Python дозволяє розробникам експортувати файл [COLLADA](https://docs.fileformat.com/3d/dae/) у формат [PDF](https://docs.fileformat.com/pdf/). Підхід конвертації [COLLADA](https://docs.fileformat.com/3d/dae/) в [PDF](https://docs.fileformat.com/pdf/) працює наступним чином:

1. Завантажте файл малюнка [COLLADA](https://docs.fileformat.com/3d/dae/) за допомогою методу **Image.load**.
2. Створіть об'єкт класу **CadRasterizationOptions** і встановіть властивості **page_height** та **page_width**.
3. Створіть об'єкт класу **PdfOptions** та встановіть властивість **vector_rasterization_options**.
4. Викликайте **Image.save**, передаючи об'єкт **PdfOptions** як другий параметр.

## Приклад коду

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-COLLADA-to-PDF-Export.py" >}}
