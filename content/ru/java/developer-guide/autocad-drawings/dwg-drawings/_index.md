---
title: DWG Чертежи
type: docs
weight: 40
url: /ru/java/developer-guide/autocad-drawings/dwg-drawings/
---

## **Экспорт DWG Чертежей в PDF**

Aspose.CAD для Java API может загружать чертежи AutoCAD в формате DWG и конвертировать их в PDF. Эта тема объясняет использование API Aspose.CAD для выполнения конвертации DWG в формат PDF через простые шаги, описанные ниже.

{{% alert color="primary" %}}

API поддерживает следующие ревизии AutoCAD DWG:

- DWG 2004 версия 16.0, выпуск 18
- DWG 2005 версия 16.1
- DWG 2010 версия 18.0
- DWG 2013 версия 19.0

{{% /alert %}}

### **Формат файла DWG**

DWG - это бинарный файл, который содержит векторные данные изображения и метаданные. Векторные данные изображения предоставляют инструкции CAD-приложению о том, как отображать DWG; метаданные могут содержать разнообразную информацию о файле, включая данные о местоположении и данные клиента. Открытые спецификации формата файлов DWG можно найти [в этом PDF](https://www.opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Конвертация файлов DWG в PDF**

Для конвертации DWG в PDF необходимы следующие простые шаги.

1. Загрузите файл DWG в экземпляр [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Создайте объект класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) и установите свойства [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) и [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Создайте объект класса [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) и установите свойство [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Вызовите метод [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) и передайте объект [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) в качестве второго параметра.

Пример кода ниже показывает, как экспортировать DWG Чертежи в PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ConvertDWGFileToPDF-ConvertDWGFileToPDF.java" >}}

### **Создание единого PDF с различными размерами макета**

Aspose.CAD для Java позволяет вам конвертировать файл DWG в единый PDF с различными размерами макета. Этот подход работает следующим образом:

1. Загрузите файл DWG, используя фабричный метод [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Создайте экземпляр класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) и установите высоту и ширину страницы.
1. Добавьте необходимые [**LayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setLayoutPageSizes-com.aspose.ms.System.Collections.Generic.Dictionary-) для объекта [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Создайте экземпляр класса [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) и установите его свойство [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Экспортируйте изображение в PDF, используя метод [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Пример кода ниже показывает, как создать единый PDF с различными макетами.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.java" >}}

### **Экспорт DWG в PDF/A и PDF/E**

Для конвертации DWG в PDF требуются следующие простые шаги.

1. Загрузите файл DWG в экземпляр [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Создайте объект класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) и установите свойства [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) и [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Создайте объект класса [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) и установите свойство [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Вызовите метод [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) и передайте объект [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) в качестве второго параметра.

Пример кода ниже показывает, как экспортировать DWG Чертежи в PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToCompliancePDF-DWGToCompliancePDF.java" >}}

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

1. Загрузите файл DWG, используя фабричный метод [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Создайте экземпляр класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) и установите высоту и ширину страницы.
1. Установите свойство [**Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) для объекта [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Создайте экземпляр класса [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) и установите его свойство [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Экспортируйте изображение в PDF, используя метод [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Пример кода ниже показывает, как конвертировать конкретный макет DWG в PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportSpecificDWGLayoutToPDF-ExportSpecificDWGLayoutToPDF.java" >}}

## **Экспорт DWG в растровый формат или PDF с фиксированным размером**

Aspose.CAD для Java API может загружать чертежи AutoCAD в формате DWG и конвертировать их в PDF или растровый формат с фиксированным размером.

Пример кода ниже показывает, как реализовать эту функцию.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.java" >}}

## **Поддержка округленных скрытых линий при экспорте DWG/DXF в BMP и PDF**

Этот подход работает следующим образом:

1. Загрузите файл DWG, используя фабричный метод [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Создайте экземпляр класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Создайте экземпляр класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) и установите высоту и ширину страницы.
1. Создайте экземпляр класса [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) и установите его свойство [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Экспортируйте изображение в PDF, используя метод [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Пример кода ниже показывает, как реализовать эту функцию.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportForHiddenLines-SupportForHiddenLines.java" >}}

## **Поддержка настройки области печати для изображения DWG в экспортированном PDF**

Aspose.CAD для Java API может загружать чертежи AutoCAD в формате DWG и конвертировать их в PDF. Эта тема объясняет использование API Aspose.CAD для достижения поддержки настройки области печати для изображения DWG в экспортированном PDF.

Пример кода ниже показывает, как реализовать эту функцию.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Поддержка чтения метаданных XREF для файла DWG**

1. Загрузите файл DWG, используя фабричный метод [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Перемещайтесь через каждую сущность изображения.
1. Если сущность является [**CadUnderlay**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadUnderlay), то это сущность XREF с метаданными.

Пример кода ниже показывает, как достичь этой функции.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ReadXREEFMetaData-ReadXREEFMetaData.java" >}}

## **DWG документ с указанием координат**

Aspose.CAD для Java API теперь предоставляет функцию рендеринга документов DWG, указывая координаты ширины и высоты документа.

Пример кода ниже показывает, как отрендерить документ DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-RenderDWGDocument-RenderDWGDocument.java" >}}

Свойство [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#getLayouts--) является массивом строк, так что вы можете указать более одного макета одновременно для возможной конвертации в формат PDF. При указании нескольких макетов для свойства [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) результирующий PDF будет иметь несколько страниц, где каждая страница представляет собой отдельный макет AutoCAD.

### **Список всех макетов**

Вы можете перечислить все макеты, присутствующие в чертеже AutoCAD, используя следующий фрагмент кода.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ListAllLayoutsInAnAutoCADDrawing-ListAllLayoutsInAnAutoCADDrawing.java" >}}

## **Получить значение атрибута блока внешней ссылки**

Aspose.CAD для Java API позволяет вам получить внешнюю ссылку на атрибут блока. API Aspose.CAD предоставляет свойство [**getXRefPathName()**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity#getXRefPathName--) для получения внешней ссылки на атрибут блока в коллекции [**CadBlockDictionary**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadBlockDictionary).

Следующий код демонстрирует, как получить внешнюю ссылку на атрибут блока.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-GetBlockAttributeValueOfExternalReference-GetBlockAttributeValueOfExternalReference.java" >}}

## **Поиск текста в файле DWG AutoCAD**

Aspose.CAD для Java API позволяет вам искать текст в файле DWG AutoCAD. API Aspose.CAD предоставляет класс [**CadText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadText), который представляет сущности текста в файле DWG AutoCAD. Класс [**CadMText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadMText) также включен в API Aspose.CAD, так как некоторые другие сущности также могут содержать текст.

Следующий код демонстрирует, как искать текст в файле DWG AutoCAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchTextInDWGAutoCADFile.java" >}}

### **Поиск текста в конкретном макете**

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchForTextInSpecificLayout.java" >}}

### **Доступ к флагам подложки для формата DWG**

Aspose.CAD для Java реализовал флаги подложки для формата DWG и позволяет разработчикам иметь к ним доступ. Ниже приведена простая демонстрация кода.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.java" >}}

## **Поддержка сущностей DWG**

Aspose.CAD для Java API может загружать чертежи AutoCAD в формате DWG и поддерживать различные сущности для работы с ними.

### **Поддержка сущности MLeader**

DWG - это бинарный файл, который содержит векторные данные изображения и метаданные. В файле DWG есть различные сущности. В следующем разделе описан пример работы с сущностью MLeader внутри файла DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.java" >}}

### **Поддержка экспорта сущности DWG в изображение**

DWG - это бинарный файл, который содержит векторные данные изображения и метаданные. В файле DWG есть различные сущности. В следующем разделе приведен пример экспорта конкретной сущности DWG в изображение.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ParticularDWGToImage-ParticularDWGToImage.java" >}}

## **Поддержка импорта изображения в файл DWG**

Aspose.CAD для Java API может загружать чертежи AutoCAD в формате DWG и поддерживать различные сущности для работы с ними. DWG - это бинарный файл, который содержит векторные данные изображения и метаданные. В файле DWG есть различные сущности. В следующем разделе описывается, как мы можем импортировать изображения в файл DWG.

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ImportImageToDWG-ImportImageToDWG.java" >}}

## **Поддержка добавления текста в DWG**

Aspose.CAD для Java API может загружать чертежи AutoCAD в формате DWG и поддерживать различные сущности для работы с ними. DWG - это бинарный файл, который содержит векторные данные изображения и метаданные. В файле DWG есть различные сущности. В следующем разделе описывается, как мы можем добавить текст в файл DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-AddTextInDWG-AddTextInDWG.java" >}}

## **Поддержка сетки в DWG**

Aspose.CAD для Java API теперь может получить доступ к сущностям, поддерживающим сетку, включая типы [**CadPolyFaceMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolyFaceMesh) и [**CadPolygonMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolygonMesh). В следующем примере описывается, как мы можем получить доступ к типам сетки.

## **Конвертация DWG Чертежей в DXF**

Aspose.CAD предоставляет функцию загрузки файла AutoCAD DWG и экспорта его в формат DXF. Подход к конвертации DWG в DXF работает следующим образом:

1. Загрузите файл чертежа DWG с помощью фабричного метода [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Экспортируйте чертеж DWG в DXF с помощью метода [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Пример кода ниже показывает, как конвертировать файл DWG в формат DXF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToDXF-DWGToDXF.java" >}}

## **Конвертация DWG Чертежей в SVG**

API Aspose.CAD может загружать чертежи AutoCAD в формате DWG и конвертировать их в SVG. Эта тема объясняет использование API Aspose.CAD для достижения конвертации DWG в формат SVG через простые шаги, описанные ниже.

1. Загрузите файл DWG в экземпляр [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Создайте объект класса [**SvgOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/SvgOptions) и установите необходимые свойства.
1. Экспортируйте чертеж DWG в SVG, используя метод [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Пример кода ниже показывает, как конвертировать файл DWG в формат SVG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportToSVG-ExportToSVG.java" >}}
