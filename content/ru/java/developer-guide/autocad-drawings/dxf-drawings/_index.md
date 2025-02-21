---
title: DXF Чертежи
type: docs
weight: 60
url: /ru/java/developer-guide/autocad-drawings/dxf-drawings/
---

## **Экспорт DXF Чертежей в PDF**

Aspose.CAD предоставляет возможность загружать сущности чертежей AutoCAD DXF и рендерить их как целый чертеж в формате PDF. Подход к конвертации DXF в PDF работает следующим образом:

1. Загрузите файл чертежа DXF с помощью метода-фабрики [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Создайте объект класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) и установите свойства [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) и [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Создайте объект класса [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) и установите свойство [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Вызовите Image.Save, передав объект [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) в качестве второго параметра.

Пример кода ниже показывает, как конвертировать файл с помощью настроек по умолчанию.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFDrawingToPDF-.java" >}}

### **Поддерживаемые Форматы**

На данный момент мы полностью поддерживаем форматы файлов AutoCAD DXF 2010. Предыдущие версии DXF не гарантированы как 100% валидные. Мы планируем включить больше форматов и функций в будущие версии Aspose.CAD.

### **Поддерживаемые Сущности**

На данный момент мы поддерживаем все широко распространенные 2D сущности и их основные параметры по умолчанию:

1. Выравненная Размерность
1. Угловая Размерность
1. Дуга
1. Атрибут
1. Ссылка на Блок
1. Круг
1. Размерность Диаметра
1. Эллипс
1. Заливка
1. Линия
1. Многострочный Текст
1. Ориентированная Размерность
1. Точка
1. Полилиния
1. Радиальная Размерность
1. Луч
1. Поворотная Размерность
1. Таблица
1. Текст
1. XLine

{{% alert color="primary" %}}

Если в процессе разбора мы столкнемся с какой-либо сущностью или свойством, которое мы не поддерживаем, сущность или свойство будут тихо проигнорированы.

{{% /alert %}}

### **Управление Памятью**

Свойство [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) можно использовать для управления повторным выделением памяти. Повторное выделение, скорее всего, произойдет для предварительно выделенных кешей. Это может произойти, когда система определит, что выделенное пространство будет недостаточным.

- Если [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) установлено на значение по умолчанию, **False**, пространство повторно выделяется в том же медиуме.
- Когда установлено значение **True**, повторное выделение не может превышать максимальное заданное пространство. В этом случае существующий выделенный кеш в памяти (который требует повторного выделения) освобождается, и дополнительное пространство выделяется на диске.

## **Экспорт Определённого Слоя DXF Чертежей в PDF**

Этот подход работает следующим образом:

1. Откройте файл чертежа DXF с помощью метода-фабрики [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Создайте экземпляр [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) и укажите свойства [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) и [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Добавьте слои в объект [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Создайте экземпляр [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) и установите его свойство [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Экспортируйте чертеж в PDF с помощью метода [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Пример кода ниже показывает, как конвертировать определённый слой DXF в PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificLayerOfDXFDrawingToPDF-.java" >}}

## **Экспорт Определённого Слоя DXF Чертежей в Изображение**

Этот подход работает следующим образом:

1. Откройте файл чертежа DXF с помощью метода-фабрики [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Создайте экземпляр [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) и укажите свойства [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) и [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Добавьте слои в объект [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Создайте экземпляр [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) и установите его свойство [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Экспортируйте чертеж в PDF с помощью метода [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Пример кода ниже показывает, как конвертировать определённый слой DXF в изображение.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.java" >}}

## **Рендеринг PDF файлов как части DXF Чертежей**

Этот подход работает следующим образом:

1. Загрузите файл чертежа DXF с помощью метода-фабрики [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Создайте объект класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) и загрузите PDF файлы.
1. Установите свойства [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) и [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Вызовите [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) и сохраните файл.

Пример кода ниже показывает, как рендерить PDF файлы как часть DXF чертежей.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-RenderDXFAsPDF-RenderDXFAsPDF.java" >}}

## **Экспорт DXF в WMF**

Этот подход работает следующим образом:

1. Загрузите файл чертежа DXF с помощью метода-фабрики [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Создайте объект класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) и загрузите PDF файлы.
1. Установите свойства [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) и [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Вызовите [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) и сохраните файл.

Пример кода ниже показывает, как экспортировать DXF в WMF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFToWMF-ExportDXFToWMF.java" >}}

## **Поддержка Сохранения DXF Файлов**

Aspose.CAD предоставляет возможность загружать файлы AutoCAD DXF, вносить в них изменения и снова сохранять как файлы DXF. Пример кода ниже показывает, как достичь указанных требований.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SaveDXFFiles-SaveDXFFiles.java" >}}

## **Экспорт встроенной подложки DGN для формата DXF**

Aspose.CAD предоставляет возможность загружать файлы AutoCAD DXF и экспортировать встроенную подложку DGN для формата DXF.

Пример кода ниже показывает, как достичь указанных требований.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportEmbeddedDGN-ExportEmbeddedDGN.java" >}}

## **Экспортирование Определённого Макета DXF в PDF**

Этот подход работает следующим образом:

1. Откройте файл чертежа DXF с помощью метода-фабрики [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Создайте экземпляр [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) и укажите свойства [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) и [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Укажите желаемые имена макета(ов) с помощью свойства [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-).
1. Создайте экземпляр [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) и установите его свойство [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Экспортируйте чертеж в PDF с помощью метода [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Пример кода ниже показывает, как конвертировать определённый макет DXF в PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToPDF-.java" >}}

{{% alert color="primary" %}}

Свойство [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) имеет тип строкового массива, так что вы можете указать более одного макета одновременно для возможной конвертации в формат PDF. При указании нескольких макетов для свойства [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) создаваемый PDF будет содержать несколько страниц, где каждая страница представляет собой отдельный макет AutoCAD.

{{% /alert %}}

## **Доступ к объектам ATTRIB и MTEXT**

Этот подход работает следующим образом:

1. Откройте файл чертежа DXF с помощью метода-фабрики [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Получите доступ к сущностям внутри CAD файла.
1. Проверьте сущности [**CadEntityTypeName.MTEXT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#MTEXT) и [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT).
1. Добавьте в временный список для дальнейшей обработки.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-AddAttribMText-AddAttribMText.java" >}}

## **Декомпозиция CAD Объектов Вставки**

Этот подход работает следующим образом:

1. Откройте файл **DXF** с помощью метода-фабрики [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Получите доступ к сущностям внутри CAD файла.
1. Проверьте сущности [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT).
1. Проверьте список типов [**CadBlockEntity**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity).
1. Обработайте сущности.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-DecomposeCadInsertObject-DecomposeCadInsertObject.java" >}}

## **Поддержка Обрезки Блока**

Aspose.CAD предоставляет функцию обрезки блока. Подход к обрезке блока работает следующим образом:

1. Загрузите файл чертежа DXF с помощью метода-фабрики [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Создайте объект класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) и загрузите PDF файлы.
1. Установите желаемые свойства [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Вызовите [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) и передайте объект [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) в качестве второго параметра и сохраните файл.

Пример кода ниже показывает, как работает обрезка блока.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SupportOfBlockClipping-SupportOfBlockClipping.java" >}}

## **Экспорт Изображений в DXF**

С помощью Aspose.CAD вы можете экспортировать изображения в формат DXF. С использованием этого подхода вы можете выполнять следующие действия:

1. Установите новый шрифт.
1. Скрыть сущности.
1. Обновить текст.

Следующий фрагмент кода показывает, как выполнить указанные выше действия.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-ExportImagesToDXF.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-GetFileExtension.java" >}}
