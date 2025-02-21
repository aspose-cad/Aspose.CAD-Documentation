---
title: Експорт формату DGN AutoCAD
type: docs
weight: 50
url: /uk/java/developer-guide/exporting-dgn-autocad/
---

## **Експорт формату DGN AutoCAD у PDF**

Aspose.CAD для Java API ввів функціональність для завантаження файлу [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD та конвертації його у формат [PDF](https://docs.fileformat.com/pdf/). Клас [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) виконує цю мету.

Вам потрібно завантажити існуючий файл DGN як [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage). Створіть екземпляр класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) і задайте різні властивості. Створіть екземпляр класу [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/pdfoptions) і передайте екземпляр [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). Тепер викличте метод [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) екземпляра класу [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage).

### Приклад коду

Наступний код демонструє, як конвертувати/експортувати DGN у формат PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToPDF-ExportingDGNAutoCADFormatToPDF.java" >}}

## **Експорт формату DGN AutoCAD у растровий формат зображення**

Aspose.CAD для Java API ввів функціональність для завантаження файлу [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD та конвертації його в растрове зображення. Клас [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage) виконує цю мету.

Вам потрібно завантажити існуючий файл DGN як [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage). Створіть екземпляр класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) і задайте різні властивості. Створіть екземпляр класу [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) і передайте екземпляр [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions). Тепер викличте метод [**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) екземпляра класу [**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage).

### Приклад коду

Наступний код демонструє, як конвертувати/експортувати [DGN](https://docs.fileformat.com/cad/dgn/) у зображення [JPEG](https://docs.fileformat.com/image/jpeg/).

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToRasterImageFormat-ExportingDGNAutoCADFormatToRasterImageFormat.java" >}}
