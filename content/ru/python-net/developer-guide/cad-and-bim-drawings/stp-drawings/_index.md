---
title: Чертежи STP
type: docs
weight: 160
url: /ru/python-net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **Экспорт формата STP в PDF**

Aspose.CAD для Python позволяет разработчикам экспортировать файл [STP](https://docs.fileformat.com/3d/stp/) в формат [PDF](https://docs.fileformat.com/pdf/). Подход к конвертации [STP](https://docs.fileformat.com/3d/stp/) в [PDF](https://docs.fileformat.com/pdf/) работает следующим образом:

1. Загрузите файл чертежа [STP](https://docs.fileformat.com/3d/stp/) с помощью метода фабрики **Image.load**.
1. Создайте объект класса **CadRasterizationOptions** и установите свойства **page_height** и **page_width**.
1. Создайте объект класса **PdfOptions** и установите свойство **vector_rasterization_options**.
1. Вызовите **Image.save**, передав объект **PdfOptions** в качестве второго параметра.

## Пример кода

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-STP-to-PDF-Export.py" >}}
