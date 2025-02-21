---
title: COLLADA Чертежи
type: docs
weight: 20
url: /ru/python-net/developer-guide/cad-and-bim-drawings/collada-drawings/
---

## **Экспорт формата COLLADA в PDF**

Aspose.CAD для Python позволяет разработчикам экспортировать файл [COLLADA](https://docs.fileformat.com/3d/dae/) в формат [PDF](https://docs.fileformat.com/pdf/). Подход к конвертации [COLLADA](https://docs.fileformat.com/3d/dae/) в [PDF](https://docs.fileformat.com/pdf/) работает следующим образом:

1. Загрузите чертежный файл [COLLADA](https://docs.fileformat.com/3d/dae/) с помощью фабричного метода **Image.load**.
1. Создайте объект класса **CadRasterizationOptions** и установите свойства **page_height** и **page_width**.
1. Создайте объект класса **PdfOptions** и установите свойство **vector_rasterization_options**.
1. Вызовите **Image.save**, передавая объект **PdfOptions** в качестве второго параметра.

## Пример кода

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-COLLADA-to-PDF-Export.py" >}}
