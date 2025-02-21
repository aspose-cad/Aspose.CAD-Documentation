---
title: DXF Чертежи
type: docs
weight: 60
url: /ru/net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **Экспорт DXF чертежей в PDF**

Aspose.CAD предоставляет возможность загружать объекты чертежей AutoCAD DXF и отображать их в формате PDF. Подход к конвертации DXF в PDF работает следующим образом:

1. Загрузите файл чертежа DXF с использованием метода фабрики [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Создайте объект класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) и установите свойства [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) и [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Создайте объект класса [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) и установите свойство [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Вызовите [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), передавая объект [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) в качестве второго параметра.

Пример кода ниже демонстрирует, как конвертировать файл с использованием настроек по умолчанию.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFToPDF-ExportDXFToPDF.cs" >}}

### **Поддерживаемые форматы**

На данный момент мы полностью поддерживаем форматы файлов AutoCAD DXF 2010. Предыдущие версии DXF не гарантируются как 100% действительные. Мы планируем включить больше форматов и функций в будущих версиях Aspose.CAD.

### **Поддерживаемые объекты**

На данный момент мы поддерживаем все широко распространенные 2D объекты и их основные стандартные параметры, как показано ниже:

1. Выравненное измерение
1. Угловое измерение
1. Дуга
1. Атрибут
1. Ссылка на блок
1. Окружность
1. Измерение диаметра
1. Элипс
1. Штриховка
1. Линия
1. Многострочный текст
1. Ординатное измерение
1. Точка
1. Полилиния
1. Радиальное измерение
1. Луч
1. Поворотное измерение
1. Таблица
1. Текст
1. Х-лайн

{{% alert color="primary" %}}

Если при парсинге мы сталкиваемся с некоторым объектом или свойством, которое мы не поддерживаем, то объект или свойство будет тихо проигнорировано.

{{% /alert %}}

### **Управление памятью**

Свойство [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) класса [**Cache**](https://reference.aspose.com/cad/net/aspose.cad/cache) может быть использовано для управления перераспределением памяти. Перераспределение, скорее всего, произойдет для предварительно выделенных кэшей. Это может случиться, когда система понимает, что выделенного пространства недостаточно.

- Если [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) установлено на значение по умолчанию, **False**, пространство перераспределяется на то же средство.
- Когда выставлено **True**, перераспределение не может превышать максимальное заданное пространство. В этом случае существующий выделенный в памяти кэш (который требует перераспределения) освобождается, и дополнительное пространство выделяется на диске.

## **Экспорт специфического слоя DXF чертежей в PDF**

Этот подход работает следующим образом:

1. Откройте файл чертежа DXF с использованием метода фабрики [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Создайте экземпляр [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) и укажите свойства [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) и [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Добавьте слои в объект [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Создайте экземпляр [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) и установите его свойство [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Вызовите метод [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) и передайте объект [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) в качестве второго параметра.

Пример кода ниже демонстрирует, как конвертировать специфический слой DXF в PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayerToPDF-ExportDXFSpecificLayerToPDF.cs" >}}

## **Отрисовка PDF файлов как части DXF чертежей**

Этот подход работает следующим образом:

1. Загрузите файл чертежа DXF с использованием метода фабрики [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Создайте объект класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) и загрузите PDF файлы.
1. Установите свойства [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) и [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Вызовите [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) и сохраните файл.

Пример кода ниже демонстрирует, как отрисовать PDF файлы как часть DXF чертежей.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

## **Экспорт встроенного подложки DGN для формата DXF**

Aspose.CAD предоставляет возможность загружать файлы AutoCAD DXF и экспортировать встроенные подложки DGN для формата DXF.

Пример кода ниже демонстрирует, как достичь указанных требований.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **Поддержка сохранения DXF файлов**

Aspose.CAD предоставляет возможность загружать файлы AutoCAD DXF, вносить изменения в них и снова сохранять их как файлы DXF.

Пример кода ниже демонстрирует, как достичь указанных требований.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-SaveDXFFiles-SaveDXFFiles.cs" >}}

## **Экспорт DXF в WMF**

Этот подход работает следующим образом:

1. Загрузите файл чертежа DXF с использованием метода фабрики [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Создайте объект класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) и загрузите PDF файлы.
1. Установите свойства [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) и [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Вызовите [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) и сохраните файл.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportDXFToWMF-ExportDXFToWMF.cs" >}}

## **Экспорт специфического макета DXF в PDF**

Этот подход работает следующим образом:

1. Откройте файл чертежа DXF с использованием метода фабрики [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Создайте экземпляр [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) и укажите свойства [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) и [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Укажите предполагаемое имя(я) макета с использованием свойства [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts).
1. Создайте экземпляр [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) и установите его свойство [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Экспортируйте чертеж в PDF, вызвав метод [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) и передав объект [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) в качестве второго параметра.

Пример кода ниже демонстрирует, как конвертировать специфический макет DXF в PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

{{% alert color="primary" %}}

Свойство [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) является массивом строк, поэтому вы можете указать более одного макета одновременно для возможной конвертации в формат PDF. Если вы укажете несколько макетов для свойства [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts), результирующий PDF будет содержать несколько страниц, где каждая страница представляет собой отдельный макет AutoCAD.

{{% /alert %}}

## **Поддержка обрезки блоков**

Aspose.CAD предоставляет возможность обрезки блоков. Подход обрезки блоков работает следующим образом:

1. Загрузите файл чертежа DXF с использованием метода фабрики [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Создайте объект класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) и загрузите PDF файлы.
1. Установите необходимые свойства [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Вызовите [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), передав объект [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) во втором параметре, и сохраните файл.

Пример кода ниже демонстрирует, как работает обрезка блоков.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DXF-Drawings-SupportOfBlockClipping-SupportOfBlockClipping.cs" >}}

## **Экспорт изображений в DXF**

С помощью Aspose.CAD вы можете экспортировать изображения в формат DXF. С помощью этого подхода вы можете выполнить следующие действия:

1. Установить новый шрифт
1. Скрыть объекты
1. Обновить текст

Следующий фрагмент кода показывает, как выполнить перечисленные выше действия.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportImagesToDXF-ExportImagesToDXF.cs" >}}

## **Экспорт специфического слоя DXF чертежей в изображение**

Этот подход работает следующим образом:

1. Откройте файл чертежа DXF с использованием метода фабрики [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Создайте экземпляр [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) и укажите свойства [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) и [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Добавьте слои в объект [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Создайте экземпляр [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) и установите его свойство [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Экспортируйте чертеж в PDF с помощью метода [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Пример кода ниже демонстрирует, как конвертировать специфический слой DXF в изображение.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.cs" >}}
