---
title: Чертежи DRC
type: docs
weight: 40
url: /ru/python-net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **Экспорт формата DRC в PDF**

Aspose.CAD для Python позволяет разработчикам экспортировать файл [DRC](https://docs.fileformat.com/3d/drc/) в формат [PDF](https://docs.fileformat.com/pdf/). Подход к конвертации [DRC](https://docs.fileformat.com/3d/drc/) в [PDF](https://docs.fileformat.com/pdf/) работает следующим образом:

1. Загрузите файл чертежа DRC, используя метод фабрики **Image.load**.
1. Создайте объект класса **CadRasterizationOptions** и установите свойства **page_height** и **page_width**.
1. Создайте объект класса **PdfOptions** и установите свойство **VectorRasterizationOptions**.
1. Вызовите **Image.save**, передавая объект **PdfOptions** в качестве второго параметра.

## Пример кода


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "convert-drc-to-pdf.py" >}}
