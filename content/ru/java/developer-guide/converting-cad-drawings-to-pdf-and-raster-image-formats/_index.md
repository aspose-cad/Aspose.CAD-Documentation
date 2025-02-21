---
title: Преобразование чертежей CAD в форматы PDF и растровых изображений
type: docs
weight: 30
url: /ru/java/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
---

{{% alert color="primary" %}} 

Aspose.CAD для Java непосредственно записывает информацию об API и номере версии в выходные документы. Например, при рендеринге документа в PDF Aspose.CAD для Java заполняет поле приложения значением 'Aspose.CAD' и поле "PDF Producer" значением, например, 'Aspose.CAD v 17.9'.

Обратите внимание, что вы не можете указать Aspose.CAD для Java изменить или удалить эту информацию из выходных документов.

{{% /alert %}} 
## **Преобразование чертежей CAD в форматы растровых изображений**
Aspose.CAD для Java может преобразовывать форматы чертежей CAD, такие как [**DXF**](https://docs.fileformat.com/cad/dxf/) и [**DWG**](https://docs.fileformat.com/cad/dwg/), в поддерживаемые форматы растровых изображений, такие как [**PNG**](https://docs.fileformat.com/image/png/), [**BMP**](https://docs.fileformat.com/image/bmp/), [**TIFF**](https://docs.fileformat.com/image/tiff/), [**JPEG**](https://docs.fileformat.com/image/jpeg/) и [**GIF**](https://docs.fileformat.com/image/gif/). API Aspose.CAD для Java предложил эффективные и простые в использовании средства для достижения этой цели.
Вы можете преобразовать любой поддерживаемый формат чертежа CAD в форматы растровых изображений, следуя простым шагам, изложенным ниже.

1. Загрузите файл CAD в экземпляр [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Создайте экземпляр [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) и установите его обязательные свойства, такие как [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) и [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Создайте экземпляр **ImageOptionsBase** и установите его свойство [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) на экземпляр **CadRasterizationOptions**, созданный на предыдущем шаге.
1. Вызовите **Image.save**, передав путь к файлу (или объект MemoryStream), а также экземпляр [**ImageOptionsBase**](https://reference.aspose.com/cad/java/com.aspose.cad.class-use/ImageOptionsBase), созданный на предыдущем шаге.

Вот полный исходный код.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADDrawingToRasterImageFormat-ConvertCADDrawingToRasterImageFormat.java" >}}



По умолчанию API отображает только макет "Model". Однако вы также можете указать макеты по вашему выбору при преобразовании чертежей CAD в форматы изображений.
## **Настройка преобразования CAD**
Процедуры преобразования CAD в [PDF](https://docs.fileformat.com/pdf/) и CAD в растровые изображения имеют высокую степень настройки, поскольку класс [**CadRasterizationOptions**](https://reference.aspose.com/java/cad/com.aspose.cad.imageoptions/CadRasterizationOptions) реализован таким образом, что предоставляет множество дополнительных функций, которые при настройке могут переопределить процесс рендеринга в соответствии с потребностями приложения.
### **Класс CadRasterizationOptions**
Класс [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) является общим для всех поддерживаемых форматов CAD, таких как [**DWG**](https://docs.fileformat.com/cad/dwg/) и [DXF](https://docs.fileformat.com/cad/dxf/), поэтому информация, представленная в этой статье, актуальна для обоих вышеупомянутых форматов CAD.

Наиболее полезные свойства класса **CadRasterizationOptions**:

|**Свойство**|**Значение по умолчанию**|**Обязательно**|**Описание**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Да|Указывает ширину страницы.|
|**PageHeight**|**0**|Да|Указывает высоту страницы.|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|Нет|Указывает, следует ли автоматически масштабировать чертеж. Значение по умолчанию автоматически уменьшает изображение, чтобы оно соответствовало размеру холста. Переключитесь на режим **GrowToFit** или используйте настройку **None**, чтобы отключить автоматическое масштабирование.|
|**BackgroundColor**|**Color.White**|Нет|Указывает цвет фона выходного изображения.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|Нет|Указывает режим окраски сущности. Укажите опцию **UseObjectColor**, чтобы рисовать сущности с использованием их родного цвета, или опцию **UseDrawColor**, чтобы переопределить родные цвета.|
|**DrawColor**|**Color.Black**|Нет|Указывает переопределенный цвет сущности (только если **DrawType** установлен на значение **UseDrawColor**).|
|**AutomaticLayoutsScaling**|False|Нет|Указывает, нужно ли производить автоматическое масштабирование макета для соответствия макету модели.|
### **Установка размера полотна и режима**
Экспорт из CAD в PDF или CAD в растровые форматы изображений — это непростая задача. Поскольку итоговый PDF или изображение требует определения размера холста, нам необходимо указать выходные размеры для страницы PDF, чтобы правильно отобразить чертеж. Явно установите свойства **CadRasterizationOptions.PageWidth** и **CadRasterizationOptions.PageHeight**, в противном случае вы можете получить **ImageSaveException**.

Кроме того, вы можете задать параметры масштабирования по размеру. Параметры масштабирования задаются свойством **CadRasterizationOptions.ScaleMethod**. Используйте этот параметр, чтобы автоматически настроить размеры изображения в соответствии со значениями **CadRasterizationOptions.PageWidth** и **CadRasterizationOptions.PageHeight**. По умолчанию **CadRasterizationOptions.ScaleMethod** установлен в режим **ScaleType.ShrinkToFit**. Это свойство определяет следующее поведение:

- Если размеры чертежа CAD больше, чем размер итогового холста, то размеры чертежа уменьшаются для соответствия итоговому холсту, сохраняя при этом пропорции.
- Если размеры чертежа CAD меньше, чем размер итогового холста, установите свойство **CadRasterizationOptions.ScaleMethod** в **ScaleType.GrowToFit**, чтобы увеличить размер чертежа, чтобы он соответствовал холсту PDF, сохраняя при этом пропорции.
- Или отключите автоматическое масштабирование с помощью опции **ScaleType.None**.

Пример кода ниже демонстрирует использование функции автоматического масштабирования.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetCanvasSizeAndMode-SetCanvasSizeAndMode.java" >}}




### **Настройка цветов фона и рисования**
По умолчанию палитра цветов для результирующего холста установлена в общую схему документа. Это означает, что все сущности внутри чертежа CAD рисуются черным цветом на сплошном белом фоне. Эти настройки можно изменить с помощью свойств **CadRasterizationOptions.BackgroundColor** и **CadRasterizationOptions.DrawColor**. Изменение свойства **CadRasterizationOptions.DrawColor** также требует установки свойства **CadRasterizationOptions.DrawType**, чтобы использовать цвет рисования. Свойство **CadRasterizationOptions.DrawType** контролирует, сохраняют ли сущности CAD свои цвета или преобразуются в пользовательские цвета. Чтобы сохранить цвета сущностей, укажите **CadRasterizationOptions.DrawType** как **CadDrawTypeMode.UseObjectColor**, в противном случае укажите значение **CadDrawTypeMode.UseDrawColor**.

Пример кода ниже показывает, как использовать различные цветовые свойства.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetBackgroundAndDrawingColor-SetBackgroundAndDrawingColor.java" >}}




### **Настройка автоматического масштабирования макетов**
Большинство чертежей CAD имеют несколько макетов, хранящихся в одном файле, и каждый макет может иметь разные размеры. При отображении таких чертежей CAD в PDF каждая страница PDF может иметь различное масштабирование в зависимости от размера макета. Чтобы сделать рендеринг однородным, API Aspose.CAD предложили свойство **CadRasterizationOptions.AutomaticLayoutsScaling**. Его значение по умолчанию —  **false**, но когда оно равно true, API будет пытаться искать соответствующий масштаб для каждого отдельного макета и рисовать их соответствующим образом, выполняя автоматическое изменение размера в зависимости от размера страницы.

Вот как работает свойство **CadRasterizationOptions.AutomaticLayoutsScaling** в сотрудничестве с свойством **CadRasterizationOptions.ScaleMethod**.

1. Если **ScaleMethod** установлен в **ScaleType.ShrinkToFit** или **ScaleType.GrowToFit** с **AutomaticLayoutsScaling**, установленным на false, то все макеты (включая модель) будут обрабатываться в соответствии с первым вариантом.
1. Если **ScaleMethod** установлен в **ScaleType.ShrinkToFit** или **ScaleType.GrowToFit** с **AutomaticLayoutsScaling**, установленным на true, все макеты (кроме модели) будут обрабатываться в соответствии с их размером, а модель будет обрабатываться в соответствии с первым вариантом.
1. Если **ScaleMethod** установлен в **ScaleType.None** с **AutomaticLayoutsScaling**, установленным на true или false, то никакого масштабирования не будет выполнено.

Пример кода ниже демонстрирует, как установить автоматическое масштабирование макета для преобразования CAD в PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SettingAutoLayoutScaling-SettingAutoLayoutScaling.java" >}}




## **Преобразование макетов CAD в форматы растровых изображений**
API Aspose.CAD для Java способен преобразовывать макеты CAD поддерживаемых форматов, таких как DXF и DWG, в растровые изображения, такие как PNG, BMP, TIFF, JPEG и GIF. API также поддерживает отображение конкретных макетов чертежа CAD на разные слои PSD. 
API Aspose.CAD для Java предложил эффективные и простые в использовании средства для указания списка необходимых макетов CAD и их рендеринга в форматы растровых изображений. Вот как вы можете достичь этого за 5 простых шагов, перечисленных ниже.

1. Загрузите файл CAD в экземпляр **Image** с помощью фабричного метода **load**.
1. Создайте экземпляр **CadRasterizationOptions** и установите его обязательные свойства, такие как **PageWidth** и **PageHeight**.
1. Укажите желаемые имена макетов с помощью свойства CadRasterizationOptions.Layouts.
1. Создайте экземпляр **ImageOptionsBase** и установите его свойство **VectorRasterizationOptions** на экземпляр **CadRasterizationOptions**, созданный на предыдущем шаге.
1. Вызовите **Image.Save**, передав путь к файлу (или объект MemoryStream), а также экземпляр **ImageOptionsBase**, созданный на предыдущем шаге.

Вот полный исходный код.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayoutToRasterImageFormat-ConvertCADLayoutToRasterImageFormat.java" >}}

`  `{{% alert color="primary" %}} 

Свойство **CadRasterizationOptions.Layouts** представляет собой массив строк, поэтому вы можете указать более одного макета одновременно для возможного преобразования в форматы изображений. При указании нескольких макетов для свойства **CadRasterizationOptions.Layouts** результирующее TIFF-изображение будет содержать несколько страниц, изображение GIF будет содержать несколько кадров, а формат PSD будет содержать несколько слоев, где каждая страница/кадр/слой представляет собой отдельный макет AutoCAD. Если выбран другой формат изображения, такой как PNG, BMP, JPEG для хранения результата, API будет отображать только макет по умолчанию; то есть "Model".

{{% /alert %}} 
## **Включение трассировки процесса рендеринга CAD**
Aspose.CAD представил ряд классов и поддерживающих перечисляемых полей для помощи в трассировке процесса рендеринга CAD. С этими изменениями преобразование CAD в PDF теперь можно выполнить следующим образом, включая трассировку.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-EnableTracking.java" >}}



{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-CadRenderHandler.java" >}}



Трассировка процесса рендеринга CAD может обнаружить следующие возможные проблемы.

1. Пропущенная или поврежденная информация заголовка.
1. Пропущенная информация о макете.
1. Пропущенные блоки сущностей.
1. Пропущенные стили размеров.
1. Пропущенные стили.
## **Замена шрифтов при преобразовании чертежей CAD**
Вполне возможно, что конкретный чертеж CAD использует какой-то специфический шрифт, который недоступен на машине, где выполняется преобразование CAD в PDF или CAD в растровое изображение. В таких ситуациях API Aspose.CAD вызовет соответствующее исключение, чтобы выделить отсутствующий шрифт(ы) и остановить процесс преобразования, поскольку API требует, чтобы эти шрифты правильно отображали содержимое на итоговом PDF и/или изображениях.
API Aspose.CAD предоставляет простой способ использования механизма замены необходимых шрифтов на доступные. Свойство **CadImage.Styles** возвращает экземпляр **CadStylesDictionary**, который, в свою очередь, содержит **CadStyleTableObject** для каждого стиля в чертеже CAD, тогда как **CadStyleTableObject.PrimaryFontName** можно использовать для указания доступного имени шрифта.

Следующий фрагмент кода демонстрирует использование Aspose.CAD для Java API для изменения шрифта всех стилей в чертеже CAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFont-SubstituteFont.java" >}}




Также возможно изменить шрифт только одного конкретного стиля, получив доступ к нему через имя стиля. Следующий фрагмент кода демонстрирует использование этого подхода.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFontOfAParticularStyle-SubstituteFontOfAParticularStyle.java" >}}




## **Преобразование слоев CAD в форматы растровых изображений**
API Aspose.CAD для Java предложил эффективные и простые в использовании средства для указания имени необходимого слоя CAD и его рендеринга в форматы растровых изображений. Вот как вы можете достичь этого за 5 простых шагов, перечисленных ниже.

1. Загрузите файл CAD в экземпляр **Image** с помощью фабричного метода **load**.
1. Создайте экземпляр **CadRasterizationOptions** и установите его обязательные свойства, такие как **PageWidth** и **PageHeight**.
1. Добавьте желаемое имя слоя с помощью метода **CadRasterizationOptions.Layers.add**.
1. Создайте экземпляр **ImageOptionsBase** и установите его свойство **VectorRasterizationOptions** на экземпляр **CadRasterizationOptions**, созданный на предыдущем шаге.
1. Вызывайте метод **Image.save**, передавая путь к файлу (или объект MemoryStream), а также экземпляр **ImageOptionsBase**, созданный на предыдущем шаге.

Вот полный исходный код.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayerToRasterImageFormat-ConvertCADLayerToRasterImageFormat.java" >}}




### **Преобразование всех слоев CAD в отдельные изображения**
Вы можете получить все слои из чертежа CAD, используя **CadImage.Layers**, и отобразить каждый слой в отдельное изображение, как показано ниже.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertAllCADLayersToSeparateImages-ConvertAllCADLayersToSeparateImages.java" >}}


## **Преобразование слоев DWF CAD в форматы растровых изображений**
API Aspose.CAD для Java предложил эффективные и простые в использовании средства для указания имени необходимого слоя CAD и его рендеринга в форматы растровых изображений. Вот как вы можете достичь этого за 5 простых шагов, перечисленных ниже.

1. Загрузите файл DWF CAD в экземпляр **Image** с помощью фабричного метода **Load**.
1. Создайте экземпляр **CadRasterizationOptions** и установите его обязательные свойства, такие как **PageWidth** и **PageHeight**.
1. Добавьте желаемое имя слоя с помощью метода **CadRasterizationOptions.Layers.Add**.
1. Создайте экземпляр **ImageOptionsBase** и установите его свойство **VectorRasterizationOptions** на экземпляр **CadRasterizationOptions**, созданный на предыдущем шаге.
1. Вызовите метод **Image.Save**, передавая путь к файлу (или объект MemoryStream), а также экземпляр **ImageOptionsBase**, созданный на предыдущем шаге.

Вот полный исходный код.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToBMP-ExportToBMP.java" >}}
