---
title: DWG DXF до PDF C# | Конвертувати Auto CAD файли у PDF JPEG PNG у C# .NET
type: docs
weight: 30
url: /uk/net/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
keywords: "DWG до PDF C#, DXF до PDF C#, DWF DWT до PDF C#, конвертувати AutoCAD, конвертувати DWG, конвертувати DWF, конвертувати DWT, конвертувати DXF, конвертувати autocad до pdf, конвертувати DWG до PDF, конвертувати DWG до PNG, конвертувати DWG до TIFF, конвертувати DWG до JPG"
description: Використовуйте конвертер AutoCAD у PDF на C# .NET для конвертації DWG або DXF у PDF. Ви можете конвертувати DWG, DWF, DWT та DXF у PDF, JPEG, PNG, BMP, GIF та TIFF у C# .NET також.
---

## **Конвертація DWG або DXF у PNG JPEG BMP GIF або TIFF у C#**

Aspose.CAD для .NET може конвертувати формати малюнків AutoCAD, такі як [DXF](https://docs.fileformat.com/cad/dxf/) та [DWG](https://docs.fileformat.com/cad/dwg/) у [PNG](https://docs.fileformat.com/image/png/), [BMP](https://docs.fileformat.com/image/bmp/), [TIFF](https://docs.fileformat.com/image/tiff/), [JPEG](https://docs.fileformat.com/image/jpeg/) та [GIF](https://docs.fileformat.com/image/gif/). Він має ефективний та простий у використанні API для досягнення цієї мети.

Ви можете конвертувати будь-який підтримуваний формат малюнка AutoCAD в растрові формати зображень, використовуючи прості кроки, викладені нижче.

1. Завантажте файл AutoCAD DWG або DXF у клас [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Створіть екземпляр [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Встановіть/змініть розмір зображення за допомогою [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) та [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight)
1. Створіть екземпляр [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase)
1. Встановіть властивість [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) на [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions), створений на попередньому кроці.
1. Збережіть малюнок AutoCAD як PDF за допомогою [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save), передавши шлях до файлу (або об’єкт MemoryStream), а також екземпляр [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase), створений на попередньому кроці.

Ось повний вихідний код.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertDrawingToRasterImage-ConvertDrawingToRasterImage.cs" >}}

За замовчуванням API рендерить лише макет "Модель". Однак ви також можете вказати макети на ваш розсуд при конвертації малюнків CAD у формати зображень.

## **Налаштування конвертації CAD**

Процедури конвертації CAD у [PDF](https://docs.fileformat.com/pdf/) та CAD у растрові зображення є високонастроюваними, оскільки клас [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) реалізований таким чином, що надає багато необов'язкових функцій, які при налаштуванні можуть переопреділяти процес рендерингу відповідно до потреб програми.

### **Клас CadRasterizationOptions**

Клас **CadRasterizationOptions** є загальним для всіх підтримуваних CAD форматов, таких як DWG і DXF, тому інформація, наведена в цій статті, дійсна для обох вищезазначених CAD форматів.

Найбільш корисні властивості класу **CadRasterizationOptions**:

|**Властивість**|**Значення за замовчуванням**|**Обов'язково**|**Опис**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Так|Визначає ширину сторінки.|
|**PageHeight**|**0**|Так|Визначає висоту сторінки.|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|Ні|Визначає, чи має малюнок автоматично масштабуватися. Значення за замовчуванням автоматично зменшує зображення, щоб воно відповідало розміру полотна. Перейдіть в режим **GrowToFit** або використовуйте налаштування **None**, щоб вимкнути автоматичне масштабування.|
|**BackgroundColor**|**Color.White**|Ні|Визначає колір фону вихідного зображення.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|Ні|Визначає режим кольорізації об'єкта. Вкажіть опцію **UseObjectColor**, щоб намалювати об'єкти, використовуючи їх рідний колір, або опцію **UseDrawColor**, щоб переопределити рідні кольори.|
|**DrawColor**|**Color.Black**|Ні|Визначає переопределений колір об'єкта (тільки якщо **DrawType** встановлено на значення властивості **UseDrawColor**).|
|**AutomaticLayoutsScaling**|False|Ні|Визначає, чи має виконуватися автоматичне масштабування макета, щоб відповідати макету моделі. |

### **Встановлення розміру полотна та режиму**

Експорт з CAD до PDF або CAD у растрові формати зображень не є тривіальним завданням. Оскільки результуючий PDF або зображення вимагає визначення розміру полотна, нам потрібно вказати вихідні розміри для сторінки PDF, щоб коректно відобразити малюнок. Явно встановіть властивості **CadRasterizationOptions.PageWidth** та **CadRasterizationOptions.PageHeight**, або ви можете отримати **ImageSaveException**.

Крім того, ви можете вказати параметри масштабування розмірів. Параметри масштабування встановлюються за допомогою властивості **CadRasterizationOptions.ScaleMethod**. Використовуйте цю опцію для автоматичного коригування розмірів зображення відповідно до значень **CadRasterizationOptions.PageWidth** та **CadRasterizationOptions.PageHeight**. За замовчуванням **CadRasterizationOptions.ScaleMethod** встановлено в режим **ScaleType.ShrinkToFit**. Ця властивість визначає наступну поведінку:

- Якщо розміри малюнка CAD більші за результуючий розмір полотна, то розміри малюнка зменшуються, щоб увійти в результуюче полотно зберігаючи співвідношення сторін.
- Якщо розміри малюнка CAD менші за результуючий розмір полотна, встановіть властивість **CadRasterizationOptions.ScaleMethod** на **ScaleType.GrowToFit**, щоб збільшити розмір малюнка, щоб він увійшов у полотно PDF, зберігаючи співвідношення сторін.
- Або вимкніть автоматичне масштабування, використовуючи опцію **ScaleType.None**.

Нижче наведено кодовий приклад, що демонструє використання авто-масштабування.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingCanvasSizeAndMode-SettingCanvasSizeAndMode.cs" >}}

### **Встановлення фону та кольорів малювання**

За замовчуванням палітра кольорів для результуючого полотна встановлена на загальну схему документа. Це означає, що всі об'єкти всередині малюнка CAD малюються чорним кольором на твердому білому фоні. Ці налаштування можна змінити за допомогою властивостей **CadRasterizationOptions.BackgroundColor** та **CadRasterizationOptions.DrawColor**. Зміна властивості **CadRasterizationOptions.DrawColor** також вимагає встановлення властивості **CadRasterizationOptions.DrawType**, щоб використовувати колір малювання. Властивість **CadRasterizationOptions.DrawType** контролює, чи зберігають кольори об'єктів CAD свої кольори або перетворюються на користувацькі кольори. Для збереження кольорів об'єктів вкажіть **CadRasterizationOptions.DrawType** як **CadDrawTypeMode.UseObjectColor**, інакше вкажіть значення **CadDrawTypeMode.UseDrawColor**.

Нижче наведено кодовий приклад, що демонструє, як використовувати різні колірні властивості.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingBackgroundAndDrawingColors-SettingBackgroundAndDrawingColors.cs" >}}

### **Увімкнення автоматичного масштабування макета**

Більшість малюнків CAD має більше ніж один макет, збережений в одному файлі, і кожен макет може мати різні розміри. Під час рендерингу таких малюнків CAD у PDF кожна сторінка PDF може мати різне масштабування відповідно до розміру макета. Для того, щоб зробити рендеринг однорідним, API Aspose.CAD вивів властивість **CadRasterizationOptions.AutomaticLayoutsScaling**. Її значення за замовчуванням **false**, але якщо встановити **true**, API спробує знайти відповідний масштаб для кожного окремого макета і намалює їх відповідно, виконуючи автоматичну операцію зміни розміру відповідно до розміру сторінки.

Ось як властивість **CadRasterizationOptions.AutomaticLayoutsScaling** працює у співпраці з властивістю **CadRasterizationOptions.ScaleMethod**.

1. Якщо **ScaleMethod** встановлено на **ScaleType.ShrinkToFit** або **ScaleType.GrowToFit** з **AutomaticLayoutsScaling**, встановленим в false, то всі макети (включаючи Модель) обробляються відповідно до першої опції.
1. Якщо **ScaleMethod** встановлено на **ScaleType.ShrinkToFit** або **ScaleType.GrowToFit** з **AutomaticLayoutsScaling**, встановленим в true, то всі макети (окрім Моделі) обробляються відповідно до їхнього розміру, тоді як Модель обробляється відповідно до першої опції.
1. Якщо **ScaleMethod** встановлено на **ScaleType.None** з **AutomaticLayoutsScaling**, встановленим на true або false, жодне масштабування не буде виконуватись.

Нижче наведено кодовий приклад, що показує, як встановити автоматичне масштабування макета для конвертації CAD у PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingAutoLayoutScaling-SettingAutoLayoutScaling.cs" >}}

## **Конвертація макетів AutoCAD DXF або DWG у PNG або інші формати зображень у C#**

API Aspose.CAD для .NET може конвертувати макети CAD підтримуваних форматів, таких як DXF та DWG у PNG, BMP, TIFF, JPEG і GIF. API також надає підтримку для рендерингу конкретних макетів малюнка CAD у різні шари PSD.

Ось як ви можете досягти цього наступними простими кроками.

- Завантажте файл AutoCAD DWG або DXF, використовуючи клас **Image**.
- Установіть/змініть ширину та висоту зображення.
- Встановіть бажане ім'я макета, використовуючи властивість CadRasterizationOptions.Layouts.
- Створіть екземпляр **ImageOptionsBase** та встановіть його властивість **VectorRasterizationOptions** на екземпляр **CadRasterizationOptions**, створений на попередньому кроці.
- Збережіть макет CAD як TIFF або зображення.

Ось повний вихідний код.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertLayoutsToRasterImage-ConvertLayoutsToRasterImage.cs" >}}

{{% alert color="primary" %}} 

Властивість **CadRasterizationOptions.Layouts** є масивом строк, тому ви можете вказати більше ніж один макет одночасно для можливого конвертування в формати зображень. При вказівці кількох макетів для властивості **CadRasterizationOptions.Layouts** результуюче зображення TIFF буде мати кілька сторінок, зображення GIF буде мати кілька рамок, а формат [PSD](https://docs.fileformat.com/image/psd/) буде мати кілька шарів, де кожна сторінка/рама/шар представляє окремий макет AutoCAD. У разі, якщо вибрано будь-який інший формат зображення, наприклад PNG, BMP, JPEG, для збереження результату, API буде рендерити лише макет за замовчуванням, тобто "Модель".

{{% /alert %}}

## **Увімкнення трекінгу для процесу рендерингу CAD**

Aspose.CAD представив низку класів та підтримуючих переліків, щоб допомогти з трекінгом процесу рендерингу CAD. З цими змінами процес конвертації CAD у PDF тепер можна здійснити так, увімкнувши трекінг.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-EnableTrackingForCADRendering-EnableTrackingForCADRendering.cs" >}}

Трекінг процесу рендеринга CAD може виявити такі можливі проблеми.

1. Відсутня або пошкоджена інформація заголовка.
1. Відсутня інформація про макет.
1. Відсутні блоки об'єктів.
1. Відсутні стилі вимірювань.
1. Відсутні стилі.

## **Заміна шрифтів під час конвертації малюнків CAD**

Цілком ймовірно, що певний малюнок CAD використовує специфічний шрифт, який недоступний на машині, де виконується конвертація CAD у PDF або CAD у растрові зображення. У таких ситуаціях API Aspose.CAD викликає відповідне виключення, щоб підкреслити відсутні шрифти і зупинити процес конвертації, оскільки API вимагає ці шрифти для правильного рендерингу вмісту на результуючих PDF або зображеннях.

API Aspose.CAD надає простий спосіб використання механізму для заміни потрібних шрифтів доступними шрифтами. Властивість **CadImage.Styles** повертає екземпляр **CadStylesDictionary**, який, у свою чергу, містить **CadStyleTableObject** для кожного стилю в малюнку CAD, а **CadStyleTableObject.PrimaryFontName** можна використовувати для вказівки доступної назви шрифту.

Наступний кодовий фрагмент демонструє використання API Aspose.CAD для .NET для зміни шрифту всіх стилів у малюнку CAD.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SubstitutingFonts-SubstitutingFonts.cs" >}}

Також можливе змінювання шрифту лише одного конкретного стилю, отримуючи доступ до нього за назвою стилю. Наступний кодовий фрагмент демонструє використання цього підходу.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-SubstitutingFonts-SubstitutingFontByName.cs" >}}

## **Конвертування шарів CAD у растрові формати зображень**

API Aspose.CAD для .NET надає ефективний та простий у використанні засіб для вказівки імені потрібного шару CAD та рендерингу його у растрові формати зображень. Ось як ви можете досягти цього у 5 простих кроках, наведених нижче.

1. Завантажте файл CAD в екземпляр **Image**, використовуючи фабричний метод **Load**.
1. Створіть екземпляр **CadRasterizationOptions** та встановіть його обов'язкові властивості, такі як **PageWidth** та **PageHeight**.
1. Додайте бажане ім'я шару, використовуючи метод **CadRasterizationOptions.Layers.Add**.
1. Створіть екземпляр **ImageOptionsBase** та встановіть його властивість **VectorRasterizationOptions** на екземпляр **CadRasterizationOptions**, створений на попередньому кроці.
1. Викличте метод **Image.Save**, передавши шлях до файлу (або об'єкт MemoryStream), а також екземпляр **ImageOptionsBase**, створений на попередньому кроці.

Ось повний вихідний код.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-CADLayersToRasterImageFormats-CADLayersToRasterImageFormats.cs" >}}

### **Конвертування всіх шарів CAD у окремі зображення**

Ви можете отримати всі шари з малюнка CAD, використовуючи **CadImage.Layers** і рендерити кожен шар окремо, як показано нижче.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-CADLayersToRasterImageFormats-ConvertAllLayersToRasterImageFormats.cs" >}}

## **Конвертація шарів DWF CAD у растрові формати зображень**

API Aspose.CAD для .NET надає ефективний та простий у використанні спосіб вказати ім'я потрібного шару CAD та рендерити його в растрові формати зображень. Ось як ви можете досягти цього в 5 простих кроках, наведені нижче.

1. Завантажте DWF CAD файл в екземпляр **Image**, використовуючи фабричний метод **Load**.
1. Створіть екземпляр **CadRasterizationOptions** та встановіть його обов'язкові властивості, такі як **PageWidth** та **PageHeight**.
1. Додайте бажане ім'я шару, використовуючи метод **CadRasterizationOptions.Layers.Add**.
1. Створіть екземпляр **ImageOptionsBase** і встановіть його властивість **VectorRasterizationOptions** на екземпляр **CadRasterizationOptions**, створений на попередньому кроці.
1. Викличте метод **Image.Save**, передавши шлях до файлу (або об’єкт MemoryStream) і екземпляр **ImageOptionsBase**, що був створений на попередньому кроці.

Ось повний вихідний код.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}

Aspose.CAD для .NET безпосередньо записує інформацію про API та номер версії в вихідних документах. Наприклад, при рендерингу документа у PDF Aspose.CAD для .NET заповнює поле Application значенням 'Aspose.CAD' та поле PDF Producer значенням, наприклад 'Aspose.CAD v 17.10'.

Зверніть увагу, що ви не можете наказати Aspose.CAD для .NET змінити або видалити цю інформацію з вихідних документів.
