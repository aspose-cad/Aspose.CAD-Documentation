---
title: Экспорт формата DGN AutoCAD
type: docs
weight: 50
url: /ru/java/developer-guide/exporting-dgn-autocad/
---

## **Экспорт формата DGN AutoCAD в PDF**

Aspose.CAD для Java API представил функциональность загрузки файла [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD и конвертации его в формат [PDF](https://docs.fileformat.com/pdf/). Класс [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) служит этой цели.

Вам нужно загрузить существующий файл DGN как [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage). Создайте экземпляр класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) и установите различные свойства. Создайте экземпляр класса [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/pdfoptions) и передайте экземпляр [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). Теперь вызовите метод [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) экземпляра класса [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage).

### Пример кода

Следующий код демонстрирует конвертацию/экспорт DGN в формат PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToPDF-ExportingDGNAutoCADFormatToPDF.java" >}}

## **Экспорт формата DGN AutoCAD в растровый формат изображения**

Aspose.CAD для Java API представил функциональность загрузки файла [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD и конвертации его в растровое изображение. Класс [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) служит этой цели.

Вам нужно загрузить существующий файл DGN как [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage). Создайте экземпляр класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) и установите различные свойства. Создайте экземпляр класса [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) и передайте экземпляр [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). Теперь вызовите метод [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) экземпляра класса [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage).

### Пример кода

Следующий код демонстрирует конвертацию/экспорт [DGN](https://docs.fileformat.com/cad/dgn/) в изображение [JPEG](https://docs.fileformat.com/image/jpeg/).

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToRasterImageFormat-ExportingDGNAutoCADFormatToRasterImageFormat.java" >}}
