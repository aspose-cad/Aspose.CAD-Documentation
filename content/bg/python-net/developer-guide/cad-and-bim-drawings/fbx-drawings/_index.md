---
title: Рисунки FBX
type: docs
weight: 110
url: /bg/python-net/fbx-drawings/
---

## **Експортиране на формат FBX към PDF**

Aspose.CAD за Python позволява на разработчиците да експортират файл в [FBX](https://docs.fileformat.com/3d/fbx/) формат към [PDF](https://docs.fileformat.com/pdf/). Процесът на конвертиране от [FBX](https://docs.fileformat.com/3d/fbx/) към [PDF](https://docs.fileformat.com/pdf/) работи по следния начин:

1. Зареждане на файл с рисунка в [FBX](https://docs.fileformat.com/3d/fbx/) формат чрез фабричния метод **Image.load**.
1. Създаване на обект от класа **CadRasterizationOptions** и задаване на свойствата **PageHeight** и **PageWidth**.
1. Създаване на обект от класа **PdfOptions** и настройване на свойството **vector_rasterization_options**.
1. Извикване на **Image.save**, като се подава обект от **PdfOptions** като втори параметър.

## Примерен код

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-FBX-to-PDF-Export.py" >}}
