---
title: Рисунки DXB
type: docs
weight: 90
url: /bg/python-net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **Експортиране на формат DXB към PDF**

Aspose.CAD за Python позволява на разработчиците да експортират файл DXB в [PDF](https://docs.fileformat.com/pdf/) формат. Подходът за конвертиране на DXB в [PDF](https://docs.fileformat.com/pdf/) работи по следния начин:

1. Заредете файл с рисунка DXB, използвайки фабричния метод **Image.load**.
1. Създайте обект от класа **CadRasterizationOptions** и задайте свойствата **page_height** и **page_width**.
1. Създайте обект от класа **PdfOptions** и задайте свойството **vector_rasterization_options**.
1. Извикайте **Image.save**, като подадете обект на **PdfOptions** като втори параметър.

## Примерен код

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXB-to-PDF-Export.py" >}}
