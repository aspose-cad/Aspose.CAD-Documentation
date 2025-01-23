---
title: Конвертиране на CAD чертежи в PDF и растерни формати
type: docs
weight: 30
url: /bg/java/converting-cad-drawings-to-pdf-and-raster-image-formats/
---

{{% alert color="primary" %}} 

Aspose.CAD за Java директно записва информацията за API и номера на версията в изходните документи. Например, при рендериране на документ в PDF, Aspose.CAD за Java запълва полето "Приложение" с стойност "Aspose.CAD" и полето "PDF производител" с нещо като "Aspose.CAD v 17.9".

Моля, обърнете внимание, че не можете да инструктирате Aspose.CAD за Java да променя или премахва тази информация от изходните документи.

{{% /alert %}} 
## **Конвертиране на CAD чертежи в растерни формати**
Aspose.CAD за Java може да конвертира CAD чертожни формати като [**DXF**](https://docs.fileformat.com/cad/dxf/) и [**DWG**](https://docs.fileformat.com/cad/dwg/) в поддържаните растерни формати като [**PNG**](https://docs.fileformat.com/image/png/), [**BMP**](https://docs.fileformat.com/image/bmp/), [**TIFF**](https://docs.fileformat.com/image/tiff/), [**JPEG**](https://docs.fileformat.com/image/jpeg/) и [**GIF**](https://docs.fileformat.com/image/gif/). Aspose.CAD за Java API предоставя ефективни и лесни за използване средства за постигане на тази цел.
Можете да конвертирате всеки поддържан формат на CAD чертеж в растерни формати с помощта на простите стъпки, описани по-долу.

1. Заредете CAD файла в инстанция на [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Създайте инстанция на [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) и задайте нейните задължителни свойства, като [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) и [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Създайте инстанция на **ImageOptionsBase** и задайте свойството  [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) на инстанция на **CadRasterizationOptions**, създадена в предишната стъпка.
1. Извикайте **Image.save**, като предадете пътя на файла (или обект на MemoryStream) и инстанцията на [**ImageOptionsBase**](https://reference.aspose.com/cad/java/com.aspose.cad.class-use/ImageOptionsBase), създадена в предишната стъпка.

Ето пълния изходен код.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADDrawingToRasterImageFormat-ConvertCADDrawingToRasterImageFormat.java" >}}



По подразбиране API рендерира само "Модел" оформление. Въпреки това можете също да укажете оформленията по ваш избор, когато конвертирате CAD чертежи в растерни формати.
## **Персонализиране на CAD конверсия**
Процедурите за конвертиране на CAD в [PDF](https://docs.fileformat.com/pdf/) и CAD в растерни изображения са силно конфигурируеми, защото класът [**CadRasterizationOptions**](https://reference.aspose.com/java/cad/com.aspose.cad.imageoptions/CadRasterizationOptions) е реализиран по такъв начин, че предоставя много опционални функции, които при настройка могат да надмине рендериращия процес в зависимост от нуждите на приложението.
### **Клас CadRasterizationOptions**
Класът [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) е общ за всички поддържани CAD формати като [**DWG**](https://docs.fileformat.com/cad/dwg/) и [DXF](https://docs.fileformat.com/cad/dxf/), следователно информацията, предоставена в тази статия, е валидна и за двата споменати CAD формата.

Най-полезните свойства на класа **CadRasterizationOptions** са:

|**Свойство**|**Стойност по подразбиране**|**Задължително**|**Описание**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Да|Определя ширината на страницата.|
|**PageHeight**|**0**|Да|Определя височината на страницата.|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|Не|Определя дали чертежът да бъде автоматично мащабиран. Стойността по подразбиране автоматично намалява изображението, за да пасне на размера на платното. Преминете в режим **GrowToFit** или използвайте настройката **None**, за да деактивирате автоматичното мащабиране.|
|**BackgroundColor**|**Color.White**|Не|Определя цвета на фона на изходното изображение.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|Не|Определя режима на оцветяване на обектите. Укажете опцията **UseObjectColor**, за да рисувате обектите с техния оригинален цвят, или опцията **UseDrawColor**, за да надмине оригиналните цветове.|
|**DrawColor**|**Color.Black**|Не|Определя цвета на надминатия обект (само ако **DrawType** е зададен на стойността на свойството **UseDrawColor**).|
|**AutomaticLayoutsScaling**|False|Не|Определя дали да се извърши автоматично мащабиране на оформлението, за да съответства на модела.|
### **Настройка на размера и режима на платното**
Експортирането от CAD в PDF или CAD в растерни формати не е тривиална задача. Тъй като резултатният PDF или изображение изисква определяне на размера на платното, трябва да зададем изходните размери за PDF страницата, за да рендерираме чертежа правилно. Явно задайте свойствата **CadRasterizationOptions.PageWidth** и **CadRasterizationOptions.PageHeight**, в противен случай можете да получите **ImageSaveException**.

Освен това можете да зададете опции за мащабиране на размерите. Опциите за мащабиране се задават чрез свойството **CadRasterizationOptions.ScaleMethod**. Използвайте тази опция, за да регулирате автоматично размерите на изображението според стойностите на **CadRasterizationOptions.PageWidth** и **CadRasterizationOptions.PageHeight**. По подразбиране **CadRasterizationOptions.ScaleMethod** е зададен на режим **ScaleType.ShrinkToFit**. Това свойство определя следното поведение:

- Ако размерите на CAD чертежа са по-големи от размера на резултатното платно, размерите на чертежа се намаляват, за да паснат на резултатното платно, запазвайки съотношението.
- Ако размерите на CAD чертежа са по-малки от размера на резултатното платно, задайте свойството **CadRasterizationOptions.ScaleMethod** на **ScaleType.GrowToFit**, за да увеличите размера на чертежа, за да пасне на PDF платното, запазвайки съотношението.
- Или деактивирайте автоматичното мащабиране с опцията **ScaleType.None**.

Примерният код по-долу показва как се използва опцията за автоматично мащабиране.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetCanvasSizeAndMode-SetCanvasSizeAndMode.java" >}}




### **Настройка на цветовете на фона и рисуването**
По подразбиране цветната палитра за резултантното платно е зададена на общата схема на документа. Това означава, че всички обекти в CAD чертежа се рисуват с черен цвят на плътно бял фон. Тези настройки могат да бъдат променени с свойствата **CadRasterizationOptions.BackgroundColor** и **CadRasterizationOptions.DrawColor**. Промяната на свойството **CadRasterizationOptions.DrawColor** също изисква настройване на свойството **CadRasterizationOptions.DrawType**, за да се използва цвета за рисуване. Свойството **CadRasterizationOptions.DrawType** контролира дали обектите CAD запазват цветовете си или са конвертирани в персонализирани цветове. За да запазите цветовете на обектите, задайте **CadRasterizationOptions.DrawType** като **CadDrawTypeMode.UseObjectColor**, в противен случай задайте стойността **CadDrawTypeMode.UseDrawColor**.

Примерният код по-долу показва как да използвате различните цветови свойства.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetBackgroundAndDrawingColor-SetBackgroundAndDrawingColor.java" >}}




### **Настройка на автоматичното мащабиране на оформлението**
Повечето CAD чертежи имат повече от едно оформление, съхранено в един файл, и всяко оформление може да има различни размери. При рендериране на такива CAD чертежи в PDF, всяка страница на PDF документа може да има различно мащабиране в зависимост от размера на оформлението. За да направим рендерирането хомогенно, API на Aspose.CAD предоставя свойството **CadRasterizationOptions.AutomaticLayoutsScaling**. Неговата стойност по подразбиране е **false**, но когато е true, API-то ще се опита да намери съответстващо мащабиране за всяко отделно оформление и да ги нарисува по съответен начин, извършвайки автоматична операция по преоразмеряване в зависимост от размера на страницата.

Ето как свойството **CadRasterizationOptions.AutomaticLayoutsScaling** работи в сътрудничество със свойството **CadRasterizationOptions.ScaleMethod**.

1. Ако **ScaleMethod** е зададен на **ScaleType.ShrinkToFit** или **ScaleType.GrowToFit** с **AutomaticLayoutsScaling** зададено на false, тогава всички оформления (включително Модела) ще бъдат обработени според първия вариант.
1. Ако **ScaleMethod** е зададен на **ScaleType.ShrinkToFit** или **ScaleType.GrowToFit** с **AutomaticLayoutsScaling** зададено на true, тогава всички оформления (с изключение на Модела) ще бъдат обработени в зависимост от техния размер, докато Моделът ще бъде обработен според първия вариант.
1. Ако **ScaleMethod** е зададен на **ScaleType.None** с **AutomaticLayoutsScaling** зададено на true или false, тогава никое мащабиране няма да бъде извършено.

Примерният код по-долу показва как да настроите автоматичното мащабиране на оформлението за конвертиране от CAD в PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SettingAutoLayoutScaling-SettingAutoLayoutScaling.java" >}}




## **Конвертиране на CAD оформления в растерни формати**
Aspose.CAD за Java API е способен да конвертира CAD оформления от поддържани формати като DXF и DWG в растерни изображения, като PNG, BMP, TIFF, JPEG и GIF. API-то също така предоставя поддръжка за рендериране на специфични оформления на CAD чертежи в различни PSD слоеве.
Aspose.CAD за Java API предоставя ефективни и лесни за използване средства за задаване на списък с необходими CAD оформления и тяхното рендериране в растерни формати. Ето как можете да постигнете същото в 5 прости стъпки, изброени по-долу.

1. Заредете CAD файла в инстанция на **Image** с помощта на фабричния метод **load**.
1. Създайте инстанция на **CadRasterizationOptions** и задайте нейните задължителни свойства, като **PageWidth** и **PageHeight**.
1. Укажете желаното име(а) на оформлението, използвайки свойството CadRasterizationOptions.Layouts.
1. Създайте инстанция на **ImageOptionsBase** и задайте свойството **VectorRasterizationOptions** на инстанцията на **CadRasterizationOptions**, създадена в предишната стъпка.
1. Извикайте метода **Image.Save**, като предадете пътя на файла (или обект на MemoryStream) и инстанцията на **ImageOptionsBase**, създадена в предишната стъпка.

Ето пълния изходен код.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayoutToRasterImageFormat-ConvertCADLayoutToRasterImageFormat.java" >}}

`  `{{% alert color="primary" %}} 

Свойството **CadRasterizationOptions.Layouts** е от тип масив от низове, така че можете да зададете повече от одно оформление наведнъж за възможната конверсия в растерни формати. При задаване на множество оформления за свойството **CadRasterizationOptions.Layouts**, резултантното TIFF изображение ще има множество страници, GIF изображението ще има множество кадри, а PSD форматът ще има множество слоеве, където всяка страница/рамка/слой представлява отделно оформление на AutoCAD. В случай, че се избере друг формат на изображение, като PNG, BMP, JPEG, за съхранение на резултата, тогава API ще рендерира само основното оформление; тоест "Модел".

{{% /alert %}} 
## **Активиране на проследяване на процеса на CAD рендериране**
Aspose.CAD е въвел серия от класове и поддържащи полета на изброените типове, за да помогне с проследяването на процеса на CAD рендериране. С тези промени, конверсията от CAD в PDF може сега да бъде постигната, докато се активира проследяването.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-EnableTracking.java" >}}



{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-CadRenderHandler.java" >}}



Проследяването на процеса на CAD рендериране може да открие следните възможни проблеми.

1. Липсваща или повредена информация за заглавката.
1. Липсваща информация за оформлението.
1. Липсващи блокови единици.
1. Липсващи стилове на измерване.
1. Липсващи стилове.
## **Субституиране на шрифтове при конвертиране на CAD чертежи**
Възможно е конкретен CAD чертеж да използва специфичен шрифт, който не е наличен на машината, на която се извършва конверсията от CAD в PDF или растерни изображения. В такива ситуации, API-то на Aspose.CAD ще задейства подходящо изключение, за да подчертае липсващите шрифтове и да спре процеса на конверсия, тъй като API-то изисква тези шрифтове да рендерира правилно съдържанието в резултатния PDF и/или изображения.
API-то на Aspose.CAD предоставя лесен начин за използване на механизма за замяна на необходимите шрифтове с наличните шрифтове. Свойството **CadImage.Styles** връща инстанция на **CadStylesDictionary**, която от своя страна съдържа **CadStyleTableObject** за всеки стил в CAD чертежа, докато **CadStyleTableObject.PrimaryFontName** може да се използва за указване на името на наличния шрифт.

Следният кодов фрагмент демонстрира употребата на Aspose.CAD за Java API за промяна на шрифта на всички стилове в CAD чертеж.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFont-SubstituteFont.java" >}}




Също така е възможно да промените шрифта на само един конкретен стил, като получите достъп до него чрез името на стила. Следният кодов фрагмент демонстрира употребата на този подход.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFontOfAParticularStyle-SubstituteFontOfAParticularStyle.java" >}}




## **Конвертиране на CAD слоеве в растерни формати**
Aspose.CAD за Java API предоставя ефективни и лесни за използване средства за задаване на името на необходимия CAD слой и рендериране на него в растерни формати. Ето как можете да постигнете същото в 5 прости стъпки, изброени по-долу.

1. Заредете CAD файла в инстанция на **Image** с помощта на фабричния метод **load**.
1. Създайте инстанция на **CadRasterizationOptions** и задайте нейните задължителни свойства, като **PageWidth** и **PageHeight**.
1. Добавете желаното име на слоя, използвайки метода **CadRasterizationOptions.Layers.add**.
1. Създайте инстанция на **ImageOptionsBase** и задайте свойството **VectorRasterizationOptions** на инстанцията на **CadRasterizationOptions**, създадена в предишната стъпка.
1. Извикайте метода **Image.save**, като предадете пътя на файла (или обект на MemoryStream) и инстанцията на **ImageOptionsBase**, създадена в предишната стъпка.

Ето пълния изходен код.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayerToRasterImageFormat-ConvertCADLayerToRasterImageFormat.java" >}}




### **Конвертиране на всички CAD слоеве в отделни изображения**
Можете да получите всички слоеве от CAD чертеж, използвайки **CadImage.Layers** и да рендерирате всеки слой в отделно изображение, както е демонстрирано по-долу.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertAllCADLayersToSeparateImages-ConvertAllCADLayersToSeparateImages.java" >}}


## **Конвертиране на DWF CAD слоеве в растерни формати**
Aspose.CAD за Java API предлага ефективни и лесни за използване средства за задаване на името на необходимия CAD слой и рендериране на него в растерни формати. Ето как можете да постигнете същото в 5 прости стъпки, изброени по-долу.

1. Заредете DWF CAD файла в инстанция на **Image** с помощта на фабричния метод **Load**.
1. Създайте инстанция на **CadRasterizationOptions** и задайте нейните задължителни свойства, като **PageWidth** и **PageHeight**.
1. Добавете желаното име на слоя, използвайки метода **CadRasterizationOptions.Layers.Add**.
1. Създайте инстанция на **ImageOptionsBase** и задайте свойството **VectorRasterizationOptions** на инстанцията на **CadRasterizationOptions**, създадена в предишната стъпка.
1. Извикайте метода **Image.Save**, като предадете пътя на файла (или обект на MemoryStream) и инстанцията на **ImageOptionsBase**, създадена в предишната стъпка.

Ето пълния изходен код.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToBMP-ExportToBMP.java" >}}