---
title: DWG DXF към PDF C# | Конвертиране на Auto CAD файлове в PDF JPEG PNG в C# .NET
type: docs
weight: 30
url: /bg/net/converting-cad-drawings-to-pdf-and-raster-image-formats/
keywords: "DWG към PDF C#, DXF към PDF C#, DWF DWT към PDF C#, конвертиране на AutoCAD, конвертиране на DWG, конвертиране на DWF, конвертиране на DWT, конвертиране на DXF, конвертиране на autocad в pdf, конвертиране на DWG в PDF, конвертиране на DWG в PNG, конвертиране на DWG в TIFF, конвертиране на DWG в JPG"
description: Използвайте преобразувателя C# .NET AutoCAD към PDF, за да конвертирате DWG или DXF в PDF в C#. Можете да конвертирате DWG, DWF, DWT и DXF в PDF, JPEG, PNG, BMP, GIF и TIFF в C# .NET също.
---

## **Конвертиране на DWG или DXF в PNG JPEG BMP GIF или TIFF в C#**

Aspose.CAD за .NET може да конвертира формати на AutoCAD като [DXF](https://docs.fileformat.com/cad/dxf/) и [DWG](https://docs.fileformat.com/cad/dwg/) в [PNG](https://docs.fileformat.com/image/png/), [BMP](https://docs.fileformat.com/image/bmp/), [TIFF](https://docs.fileformat.com/image/tiff/), [JPEG](https://docs.fileformat.com/image/jpeg/) и [GIF](https://docs.fileformat.com/image/gif/). Той е предоставил ефективен и лесен за използване API, за да постигне тази цел.

Можете да конвертирате всеки поддържан формат на AutoCAD в формати на растерно изображение, следвайки простите стъпки, описани по-долу.

1. Заредете файла AutoCAD DWG или DXF в класа [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Създайте инстанция на [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Задайте/променете размера на изображението с помощта на [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) и [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Създайте инстанция на [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase).
1. Задайте свойството [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) на [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions), създадено в предишната стъпка.
1. Запазете AutoCAD чертежа като PDF с [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) и предайте пътя на файла (или обект от MemoryStream), както и инстанцията на [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase), създадена в предишната стъпка.

Ето и целия изходен код.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertDrawingToRasterImage-ConvertDrawingToRasterImage.cs" >}}

По подразбиране API-то визуализира само "Model" оформление. Въпреки това, можете също да зададете оформлението по ваш избор при конвертиране на CAD чертежи в формати на изображения.

## **Персонализиране на CAD конверсията**

Процедурите за конвертиране на CAD в [PDF](https://docs.fileformat.com/pdf/) и CAD в растерно изображение са високо конфигурируеми, тъй като класът [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) е реализиран по такъв начин, че предлага много опционални функции, които при задаване могат да надстроят процеса на визуализиране според нуждите на приложението.

### **Клас CadRasterizationOptions**

Класът **CadRasterizationOptions** е общ за всички поддържани CAD формати като DWG и DXF, следователно информацията, споделена в тази статия, е валидна и за двете споменати CAD формати.

Най-полезните свойства на клас **CadRasterizationOptions** са:

|**Свойство**|**Стойност по подразбиране**|**Задължително**|**Описание**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Да|Определя ширината на страницата.|
|**PageHeight**|**0**|Да|Определя височината на страницата|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|Не|Определя дали чертежът трябва да бъде автоматично мащабиран. Стойността по подразбиране автоматично намалява изображението, за да се побере в размера на канваса. Превключете в режим **GrowToFit** или използвайте настройката **None**, за да деактивирате автоматичното мащабиране.|
|**BackgroundColor**|**Color.White**|Не|Определя фоновия цвят на изходното изображение.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|Не|Определя режима на оцветяване на единицата. Определете опцията **UseObjectColor**, за да нарисувате единиците с техния роден цвят, или опцията **UseDrawColor**, за да замените родните цветове.|
|**DrawColor**|**Color.Black**|Не|Определя заменения цвят на единицата (само ако **DrawType** е зададено на стойността на свойството **UseDrawColor**).|
|**AutomaticLayoutsScaling**|False|Не|Определя дали да се извърши автоматично мащабиране, за да се съответства на оформлението на модела.|

### **Настройка на размера и режима на канваса**

Експортирането от CAD в PDF или формати на растерно изображение не е тривиална задача. Тъй като полученото PDF или изображение изисква определяне на размера на канваса, трябва да посочим изходните размери за страницата на PDF, за да визуализираме чертежа правилно. Ясно задайте свойствата **CadRasterizationOptions.PageWidth** и **CadRasterizationOptions.PageHeight**, или може да получите **ImageSaveException**.

Освен това можете да зададете опции за скалиране на размерите. Опциите за скалиране се задават чрез свойството **CadRasterizationOptions.ScaleMethod**. Използвайте тази опция, за да автоматично настроите размерите на изображението според стойностите **CadRasterizationOptions.PageWidth** и **CadRasterizationOptions.PageHeight**. По подразбиране свойството **CadRasterizationOptions.ScaleMethod** е зададено на режим **ScaleType.ShrinkToFit**. Това свойство определя следното поведение:

- Ако размерите на CAD чертежа са по-големи от получения размер на канваса, размерите на чертежа ще бъдат намалени, за да се впишат в получения канвас, като се запази съотношението на страните.
- Ако размерите на CAD чертежа са по-малки от получените размери на канваса, задайте свойството **CadRasterizationOptions.ScaleMethod** на **ScaleType.GrowToFit**, за да увеличите размера на чертежа, за да се впише в PDF канваса, като се запази съотношението на страните.
- Или деактивирайте автоматичното скалиране с опцията **ScaleType.None**.

Примерният код по-долу показва как се използва автоматичното скалиране.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingCanvasSizeAndMode-SettingCanvasSizeAndMode.cs" >}}

### **Задаване на фонови и цветови настройки на рисуването**

По подразбиране цветната палитра за получения канвас е зададена на общата схема за документа. Това означава, че всички единици в CAD чертежа са нарисувани с черен флуид на солидно бял фон. Тези настройки могат да бъдат променени с помощта на свойствата **CadRasterizationOptions.BackgroundColor** и **CadRasterizationOptions.DrawColor**. Промяната на свойството **CadRasterizationOptions.DrawColor** също изисква настройка на свойството **CadRasterizationOptions.DrawType**, за да се използва цвета на рисуването. Свойството **CadRasterizationOptions.DrawType** контролира дали CAD единиците запазват цветовете си или се преобразуват в нестандартни цветове. За да запазите цветовете на единиците, задайте **CadRasterizationOptions.DrawType** като **CadDrawTypeMode.UseObjectColor**, в противен случай задайте стойността **CadDrawTypeMode.UseDrawColor**.

Примерният код по-долу показва как да се използват различни цветови свойства.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingBackgroundAndDrawingColors-SettingBackgroundAndDrawingColors.cs" >}}

### **Настройка на автоматичното мащабиране на оформлението**

Повечето CAD чертежи имат повече от едно оформление, съхранено в един файл, и всяко оформление може да има различни размери. При визуализиране на такива CAD чертежи в PDF, всяка страница от PDF може да има различно мащабиране, в зависимост от размера на оформлението. За да направите визуализирането хомогенно, API от Aspose.CAD са изложили свойството **CadRasterizationOptions.AutomaticLayoutsScaling**. Неговата стойност по подразбиране е **false**, но когато е зададена на **true**, API-то ще се опита да намери съответстващ мащаб за всяко отделно оформление и да ги нарисува по съответния начин, извършвайки автоматична операция по преоразмеряване в зависимост от размера на страницата.

Ето как работи свойството **CadRasterizationOptions.AutomaticLayoutsScaling** в сътрудничество със свойството **CadRasterizationOptions.ScaleMethod**.

1. Ако **ScaleMethod** е зададено на **ScaleType.ShrinkToFit** или **ScaleType.GrowToFit** с **AutomaticLayoutsScaling**, зададено на false, тогава всички оформления (включително Модела) ще бъдат обработени според първата опция.
1. Ако **ScaleMethod** е зададено на **ScaleType.ShrinkToFit** или **ScaleType.GrowToFit** с **AutomaticLayoutsScaling**, зададено на true, тогава всички оформления (с изключение на Модела) ще бъдат обработени съобразно техния размер, докато Моделът ще бъде обработен в съответствие с първата опция.
1. Ако **ScaleMethod** е зададено на **ScaleType.None** с **AutomaticLayoutsScaling**, зададено на true или false, тогава няма да се извърши мащабиране.

Примерният код по-долу показва как да зададете автоматичното мащабиране на оформленията за конверсия от CAD в PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingAutoLayoutScaling-SettingAutoLayoutScaling.cs" >}}

## **Конвертиране на оформления на AutoCAD DXF или DWG в PNG или други формати на изображения в C#**

API Aspose.CAD за .NET може да конвертира оформления на CAD от поддържани формати като DXF и DWG в PNG BMP TIFF JPEG и GIF. API-то също така осигурява поддръжка за визуализиране на конкретни оформления на CAD чертеж в различни слоеве на PSD.

Ето как можете да постигнете това в следните прости стъпки.

- Заредете файла AutoCAD DWG или DXF, използвайки класа **Image**.
- Задайте/променете ширината и височината на изображението.
- Задайте желаното име на оформление(я), използвайки свойството CadRasterizationOptions.Layouts.
- Създайте инстанция на **ImageOptionsBase** и задайте свойството си **VectorRasterizationOptions** на инстанцията на **CadRasterizationOptions**, създадена в предишната стъпка.
- Запазете CAD оформлението като TIFF или изображение.

Ето и целия изходен код.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertLayoutsToRasterImage-ConvertLayoutsToRasterImage.cs" >}}

{{% alert color="primary" %}} 

Свойството **CadRasterizationOptions.Layouts** е от тип масив от низове, така че можете да зададете повече от едно оформление едновременно за възможна конверсия в формати на изображение. При задаване на множество оформления за свойството **CadRasterizationOptions.Layouts**, полученото изображение TIFF ще има множество страници, изображението GIF ще има множество кадри, а форматът [PSD](https://docs.fileformat.com/image/psd/) ще има множество слоеве, където всяка страница/кадр/слой представлява индивидуално оформление на AutoCAD. В случай, че бъде избран друг формат на изображение, като PNG, BMP, JPEG, за да се съхрани резултатът, API-то ще визуализира само основното оформление; тоест "Модел".

{{% /alert %}}

## **Включване на проследяване на процеса на CAD визуализиране**

Aspose.CAD е въвел серия от класове и поддържащи перечисления, за да помогне с проследяването на процеса на CAD визуализиране. С тези промени процесът на конвертиране на CAD в PDF сега може да бъде постигнат, като се включи проследяването.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-EnableTrackingForCADRendering-EnableTrackingForCADRendering.cs" >}}

Проследяването на процеса на CAD визуализиране може да открие следните възможни проблеми.

1. Липсваща или повредена информация за заглавката.
1. Липсваща информация за оформлението.
1. Липсващи блокови единици.
1. Липсващи стилове на измерване.
1. Липсващи стилове.

## **Замяна на шрифтове при конвертиране на CAD чертежи**

Напълно е възможно определен CAD чертеж да използва специфичен шрифт, който не е наличен на машината, където се извършва конверсията от CAD в PDF или от CAD в растерно изображение. В такива ситуации API-то Aspose.CAD ще задейства подходящо изключение, за да подчертае липсващите шрифтове и да спре процеса на конвертиране, защото API-то изисква тези шрифтове, за да визуализира правилно съдържанието върху получения PDF или изображения.

API Aspose.CAD предлага лесен начин за използване на механизма за замяна на изискваните шрифтове с наличните шрифтове. Свойството **CadImage.Styles** връща инстанция на **CadStylesDictionary**, която от своя страна съдържа **CadStyleTableObject** за всеки стил в CAD чертежа, докато **CadStyleTableObject.PrimaryFontName** може да се използва за задаване на наличното име на шрифта.

Следният кодов фрагмент демонстрира използването на API Aspose.CAD за .NET за смяна на шрифта на всички стилове в CAD чертеж.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SubstitutingFonts-SubstitutingFonts.cs" >}}

Възможно е също така да промените шрифта на само един определен стил, като получите достъп до него чрез името на стила. Следният кодов фрагмент демонстрира използването на този подход.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-SubstitutingFonts-SubstitutingFontByName.cs" >}}

## **Конвертиране на CAD слоеве в формати на растерно изображение**

API Aspose.CAD за .NET предлага ефективен и лесен за използване метод за задаване на името на изисквания CAD слой и визуализиране на него в формати на растерно изображение. Ето как можете да постигнете това в 5 прости стъпки, както е изброено по-долу.

1. Заредете CAD файла в инстанция на **Image**, използвайки фабричния метод **Load**.
1. Създайте инстанция на **CadRasterizationOptions** и задайте задължителните свойства като **PageWidth** и **PageHeight**.
1. Добавете желаното име на слоя, използвайки метода **CadRasterizationOptions.Layers.Add**.
1. Създайте инстанция на **ImageOptionsBase** и задайте свойството си **VectorRasterizationOptions** на инстанцията на **CadRasterizationOptions**, създадена в предишната стъпка.
1. Извикайте метода **Image.Save**, предавайки пътя на файла (или обект от MemoryStream) и инстанцията на **ImageOptionsBase**, създадена в предишната стъпка.

Ето и целия изходен код.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-CADLayersToRasterImageFormats-CADLayersToRasterImageFormats.cs" >}}

### **Конвертиране на всички CAD слоеве в отделни изображения**

Можете да получите всички слоеве от CAD чертеж, използвайки **CadImage.Layers** и да визуализирате всеки слой в отделно изображение, както е демонстрирано по-долу.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-CADLayersToRasterImageFormats-ConvertAllLayersToRasterImageFormats.cs" >}}

## **Конвертиране на DWF CAD слоеве в формати на растерно изображение**

API Aspose.CAD за .NET предлага ефективен и лесен за използване метод за задаване на името на изисквания CAD слой и визуализиране на него в формати на растерно изображение. Ето как можете да постигнете това в 5 прости стъпки, както е изброено по-долу.

1. Заредете DWF CAD файла в инстанция на **Image**, използвайки фабричния метод **Load**.
1. Създайте инстанция на **CadRasterizationOptions** и задайте задължителните свойства като **PageWidth** и **PageHeight**.
1. Добавете желаното име на слоя, използвайки метода **CadRasterizationOptions.Layers.Add**.
1. Създайте инстанция на **ImageOptionsBase** и задайте свойството си **VectorRasterizationOptions** на инстанцията на **CadRasterizationOptions**, създадена в предишната стъпка.
1. Извикайте метода **Image.Save**, предавайки пътя на файла (или обект от MemoryStream) и инстанцията на **ImageOptionsBase**, създадена в предишната стъпка.

Ето и целия изходен код.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}

Aspose.CAD за .NET директно записва информация за API и номер на версия в изходните документи. Например, при визуализиране на документа в PDF, Aspose.CAD за .NET попълва полето Application с 'Aspose.CAD' и полето PDF Producer с например 'Aspose.CAD v 17.10'.

Моля, обърнете внимание, че не можете да инструктирате Aspose.CAD за .NET да променя или премахва тази информация от изходните документи.