---
title: DWF креслення
type: docs
weight: 20
url: /uk/net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **Експорт DWF креслень у PDF**

Aspose.CAD надає функцію завантаження сутностей креслень AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) та відображення їх як єдиного креслення у формат [PDF](https://docs.fileformat.com/pdf/). Підхід до конвертації з [DWF](https://docs.fileformat.com/cad/dwf/) в [PDF](https://docs.fileformat.com/pdf/) працює наступним чином:

1. Завантажте файл [DWF](https://docs.fileformat.com/cad/dwf/) креслення за допомогою методу заводської функції [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Створіть об'єкт класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) та встановіть властивості [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) та [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Створіть об'єкт класу [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) та встановіть властивість [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Викликайте [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), передаючи об'єкт класу [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) як другий параметр.

### Приклад коду

Приклад коду нижче показує, як конвертувати файл за допомогою налаштувань за замовчуванням.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **Витягування шарів з креслення DWF**

Aspose.CAD надає функцію завантаження сутностей креслень AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) та відображення їх як єдиного креслення у формат [JPEG](https://docs.fileformat.com/image/jpeg/).

1. Завантажте файл [DWF](https://docs.fileformat.com/cad/dwf/) креслення за допомогою методу заводської функції [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Створіть об'єкт класу [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions).
1. Створіть об'єкт класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Витягніть назви шарів за допомогою об'єкта [JPEG](https://docs.fileformat.com/image/jpeg/).
1. Викликайте [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), передаючи об'єкт класу [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) як другий параметр.

### Приклад коду

Приклад коду нижче показує, як конвертувати файл за допомогою налаштувань за замовчуванням.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **Підтримка шарів у DWF**

Aspose.CAD надає функцію завантаження сутностей креслень AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) та відображення їх як єдиного креслення у формат [JPEG](https://docs.fileformat.com/image/jpeg/).

1. Завантажте файл [DWF](https://docs.fileformat.com/cad/dwf/) креслення за допомогою методу заводської функції [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Створіть об'єкт класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Додайте бажані шари.
1. Викликайте [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), передаючи об'єкт класу [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) як другий параметр.

### Приклад коду

Приклад коду нижче показує, як конвертувати файл за допомогою налаштувань за замовчуванням.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWF-Drawings-SupportOfLayers-SupportOfLayers.cs" >}}

## **Експорт DWF креслень у BMP**

Aspose.CAD надає функцію завантаження сутностей креслень AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) та відображення їх як єдиного креслення у формат [BMP](https://docs.fileformat.com/image/bmp/). Підхід до конвертації з [DWF](https://docs.fileformat.com/cad/dwf/) в [BMP](https://docs.fileformat.com/image/bmp/) працює наступним чином:

1. Завантажте файл [DWF](https://docs.fileformat.com/cad/dwf/) креслення за допомогою методу заводської функції [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Створіть об'єкт класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) та встановіть властивості [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) та [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Створіть об'єкт класу [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) та встановіть властивість [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Викликайте [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), передаючи об'єкт класу [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) як другий параметр.

### Приклад коду

Приклад коду нижче показує, як конвертувати файл [DWF](https://docs.fileformat.com/cad/dwf/) в [BMP](https://docs.fileformat.com/image/bmp/) за допомогою налаштувань за замовчуванням.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}
