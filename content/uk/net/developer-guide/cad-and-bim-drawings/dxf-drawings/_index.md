---
title: DXF Малюнки
type: docs
weight: 60
url: /uk/net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **Експорт DXF малюнків у PDF**

Aspose.CAD надає можливість завантажувати сутності малюнків AutoCAD DXF та виводити їх у форматі PDF. Процес конвертації DXF у PDF працює наступним чином:

1. Завантажте файл малюнка DXF за допомогою методу-фабрики [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Створіть об'єкт класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) та встановіть властивості [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) та [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Створіть об'єкт класу [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) та встановіть властивість [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Викличте [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), передавши об'єкт [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) як другий параметр.

Нижче наведено зразок коду, який демонструє, як конвертувати файл, використовуючи настройки за замовчуванням.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFToPDF-ExportDXFToPDF.cs" >}}

### **Підтримувані формати**

На даний момент ми повністю підтримуємо формати файлів AutoCAD DXF 2010. Попередні версії DXF не можуть бути гарантовані як 100% дійсні. Ми плануємо включити більше форматів та функцій у майбутні версії Aspose.CAD.

### **Підтримувані сутності**

На даний момент ми підтримуємо всі поширені 2D-сутності та їх основні параметри за замовчуванням, а саме:

1. Вирівняне вимірювання
1. Кутове вимірювання
1. Дуга
1. Атрибут
1. Посилання на блок
1. Коло
1. Діаметр
1. Еліпс
1. Заповнення
1. Лінія
1. Багаторядковий текст
1. Ордінатне вимірювання
1. Точка
1. Лінійний контур
1. Радіальне вимірювання
1. Промінь
1. Поворотне вимірювання
1. Таблиця
1. Текст
1. Х-лінія

{{% alert color="primary" %}}

Якщо під час парсингу ми натрапимо на сутність або властивість, яку ми не підтримуємо, сутність чи властивість буде тихо проігнорована.

{{% /alert %}}

### **Управління пам'яттю**

Властивість [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) класу [**Cache**](https://reference.aspose.com/cad/net/aspose.cad/cache) може бути використана для контролю повторного виділення пам'яті. Повторне виділення, швидше за все, відбудеться для попередньо виділених кешів. Це може статися, коли система визначає, що виділеного простору недостатньо.

- Якщо [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) встановлено на значення за замовчуванням, **False**, простір повторно виділяється на той же носій.
- Коли встановлено **True**, повторне виділення не може перевищувати максимальний вказаний об'єм. У цьому випадку існуючий виділений кеш в пам'яті (який вимагає повторного виділення) звільняється, а новий простір виділяється на диску.

## **Експорт конкретного шару DXF малюнків у PDF**

Цей підхід працює наступним чином:

1. Відкрийте файл малюнка DXF за допомогою методу-фабрики [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Створіть екземпляр [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) та вкажіть властивості [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) та [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Додайте шари до об'єкта [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Створіть екземпляр [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) та встановіть властивість [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Викличте метод [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) і передайте об'єкт [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) як другий параметр.

Нижче наведено зразок коду, який показує, як конвертувати конкретний шар DXF у PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayerToPDF-ExportDXFSpecificLayerToPDF.cs" >}}

## **Відображення PDF файлів як частини DXF малюнків**

Цей підхід працює наступним чином:

1. Завантажте файл малюнка DXF за допомогою методу [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Створіть об'єкт класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) та завантажте PDF файли.
1. Встановіть властивості [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) та [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Викличте [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) і збережіть файл.

Нижче наведено зразок коду, який демонструє, як відобразити PDF файли як частину DXF малюнків.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

## **Експорт вбудованого DGN підкладки для формату DXF**

Aspose.CAD надає можливість завантажувати файли AutoCAD DXF і експортувати вбудовану DGN підкладку для формату DXF.

Нижче наведено зразок коду, який демонструє, як досягти вказаних вимог.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **Підтримка збереження DXF файлів**

Aspose.CAD надає можливість завантажувати файли AutoCAD DXF, вносити в них зміни та зберігати їх знову у вигляді файлів DXF.

Нижче наведено зразок коду, який показує, як досягти вказаних вимог.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-SaveDXFFiles-SaveDXFFiles.cs" >}}

## **Експорт DXF у WMF**

Цей підхід працює наступним чином:

1. Завантажте файл малюнка DXF за допомогою методу [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Створіть об'єкт класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) та завантажте PDF файли.
1. Встановіть властивості [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) та [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Викличте [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) та збережіть файл.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportDXFToWMF-ExportDXFToWMF.cs" >}}

## **Експорт конкретного макету DXF у PDF**

Цей підхід працює наступним чином:

1. Відкрийте файл малюнка DXF за допомогою методу [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Створіть екземпляр [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) та вкажіть властивості [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) та [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Вкажіть бажані імена макета(ів), використовуючи властивість [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts).
1. Створіть екземпляр [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) та встановіть властивість [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Експортуйте малюнок у PDF, викликавши метод [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) і передавши об'єкт [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) як другий параметр.

Нижче наведено зразок коду, який показує, як конвертувати конкретний макет DXF у PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

{{% alert color="primary" %}}

Властивість [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) є масивом рядків, тому ви можете вказати більше ніж один макет для можливого конвертування у PDF формат. При вказівці кількох макетів для властивості [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) сформований PDF міститиме кілька сторінок, де кожна сторінка представляє окремий макет AutoCAD.

{{% /alert %}}

## **Підтримка обрізки блоків**

Aspose.CAD надає можливість обрізки блоків. Підхід до обрізки блоків працює наступним чином:

1. Завантажте файл малюнка DXF за допомогою методу [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Створіть об'єкт класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) та завантажте PDF файли.
1. Встановіть бажані властивості [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Викличте [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), передавши об'єкт [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) як другий параметр, і збережіть файл.

Нижче наведено зразок коду, який показує, як працює обрізка блоків.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DXF-Drawings-SupportOfBlockClipping-SupportOfBlockClipping.cs" >}}

## **Експорт зображень у DXF**

Використовуючи Aspose.CAD, ви можете експортувати зображення у формат DXF. Використовуючи цей підхід, ви можете виконати наступні дії:

1. Встановити новий шрифт
1. Сховати сутності
1. Оновити текст

Нижче наведено фрагмент коду, який показує, як виконати зазначені дії.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportImagesToDXF-ExportImagesToDXF.cs" >}}

## **Експорт конкретного шару DXF малюнків у зображення**

Цей підхід працює наступним чином:

1. Відкрийте файл малюнка DXF за допомогою методу [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Створіть екземпляр [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) та вкажіть властивості [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) та [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Додайте шари до об'єкта [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Створіть екземпляр [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) і встановіть його властивість [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Експортуйте малюнок у PDF, використовуючи метод [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Нижче наведено зразок коду, який показує, як конвертувати конкретний шар DXF у зображення.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.cs" >}}
