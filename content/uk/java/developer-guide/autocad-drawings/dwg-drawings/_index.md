---
title: DWG Малюнки
type: docs
weight: 40
url: /uk/java/developer-guide/autocad-drawings/dwg-drawings/
---

## **Експорт DWG малюнків у PDF**

Aspose.CAD для Java API може завантажувати малюнки AutoCAD у форматі DWG та конвертувати їх у PDF. Ця тема пояснює використання API Aspose.CAD для досягнення конверсії DWG у формат PDF через прості кроки, визначені нижче.

{{% alert color="primary" %}}

API підтримує наступні версії AutoCAD DWG:

- DWG 2004 версія 16.0 випуск 18
- DWG 2005 версія 16.1
- DWG 2010 версія 18.0
- DWG 2013 версія 19.0

{{% /alert %}}

### **Формат файлу DWG**

DWG — це бінарний файл, який містить дані векторного зображення та метадані. Дані векторного зображення надають інструкції CAD-додатку про те, як відображати DWG; метадані можуть містити різноманітну інформацію про файл, включаючи дані, специфічні для місця, а також дані клієнта. Відкриті специфікації для формату файлу DWG можна знайти [в цьому PDF](https://www.opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Конвертація файлів DWG у PDF**

Для конвертації DWG у PDF необхідні наступні прості кроки.

1. Завантажте файл DWG в екземпляр [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Створіть об'єкт класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) та встановіть властивості [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) та [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Створіть об'єкт класу [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) і встановіть властивість [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Викликайте метод [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) і передайте об'єкт [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) як другий параметр.

Наступний фрагмент коду показує, як експортувати DWG малюнки у PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ConvertDWGFileToPDF-ConvertDWGFileToPDF.java" >}}

### **Створення одного PDF з різними розмірами оформлення**

Aspose.CAD для Java дозволяє конвертувати файл DWG в один PDF з різними розмірами оформлення. Цей підхід працює наступним чином:

1. Завантажте файл DWG за допомогою методу [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Створіть екземпляр класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) та встановіть висоту та ширину результуючої сторінки.
1. Додайте необхідні [**LayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setLayoutPageSizes-com.aspose.ms.System.Collections.Generic.Dictionary-) для об'єкта [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Створіть екземпляр класу [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) і встановіть його властивість [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Експортуйте зображення у PDF, використовуючи метод [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Фрагмент коду нижче показує, як створити один PDF з різними оформленнями.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.java" >}}

### **Експорт DWG у PDF/A та PDF/E**

Для конвертації DWG в PDF необхідні наступні прості кроки.

1. Завантажте файл DWG в екземпляр [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Створіть об'єкт класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) та встановіть властивості [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) та [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Створіть об'єкт класу [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) та встановіть властивість [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Викликайте метод [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) і передайте об'єкт [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) як другий параметр.

Фрагмент коду нижче показує, як експортувати DWG малюнки у PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToCompliancePDF-DWGToCompliancePDF.java" >}}

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

1. Завантажте файл DWG за допомогою методу [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Створіть екземпляр класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) та встановіть висоту та ширину результуючої сторінки.
1. Встановіть властивість [**Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) для об'єкта [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Створіть екземпляр класу [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) та встановіть його властивість [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Експортуйте зображення у PDF, використовуючи метод [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Фрагмент коду нижче показує, як конвертувати конкретний макет DWG у PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportSpecificDWGLayoutToPDF-ExportSpecificDWGLayoutToPDF.java" >}}

## **Експорт DWG у растровий формат або PDF з фіксованим розміром**

Aspose.CAD для Java API може завантажувати малюнки AutoCAD у форматі DWG і конвертувати їх у PDF або растровий формат з фіксованим розміром.

Фрагмент коду нижче показує, як реалізувати цю функцію.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.java" >}}

## **Підтримка заокруглених прихованих ліній під час експорту DWG/DXF в BMP та PDF**

Цей підхід працює наступним чином:

1. Завантажте файл DWG за допомогою фабричного методу [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Створіть екземпляр класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Створіть екземпляр класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) і встановіть висоту та ширину результуючої сторінки.
1. Створіть екземпляр класу [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) і встановіть його властивість [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Експортуйте зображення у PDF, використовуючи метод [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Фрагмент коду нижче показує, як реалізувати цю функцію.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportForHiddenLines-SupportForHiddenLines.java" >}}

## **Підтримка встановлення зони друку для зображення DWG в експортованому PDF**

Aspose.CAD для Java API може завантажувати малюнки AutoCAD у форматі DWG і конвертувати їх у PDF. Ця тема пояснює використання API Aspose.CAD для досягнення підтримки встановлення зони друку для зображення DWG в експортованому PDF.

Фрагмент коду нижче показує, як реалізувати цю функцію.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Підтримка читання метаданих XREF для файлу DWG**

1. Завантажте файл DWG за допомогою фабричного методу [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Перейдіть до кожної сутності зображення.
1. Якщо сутність є [**CadUnderlay**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadUnderlay), то XREF сутність з метаданими.

Фрагмент коду нижче показує, як досягти цієї функції.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ReadXREEFMetaData-ReadXREEFMetaData.java" >}}

## **Документ DWG, вказуючи координати**

Aspose.CAD для Java API тепер надає функцію рендеринга DWG документів, вказуючи координати ширини та висоти документа.

Фрагмент коду нижче показує, як рендерити документ DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-RenderDWGDocument-RenderDWGDocument.java" >}}

Властивість [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#getLayouts--) є масивом рядків, так що ви можете вказати більше ніж один макет одночасно для можливого перетворення у формат PDF. При вказуванні кількох макетів для властивості [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) результуючий PDF матиме кілька сторінок, де кожна сторінка представляє окремий макет AutoCAD.

### **Список усіх макетів**

Ви можете перерахувати всі макети, присутні у малюнку AutoCAD, використовуючи наступний фрагмент коду.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ListAllLayoutsInAnAutoCADDrawing-ListAllLayoutsInAnAutoCADDrawing.java" >}}

## **Отримати значення атрибута блоку зовнішньої ссылки**

Aspose.CAD для Java API дозволяє отримати зовнішню ссылку атрибута блоку. API Aspose.CAD надає властивість [**getXRefPathName()**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity#getXRefPathName--) для отримання зовнішньої ссылки атрибута блоку у колекції [**CadBlockDictionary**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadBlockDictionary).

Наступний код демонструє, як отримати зовнішню ссылку атрибута блоку.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-GetBlockAttributeValueOfExternalReference-GetBlockAttributeValueOfExternalReference.java" >}}

## **Пошук тексту в DWG файлі AutoCAD**

Aspose.CAD для Java API дозволяє вам шукати текст у DWG файлі AutoCAD. API Aspose.CAD надає клас [**CadText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadText), який представляє текстові сутності у DWG файлі AutoCAD. Клас [**CadMText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadMText) також включений у API Aspose.CAD, оскільки деякі інші сутності можуть також містити текст.

Наступний код демонструє, як шукати текст у файлі DWG AutoCAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchTextInDWGAutoCADFile.java" >}}

### **Пошук тексту в конкретному макеті**

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchForTextInSpecificLayout.java" >}}

### **Доступ до прапорів підкладки для формату DWG**

Aspose.CAD для Java реалізував прапори підкладки для формату DWG і дозволяє розробникам отримати до них доступ. Ось простий демонстраційний код.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.java" >}}

## **Підтримка сутностей DWG**

Aspose.CAD для Java API може завантажувати малюнки AutoCAD у форматі DWG і підтримувати різні сутності для роботи з ними.

### **Підтримка сутності MLeader**

DWG — це бінарний файл, який містить дані векторного зображення та метадані. У файлі DWG є різні сутності. Наступний розділ описує приклад роботи з сутністю MLeader всередині файлу DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.java" >}}

### **Підтримка експорту сутності DWG у зображення**

DWG — це бінарний файл, який містить дані векторного зображення та метадані. У файлі DWG є різні сутності. Наступний розділ описує приклад експорту конкретної сутності DWG у зображення.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ParticularDWGToImage-ParticularDWGToImage.java" >}}

## **Підтримка імпорту зображення у файл DWG**

Aspose.CAD для Java API може завантажувати малюнки AutoCAD у форматі DWG і підтримувати різні сутності для роботи з ними. DWG — це бінарний файл, який містить дані векторного зображення та метадані. У файлі DWG є різні сутності. Наступний розділ описує, як ми можемо імпортувати зображення в файл DWG.

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ImportImageToDWG-ImportImageToDWG.java" >}}

## **Підтримка додавання тексту в DWG**

Aspose.CAD для Java API може завантажувати малюнки AutoCAD у форматі DWG і підтримувати різні сутності для роботи з ними. DWG — це бінарний файл, який містить дані векторного зображення та метадані. У файлі DWG є різні сутності. Наступний розділ описує, як ми можемо додати текст у файл DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-AddTextInDWG-AddTextInDWG.java" >}}

## **Підтримка сітки в DWG**

Aspose.CAD для Java API тепер може отримати доступ до сутностей, які підтримують сітку, які включають типи [**CadPolyFaceMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolyFaceMesh) та [**CadPolygonMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolygonMesh). Наступний приклад описує, як ми можемо отримати доступ до типів сітки.

## **Конвертація DWG малюнків у DXF**

Aspose.CAD надає можливість завантажувати файл AutoCAD DWG та експортувати його у формат DXF. Підхід конвертації DWG у DXF працює наступним чином:

1. Завантажте файл малюнка DWG за допомогою фабричного методу [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Експортуйте малюнок DWG у DXF, використовуючи метод [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Фрагмент коду нижче показує, як конвертувати файл DWG у формат DXF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToDXF-DWGToDXF.java" >}}

## **Конвертація DWG малюнків у SVG**

API Aspose.CAD може завантажувати малюнки AutoCAD у форматі DWG та конвертувати їх у SVG. Ця тема пояснює використання API Aspose.CAD для досягнення конверсії DWG у формат SVG через прості кроки, визначені нижче.

1. Завантажте файл DWG в екземпляр [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Створіть об'єкт класу [**SvgOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/SvgOptions) та встановіть необхідні властивості.
1. Експортуйте малюнок DWG у SVG, використовуючи метод [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Фрагмент коду нижче показує, як конвертувати файл DWG у формат SVG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportToSVG-ExportToSVG.java" >}}
