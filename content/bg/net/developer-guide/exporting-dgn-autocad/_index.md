---
title: Експортиране на DGN AutoCAD
type: docs
weight: 50
url: /bg/net/developer-guide/exporting-dgn-autocad/
---

## **Експортиране на DGN формат AutoCAD в PDF**

Aspose.CAD за .NET API въведе функцията за зареждане на DGN AutoCAD файл и конвертиране в PDF формат. [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) класът служи за тази цел.

Необходимо е да заредите съществуващ DGN файл като [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage). Създайте инстанция на класа [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) и задайте различни свойства. Създайте инстанция на класа [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) и предайте инстанцията на [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions). Сега извикайте метода [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) на инстанцията на класа [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage).

### Примерен Код

Следва демонстрация на кода за конвертиране/експортиране на [DGN](https://docs.fileformat.com/cad/dgn/) в [PDF](https://docs.fileformat.com/pdf/) формат.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **Експортиране на DGN формат AutoCAD в растерно изображение**

Aspose.CAD за .NET API въведе функцията за зареждане на DGN AutoCAD файл и конвертиране в растерно изображение. [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) класът служи за тази цел.

Необходимо е да заредите съществуващ DGN файл като [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage). Създайте инстанция на класа [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) и задайте различни свойства. Създайте инстанция на класа [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) и предайте инстанцията на [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions). Сега извикайте метода [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) на инстанцията на класа [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage).

### Примерен Код

Следва демонстрация на кода за конвертиране/експортиране на [DGN](https://docs.fileformat.com/cad/dgn/) в [JPEG](https://docs.fileformat.com/image/jpeg/) изображение.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-ExportDGNToRasterImage-ExportDGNToRasterImage.cs" >}}

## **Подкрепа за 3D елементи за DGN v7**

Aspose.CAD за .NET API въведе функцията за зареждане на [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD файл и поддръжка на 3D елементи за DGN v7. [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) класът служи за тази цел. Всеки [DGN](https://docs.fileformat.com/cad/dgn/) изображение поддържа 9 предварително определени изгледа. Те са номерирани от 1 до 9. Ако изгледът не е дефиниран при експортиране, за формати с множество страници (като PDF) всички изгледи ще бъдат експортирани, всеки на отделна страница. 3D елементи се поддържат във DGN файлов формат, както и 2D. За това се използва [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions), TypeOfEntities вече не се използва за DGN формат (и 2D и 3D се поддържат едновременно).

### Примерен Код

Следва примерен код за разглеждане на поддържаните DGN елементи.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-SupportOf3DForDGNV7-3DSupportForDGNV7.cs" >}}
