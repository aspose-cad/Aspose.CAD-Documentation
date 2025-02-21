---
title: DWF Чертежи
type: docs
weight: 50
url: /ru/python-net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **Экспорт DWF Чертежей в PDF**

Aspose.CAD предоставляет возможность загружать сущности чертежей AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) и отображать их как целый чертеж в формате [PDF](https://docs.fileformat.com/pdf/). Подход к конвертации [DWF](https://docs.fileformat.com/cad/dwf/) в [PDF](https://docs.fileformat.com/pdf/) работает следующим образом:

1. Загружайте файл чертежа [DWF](https://docs.fileformat.com/cad/dwf/) с использованием фабричного метода **Image.load**.
1. Создайте объект класса **CadRasterizationOptions** и установите свойства **page_height** и **page_width**.
1. Создайте объект класса **PdfOptions** и установите свойство **vector_rasterization_options**.
1. Вызовите **Image.save**, передавая объект **PdfOptions** в качестве второго параметра.

### Пример кода

Пример кода ниже показывает, как конвертировать файл, используя настройки по умолчанию.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-PDF-Export.py" >}}

## **Экспорт DWF Чертежей в BMP**

Aspose.CAD предоставляет возможность загружать сущности чертежей AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) и отображать их как целый чертеж в формате [BMP](https://docs.fileformat.com/image/bmp/). Подход к конвертации [DWF](https://docs.fileformat.com/cad/dwf/) в [BMP](https://docs.fileformat.com/image/bmp/) работает следующим образом:

1. Загружайте файл чертежа [DWF](https://docs.fileformat.com/cad/dwf/) с использованием фабричного метода **Image.load**.
1. Создайте объект класса **CadRasterizationOptions** и установите свойства **page_height** и **page_width**.
1. Создайте объект класса **BmpOptions** и установите свойство **vector_rasterization_options**.
1. Вызовите **Image.save**, передавая объект **BmpOptions** в качестве второго параметра.

### Пример кода

Пример кода ниже показывает, как конвертировать файл [DWF](https://docs.fileformat.com/cad/dwf/) в [BMP](https://docs.fileformat.com/image/bmp/) с использованием настроек по умолчанию.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-BMP-Export.py" >}}
