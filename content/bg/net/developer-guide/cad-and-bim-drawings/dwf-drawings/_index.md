---
title: Рисунки DWF
type: docs
weight: 20
url: /bg/net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **Експортиране на рисунки DWF към PDF**

Aspose.CAD предоставя функционалност за зареждане на съществата на AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) и изобразяването им като цяло изображение във формат [PDF](https://docs.fileformat.com/pdf/). Подходът за конвертиране от [DWF](https://docs.fileformat.com/cad/dwf/) в [PDF](https://docs.fileformat.com/pdf/) работи по следния начин:

1. Заредете файл с рисунка във формат [DWF](https://docs.fileformat.com/cad/dwf/) чрез фабричния метод [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Създайте обект от класа [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) и задайте свойствата [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) и [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Създайте обект от класа [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) и задайте свойството [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Извикайте [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), като предадете обект от класа [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) като втори параметър.

### Примерен код

Примерният код по-долу показва как да конвертирате файл с настройки по подразбиране.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **Извличане на слоеве от рисунка DWF**

Aspose.CAD предоставя функционалност за зареждане на съществата на AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) и изобразяването им като цяло изображение във формат [JPEG](https://docs.fileformat.com/image/jpeg/).

1. Заредете файл с рисунка във формат [DWF](https://docs.fileformat.com/cad/dwf/) чрез фабричния метод [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Създайте обект от класа [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions).
1. Създайте обект от класа [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Извлечете имената на слоевете с помощта на обекта [JPEG](https://docs.fileformat.com/image/jpeg/).
1. Извикайте [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), като предадете обект от класа [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) като втори параметър.

### Примерен код

Примерният код по-долу показва как да конвертирате файл с настройки по подразбиране.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **Поддръжка на слоевете в рисунка DWF**

Aspose.CAD предоставя функционалност за зареждане на съществата на AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) и изобразяването им като цяло изображение във формат [JPEG](https://docs.fileformat.com/image/jpeg/).

1. Заредете файл с рисунка във формат [DWF](https://docs.fileformat.com/cad/dwf/) чрез фабричния метод [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Създайте обект от класа [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Добавете желаните слоеве.
1. Извикайте [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), като предадете обект от класа [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) като втори параметър.

### Примерен код

Примерният код по-долу показва как да конвертирате файл с настройки по подразбиране.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWF-Drawings-SupportOfLayers-SupportOfLayers.cs" >}}

## **Експортиране на рисунки DWF към BMP**

Aspose.CAD предоставя функционалност за зареждане на съществата на AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) и изобразяването им като цяло изображение във формат [BMP](https://docs.fileformat.com/image/bmp/). Подходът за конвертиране от [DWF](https://docs.fileformat.com/cad/dwf/) в [BMP](https://docs.fileformat.com/image/bmp/) работи по следния начин:

1. Заредете файл с рисунка във формат [DWF](https://docs.fileformat.com/cad/dwf/) чрез фабричния метод [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Създайте обект от класа [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) и задайте свойствата [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) и [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Създайте обект от класа [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) и задайте свойството [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Извикайте [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index), като предадете обект от класа [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) като втори параметър.

### Примерен код

Примерният код по-долу показва как да конвертирате файл с настройки по подразбиране от [DWF](https://docs.fileformat.com/cad/dwf/) към [BMP](https://docs.fileformat.com/image/bmp/).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}
