---
title: Чертежи DWG
type: docs
weight: 70
url: /bg/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **Експортиране на чертежи DWG към PDF**

Aspose.CAD за Python API може да зареди чертежи AutoCAD във [DWG](https://docs.fileformat.com/cad/dwg/) формат и да ги конвертира в [PDF](https://docs.fileformat.com/pdf/). Тази тема обяснява използването на Aspose.CAD API за постигане на конверсия от DWG към PDF формат чрез определени стъпки както следва.

{{% alert color="primary" %}}

API-то поддържа следните ревизии на AutoCAD DWG:

- DWG 2004 версия 16.0 издание 18
- DWG 2005 версия 16.1
- DWG 2010 версия 18.0
- DWG 2013 версия 19.0

{{% /alert %}}

### **Формат на файлове DWG**

[DWG](https://docs.fileformat.com/cad/dwg/) е двоичен файл, който съдържа данни за векторни изображения и метаданни. Данните за векторните изображения предоставят на CAD приложението инструкции за показване на DWG; метаданните могат да съдържат различна информация за файла, включително местно-специфични данни и данни за клиента. Спецификациите за отворения формат на файлове DWG могат да бъдат намерени [в този PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Конвертиране на файлове DWG в PDF**

Следните опростени стъпки са необходими за конвертиране на [DWG](https://docs.fileformat.com/cad/dwg/) в [PDF](https://docs.fileformat.com/pdf/).

1. Заредете DWG файла в екземпляр на **Image**.
1. Създайте обект от класа **CadRasterizationOptions** и задайте свойствата **page_height** и **page_width**.
1. Създайте обект от класа **PdfOptions** и задайте свойството **VectorRasterizationOptions**.
1. Извикайте **Image.save**, като подадете обект на **PdfOptions** като втори параметър.

По-долу е показан примерен код за експортиране на чертежи DWG към PDF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-PDF-Export.py" >}}


### **Поддържани автокадови примитиви**

Поддържат се следните автокадови примитиви.

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

## **Експортиране на конкретен DWG Layout към PDF**

Този подход работи по следния начин:

1. Заредете DWG файл, използвайки фабричния метод **Aspose.CAD.Image.load**.
1. Създайте екземпляр на класа **CadRasterizationOptions** и задайте височината и ширината на страницата.
1. Задайте свойството **Layouts** за обекта **CadRasterizationOptions**.
1. Създайте екземпляр на класа **PdfOptions** и задайте свойството му **VectorRasterizationOptions**.
1. Експортирайте изображението към PDF, използвайки метода **Image.save()**.

Примерният код по-долу показва как да конвертирате определен Layout от DWG в PDF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-ExportSpecificLayoutToPDF.py" >}}


## **Експортиране на DWG към PDF/A и PDF/E**

Този метод работи по следния начин:

1. Заредете DWG файл, използвайки фабричния метод **Image.load**.
1. Създайте екземпляр на класа **CadRasterizationOptions**.
1. Създайте екземпляр на класа **PdfOptions** и задайте неговото свойство **VectorRasterizationOptions**.
1. Задайте свойството за съответствие на PDF и го запазете.
1. Експортирайте изображението към PDF, използвайки метода **Image.save()**.

Примерният код по-долу показва как да конвертирате DWG файл в PDF/A и PDF/E.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-to-Compliance-PDF.py" >}}


## **Конвертиране на DWG чертежи в DXF**

Aspose.CAD предоставя възможност за зареждане на файл DWG от AutoCAD и експортиране към формат DXF. Подходът за конвертиране от DWG в DXF работи по следния начин:

1. Заредете DWG чертежния файл, използвайки фабричния метод **Image.load**.
1. Експортирайте DWG чертежа към DXF, използвайки метода **Image.save()**.

Примерният код по-долу показва как да конвертирате DWG файл във формат DXF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-DXF.py" >}}


## **Конвертиране на DWG чертежи в SVG**

Aspose.CAD за Python API може да зареди чертежи AutoCAD в DWG формат и да ги конвертира в SVG. Тази тема обяснява използването на Aspose.CAD API за постигане на конверсия от DWG в SVG формат чрез определени стъпки както следва.

1. Заредете DWG файла в екземпляр на **Image**.
1. Създайте обект от класа **SvgOptions** и задайте необходимите свойства.
1. Експортирайте DWG чертежа към SVG, използвайки метода **Image.save()**.

Примерният код по-долу показва как да конвертирате DWG файл в SVG формат.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-SVG.py" >}}
