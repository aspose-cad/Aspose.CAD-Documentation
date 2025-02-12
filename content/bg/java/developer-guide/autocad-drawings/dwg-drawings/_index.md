---
title: Изчертания DWG
type: docs
weight: 40
url: /bg/java/developer-guide/autocad-drawings/dwg-drawings/
---

## **Експортиране на изчертания DWG към PDF**

Aspose.CAD за Java API може да зарежда изчертания AutoCAD във формат DWG и да ги преобразува към PDF. Тази тема обяснява използването на Aspose.CAD API за постигане на конвертирането на DWG във формат PDF чрез прости стъпки, както е посочено по-долу.

{{% alert color="primary" %}}

API-то поддържа следните ревизии на AutoCAD DWG:

- DWG 2004 версия 16.0 издание 18
- DWG 2005 версия 16.1
- DWG 2010 версия 18.0
- DWG 2013 версия 19.0

{{% /alert %}}

### **Формат на DWG файл**

DWG е бинарен файл, който съдържа векторни данни за изображението и метаданни. Векторните данни за изображението предоставят инструкции на CAD приложението за това как да показва DWG; метаданните могат да съдържат разнообразна информация за файла, включително данни, специфични за местоположението, както и данни за клиенти. Спецификациите за отворения формат на DWG файл могат да бъдат намерени [в този PDF](https://www.opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Преобразуване на DWG файлове в PDF**

Необходими са следните прости стъпки за конвертиране на DWG в PDF.

1. Заредете DWG файла в инстанция на [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Създайте обект на класа [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) и задайте свойствата [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) и [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Създайте обект на класа [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) и задайте свойството [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Извикайте метода [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) и подайте обекта на [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) като втори параметър.

Подолу е показан образец на код за експортиране на изчертания DWG към PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ConvertDWGFileToPDF-ConvertDWGFileToPDF.java" >}}

### **Създаване на едно PDF с различни размери на макетите**

Aspose.CAD за Java ви позволява да конвертирате DWG файла в едно PDF с различни размери на макетите. Този подход работи по следния начин:

1. Заредете DWG файла, използвайки фабричния метод [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Създайте инстанция на класа [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) и задайте резултатната височина и ширина на страницата.
1. Добавете необходимите [**LayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setLayoutPageSizes-com.aspose.ms.System.Collections.Generic.Dictionary-) за обекта на [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Създайте инстанция на класа [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) и задайте свойството му [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Експортирайте изображението в PDF използвайки метода [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Подолу е показан образец на код за създаване на едно PDF с различни макети.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.java" >}}

### **Експортиране от DWG към PDF/A и PDF/E**

Необходими са следните прости стъпки за конвертиране на DWG в PDF.

1. Заредете DWG файла в инстанция на [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Създайте обект на класа [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) и задайте свойствата [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) и [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Създайте обект на класа [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) и задайте свойството [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Извикайте метода [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) и подайте обекта на [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) като втори параметър.

Подолу е показан образец на код за експортиране на изчертания DWG към PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToCompliancePDF-DWGToCompliancePDF.java" >}}

### **Поддържани AutoCAD основни фигури**

Следните AutoCAD основни фигури се поддържат.

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

## **Експортиране на конкретен макет DWG към PDF**

Този подход работи по следния начин:

1. Заредете DWG файла, използвайки фабричния метод [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Създайте инстанция на класа [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) и задайте резултатната височина и ширина на страницата.
1. Задайте свойството [**Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) за обекта на [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Създайте инстанция на класа [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) и задайте свойството му [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Експортирайте изображението към PDF, използвайки метода [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Подолу е показан образец на код за конвертиране на конкретен макет на DWG в PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportSpecificDWGLayoutToPDF-ExportSpecificDWGLayoutToPDF.java" >}}

## **Експортиране на DWG в Растер или PDF с фиксиран размер**

Aspose.CAD за Java API може да зарежда изчертания AutoCAD във формат DWG и да ги преобразува в PDF или Растер с фиксиран размер.

Подолу е показан образец на код за прилагане на тази функционалност.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.java" >}}

## **Поддръжка за закръглени скрити линии при експортиране на DWG/DXF в BMP и PDF**

Този подход работи по следния начин:

1. Заредете DWG файла, използвайки метода [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Създайте инстанция на класа [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Създайте инстанция на класа [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) и задайте резултатната височина и ширина на страницата.
1. Създайте инстанция на класа [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) и задайте неговото свойство [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Изведете изображението към PDF, използвайки метода [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Подолу е показан образец на код за прилагане на тази функционалност.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportForHiddenLines-SupportForHiddenLines.java" >}}

## **Поддръжка за задаване на района за печат на изображение DWG в експортиран PDF**

Aspose.CAD за Java API може да зарежда изчертания AutoCAD във формат DWG и да ги преобразува в PDF. Тази тема обяснява използването на Aspose.CAD API за постигане на поддръжка за задаване на района за печат на изображение DWG в експортиран PDF.

Подолу е показан образец на код за прилагане на тази функционалност.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Поддръжка за четене на метаданни за XREF за DWG файл**

1. Заредете DWG файла, използвайки метода [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Обходете всеки изображен обект.
1. Ако обектът е [**CadUnderlay**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadUnderlay), тогава XREF обект с метаданни.

Подолу е показан образец на код за постигане на тази функционалност.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ReadXREEFMetaData-ReadXREEFMetaData.java" >}}

## **Документ DWG, като се посочат координати**

Aspose.CAD за Java API вече предоставя функционалност за изписване на документи DWG, като се предоставят координати за ширината и височината на документа.

Подолу е показан образец на код за изобразяване на документ DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-RenderDWGDocument-RenderDWGDocument.java" >}}

Свойството [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#getLayouts--) е от тип масив от низове, така че можете да посочвате повече от един макет едновременно за възможно конвертиране в PDF формат. Докато посочвате множество макети за свойството [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-), резултатният PDF ще има множество страници, където всяка страница представлява отделен AutoCAD м