---
title: DWG Ч drawings
type: docs
weight: 40
url: /uk/net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **Експорт DWG малюнків у PDF**

Aspose.CAD для .NET API може завантажувати малюнки AutoCAD у форматі [DWG](https://docs.fileformat.com/cad/dwg/) та конвертувати їх у [PDF](https://docs.fileformat.com/pdf/). Ця тема пояснює використання API Aspose.CAD для досягнення конвертації DWG у формат PDF через прості кроки, як зазначено далі.

{{% alert color="primary" %}}

API підтримує наступні ревізії AutoCAD DWG:

- Версія 16.0 релізу 18 DWG 2004
- Версія 16.1 DWG 2005
- Версія 18.0 DWG 2010
- Версія 19.0 DWG 2013

{{% /alert %}}

### **Формат файлу DWG**

[DWG](https://docs.fileformat.com/cad/dwg/) - це двійковий файл, який містить векторні дані зображення та метадані. Векторні дані зображення надають інструкції CAD-додатку про те, як відобразити DWG; метадані можуть містити різноманітну інформацію про файл, включаючи специфічні для розташування дані та також дані клієнтів. Відкриті специфікації для формату файлу DWG можна знайти [в цьому PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf).

### **Конвертувати файли DWG у PDF**

Наступні прості кроки необхідні для конвертації [DWG](https://docs.fileformat.com/cad/dwg/) у [PDF](https://docs.fileformat.com/pdf/).

1. Завантажте файл DWG в екземпляр [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Створіть об'єкт класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) і задайте властивості [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) та [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Створіть об'єкт класу [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) і задайте властивість [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Викликайте [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save), передаючи об'єкт [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) як другий параметр.

Нижче наведено зразок коду, який показує, як експортувати малюнки DWG у PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToPDF-ExportToPDF.cs" >}}

### **Створити один PDF з різними розмірами макета**

Aspose.CAD для .NET дозволяє конвертувати файл DWG в один PDF з різними розмірами макета. Цей підхід працює наступним чином:

1. Завантажте файл DWG, використовуючи фабричний метод [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Створіть екземпляр класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) і задайте висоту та ширину результуючої сторінки.
1. Додайте потрібні [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/layoutpagesizes) для об'єкта [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Створіть екземпляр класу [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) і задайте його властивість [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Експортуйте зображення у PDF, використовуючи метод [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Нижче наведено зразок коду, який показує, як створити один [PDF](https://docs.fileformat.com/pdf/) з різними макетами.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.cs" >}}

### **Підтримувані примітиви AutoCAD**

Наступні примітиви AutoCAD підтримуються.

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

## **Експорт конкретного макета DWG у PDF**

Цей підхід працює наступним чином:

1. Завантажте файл DWG, використовуючи фабричний метод [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Створіть екземпляр класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) і задайте висоту та ширину результуючої сторінки.
1. Задайте властивість [**Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) для об'єкта [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Створіть екземпляр класу [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) і задайте його властивість [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Експортуйте зображення у PDF, використовуючи метод [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Нижче наведено зразок коду, який показує, як конвертувати конкретний макет DWG у PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Візуалізація документа DWG, вказуючи координати**

Aspose.CAD для .NET API тепер надає функцію візуалізації документів DWG, надаючи координати ширини та висоти документа.

Нижче наведено зразок коду, який показує, як візуалізувати документ DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-RenderDWGDocument-RenderDWGDocument.cs" >}}

## **Експорт DWG у растровий чи PDF за допомогою фіксованого розміру**

Aspose.CAD для .NET API може завантажувати малюнки AutoCAD у форматі DWG та конвертувати їх у PDF або растровий зображення, використовуючи фіксований розмір.

Нижче наведено зразок коду, який показує, як реалізувати цю функцію.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.cs" >}}

## **Експорт DWG у PDF/A та PDF/E**

Цей підхід працює наступним чином:

1. Завантажте файл DWG, використовуючи фабричний метод [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Створіть екземпляр класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Створіть екземпляр класу [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) та задайте його властивість [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Задайте властивість відповідності PDF та збережіть його.
1. Експортуйте зображення у PDF, використовуючи метод [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Нижче наведено зразок коду, який показує, як конвертувати файл DWG у PDF/A та PDF/E.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-DWGToCompliancePDF-DWGToCompliancePDF.cs" >}}

## **Підтримка округлих прихованих ліній під час експорту DWG/DXF у BMP і PDF**

Цей підхід працює наступним чином:

1. Завантажте файл DWG, використовуючи фабричний метод [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Створіть екземпляр класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) та задайте висоту та ширину результуючої сторінки.
1. Створіть екземпляр класу [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) та задайте її властивість [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Експортуйте зображення у PDF, використовуючи метод [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Нижче наведено зразок коду, який показує, як реалізувати цю функцію.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-SupportForHiddenLines-SupportForHiddenLines.cs" >}}

## **Підтримка встановлення області друку для зображення DWG в експортованому PDF**

Aspose.CAD для .NET API може завантажувати малюнки AutoCAD у форматі DWG і конвертувати їх у PDF. Ця тема пояснює використання API Aspose.CAD для досягнення підтримки встановлення області друку для зображення DWG в експортованому PDF.

Нижче наведено зразок коду, який показує, як реалізувати цю функцію.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Підтримка читання метаданих XREF для DWG файлу**

1. Завантажте файл DWG, використовуючи фабричний метод [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Пройдіть через кожен об'єкт зображення.
1. Якщо об'єкт є CadUnderlay, то XREF об'єкт з метаданими.

Нижче наведено зразок коду, який показує, як досягти цієї функції.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ReadXREEFMetaData-ReadXREEFMetaData.cs" >}}

Властивість [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) має тип масиву рядків, тому ви можете одночасно вказати більше ніж один макет для можливого конвертування у формат PDF. Під час специфікації декількох макетів для властивості [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) результуючий PDF матиме кілька сторінок, де кожна сторінка представляє окремий макет AutoCAD.

### **Перерахувати всі макети**

Ви можете перерахувати всі макети, присутні в малюнку AutoCAD, використовуючи наступний зразок коду.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-ListLayouts-ListLayouts.cs" >}}

### **Доступ до прапорів підкладів для формату DWG**

Aspose.CAD для .NET реалізував прапори підкладів для формату DWG і дозволяє розробникам отримати до них доступ. Наступний простий код демонструє це.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.cs" >}}

## **Підтримка об'єктів DWG**

Aspose.CAD для .NET API може завантажувати малюнки AutoCAD у форматі DWG та підтримувати різні об'єкти для роботи з ними.

### **Підтримка об'єкта MLeader**

DWG - це двійковий файл, що містить векторні дані зображення та метадані. Є різні об'єкти в файлі DWG. Наступний розділ описує приклад роботи з об'єктом MLeader усередині файлу DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.cs" >}}

### **Підтримка експорту об'єкта DWG у зображення**

DWG - це двійковий файл, що містить векторні дані зображення та метадані. Є різні об'єкти в файлі DWG. Наступний розділ описує приклад експорту конкретного об'єкта DWG у зображення.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ParticularDWGToImage-ParticularDWGToImage.cs" >}}

## **Підтримка додавання тексту в DWG**

Aspose.CAD для .NET API може завантажувати малюнки AutoCAD у форматі DWG і підтримувати різні об'єкти для роботи з ними. DWG - це двійковий файл, що містить векторні дані зображення та метадані. Є різні об'єкти в файлі DWG. Наступний розділ описує, як ми можемо додати текст усередині файлу DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-AddTextInDWG-AddTextInDWG.cs" >}}

## **Підтримка імпорту зображення у файл DWG**

Aspose.CAD для .NET API може завантажувати малюнки AutoCAD у форматі DWG і підтримувати різні об'єкти для роботи з ними. DWG - це двійковий файл, що містить векторні дані зображення та метадані. Є різні об'єкти в файлі DWG. Наступний розділ описує, як ми можемо імпортувати зображення в файл DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DWG-Drawings-ImportImageToDWG-ImportImageToDWG.cs" >}}

## **Підтримка сітки в DWG**

Aspose.CAD для .NET API тепер може отримувати доступ до об'єктів, які підтримують сітку, включаючи типи [**CadPolyFaceMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolyfacemesh) та [**CadPolygonMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolygonmesh). Наступний приклад описує, як ми можемо отримати доступ до сіткових типів.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-MeshSupportForDWG-MeshSupportForDWG.cs" >}}

## **Конвертувати малюнки DWG у DXF**

Aspose.CAD надає можливість завантажувати файл DWG AutoCAD та експортувати його у формат DXF. Підхід конвертації DWG у DXF працює наступним чином:

1. Завантажте файл малюнка DWG, використовуючи фабричний метод [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Експортуйте малюнок DWG у DXF, використовуючи метод [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Нижче наведено зразок коду, який показує, як конвертувати файл DWG у формат DXF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-DWGToDXF-DWGToDXF.cs" >}}

## **Конвертувати малюнки DWG у SVG**

Aspose.CAD для .NET API може завантажувати малюнки AutoCAD у форматі DWG та конвертувати їх у SVG. Ця тема пояснює використання API Aspose.CAD для досягнення конвертації DWG у формат SVG через прості кроки, які наведені нижче.

1. Завантажте файл DWG в екземпляр [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Створіть об'єкт класу [**SvgOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/svgoptions) та задайте необхідні властивості.
1. Експортуйте малюнок DWG у SVG, використовуючи метод [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Нижче наведено зразок коду, який показує, як конвертувати файл DWG у формат SVG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToSVG-ExportToSVG.cs" >}}

## **Завантаження великого файлу DWG**

Aspose.CAD для .NET надає можливість відкривати дуже великі файли DWG, використовуючи клас [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image). Тепер ви можете легко відкривати великі файли за допомогою наведеного нижче прикладу коду.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-LargeDWGToPDF-LargeDWGToPDF.cs" >}}
