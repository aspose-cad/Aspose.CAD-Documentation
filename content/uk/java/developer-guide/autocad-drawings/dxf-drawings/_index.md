---
title: DXF Малюнки
type: docs
weight: 60
url: /uk/java/developer-guide/autocad-drawings/dxf-drawings/
---

## **Експорт DXF малюнків у PDF**

Aspose.CAD пропонує можливість завантажувати об'єкти малюнків AutoCAD DXF і відображати їх як цілий малюнок у формат PDF. Підхід конвертації DXF у PDF працює наступним чином:

1. Завантажте файл малюнка DXF, використовуючи метод фабрики [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Створіть об'єкт класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) та встановіть властивості [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) і [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Створіть об'єкт класу [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) та встановіть властивість [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Викличте Image.Save, передаючи об'єкт [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) як другий параметр.

Приклад коду нижче демонструє, як конвертувати файл за допомогою налаштувань за замовчуванням.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFDrawingToPDF-.java" >}}

### **Підтримувані формати**

На даний момент ми повністю підтримуємо формати файлів AutoCAD DXF 2010. Попередні версії DXF не гарантуються як 100% дійсні. Ми плануємо включити більше форматів та функцій у майбутніх версіях Aspose.CAD.

### **Підтримувані об'єкти**

На даний момент ми підтримуємо всі поширені 2D об'єкти та їх основні параметри за замовчуванням, як наведено нижче:

1. Вирівняний розмір
1. Кутовий розмір
1. Дуга
1. Атрибут
1. Посилання на блок
1. Коло
1. Розмір діаметра
1. Еліпс
1. Хатч
1. Лінія
1. Багаторядковий текст
1. Ордінатний розмір
1. Точка
1. Полілінія
1. Радіальний розмір
1. Промінь
1. Поворотний розмір
1. Таблиця
1. Текст
1. Х-лінія

{{% alert color="primary" %}}

Якщо під час парсингу ми натрапимо на якийсь об'єкт чи властивість, яку ми не підтримуємо, цей об'єкт чи властивість буде мовчки проігноровано.

{{% /alert %}}

### **Управління пам’яттю**

Властивість [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) може бути використана для управління повторним розподілом пам’яті. Повторне розподілення найбільш ймовірно происходит для заздалегідь виділених кешів. Це може статися, коли система визначає, що виділеного простору буде недостатньо.

- Якщо [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) встановлено на значення за замовчуванням, **False**, простір повторно розподіляється на той же носій.
- Коли встановлено на **True**, повторне розподілення не може перевищувати максимальний зазначений простір. У цьому випадку існуючий виділений кеш у пам’яті (який вимагає повторного розподілу) звільняється, і додатковий простір виділяється на диску.

## **Експорт конкретного шару DXF малюнків у PDF**

Цей підхід працює наступним чином:

1. Відкрийте файл малюнка DXF, використовуючи метод фабрики [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Створіть екземпляр [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) та вкажіть властивості [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) та [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Додайте шари до об'єкта [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Створіть екземпляр [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) та встановіть його властивість [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Експортуйте малюнок у PDF за допомогою методу [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Приклад коду нижче демонструє, як конвертувати конкретний шар DXF у PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificLayerOfDXFDrawingToPDF-.java" >}}

## **Експорт конкретного шару DXF малюнків у зображення**

Цей підхід працює наступним чином:

1. Відкрийте файл малюнка DXF, використовуючи метод фабрики [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Створіть екземпляр [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) та вкажіть властивості [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) та [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Додайте шари до об'єкта [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Створіть екземпляр [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) та встановіть його властивість [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Експортуйте малюнок у PDF за допомогою методу [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Приклад коду нижче демонструє, як конвертувати конкретний шар DXF у зображення.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.java" >}}

## **Рендеринг PDF файлів як частини DXF малюнків**

Цей підхід працює наступним чином:

1. Завантажте файл малюнка DXF, використовуючи метод фабрики [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Створіть об'єкт класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) і завантажте PDF файли.
1. Встановіть властивості [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) і [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Викличте [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) та збережіть файл.

Приклад коду нижче демонструє, як рендерити PDF файли як частину DXF малюнків.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-RenderDXFAsPDF-RenderDXFAsPDF.java" >}}

## **Експорт DXF у WMF**

Цей підхід працює наступним чином:

1. Завантажте файл малюнка DXF, використовуючи метод фабрики [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Створіть об'єкт класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) і завантажте PDF файли.
1. Встановіть властивості [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) і [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Викличте [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) та збережіть файл.

Приклад коду нижче демонструє, як експортувати DXF у WMF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFToWMF-ExportDXFToWMF.java" >}}

## **Підтримка збереження файлів DXF**

Aspose.CAD пропонує можливість завантажувати файли DXF AutoCAD, вносити в них зміни та зберігати їх знову як файл DXF. Приклад коду нижче демонструє, як досягти вказаних вимог.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SaveDXFFiles-SaveDXFFiles.java" >}}

## **Експорт вбудованого DGN підкладки для формату DXF**

Aspose.CAD пропонує можливість завантажувати файли DXF AutoCAD та експортувати вбудовану DGN підкладку для формату DXF.

Приклад коду нижче демонструє, як досягти вказаних вимог.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportEmbeddedDGN-ExportEmbeddedDGN.java" >}}

## **Експорт конкретного макету DXF у PDF**

Цей підхід працює наступним чином:

1. Відкрийте файл малюнка DXF, використовуючи метод фабрики [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Створіть екземпляр [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) і вкажіть властивості [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) та [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Вкажіть потрібні назви макетів, використовуючи властивість [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-).
1. Створіть екземпляр [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) та встановіть його властивість [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Експортуйте малюнок у PDF за допомогою методу [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Приклад коду нижче демонструє, як конвертувати конкретний макет DXF у PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToPDF-.java" >}}

{{% alert color="primary" %}}

Властивість [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) має тип масиву рядків, тому ви можете вказати більше ніж один макет одночасно для можливого експорту у формат PDF. При зазначенні декількох макетів для властивості [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-), результатний PDF буде мати кілька сторінок, де кожна сторінка представляє окремий макет AutoCAD.

{{% /alert %}}

## **Доступ до об'єктів ATTRIB та MTEXT**

Цей підхід працює наступним чином:

1. Відкрийте файл малюнка DXF, використовуючи метод фабрики [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Доступ до об'єктів у файлі CAD.
1. Перевірте на наявність об'єктів [**CadEntityTypeName.MTEXT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#MTEXT) та [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT).
1. Додайте до тимчасового списку для подальшої обробки.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-AddAttribMText-AddAttribMText.java" >}}

## **Декомпозиція об'єктів вставки CAD**

Цей підхід працює наступним чином:

1. Відкрийте файл **DXF** малюнка, використовуючи метод фабрики [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Доступ до об'єктів у файлі CAD.
1. Перевірте на наявність об'єктів [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT).
1. Перевірте список типів [**CadBlockEntity**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity).
1. Обробіть об'єкти.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-DecomposeCadInsertObject-DecomposeCadInsertObject.java" >}}

## **Підтримка обрізання блоців**

Aspose.CAD надає можливість обрізання блоців. Підхід обрізання блоців працює наступним чином:

1. Завантажте файл малюнка DXF, використовуючи метод фабрики [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Створіть об'єкт класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) і завантажте PDF файли.
1. Встановіть бажані властивості [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Викличте [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--), передавши об'єкт [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) як другий параметр та збережіть файл.

Приклад коду нижче демонструє, як працює обрізання блоців.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SupportOfBlockClipping-SupportOfBlockClipping.java" >}}

## **Експорт зображень у DXF**

За допомогою Aspose.CAD ви можете експортувати зображення у формат DXF. Використовуючи цей підхід, ви можете виконати наступні дії:

1. Встановіть новий шрифт.
1. Сховати об'єкти.
1. Оновлення тексту.

Нижче наведено фрагмент коду, який демонструє, як виконати вказані дії.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-ExportImagesToDXF.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-GetFileExtension.java" >}}
