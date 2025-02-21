---
title: SVG Рисунки
type: docs
weight: 170
url: /ru/python-net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **Экспортирование SVG формата в PDF**

Aspose.CAD для Python позволяет разработчикам экспортировать файл [SVG](https://docs.fileformat.com/page-description-language/svg/) в формат [PDF](https://docs.fileformat.com/pdf/). Подход к конвертации [SVG](https://docs.fileformat.com/page-description-language/svg/) в [PDF](https://docs.fileformat.com/pdf/) работает следующим образом:

1. Загрузите файл рисунка SVG, используя метод фабрики **Image.load**.
1. Создайте объект класса **CadRasterizationOptions** и установите свойства **page_height** и **page_width**.
1. Создайте объект класса **PdfOptions** и установите свойство **VectorRasterizationOptions**.
1. Вызовите **Image.save**, передав объект **PdfOptions** в качестве второго параметра.

## Пример кода

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-SVG-to-PDF-Export.py" >}}
