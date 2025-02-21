---
title: DWG Чертежи
type: docs
weight: 70
url: /ru/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **Экспорт DWG чертежей в PDF**

Aspose.CAD для Python API может загружать чертежи AutoCAD в формате [DWG](https://docs.fileformat.com/cad/dwg/) и конвертировать их в [PDF](https://docs.fileformat.com/pdf/). Эта тема объясняет использование API Aspose.CAD для достижения преобразования DWG в формат PDF через простые шаги, описанные ниже.

{{% alert color="primary" %}}

API поддерживает следующие ревизии AutoCAD DWG:

- DWG 2004 версия 16.0 релиз 18
- DWG 2005 версия 16.1
- DWG 2010 версия 18.0
- DWG 2013 версия 19.0

{{% /alert %}}

### **Формат файла DWG**

[DWG](https://docs.fileformat.com/cad/dwg/) — это двоичный файл, который содержит данные векторного изображения и метаданные. Данные векторного изображения предоставляют инструкции CAD-приложению о том, как отображать DWG; метаданные могут содержать разнообразную информацию о файле, включая данные, специфичные для местоположения, а также данные клиента. Открытые спецификации для формата файла DWG можно найти [в этом PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Конвертация DWG файлов в PDF**

Для конвертации [DWG](https://docs.fileformat.com/cad/dwg/) в [PDF](https://docs.fileformat.com/pdf/) требуются следующие простые шаги.

1. Загрузите DWG файл в экземпляр **Image**.
1. Создайте объект класса **CadRasterizationOptions** и установите свойства **page_height** и **page_width**.
1. Создайте объект класса **PdfOptions** и установите свойство **VectorRasterizationOptions**.
1. Вызовите **Image.save**, передав объект **PdfOptions** в качестве второго параметра.

Пример кода ниже показывает, как экспортировать DWG чертежи в PDF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-PDF-Export.py" >}}

### **Поддерживаемые примитивы AutoCAD**

Следующие примитивы AutoCAD поддерживаются.

- TEXT
- MTEXT
- ATTDEF
- ATTRIB
- ARC
- ELLIPSE
- HATCH
- LEADER
- POINT
- VERTEX 2D
- VERTEX 3D
- POLYLINE 2D
- LWPOLYLINE
- RAY
- CIRCLE
- DIMENSION ORDINATE
- DIMENSION LINEAR
- DIMENSION ALIGNED
- DIMENSION ANG 3Pt
- DIMENSION ANG 2Ln
- DIMENSION RADIUS
- DIMENSION DIAMETER
- SHAPE
- SOLID
- SPLINE
- MLINE
- LINE
- XLINE
- STYLE
- DIMSTYLE
- LTYPE
- MLINESTYLE
- LAYER
- VIEWPORT
- LAYOUT

## **Экспорт конкретного макета DWG в PDF**

Этот подход работает следующим образом:

1. Загрузите DWG файл, используя метод фабрики **Aspose.CAD.Image.load**.
1. Создайте экземпляр класса **CadRasterizationOptions** и установите высоту и ширину результирующей страницы.
1. Установите свойство **Layouts** для объекта **CadRasterizationOptions**.
1. Создайте экземпляр класса **PdfOptions** и установите его свойство **VectorRasterizationOptions**.
1. Экспортируйте изображение в PDF, используя метод **Image.save()**.

Пример кода ниже показывает, как конвертировать конкретный макет DWG в PDF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-ExportSpecificLayoutToPDF.py" >}}

## **Экспорт DWG в PDF/A и PDF/E**

Этот подход работает следующим образом:

1. Загрузите DWG файл, используя метод фабрики **Image.load**.
1. Создайте экземпляр класса **CadRasterizationOptions**.
1. Создайте экземпляр класса **PdfOptions** и установите его свойство **VectorRasterizationOptions**.
1. Установите свойство соблюдения PDF и сохраните его.
1. Экспортируйте изображение в PDF, используя метод **Image.save()**.

Пример кода ниже показывает, как конвертировать DWG файл в PDF/A и PDF/E.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-to-Compliance-PDF.py" >}}

## **Конвертация DWG чертежей в DXF**

Aspose.CAD предоставляет возможность загружать DWG файл AutoCAD и экспортировать его в формат DXF. Подход конвертации DWG в DXF работает следующим образом:

1. Загрузите файл чертежа DWG с помощью метода фабрики **Image.load**.
1. Экспортируйте чертеж DWG в DXF, используя метод **Image.save()**.

Пример кода ниже показывает, как конвертировать DWG файл в формат DXF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-DXF.py" >}}

## **Конвертация DWG чертежей в SVG**

Aspose.CAD для Python API может загружать чертежи AutoCAD в формате DWG и конвертировать их в SVG. Эта тема объясняет использование API Aspose.CAD для достижения преобразования DWG в формат SVG через простые шаги, описанные ниже.

1. Загрузите DWG файл в экземпляр **Image**.
1. Создайте объект класса **SvgOptions** и установите необходимые свойства.
1. Экспортируйте DWG чертеж в SVG, используя метод **Image.save()**.

Пример кода ниже показывает, как конвертировать DWG файл в формат SVG.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-SVG.py" >}}
