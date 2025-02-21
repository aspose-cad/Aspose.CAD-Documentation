---
title: DWF Чертежи
type: docs
weight: 20
url: /ru/net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **Экспорт DWF чертежей в PDF**

Aspose.CAD предоставляет возможность загружать объекты чертежей AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) и выводить их в формате [PDF](https://docs.fileformat.com/pdf/). Подход к конверсии [DWF](https://docs.fileformat.com/cad/dwf/) в [PDF](https://docs.fileformat.com/pdf/) работает следующим образом:

1. Загрузите файл чертежа [DWF](https://docs.fileformat.com/cad/dwf/) с помощью фабричного метода [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Создайте объект класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) и установите свойства [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) и [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Создайте объект класса [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) и установите свойство [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Вызовите [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), передав объект [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) в качестве второго параметра.

### Пример кода

Пример кода ниже демонстрирует, как конвертировать файл с использованием настроек по умолчанию.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **Извлечение слоев из DWF чертежа**

Aspose.CAD предоставляет возможность загружать объекты чертежей AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) и выводить их в формате [JPEG](https://docs.fileformat.com/image/jpeg/).

1. Загрузите файл чертежа [DWF](https://docs.fileformat.com/cad/dwf/) с помощью фабричного метода [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Создайте объект класса [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions).
1. Создайте объект класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Извлеките имена слоев с помощью объекта [JPEG](https://docs.fileformat.com/image/jpeg/).
1. Вызовите [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), передав объект [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) в качестве второго параметра.

### Пример кода

Пример кода ниже демонстрирует, как конвертировать файл с использованием настроек по умолчанию.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **Поддержка слоев в DWF**

Aspose.CAD предоставляет возможность загружать объекты чертежей AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) и выводить их в формате [JPEG](https://docs.fileformat.com/image/jpeg/).

1. Загрузите файл чертежа [DWF](https://docs.fileformat.com/cad/dwf/) с помощью фабричного метода [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Создайте объект класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Добавьте необходимые слои.
1. Вызовите [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), передав объект [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) в качестве второго параметра.

### Пример кода

Пример кода ниже демонстрирует, как конвертировать файл с использованием настроек по умолчанию.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWF-Drawings-SupportOfLayers-SupportOfLayers.cs" >}}

## **Экспорт DWF чертежей в BMP**

Aspose.CAD предоставляет возможность загружать объекты чертежей AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) и выводить их в формате [BMP](https://docs.fileformat.com/image/bmp/). Подход к конверсии [DWF](https://docs.fileformat.com/cad/dwf/) в [BMP](https://docs.fileformat.com/image/bmp/) работает следующим образом:

1. Загрузите файл чертежа [DWF](https://docs.fileformat.com/cad/dwf/) с помощью фабричного метода [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Создайте объект класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) и установите свойства [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) и [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Создайте объект класса [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) и установите свойство [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Вызовите [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), передав объект [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) в качестве второго параметра.

### Пример кода

Пример кода ниже демонстрирует, как конвертировать файл [DWF](https://docs.fileformat.com/cad/dwf/) в [BMP](https://docs.fileformat.com/image/bmp/) с использованием настроек по умолчанию.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}
