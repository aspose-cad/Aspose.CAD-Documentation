---
title: Чертежи DXF
type: docs
weight: 60
url: /bg/java/dxf-drawings/
---

## **Изнасяне на чертежи DXF към PDF**

Aspose.CAD предоставя възможността да зарежда същностите на чертежите AutoCAD DXF и да ги визуализира като цял чертеж във формат PDF. Подходът за конвертиране от DXF в PDF работи по следния начин:

1. Зареждане на файл с чертеж DXF чрез фабричния метод [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Създаване на обект от класа [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) и задаване на свойствата [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) и [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Създаване на обект от класа [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) и задаване на свойството [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Извикване на Image.Save, като се предава обект от [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) като втори параметър.

Примерът на код по-долу показва как да конвертирате файл, използвайки настройките по подразбиране.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFDrawingToPDF-.java" >}}

### **Поддържани формати**

В момента поддържаме изцяло форматите на файловете AutoCAD DXF 2010. Не можем да гарантираме, че предходните версии на DXF са 100% валидни. Планираме да включим още формати и функции в бъдещите версии на Aspose.CAD.

### **Поддържани елементи**

В момента поддържаме всички широко използвани 2D елементи и техните основни стойности по подразбиране, както следва:

1. Подравнено измерение
1. Ъглово измерение
1. Дъга
1. Атрибут
1. Блокова референция
1. Кръг
1. Диаметърно измерване
1. Елипса
1. Запълване
1. Линия
1. Много редов текст
1. Ординатно измерване
1. Точка
1. Полилиния
1. Радиално измерение
1. Лъч
1. Въртящо измерение
1. Таблица
1. Текст
1. Хоризонтална линия

{{% alert color="primary" %}}

Ако по време на парсене срещнем някакъв елемент или свойство, което не поддържаме, елементът или свойството ще бъдат мълчаливо пренебрегнати.

{{% /alert %}}

### **Управление на паметта**

Свойството [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) може да се използва за контрол на преалокацията на паметта. Преалокацията е най-вероятно да се случи за предварително заделени кешове. Тя може да се случи, когато системата установи, че заделеното пространство няма да е достатъчно.

- Ако [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) е зададено на стойността по подразбиране, **False**, пространството се преалокира към същото средство.
- Когато е зададено на **True**, преалокацията не може да надвишава максималното зададено пространство. В този случай заделеният в паметта кеш (който изисква преалокация) се освобождава и се заделя пространство на диска.

## **Изнасяне на конкретен слой от чертежи DXF към PDF**

Този подход работи по следния начин:

1. Отваряне на файл с чертеж DXF чрез фабричния метод [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Създаване на екземпляр на [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) и задаване на свойствата [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) и [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Добавяне на слоеве към екземпляра на [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Създаване на екземпляр на [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) и задаване на неговото свойство [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Изнасяне на чертежа към PDF чрез метода [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Примерът на код по-долу показва как да конвертирате конкретен слой от DXF в PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificLayerOfDXFDrawingToPDF-.java" >}}

## **Изнасяне на конкретен слой от чертежи DXF към изображение**

Този подход работи по следния начин:

1. Отваряне на файл с чертеж DXF чрез фабричния метод [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Създаване на екземпляр на [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) и задаване на свойствата [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) и [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Добавяне на слоеве към екземпляра на [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Създаване на екземпляр на [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) и задаване на неговото свойство [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Изнасяне на чертежа към изображение чрез метода [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Примерът на код по-долу показва как да конвертирате конкретен слой от DXF в изображение.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.java" >}}

## **Визуализиране на файлове PDF като част от чертежи DXF**

Този подход работи по следния начин:

1. Зареждане на файл с чертеж DXF чрез фабричния метод [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Създаване на обект от класа [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) и зареждане на файлове PDF.
1. Задаване на свойствата [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) и [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Извикване на [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) и запазване на файла.

Примерът на код по-долу показва как да визуализирате файлове PDF като част от чертежи DXF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-RenderDXFAsPDF-RenderDXFAsPDF.java" >}}

## **Изнасяне на DXF в WMF**

Този подход работи по следния начин:

1. Зареждане на файл с чертеж DXF чрез фабричния метод [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Създаване на обект от класа [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) и зареждане на файлове PDF.
1. Задаване на свойствата [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) и [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Извикване на [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) и запазване на файла.

Примерът на код по-долу показва как да изнесете DXF в WMF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFToWMF-ExportDXFToWMF.java" >}}

## **Поддръжка за Запазване на файлове DXF**

Aspose.CAD предоставя възможността да зарежда файлове AutoCAD DXF и да прави промени в тях и да ги запазва отново като файл DXF. Примерният код по-долу показва как да се постигнат конкретните изисквания

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SaveDXFFiles-SaveDXFFiles.java" >}}

## **Експорт на вграден подложен DGN за формат DXF**

Aspose.CAD предоставя възможността за зареждане на файлове AutoCAD DXF и експортиране на вграден DGN подложен за формата DXF.

Примерът на код по-долу показва как да се постигнат конкретните изисквания.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportEmbeddedDGN-ExportEmbeddedDGN.java" >}}

## **Изнасяне на конкретно DXF Layout към PDF**

Този подход работи по следния начин:

1. Отваряне на файл с чертеж DXF чрез фабричния метод [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Създаване на екземпляр на [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) и задаване на свойствата [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) и [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Задаване на желаните имена на слоевете чрез свойството [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-).
1. Създаване на екземпляр на [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) и задаване на неговото свойство [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Изнасяне на чертежа към PDF чрез метода [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Примерът на код по-долу показва как да конвертирате конкретен layout от DXF в PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToPDF-.java" >}}

{{% alert color="primary" %}}

Свойството [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) е от тип масив от низове, така че можете да посочите повече от един layout едновременно за възможно конвертиране във формат