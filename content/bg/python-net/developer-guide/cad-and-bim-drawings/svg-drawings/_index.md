---
title: Изчертавания на SVG
type: документи
weight: 170
url: /bg/python-net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **Експортиране на формат SVG към PDF**

Aspose.CAD за Python позволява на разработчиците да експортират файл SVG във формат PDF. Подходът за конвертиране от SVG към PDF работи по следния начин:

1. Заредете файл с изчертаване във формат SVG, използвайки фабричния метод **Image.load**.
1. Създайте обект от класа **CadRasterizationOptions** и задайте свойствата **page_height** и **page_width**.
1. Създайте обект от класа **PdfOptions** и задайте свойството **VectorRasterizationOptions**.
1. Извикайте **Image.save**, като подадете обект от **PdfOptions** като втори параметър.

## Примерен код

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-SVG-to-PDF-Export.py" >}}
