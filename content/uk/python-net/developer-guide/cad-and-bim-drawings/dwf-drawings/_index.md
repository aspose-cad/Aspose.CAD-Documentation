---
title: DWF drawings
type: docs
weight: 50
url: /uk/python-net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **Експорт DWF креслень у PDF**

Aspose.CAD надає можливість завантажувати об'єкти креслень AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) та рендерити їх у вигляді цілого креслення у формат [PDF](https://docs.fileformat.com/pdf/). Підхід до конвертації [DWF](https://docs.fileformat.com/cad/dwf/) у [PDF](https://docs.fileformat.com/pdf/) працює таким чином:

1. Завантажте файл креслення [DWF](https://docs.fileformat.com/cad/dwf/) за допомогою методу-фабрики **Image.load**.
1. Створіть об'єкт класу **CadRasterizationOptions** і встановіть властивості **page_height** та **page_width**.
1. Створіть об'єкт класу **PdfOptions** та встановіть властивість **vector_rasterization_options**.
1. Викличте **Image.save**, передаючи об'єкт **PdfOptions** як другий параметр.

### Приклад коду

Приклад коду нижче показує, як конвертувати файл, використовуючи настройки за замовчуванням.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-PDF-Export.py" >}}

## **Експорт DWF креслень у BMP**

Aspose.CAD надає можливість завантажувати об'єкти креслень AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) та рендерити їх у вигляді цілого креслення у формат [BMP](https://docs.fileformat.com/image/bmp/). Підхід до конвертації [DWF](https://docs.fileformat.com/cad/dwf/) у [BMP](https://docs.fileformat.com/image/bmp/) працює таким чином:

1. Завантажте файл креслення [DWF](https://docs.fileformat.com/cad/dwf/) за допомогою методу-фабрики **Image.load**.
1. Створіть об'єкт класу **CadRasterizationOptions** і встановіть властивості **page_height** та **page_width**.
1. Створіть об'єкт класу **BmpOptions** та встановіть властивість **vector_rasterization_options**.
1. Викличте **Image.save**, передаючи об'єкт **BmpOptions** як другий параметр.

### Приклад коду

Приклад коду нижче показує, як конвертувати файл [DWF](https://docs.fileformat.com/cad/dwf/) у [BMP](https://docs.fileformat.com/image/bmp/) за допомогою налаштувань за замовчуванням.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-BMP-Export.py" >}}
