---
title: Рисунки DWG
type: документация
weight: 40
url: /bg/net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **Експортиране на рисунките DWG към PDF**

Aspose.CAD за .NET API може да зареди рисунки от AutoCAD във формат [DWG](https://docs.fileformat.com/cad/dwg/) и да ги преобразува в [PDF](https://docs.fileformat.com/pdf/). Тази тема обяснява използването на Aspose.CAD API за постигане на конверсията на DWG в PDF формат чрез определени стъпки.

{{% alert color="primary" %}}

API поддържа следните ревизии на AutoCAD DWG:

- DWG 2004 версия 16.0 издание 18
- DWG 2005 версия 16.1
- DWG 2010 версия 18.0
- DWG 2013 версия 19.0

{{% /alert %}}

### **Формат на файла DWG**

[DWG](https://docs.fileformat.com/cad/dwg/) е двоичен файл, който съдържа векторни данни за изображения и метаданни. Векторните данни за изображения предоставят инструкции на CAD приложението как да показва DWG; метаданните могат да съдържат различна информация за файла, включително данни, специфични за местоположението, както и клиентски данни. Спецификациите за файловия формат DWG могат да бъдат намерени [в този PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf).

### **Конвертиране на файлове DWG в PDF**

За конвертиране на [DWG](https://docs.fileformat.com/cad/dwg/) в [PDF](https://docs.fileformat.com/pdf/) са необходими следните стъпки:

1. Заредете DWG файла в екземпляр на [**Изображение**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Създайте обект на класа [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) и задайте свойствата [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) и [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Създайте обект на класа [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) и задайте свойството [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Извикайте [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save), като подадете обект на [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) като втори параметър.

По-долу е показан примерният код за експортиране на DWG рисунки в PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToPDF-ExportToPDF.cs" >}}

### **Създаване на единичен PDF с различни размери на изгледа**

Aspose.CAD за .NET ви позволява да конвертирате DWG файл в един PDF с различни размери на изгледа. Този метод работи по следния начин:

1. Заредете DWG файл чрез фабричния метод [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Създайте екземпляр на класа [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) и задайте височината и ширината на страницата.
1. Добавете необходимите [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/layoutpagesizes) за обекта [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Създайте екземпляр на класа [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) и задайте свойството му [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Експортирайте изображението към PDF чрез метода [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

По-долу е показан примерният код за създаване на един [PDF](https://docs.fileformat.com/pdf/) с различни изгледи.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.cs" >}}

### **Поддържани AutoCAD примитиви**

Следните AutoCAD примитиви се поддържат.

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

## **Експортиране на конкретен изглед на DWG към PDF**

Този метод работи по следния начин:

1. Заредете DWG файл чрез фабричния метод [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Създайте екземпляр на класа [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) и задайте височината и ширината на страницата.
1. Задайте свойството [**Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) за обекта [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Създайте екземпляр на класа [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) и задайте свойството му [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Експортирайте изображението към PDF чрез метода [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

По-долу е показан примерният код за конвертиране на специфичен изглед на DWG в PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Визуализиране на DWG документ чрез посочване на координати**

Aspose.CAD за .NET API в момента предоставя функционалност за визуализиране на DWG документи, като се предоставят координатите на ширината и височината на документа.

По-долу е показан примерният код за визуализирането на DWG документ.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-RenderDWGDocument-RenderDWGDocument.cs" >}}

## **Експортиране на DWG в растер или PDF с фиксиран размер**

Aspose.CAD за .NET API може да зареди рисунки от AutoCAD във формат DWG и да ги преобразува в PDF или растер с фиксиран размер.

По-долу е показан примерният код за изпълнение на тази функционалност.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.cs" >}}

## **Експортиране на DWG в PDF/A и PDF/E**

Този метод работи по следния начин:

1. Заредете DWG файл чрез фабричния метод [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Създайте екземпляр на класа [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Създайте екземпляр на класа [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) и задайте свойството му [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Задайте свойството за съответствие с PDF и го запазете.
1. Експортирайте изображението към PDF чрез метода [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

По-долу е показан примерният код за конвертиране на файл DWG в PDF/A и PDF/E.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-DWGToCompliancePDF-DWGToCompliancePDF.cs" >}}

## **Помощ за закръглени скрити линии при експортиране на DWG/DXF в BMP и PDF**

Този метод работи по следния начин:

1. Заредете DWG файл чрез фабричния метод [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Създайте екземпляр на класа [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) и задайте височината и ширината на страницата.
1. Създадете екземпляр на класа [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) и задайте свойството му [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Експортирайте изображението към PDF чрез метода [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

По-долу е показан примерният код за изпълнение на тази функционалност.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-SupportForHiddenLines-SupportForHiddenLines.cs" >}}

## **Поддръжка за задаване на област за отпечатване за изображение DWG в експортиран PDF**

Aspose.CAD за .NET API може да зареди рисунки от AutoCAD във формат DWG и да ги преобразува в PDF. Тази тема обяснява използването на Aspose.CAD API за постигане на поддръжка за задаване на област за отпечатване на изображението DWG в експортиран PDF.

По-долу е показан примерният код за изпълнение на тази функционалност.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Поддръжка за четене на XREF метаданни за файл DWG**

1. Заредете DWG файл чрез фабричния метод [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Обходете всеки съществуващ обект на изображението.
1. Ако обектът е CadUnderlay, тогава той е XREF обект с метаданни.

По-долу е показан примерният код за постигане на тази функционалност.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ReadXREEFMetaData-ReadXREEFMetaData.cs" >}}

Свойството [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) е от тип масив от низове, така че можете да посочите повече от едно изгледа едновременно за евентуалната конверсия в PDF формат. При посочване на множество изгледи за свойството [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts), резултатният PDF ще съдържа множество страници, като всяка страница представлява отделен AutoCAD изглед.

### **Изброяване на всички изгледи**

Можете да изброите всички изгледи, които присъстват в AutoCAD рисунка, като използвате следния код.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-ListLayouts-ListLayouts.cs" >}}

### **Достъп до флаговете за подложка за формата DWG**

Aspose.CAD за .NET вече има имплементирани флагове за подложка за формата DWG и позволява на разработчиците да ги достъпват. По-