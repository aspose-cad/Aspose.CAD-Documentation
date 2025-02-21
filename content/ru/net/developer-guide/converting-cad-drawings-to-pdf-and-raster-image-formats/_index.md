---
title: DWG DXF в PDF C# | Конвертация файлов Auto CAD в PDF JPEG PNG в C# .NET
type: docs
weight: 30
url: /ru/net/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
keywords: "DWG в PDF C#, DXF в PDF C#, DWF DWT в PDF C#, конвертировать AutoCAD, конвертировать DWG, конвертировать DWF, конвертировать DWT, конвертировать DXF, конвертировать автокад в pdf, конвертировать DWG в PDF, конвертировать DWG в PNG, конвертировать DWG в TIFF, конвертировать DWG в JPG"
description: Используйте преобразователь C# .NET AutoCAD в PDF для конвертации DWG или DXF в PDF. Вы можете конвертировать DWG, DWF, DWT и DXF в PDF, JPEG, PNG, BMP, GIF и TIFF в C# .NET также.
---

## **Конвертация DWG или DXF в PNG JPEG BMP GIF или TIFF в C#**

Aspose.CAD для .NET может конвертировать форматы чертежей AutoCAD такие как [DXF](https://docs.fileformat.com/cad/dxf/) и [DWG](https://docs.fileformat.com/cad/dwg/) в [PNG](https://docs.fileformat.com/image/png/), [BMP](https://docs.fileformat.com/image/bmp/), [TIFF](https://docs.fileformat.com/image/tiff/), [JPEG](https://docs.fileformat.com/image/jpeg/) и [GIF](https://docs.fileformat.com/image/gif/). Он предоставляет эффективный и простой в использовании API для достижения этой цели.

Вы можете конвертировать любой поддерживаемый формат чертежа AutoCAD в форматы растровых изображений, используя простые шаги, описанные ниже.

1. Загрузите файл AutoCAD DWG или DXF в класс [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Создайте экземпляр [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Установите/измените размер изображения, используя [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) и [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Создайте экземпляр [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase).
1. Установите свойство [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) в экземпляр [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions), созданный на предыдущем шаге.
1. Сохраните чертеж AutoCAD как PDF с помощью [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save), передав путь к файлу (или объект MemoryStream) и экземпляр [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase), созданный на предыдущем шаге.

Вот полный исходный код.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertDrawingToRasterImage-ConvertDrawingToRasterImage.cs" >}}

По умолчанию API отображает только макет "Model". Однако вы также можете указать макеты по вашему выбору при конвертации чертежей CAD в форматы изображений.

## **Настройка конвертации CAD**

Процедуры конвертации CAD в [PDF](https://docs.fileformat.com/pdf/) и CAD в растровые изображения Highly имеют высокую конфигурацию, поскольку класс [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) разработан таким образом, что предоставляет множество необязательных функций, которые при установке могут переопределить процесс визуализации в соответствии с потребностями приложения.

### **Класс CadRasterizationOptions**

Класс **CadRasterizationOptions** является общим для всех поддерживаемых форматов CAD, таких как DWG и DXF, поэтому информация, представленная в этой статье, актуальна для обоих упомянутых форматов CAD.

Наиболее полезные свойства класса **CadRasterizationOptions**:

|**Свойство**|**Значение по умолчанию**|**Обязательное**|**Описание**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Да|Указывает ширину страницы.|
|**PageHeight**|**0**|Да|Указывает высоту страницы.|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|Нет|Указывает, должно ли изображение автоматически масштабироваться. Значение по умолчанию автоматически уменьшает изображение, чтобы оно подходило под размер холста. Переключите в режим **GrowToFit** или используйте настройку **None**, чтобы отключить автоматическое масштабирование.|
|**BackgroundColor**|**Color.White**|Нет|Указывает цвет фона выходного изображения.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|Нет|Указывает режим цветизации сущностей. Укажите опцию **UseObjectColor**, чтобы рисовать сущности с их родным цветом, или опцию **UseDrawColor**, чтобы переопределить родные цвета.|
|**DrawColor**|**Color.Black**|Нет|Указывает переопределенный цвет сущности (только если **DrawType** установлен на значение свойства **UseDrawColor**).|
|**AutomaticLayoutsScaling**|Ложь|Нет|Указывает, необходимо ли выполнять автоматическое масштабирование макета для соответствия макету модели.|

### **Настройка размеров холста и режима**

Экспорт из CAD в PDF или форматы растровых изображений не является тривиальной задачей. Поскольку результата PDF или изображения требует определения размера холста, нам необходимо указать выходные размеры для страницы PDF, чтобы правильно отобразить чертеж. Явно установите свойства **CadRasterizationOptions.PageWidth** и **CadRasterizationOptions.PageHeight**, или вы можете получить **ImageSaveException**.

Кроме того, вы можете указать параметры масштабирования размеров. Параметры масштабирования устанавливаются свойством **CadRasterizationOptions.ScaleMethod**. Используйте этот параметр, чтобы автоматически подгонять размеры изображения в соответствии со значениями **CadRasterizationOptions.PageWidth** и **CadRasterizationOptions.PageHeight**. По умолчанию **CadRasterizationOptions.ScaleMethod** установлен в режим **ScaleType.ShrinkToFit**. Этот параметр определяет следующее поведение:

- Если размеры чертежа CAD больше, чем размер итогового холста, тогда размеры чертежа будут уменьшены, чтобы соответствовать результирующему холсту при сохранении пропорций.
- Если размеры чертежа CAD меньше размера итогового холста, установите параметр **CadRasterizationOptions.ScaleMethod** в **ScaleType.GrowToFit**, чтобы увеличить размер чертежа, чтобы он соответствовал холсту PDF при сохранении пропорций.
- Или отключите автоматическое масштабирование с помощью параметра **ScaleType.None**.

Пример кода ниже показывает использование параметра автоматического масштабирования.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingCanvasSizeAndMode-SettingCanvasSizeAndMode.cs" >}}

### **Настройка фонов и цветов рисования**

По умолчанию цветовая палитра для результирующего холста установлена в общую схему документа. Это означает, что все сущности внутри чертежа CAD рисуются черной ручкой на сплошном белом фоне. Эти настройки могут быть изменены с помощью свойств **CadRasterizationOptions.BackgroundColor** и **CadRasterizationOptions.DrawColor**. Изменение свойства **CadRasterizationOptions.DrawColor** также требует установки свойства **CadRasterizationOptions.DrawType**, чтобы использовать цвет для рисования. Свойство **CadRasterizationOptions.DrawType** контролирует, сохраняют ли цвета сущностей CAD свои цвета или преобразуются в пользовательские цвета. Чтобы сохранить цвета сущностей, укажите **CadRasterizationOptions.DrawType** как **CadDrawTypeMode.UseObjectColor**, в противном случае укажите значение **CadDrawTypeMode.UseDrawColor**.

Пример кода ниже показывает, как использовать различные цветовые свойства.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingBackgroundAndDrawingColors-SettingBackgroundAndDrawingColors.cs" >}}

### **Настройка автоматического масштабирования макета**

Большинство чертежей CAD имеют более одного макета, хранящегося в одном файле, и каждый макет может иметь разные размеры. При визуализации таких чертежей CAD в PDF каждая страница PDF может иметь разное масштабирование в зависимости от размеров макета. Чтобы сделать визуализацию однородной, API Aspose.CAD предоставили свойство **CadRasterizationOptions.AutomaticLayoutsScaling**. Его значение по умолчанию — **false**, но когда **true**, API будет стараться искать соответствующий масштаб для каждого отдельного макета и рисовать их соответствующим образом, выполняя автоматическую операцию изменения размера в соответствии с размером страницы.

Вот как работает свойство **CadRasterizationOptions.AutomaticLayoutsScaling** в сотрудничестве со свойством **CadRasterizationOptions.ScaleMethod**.

1. Если **ScaleMethod** установлен на **ScaleType.ShrinkToFit** или **ScaleType.GrowToFit** с **AutomaticLayoutsScaling**, установленным в false, тогда все макеты (включая модель) будут обрабатываться в соответствии с первым вариантом.
1. Если **ScaleMethod** установлен на **ScaleType.ShrinkToFit** или **ScaleType.GrowToFit** с **AutomaticLayoutsScaling**, установленным в true, тогда все макеты (кроме модели) будут обрабатываться в соответствии с их размерами, в то время как модель будет обрабатываться в соответствии с первым вариантом.
1. Если **ScaleMethod** установлен на **ScaleType.None** с **AutomaticLayoutsScaling**, установленным в true или false, тогда масштабирование не будет выполнено.

Пример кода ниже показывает, как установить автоматическое масштабирование макета для конвертации CAD в PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingAutoLayoutScaling-SettingAutoLayoutScaling.cs" >}}

## **Конвертация макетов AutoCAD DXF или DWG в PNG или другие форматы изображений в C#**

API Aspose.CAD для .NET может конвертировать макеты CAD поддерживаемых форматов, таких как DXF и DWG, в PNG BMP TIFF JPEG и GIF. API также предоставляет поддержку визуализации определенных макетов чертежа CAD в различных слоях PSD.

Вот как вы можете достичь того же в следующих простых шагах.

- Загрузите файл AutoCAD DWG или DXF с помощью класса **Image**.
- Установите/измените ширину и высоту изображения.
- Установите желаемое имя(имена) макета, используя свойство CadRasterizationOptions.Layouts.
- Создайте экземпляр **ImageOptionsBase** и установите его свойство **VectorRasterizationOptions** в экземпляр **CadRasterizationOptions**, созданный на предыдущем шаге.
- Сохраните макет CAD в формате TIFF или изображении.

Вот полный исходный код.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertLayoutsToRasterImage-ConvertLayoutsToRasterImage.cs" >}}

{{% alert color="primary" %}} 

Свойство **CadRasterizationOptions.Layouts** является массивом строк, поэтому вы можете указать более одного макета за раз для возможной конвертации в форматы изображений. При указании нескольких макетов для свойства **CadRasterizationOptions.Layouts** результирующее изображение TIFF будет содержать несколько страниц, изображение GIF будет иметь несколько кадров, а формат [PSD](https://docs.fileformat.com/image/psd/) будет содержать несколько слоев, где каждая страница/кадр/слой представляет отдельный макет AutoCAD. В случае, если выбран другой формат изображения, такой как PNG, BMP, JPEG для сохранения результата, то API отобразит только макет по умолчанию; то есть "Model".

{{% /alert %}}

## **Включение отслеживания процесса визуализации CAD**

Aspose.CAD представила серию классов и поддерживающих перечислений, чтобы помочь с отслеживанием процесса визуализации CAD. С этими изменениями конвертация CAD в PDF теперь может быть достигнута следующим образом с включением отслеживания.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-EnableTrackingForCADRendering-EnableTrackingForCADRendering.cs" >}}

Отслеживание процесса визуализации CAD может обнаружить следующие возможные проблемы.

1. Отсутствующая или поврежденная информация заголовка.
1. Отсутствующая информация о макете.
1. Отсутствующие блоки сущностей.
1. Отсутствующие стили размеров.
1. Отсутствующие стили.

## **Замена шрифтов при конвертации чертежей CAD**

Вполне возможно, что конкретный чертеж CAD использует какой-то специфический шрифт, который недоступен на компьютере, где происходит конвертация CAD в PDF или CAD в растровое изображение. В таких ситуациях API Aspose.CAD вызовет соответствующее исключение, чтобы подчеркнуть отсутствующие шрифты и остановить процесс конвертации, поскольку API требует эти шрифты для правильной визуализации содержимого на результирующем PDF или изображениях.

API Aspose.CAD предоставляет простой способ использовать механизм замены необходимых шрифтов на доступные шрифты. Свойство **CadImage.Styles** возвращает экземпляр **CadStylesDictionary**, который, в свою очередь, содержит **CadStyleTableObject** для каждого стиля в чертеже CAD, тогда как **CadStyleTableObject.PrimaryFontName** может использоваться для указания доступного имени шрифта.

Следующий фрагмент кода демонстрирует использование Aspose.CAD для .NET API для изменения шрифта всех стилей в чертеже CAD.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SubstitutingFonts-SubstitutingFonts.cs" >}}

Также возможно изменить шрифт только одного конкретного стиля, получив к нему доступ по имени стиля. Следующий фрагмент кода демонстрирует использование этого подхода.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-SubstitutingFonts-SubstitutingFontByName.cs" >}}

## **Конвертация слоев CAD в форматы растровых изображений**

API Aspose.CAD для .NET предоставил эффективное и простое в использовании средство для указания имени требуемого слоя CAD и его рендеринга в форматы растровых изображений. Вот как вы можете достичь того же в 5 простых шагах, перечисленных ниже.

1. Загрузите файл CAD в экземпляр **Image**, используя заводской метод **Load**.
1. Создайте экземпляр **CadRasterizationOptions** и установите его обязательные свойства, такие как **PageWidth** и **PageHeight**.
1. Добавьте желаемое имя слоя с помощью метода **CadRasterizationOptions.Layers.Add**.
1. Создайте экземпляр **ImageOptionsBase** и установите его свойство **VectorRasterizationOptions** в экземпляр **CadRasterizationOptions**, созданный на предыдущем шаге.
1. Вызовите метод **Image.Save**, передав путь к файлу (или объект MemoryStream), а также экземпляр **ImageOptionsBase**, созданный на предыдущем шаге.

Вот полный исходный код.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-CADLayersToRasterImageFormats-CADLayersToRasterImageFormats.cs" >}}

### **Конвертация всех слоев CAD в отдельные изображения**

Вы можете получить все слои из чертежа CAD с помощью **CadImage.Layers** и отрендерить каждый слой в отдельное изображение, как показано ниже.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-CADLayersToRasterImageFormats-ConvertAllLayersToRasterImageFormats.cs" >}}

## **Конвертация слоев DWF CAD в форматы растровых изображений**

API Aspose.CAD для .NET предложил эффективное и простое в использовании средство для указания имени требуемого слоя CAD и его рендеринга в форматы растровых изображений. Вот как вы можете достичь того же в 5 простых шагах, перечисленных ниже.

1. Загрузите файл DWF CAD в экземпляр **Image**, используя заводской метод **Load**.
1. Создайте экземпляр **CadRasterizationOptions** и установите его обязательные свойства, такие как **PageWidth** и **PageHeight**.
1. Добавьте желаемое имя слоя с помощью метода **CadRasterizationOptions.Layers.Add**.
1. Создайте экземпляр **ImageOptionsBase** и установите его свойство **VectorRasterizationOptions** в экземпляр **CadRasterizationOptions**, созданный на предыдущем шаге.
1. Вызовите метод **Image.Save**, передав путь к файлу (или объект MemoryStream), а также экземпляр **ImageOptionsBase**, созданный на предыдущем шаге.

Вот полный исходный код.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}

Aspose.CAD для .NET напрямую записывает информацию об API и номере версии в выходных документах. Например, при визуализации документа в PDF Aspose.CAD для .NET заполняет поле приложения значением 'Aspose.CAD', а поле PDF Producer — значением, например 'Aspose.CAD v 17.10'.

Обратите внимание, что вы не можете указать Aspose.CAD для .NET изменить или удалить эту информацию из выходных документов.
