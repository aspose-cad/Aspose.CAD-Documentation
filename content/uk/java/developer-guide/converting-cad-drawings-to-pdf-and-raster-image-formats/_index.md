---
title: Перетворення CAD креслень на PDF та растрові формати зображень
type: docs
weight: 30
url: /uk/java/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
---

{{% alert color="primary" %}} 

Aspose.CAD для Java безпосередньо записує інформацію про API та номер версії у вихідні документи. Наприклад, під час рендерингу документа у PDF, Aspose.CAD для Java заповнює поле програми значенням 'Aspose.CAD' та поле виробника PDF значенням, наприклад, 'Aspose.CAD v 17.9'.

Зверніть увагу, що ви не можете вказати Aspose.CAD для Java змінити або видалити цю інформацію з вихідних документів.

{{% /alert %}} 
## **Перетворення CAD креслень на растрові формати зображень**
Aspose.CAD для Java здатний перетворювати формати креслень CAD, такі як [**DXF**](https://docs.fileformat.com/cad/dxf/) і [**DWG**](https://docs.fileformat.com/cad/dwg/) на підтримувані растрові формати зображень, такі як [**PNG**](https://docs.fileformat.com/image/png/), [**BMP**](https://docs.fileformat.com/image/bmp/), [**TIFF**](https://docs.fileformat.com/image/tiff/), [**JPEG**](https://docs.fileformat.com/image/jpeg/) та [**GIF**](https://docs.fileformat.com/image/gif/). API Aspose.CAD для Java має ефективні та прості у використанні засоби для досягнення цієї мети.
Ви можете конвертувати будь-який підтримуваний формат креслення CAD у растрові формати зображень, використовуючи прості кроки, описані нижче.

1. Завантажте CAD файл у екземпляр [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Створіть екземпляр [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) та встановіть його обов'язкові властивості, такі як [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) та [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Створіть екземпляр **ImageOptionsBase** та встановіть його [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) властивість на екземпляр **CadRasterizationOptions**, створений на попередньому кроці.
1. Викличте **Image.save**, передаючи шлях до файлу (або об'єкт MemoryStream), а також екземпляр [**ImageOptionsBase**](https://reference.aspose.com/cad/java/com.aspose.cad.class-use/ImageOptionsBase), створений на попередньому кроці.

Ось повний вихідний код.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADDrawingToRasterImageFormat-ConvertCADDrawingToRasterImageFormat.java" >}}



За замовчуванням API рендерить лише макет "Model". Однак ви також можете вказати макети на свій вибір під час перетворення креслень CAD на формати зображень.
## **Налаштування перетворення CAD**
Процедури перетворення CAD у [PDF](https://docs.fileformat.com/pdf/) та CAD у растрові зображення є висококонфігурованими, оскільки клас [**CadRasterizationOptions**](https://reference.aspose.com/java/cad/com.aspose.cad.imageoptions/CadRasterizationOptions) реалізований таким чином, що надає багато необов'язкових функцій, які, при налаштуванні, можуть переопределити процес рендерингу відповідно до потреб програми.
### **Клас CadRasterizationOptions**
Клас [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) є загальним для всіх підтримуваних форматів CAD, таких як [**DWG**](https://docs.fileformat.com/cad/dwg/) та [DXF](https://docs.fileformat.com/cad/dxf/), тому інформація, представлена в цій статті, є дійсною для обох згаданих форматів CAD.

Найбільш корисні властивості класу **CadRasterizationOptions**:

|**Властивість**|**Значення за замовчуванням**|**Обов'язково**|**Опис**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Так|Вказує ширину сторінки.|
|**PageHeight**|**0**|Так|Вказує висоту сторінки.|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|Ні|Вказує, чи слід автоматично масштабувати креслення. Значення за замовчуванням автоматично зменшує зображення, щоб підходити під розмір полотна. Переключіться в режим **GrowToFit** або використовуйте настройку **None**, щоб вимкнути автоматичне масштабування.|
|**BackgroundColor**|**Color.White**|Ні|Вказує колір фону вихідного зображення.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|Ні|Вказує режим колоризації сутності. Вкажіть опцію **UseObjectColor**, щоб малювати сутності за їх рідним кольором, або опцію **UseDrawColor**, щоб перевизначити рідні кольори.|
|**DrawColor**|**Color.Black**|Ні|Вказує перевизначений колір сутності (тільки якщо **DrawType** встановлено на значення властивості **UseDrawColor**).|
|**AutomaticLayoutsScaling**|False|Ні|Вказує, чи слід виконати автоматичне масштабування макетів, щоб відповідати макету моделі.|
### **Встановлення розміру та режиму полотна**
Експорт з CAD у PDF або CAD у растрові формати зображень не є тривіальним завданням. Оскільки отриманий PDF або зображення вимагає визначення розміру полотна, потрібно вказати вихідні розміри для сторінки PDF, щоб правильно відобразити креслення. Явно встановіть властивості **CadRasterizationOptions.PageWidth** та **CadRasterizationOptions.PageHeight**, або ви можете отримати **ImageSaveException**.

Крім того, ви можете вказати параметри масштабування розміру. Параметри масштабування задаються властивістю **CadRasterizationOptions.ScaleMethod**. Використовуйте цей параметр, щоб автоматично відрегулювати розміри зображення відповідно до значень **CadRasterizationOptions.PageWidth** та **CadRasterizationOptions.PageHeight**. За замовчуванням **CadRasterizationOptions.ScaleMethod** встановлено в режим **ScaleType.ShrinkToFit**. Ця властивість визначає таку поведінку:

- Якщо розміри креслення CAD перевищують розмір отриманого полотна, то розміри креслення зменшуються, щоб поміститися в отримане полотно зберігаючи співвідношення сторін.
- Якщо розміри креслення CAD менші, ніж розмір отриманого полотна, встановіть властивість **CadRasterizationOptions.ScaleMethod** на **ScaleType.GrowToFit**, щоб збільшити розмір креслення, щоб поміститися на полотні PDF, зберігаючи співвідношення сторін.
- Або вимкніть автоматичне масштабування за допомогою параметра **ScaleType.None**.

Нижче наведено приклад коду, що демонструє використання автоматичного масштабування.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetCanvasSizeAndMode-SetCanvasSizeAndMode.java" >}}




### **Встановлення кольорів фону та малювання**
Значення палітри кольорів для отриманого полотна за замовчуванням встановлено на загальну схему документа. Це означає, що всі сутності всередині креслення CAD малюються чорним кольором на суцільному білому фоні. Ці налаштування можна змінити властивостями **CadRasterizationOptions.BackgroundColor** та **CadRasterizationOptions.DrawColor**. Зміна властивості **CadRasterizationOptions.DrawColor** також потребує встановлення властивості **CadRasterizationOptions.DrawType**, щоб використовувати колір малювання. Властивість **CadRasterizationOptions.DrawType** визначає, чи зберігають сутності кольори чи перетворюються на користувацькі кольори. Щоб зберегти кольори сутностей, вкажіть **CadRasterizationOptions.DrawType** як **CadDrawTypeMode.UseObjectColor**, або вкажіть значення **CadDrawTypeMode.UseDrawColor**.

Нижче наведено зразок коду, що демонструє використання різних кольорових властивостей.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetBackgroundAndDrawingColor-SetBackgroundAndDrawingColor.java" >}}




### **Налаштування автоматичного масштабування макетів**
Більшість креслень CAD мають більше одного макету, збереженого в одному файлі, і кожен макет може мати різні розміри. Під час рендерингу таких креслень CAD у PDF, кожна сторінка PDF може мати різне масштабування відповідно до розміру макета. Для того, щоб рендеринг був однорідним, API Aspose.CAD надав властивість **CadRasterizationOptions.AutomaticLayoutsScaling**. Її значення за замовчуванням – **false**, але коли це значення **true**, API буде намагатися знайти відповідну шкалу для кожного окремого макета і малювати їх відповідним чином виконуючи автоматичну переоцінку відповідно до розміру сторінки.

Ось як працює властивість **CadRasterizationOptions.AutomaticLayoutsScaling** в співпраці з властивістю **CadRasterizationOptions.ScaleMethod**.

1. Якщо **ScaleMethod** встановлено в **ScaleType.ShrinkToFit** або **ScaleType.GrowToFit** за умови, що **AutomaticLayoutsScaling** встановлено на false, всі макети (включаючи модель) будуть оброблені відповідно до першого параметра.
1. Якщо **ScaleMethod** встановлено в **ScaleType.ShrinkToFit** або **ScaleType.GrowToFit** за умови, що **AutomaticLayoutsScaling** встановлено на true, всі макети (окрім моделі) будуть оброблені відповідно до їхнього розміру, тоді як модель буде оброблена відповідно до першого параметра.
1. Якщо **ScaleMethod** встановлено в **ScaleType.None** з **AutomaticLayoutsScaling**, встановленим на true або false, масштабування не буде виконуватися.

Нижче наведено зразок коду, що демонструє, як налаштувати автоматичне масштабування для перетворення CAD у PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SettingAutoLayoutScaling-SettingAutoLayoutScaling.java" >}}




## **Перетворення CAD макетів на растрові формати зображень**
API Aspose.CAD для Java здатний перетворювати CAD макети підтримуваних форматів, таких як DXF та DWG, у растрові зображення, такі як PNG, BMP, TIFF, JPEG та GIF. API також надає підтримку для рендерингу конкретних макетів креслення CAD в різні шари PSD.
API Aspose.CAD для Java має ефективні та прості у використанні засоби для вказівки списку необхідних макетів CAD і рендерингу їх у растрові формати зображень. Ось як ви можете досягти того ж у 5 простих кроках, описаних нижче.

1. Завантажте CAD файл у екземпляр **Image**, використовуючи фабричний метод **load**.
1. Створіть екземпляр **CadRasterizationOptions** та встановіть його обов'язкові властивості, такі як **PageWidth** та **PageHeight**.
1. Вкажіть бажане ім'я(я) макету, використовуючи властивість CadRasterizationOptions.Layouts.
1. Створіть екземпляр **ImageOptionsBase** та встановіть його **VectorRasterizationOptions** властивість на екземпляр **CadRasterizationOptions**, створений на попередньому кроці.
1. Викличте **Image.Save**, передаючи шлях до файлу (або об'єкт MemoryStream) а також екземпляр **ImageOptionsBase**, створений на попередньому кроці.

Ось повний вихідний код.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayoutToRasterImageFormat-ConvertCADLayoutToRasterImageFormat.java" >}}

`  `{{% alert color="primary" %}} 

Властивість **CadRasterizationOptions.Layouts** є масивом рядків, тому ви можете вказати більше ніж один макет одночасно для можливого перетворення на формати зображень. Під час вказівки кількох макетів для властивості **CadRasterizationOptions.Layouts** отримане TIFF зображення буде мати кілька сторінок, GIF зображення буде мати кілька кадрів, а PSD формат буде мати кілька шарів, де кожна сторінка/кадр/шар представляє індивідуальний макет AutoCAD. У разі вибору будь-якого іншого формату зображення, такого як PNG, BMP, JPEG, щоб зберегти результат, API буде рендерити лише макет за замовчуванням; тобто "Model".

{{% /alert %}} 
## **Включення відстеження для процесу рендерингу CAD**
Aspose.CAD представив серію класів та допоміжних полів перерахування для сприяння відстеженню процесу рендерингу CAD. З цими змінами, перетворення CAD у PDF тепер можна досягти так, включаючи відстеження.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-EnableTracking.java" >}}



{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-CadRenderHandler.java" >}}



Відстеження процесу рендерингу CAD може виявляти такі можливі проблеми.

1. Відсутня або пошкоджена інформація про заголовок.
1. Відсутня інформація про макет.
1. Відсутні блокові сутності.
1. Відсутні стиль вимірювання.
1. Відсутні стилі.
## **Замінювання шрифтів під час перетворення CAD креслень**
Цілком ймовірно, що певне CAD креслення використовує специфічний шрифт, який недоступний на машині, де відбувається перетворення CAD у PDF або CAD в растровий формат зображення. У таких ситуаціях API Aspose.CAD викликатиме відповідне виключення, щоб підкреслити відсутні шрифти та зупинити процес конвертації, оскільки API вимагає ці шрифти для правильного рендерингу вмісту у отриманому PDF та/або зображеннях.
API Aspose.CAD надає простий спосіб використання механізму для заміни необхідного(их) шрифтів на доступні шрифти. Властивість **CadImage.Styles** повертає екземпляр **CadStylesDictionary**, який у свою чергу містить **CadStyleTableObject** для кожного стилю в кресленні CAD, в той час як **CadStyleTableObject.PrimaryFontName** може бути використано для вказання доступного імені шрифту.

Нижче наведено зразок коду, що демонструє використання Aspose.CAD для Java API для зміни шрифту всіх стилів у кресленні CAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFont-SubstituteFont.java" >}}




Також можливо змінити шрифт лише одного конкретного стилю, звертаючись до нього через ім'я стилю. Нижче наведено зразок коду, що демонструє використання цього підходу.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFontOfAParticularStyle-SubstituteFontOfAParticularStyle.java" >}}




## **Перетворення CAD шарів на растрові формати зображень**
API Aspose.CAD для Java надав ефективні та прості у використанні засоби для вказівки імені необхідного CAD шару та рендерингу його у растрові формати зображень. Ось як ви можете досягти цього в 5 простих кроках, описаних нижче.

1. Завантажте CAD файл у екземпляр **Image**, використовуючи фабричний метод **load**.
1. Створіть екземпляр **CadRasterizationOptions** та встановіть його обов'язкові властивості, такі як **PageWidth** та **PageHeight**.
1. Додайте бажане ім'я шару, використовуючи метод **CadRasterizationOptions.Layers.add**.
1. Створіть екземпляр **ImageOptionsBase** та встановіть його **VectorRasterizationOptions** властивість на екземпляр **CadRasterizationOptions**, створений на попередньому кроці.
1. Викличте метод **Image.save**, передаючи шлях до файлу (або об'єкт MemoryStream), а також екземпляр **ImageOptionsBase**, створений на попередньому кроці.

Ось повний вихідний код.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayerToRasterImageFormat-ConvertCADLayerToRasterImageFormat.java" >}}




### **Перетворення всіх CAD шарів у окремі зображення**
Ви можете отримати всі шари з креслення CAD, використовуючи **CadImage.Layers** та рендерити кожен шар у окреме зображення, як показано нижче.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertAllCADLayersToSeparateImages-ConvertAllCADLayersToSeparateImages.java" >}}


## **Перетворення DWF CAD шарів на растрові формати зображень**
API Aspose.CAD для Java надав ефективні та прості у використанні засоби для вказівки імені необхідного CAD шару та рендерингу його у растрові формати зображень. Ось як ви можете досягти цього в 5 простих кроках, описаних нижче.

1. Завантажте DWF CAD файл у екземпляр **Image**, використовуючи фабричний метод **Load**.
1. Створіть екземпляр **CadRasterizationOptions** та встановіть його обов'язкові властивості, такі як **PageWidth** та **PageHeight**.
1. Додайте бажане ім'я шару, використовуючи метод **CadRasterizationOptions.Layers.Add**.
1. Створіть екземпляр **ImageOptionsBase** та встановіть його **VectorRasterizationOptions** властивість на екземпляр **CadRasterizationOptions**, створений на попередньому кроці.
1. Викличте метод **Image.Save**, передаючи шлях до файлу (або об'єкт MemoryStream) а також екземпляр **ImageOptionsBase**, створений на попередньому кроці.

Ось повний вихідний код.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToBMP-ExportToBMP.java" >}}
