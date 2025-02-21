---
title: DWG Чертежи
type: docs
weight: 40
url: /ru/net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **Экспорт DWG чертежей в PDF**

Aspose.CAD для .NET API может загружать чертежи AutoCAD в формате [DWG](https://docs.fileformat.com/cad/dwg/) и конвертировать их в [PDF](https://docs.fileformat.com/pdf/). Эта тема объясняет использование Aspose.CAD API для достижения конвертации DWG в PDF формат через простые шаги, описанные далее.

{{% alert color="primary" %}}

API поддерживает следующие ревизии AutoCAD DWG:

- DWG 2004 версия 16.0 релиз 18
- DWG 2005 версия 16.1
- DWG 2010 версия 18.0
- DWG 2013 версия 19.0

{{% /alert %}}

### **Формат файла DWG**

[DWG](https://docs.fileformat.com/cad/dwg/) — это бинарный файл, который содержит данные векторного изображения и метаданные. Данные векторного изображения предоставляют инструкции приложению CAD о том, как отображать DWG; метаданные могут содержать различные сведения о файле, включая специфические для местоположения данные и данные о клиенте. Открытые спецификации для формата файла DWG можно найти [в этом PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Конвертирование файлов DWG в PDF**

Для конвертации [DWG](https://docs.fileformat.com/cad/dwg/) в [PDF](https://docs.fileformat.com/pdf/) требуются следующие простые шаги:

1. Загрузите файл DWG в экземпляр [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Создайте объект класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) и установите свойства [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) и [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Создайте объект класса [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) и установите его свойство [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Вызовите [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save), передав объект [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) в качестве второго параметра.

Ниже приведен пример кода, который показывает, как экспортировать DWG чертежи в PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToPDF-ExportToPDF.cs" >}}

### **Создание одного PDF с различными размерами макета**

Aspose.CAD для .NET позволяет вам конвертировать файл DWG в один PDF с различными размерами макета. Этот подход работает следующим образом:

1. Загрузите файл DWG с помощью метода фабрики [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Создайте экземпляр класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) и установите размеры результирующей страницы.
1. Добавьте необходимые [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/layoutpagesizes) для объекта [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Создайте экземпляр класса [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) и установите его свойство [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Экспортируйте изображение в PDF, используя метод [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Ниже приведен пример кода, который показывает, как создать один [PDF](https://docs.fileformat.com/pdf/) с различными макетами.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.cs" >}}

### **Поддерживаемые примитивы AutoCAD**

Поддерживаются следующие примитивы AutoCAD.

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

1. Загрузите файл DWG с помощью метода фабрики [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Создайте экземпляр класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) и установите размеры результирующей страницы.
1. Установите свойство [**Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) для объекта [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Создайте экземпляр класса [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) и установите его свойство [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Экспортируйте изображение в PDF, используя метод [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Ниже приведен пример кода, который показывает, как конвертировать конкретный макет DWG в PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Отображение документа DWG, указывая координаты**

Aspose.CAD для .NET API теперь предоставляет возможность отображать документы DWG, предоставляя координаты ширины и высоты документа.

Ниже приведен пример кода, который показывает, как отобразить документ DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-RenderDWGDocument-RenderDWGDocument.cs" >}}

## **Экспорт DWG в растр или PDF с фиксированным размером**

Aspose.CAD для .NET API может загружать чертежи AutoCAD в формате DWG и конвертировать их в PDF или растр с использованием фиксированного размера.

Ниже приведен пример кода, который показывает, как реализовать эту функцию.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.cs" >}}

## **Экспорт DWG в PDF/A и PDF/E**

Этот подход работает следующим образом:

1. Загрузите файл DWG с помощью метода фабрики [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Создайте экземпляр класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Создайте экземпляр класса [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) и установите его свойство [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Установите свойство совместимости PDF и сохраните его.
1. Экспортируйте изображение в PDF, используя метод [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Ниже приведен пример кода, который показывает, как конвертировать файл DWG в PDF/A и PDF/E.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-DWGToCompliancePDF-DWGToCompliancePDF.cs" >}}

## **Поддержка округленных скрытых линий при экспорте DWG/DXF в BMP и PDF**

Этот подход работает следующим образом:

1. Загрузите файл DWG с помощью метода фабрики [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Создайте экземпляр класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) и установите размеры результирующей страницы.
1. Создайте экземпляр класса [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) и установите его свойство [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Экспортируйте изображение в PDF, используя метод [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Ниже приведен пример кода, который показывает, как реализовать эту функцию.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-SupportForHiddenLines-SupportForHiddenLines.cs" >}}

## **Поддержка установки области печати для изображения DWG в экспортированном PDF**

Aspose.CAD для .NET API может загружать чертежи AutoCAD в формате DWG и конвертировать их в PDF. Эта тема объясняет использование Aspose.CAD API для достижения поддержки установки области печати для изображения DWG в экспортированном PDF.

Ниже приведен пример кода, который показывает, как реализовать эту функцию.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Поддержка чтения метаданных XREF для файла DWG**

1. Загрузите файл DWG с помощью метода фабрики [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Пройдитесь по каждому объекту изображения.
1. Если объект является CadUnderlay, то XREF объект с метаданными.

Ниже приведен пример кода, который показывает, как достичь этой функции.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ReadXREEFMetaData-ReadXREEFMetaData.cs" >}}

Свойство [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) является массивом строк, поэтому вы можете указать более одного макета одновременно для возможной конвертации в PDF формат. При указании нескольких макетов для свойства [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) результирующий PDF будет иметь несколько страниц, где каждая страница представляет отдельный макет AutoCAD.

### **Список всех макетов**

Вы можете перечислить все макеты, присутствующие в чертеже AutoCAD, используя следующий код.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-ListLayouts-ListLayouts.cs" >}}

### **Доступ к флагам подложки для формата DWG**

Aspose.CAD для .NET реализовал флаги подложки для формата DWG и позволяет разработчикам получить к ним доступ. Ниже представлена простая демонстрация кода.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.cs" >}}

## **Поддержка сущностей DWG**

Aspose.CAD для .NET API может загружать чертежи AutoCAD в формате DWG и поддерживать различные сущности для работы с ними.

### **Поддержка сущности MLeader**

DWG — это бинарный файл, который содержит данные векторного изображения и метаданные. В файле DWG есть различные сущности. В следующем разделе описан пример работы с сущностью MLeader внутри файла DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.cs" >}}

### **Поддержка экспорта сущности DWG в изображение**

DWG — это бинарный файл, который содержит данные векторного изображения и метаданные. В файле DWG есть различные сущности. В следующем разделе описан пример экспорта конкретной сущности DWG в изображение.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ParticularDWGToImage-ParticularDWGToImage.cs" >}}

## **Поддержка добавления текста в DWG**

Aspose.CAD для .NET API может загружать чертежи AutoCAD в формате DWG и поддерживать различные сущности для работы с ними. DWG — это бинарный файл, который содержит данные векторного изображения и метаданные. В файле DWG есть различные сущности. В следующем разделе объясняется, как мы можем добавить текст внутри файла DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-AddTextInDWG-AddTextInDWG.cs" >}}

## **Поддержка импорта изображений в файл DWG**

Aspose.CAD для .NET API может загружать чертежи AutoCAD в формате DWG и поддерживать различные сущности для работы с ними. DWG — это бинарный файл, который содержит данные векторного изображения и метаданные. В файле DWG есть различные сущности. В следующем разделе объясняется, как мы можем импортировать изображения в файл DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DWG-Drawings-ImportImageToDWG-ImportImageToDWG.cs" >}}

## **Поддержка сетки в DWG**

Aspose.CAD для .NET API теперь может обращаться к сущностям, поддерживающим сетку, которые включают типы [**CadPolyFaceMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolyfacemesh) и [**CadPolygonMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolygonmesh). В следующем примере объясняется, как мы можем получить доступ к типам сетки.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-MeshSupportForDWG-MeshSupportForDWG.cs" >}}

## **Конвертирование чертежей DWG в DXF**

Aspose.CAD предоставляет возможность загружать файл AutoCAD DWG и экспортировать его в формат DXF. Подход к конвертации DWG в DXF работает следующим образом:

1. Загрузите файл чертежа DWG с помощью метода фабрики [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Экспортируйте чертеж DWG в DXF с помощью метода [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Ниже приведен пример кода, который показывает, как конвертировать файл DWG в формат DXF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-DWGToDXF-DWGToDXF.cs" >}}

## **Конвертирование чертежей DWG в SVG**

Aspose.CAD для .NET API может загружать чертежи AutoCAD в формате DWG и конвертировать их в SVG. Эта тема объясняет использование Aspose.CAD API для достижения конвертации DWG в SVG формат простыми шагами, описанными ниже.

1. Загрузите файл DWG в экземпляр [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Создайте объект класса [**SvgOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/svgoptions) и установите необходимые свойства.
1. Экспортируйте чертеж DWG в SVG с помощью метода [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Ниже приведен пример кода, который показывает, как конвертировать файл DWG в формат SVG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToSVG-ExportToSVG.cs" >}}

## **Загрузка большого файла DWG**

Aspose.CAD для .NET предоставляет возможность открывать очень большие файлы DWG с помощью класса [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image). Теперь вы можете легко открывать большие файлы с помощью приведенного ниже примера кода.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-LargeDWGToPDF-LargeDWGToPDF.cs" >}}
