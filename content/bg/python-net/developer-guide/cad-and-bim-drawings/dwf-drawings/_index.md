---
title: Изображения DWF
type: документация
weight: 50
url: /python-net/izobrajeniya-dwf/
---

## **Експортиране на изображения DWF към PDF**

Aspose.CAD предоставя възможност за зареждане на единици за рисуване от AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) и тяхното превръщане в цяло изображение във формат [PDF](https://docs.fileformat.com/pdf/). Процесът на конвертиране от [DWF](https://docs.fileformat.com/cad/dwf/) към [PDF](https://docs.fileformat.com/pdf/) работи по следния начин:

1. Заредете файл за рисуване [DWF](https://docs.fileformat.com/cad/dwf/) използвайки фабричния метод **Image.load**.
1. Създайте обект от класа **CadRasterizationOptions** и задайте свойствата **page_height** и **page_width**.
1. Създайте обект от класа **PdfOptions** и задайте свойството **vector_rasterization_options**.
1. Извикайте **Image.save**, като подадете обект от **PdfOptions** като втори параметър.

### Примерен код

Подолу е показан примерен код за конвертиране на файл със стандартни настройки.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-PDF-Export.py" >}}

## **Експортиране на изображения DWF към BMP**

Aspose.CAD предоставя възможност за зареждане на единици за рисуване от AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) и тяхното превръщане в цяло изображение във формат [BMP](https://docs.fileformat.com/image/bmp/). Процесът на конвертиране от [DWF](https://docs.fileformat.com/cad/dwf/) към [BMP](https://docs.fileformat.com/image/bmp/) работи по следния начин:

1. Заредете файл за рисуване [DWF](https://docs.fileformat.com/cad/dwf/) използвайки фабричния метод **Image.load**.
1. Създайте обект от класа **CadRasterizationOptions** и задайте свойствата **page_height** и **page_width**.
1. Създайте обект от класа **BmpOptions** и задайте свойството **vector_rasterization_options**.
1. Извикайте **Image.save**, като подадете обект от **BmpOptions** като втори параметър.

### Примерен код

Примерният код долу показва как да конвертирате файл от [DWF](https://docs.fileformat.com/cad/dwf/) към [BMP](https://docs.fileformat.com/image/bmp/) със стандартни настройки.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-BMP-Export.py" >}}
