---
title: Експорт на DGN AutoCAD
type: docs
weight: 50
url: /bg/java/exporting-dgn-autocad/
---

## **Експорт на DGN AutoCAD формат в PDF**

Aspose.CAD за Java API е въвел функционалността да зарежда [DGN](https://docs.fileformat.com/cad/dgn/) файл AutoCAD и да го конвертира в [PDF](https://docs.fileformat.com/pdf/) формат. Класът [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) служи за тази цел.

Трябва да заредите съществуващ DGN файл като [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage). Създайте инстанция на класа [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) и задайте различни свойства. Създайте инстанция на класа [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/pdfoptions) и предайте инстанцията на [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). Сега извикайте метода [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) на инстанцията на класа [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage).

### Примерен код

Следва демонстрацията на кода за конвертиране/експортиране на DGN в PDF формат.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToPDF-ExportingDGNAutoCADFormatToPDF.java" >}}

## **Експорт на DGN AutoCAD формат в растерен формат на изображение**

Aspose.CAD за Java API е въвел функционалността да зарежда [DGN](https://docs.fileformat.com/cad/dgn/) файл AutoCAD и да го конвертира в растерно изображение. Класът [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) служи за тази цел.

Трябва да заредите съществуващ DGN файл като [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage). Създайте инстанция на класа [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) и задайте различни свойства. Създайте инстанция на класа [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) и предайте инстанцията на [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). Сега извикайте метода [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) на инстанцията на класа [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage).

### Примерен код

Следва демонстрацията на кода за конвертиране/експортиране на [DGN](https://docs.fileformat.com/cad/dgn/) в [JPEG](https://docs.fileformat.com/image/jpeg/) изображение.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToRasterImageFormat-ExportingDGNAutoCADFormatToRasterImageFormat.java" >}}
