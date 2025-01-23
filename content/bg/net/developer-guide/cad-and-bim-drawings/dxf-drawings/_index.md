---
title: Изчертания в DXF формат
type: docs
weight: 60
url: /bg/net/dxf-drawings/
---

## **Експорт на изчертания от DXF към PDF**

Aspose.CAD предоставя възможност за зареждане на елементи на AutoCAD DXF изчертания и тяхното визуализиране като цяло изчертание в PDF формат. Подходът за конверсия от DXF към PDF работи по следния начин:

1. Заредете файл с изчертание в DXF формат чрез фабричния метод [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Създайте обект от класа [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) и задайте свойствата [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) и [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Създайте обект от класа [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) и задайте свойството [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Извикайте [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), като подадете обект от [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) като втори параметър.

Поддържаните формати са:

1. AutoCAD DXF формати от 2010 година. Предишните версии на DXF формата не се гарантира, че са 100% валидни. Планираме да включим още формати и функции в бъдещите версии на Aspose.CAD.

Поддържаните елементи са:

1.     Алгиниран размер
1.     Ъглов размер
1.     Дъга
1.     Атрибут
1.     Блок Референция
1.     Окръжност
1.     Диаметърен размер
1.     Елипса
1.     Пънктова шарка
1.     Линия
1.     Многоредов текст
1.     Ординатен размер
1.     Точка
1.     Полилиния
1.     Радиален размер
1.     Лъч
1.     Завъртян размер
1.     Таблица
1.     Текст
1.     X-Линия

{{% alert color="primary" %}}

При намиране на някакъв елемент или свойство по време на парсване, които не поддържаме, този елемент или свойство ще бъдат мълчаливо игнорирани.

{{% /alert %}}

### **Управление на паметта**

Свойството [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) на класа [**Cache**](https://reference.aspose.com/cad/net/aspose.cad/cache) може да се използва за контролиране на преразпределението на паметта. Преразпределението най-вероятно ще се случи за предварително заделените кешове. То може да се случи, когато системата установи, че заделеното пространство няма да бъде достатъчно.

- Ако [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) е зададено на стойността по подразбиране, **False**, пространството се преалокира към същата среда.
- Когато е зададено на **True**, преразпределението не може да надхвърли максималното зададено пространство. В този случай паметният кеш, който се нуждае от преразпределение, се освобождава и се заделя разширено пространство на диска.

## **Експортиране на конкретен слой от изчертания в DXF формат към PDF**

Този подход работи по следния начин:

1. Отворете файл с изчертание в DXF формат с помощта на фабричния метод [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Създайте инстанция на [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/cadrasterizationoptions) и задайте [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/vectorrasterizationoptions/properties/pagewidth) и [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/vectorrasterizationoptions/properties/pageheight) свойствата.
1. Добавете слоеве към обекта на [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/cadrasterizationoptions).
1. Създайте инстанция на [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/pdfoptions) и задайте неговото [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/vectorrasterizationoptions/properties/index) свойство.
1. Извикайте метода [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) и подайте обекта на [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/pdfoptions) като втори параметър.

Поддържаните формати са:

1. AutoCAD DXF формати от 2010 година. Предишните версии на DXF формата не се гарантира, че са 100% валидни. Планираме да включим още формати и функции в бъдещите версии на Aspose.CAD.

{{% alert color="primary" %}}

Свойството [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/cadrasterizationoptions/properties/layouts) е от тип string array, така че може да специфицирате повече от един layout едновременно за конверсия в PDF формат. При специфициране на множество layouts за свойството [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/cadrasterizationoptions/properties/layouts), резултатният PDF файл ще има множество страници, като всяка страница представлява индивидуален AutoCAD layout.

{{% /alert %}}

## **Поддръжка на Block Clipping**

Aspose.CAD предоставя възможност за Block Clipping. Подходът за Block Clipping работи по следния начин:

1. Заредете файл с изчертание в DXF формат чрез фабричния метод [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Създайте инстанция на класа [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/cadrasterizationoptions) и заредете PDF файлове.
1. Задайте желаните свойства на [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/cadrasterizationoptions).
1. Извикайте [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), като подадете обект от [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/pdfoptions) като втори параметър и запазете файла.

Поддържаните формати са:

1. AutoCAD DXF формати от 2010 година. Предишните версии на DXF формата не се гарантира, че са 100% валидни. Планираме да включим още формати и функции в бъдещите версии на Aspose.CAD.

## **Експорт на изображения в DXF формат**

С помощта на Aspose.CAD можете да експортирате изображения в DXF формат. Чрез този подход можете да извършите следните действия:

1. Задайте нов шрифт
1. Скрийте елементи
1. Обновете текст

Следващият кодов семпъл ви показва как да извършите гореспоменатите действия.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportImagesToDXF-ExportImagesToDXF.cs" >}}

## **Експорт на конкретен слой от изчертания в DXF формат към изображение**

Този подход работи по следния начин:

1. Отворете файл с изчертание в DXF формат с помощта на фабричния метод [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Създайте инстанция на [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/cadrasterizationoptions) и задайте [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/vectorrasterizationoptions/properties/pagewidth) и [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/vectorrasterizationoptions/properties/pageheight) свойствата.
1. Добавете слоеве към обекта на [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/cadrasterizationoptions).
1. Създайте инстанция на [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) и задайте неговото [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad/imageoptions/vectorrasterizationoptions/properties/index) свойство.
1. Изпълнете конверсията на изчертание в изображение като използвате метода [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Поддържаните формати са:

1. AutoCAD DXF формати от 2010 година. Предишните версии на DXF формата не се гарантира, че са 100% валидни. Планираме да включим още формати и функции в бъдещите версии на Aspose.CAD.