---
title: Намалювання STP
type: docs
weight: 160
url: /uk/python-net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **Експорт формату STP у PDF**

Aspose.CAD для Python дозволяє розробникам експортувати файл [STP](https://docs.fileformat.com/3d/stp/) у формат [PDF](https://docs.fileformat.com/pdf/). Підхід до конвертації [STP](https://docs.fileformat.com/3d/stp/) у [PDF](https://docs.fileformat.com/pdf/) працює так:

1. Завантажте файл креслення [STP](https://docs.fileformat.com/3d/stp/) за допомогою методу конструктора **Image.load**.
1. Створіть об'єкт класу **CadRasterizationOptions** та задайте властивості **page_height** та **page_width**.
1. Створіть об'єкт класу **PdfOptions** і задайте властивість **vector_rasterization_options**.
1. Викликайте **Image.save**, передаючи об'єкт **PdfOptions** як другий параметр.

## Приклад коду

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-STP-to-PDF-Export.py" >}}
