---
title: Чертежи FBX
type: docs
weight: 110
url: /ru/python-net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **Экспорт формата FBX в PDF**

Aspose.CAD для Python позволяет разработчикам экспортировать файл [FBX](https://docs.fileformat.com/3d/fbx/) в формат [PDF](https://docs.fileformat.com/pdf/). Подход к конвертации [FBX](https://docs.fileformat.com/3d/fbx/) в [PDF](https://docs.fileformat.com/pdf/) работает следующим образом:

1. Загрузите файл чертежа [FBX](https://docs.fileformat.com/3d/fbx/) с помощью фабричного метода **Image.load**.
1. Создайте объект класса **CadRasterizationOptions** и установите свойства **PageHeight** и **PageWidth**.
1. Создайте объект класса **PdfOptions** и установите свойство **vector_rasterization_options**.
1. Вызовите **Image.save**, передав объект **PdfOptions** в качестве второго параметра.

## Пример кода

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-FBX-to-PDF-Export.py" >}}
