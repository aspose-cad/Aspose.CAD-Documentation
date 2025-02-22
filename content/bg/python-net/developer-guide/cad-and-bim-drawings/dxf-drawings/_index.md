---
title: Изчертания в DXF формат
type: документация
weight: 10
url: /bg/python-net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **Изнасяне на DXF изчертания към PDF**

Aspose.CAD предоставя възможността за зареждане на елементите на AutoCAD DXF изчертания и тяхното визуализиране като цяло изчертание във формат PDF. Подходът за конвертиране на DXF в PDF работи по следния начин:

1. Заредете DXF изчертания файл, използвайки **Image.load** фабричния метод.
1. Създайте обект от класа **CadRasterizationOptions** и задайте свойствата **page_height** и **page_width**.
1. Създайте обект от класа **PdfOptions** и задайте свойството **VectorRasterizationOptions**.
1. Извикайте **Image.save**, като подадете обект от класа **PdfOptions** като втори параметър.

Долната примерна програма показва как да конвертирате файл, използвайки настройките по подразбиране.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXF-to-PDF-Export.py" >}}

### **Поддържани формати**

За момента напълно поддържаме AutoCAD DXF 2010 файлови формати. Предишните версии на DXF не се гарантира, че са 100% валидни. Планираме да включим още формати и функции в бъдещите версии на Aspose.CAD.

### **Поддържани Елементи**

За момента поддържаме всички разпространени 2D елементи и техните основни стойности по подразбиране, както следва:

1. Подравнени размери
1. Ъглови размери
1. Дъга
1. Атрибут
1. Блокова референция
1. Окръжност
1. Диаметърни размери
1. Елипса
1. Шарка
1. Линия
1. Многоредов текст
1. Ординатни размери
1. Точка
1. Полилиния
1. Радиални размери
1. Лъч
1. Завъртяни размери
1. Таблица
1. Текст
1. Хелис

{{% alert color="primary" %}}
  
При парсиране, ако срещнем някой елемент или свойство, което не поддържаме, елементът или свойството ще бъдат безразлично игнорирани.
{{% /alert %}}

## **Изнасяне на вградени DGN подложки за DXF формат**

Aspose.CAD предоставя възможността за зареждане на AutoCAD DXF файлове и изнасяне на вградени DGN подложки за формат DXF.

Долната примерна програма показва как да постигнете посочените изисквания.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ExportEmbeddedDGN.py" >}}

## **Поддръжка за Запазване на DXF Файлове**

Aspose.CAD предоставя възможността за зареждане на AutoCAD DXF файлове, направа на промени в тях и запазването им отново като DXF файл.

Долната примерна програма показва как да постигнете посочените изисквания.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-Drawings-SaveDXFFiles.py" >}}

## **Изнасяне на DXF към WMF**

Този подход работи по следния начин:

1. Заредете DXF изчертания файл, използвайки **Image.load** фабричния метод.
1. Създайте обект от класа **CadRasterizationOptions** и заредете файла в PDF формат.
1. Задайте свойствата **page_height** и **page_width**.
1. Извикайте **Image.save** и запазете файла.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-to-WMF-Export.py" >}}
