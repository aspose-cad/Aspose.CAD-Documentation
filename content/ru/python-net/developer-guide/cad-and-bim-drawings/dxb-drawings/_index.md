---
title: Чертежи DXB
type: docs
weight: 90
url: /ru/python-net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **Экспорт формата DXB в PDF**

Aspose.CAD для Python позволяет разработчикам экспортировать файл DXB в формат [PDF](https://docs.fileformat.com/pdf/). Подход к конвертации DXB в [PDF](https://docs.fileformat.com/pdf/) работает следующим образом:

1. Загрузите файл чертежа DXB, используя метод фабрики **Image.load**.
1. Создайте объект класса **CadRasterizationOptions** и установите свойства **page_height** и **page_width**.
1. Создайте объект класса **PdfOptions** и установите свойство **vector_rasterization_options**.
1. Вызовите **Image.save**, передавая объект **PdfOptions** в качестве второго параметра.

## Пример кода

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXB-to-PDF-Export.py" >}}
