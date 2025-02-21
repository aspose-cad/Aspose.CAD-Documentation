---
title: DWF малюнки
type: docs
weight: 20
url: /uk/java/developer-guide/autocad-drawings/dwf-drawings/
---

## **Експорт DWF малюнків у PDF**

Aspose.CAD для Java API може завантажувати малюнки AutoCAD у форматі DWF та перетворювати їх у PDF. Ця тема пояснює використання Aspose.CAD API для досягнення перетворення DWF у формат PDF через прості кроки, визначені далі.

### **Перетворення DWF файлів у PDF**

Для перетворення DWF у PDF необхідні наступні прості кроки.

1. Завантажте файл DWF у екземпляр [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Створіть об'єкт класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) і встановіть властивості [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) та [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Створіть об'єкт класу [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) і встановіть властивість [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Викликайте [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) передаючи об'єкт [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) як другий параметр.

Приклад коду нижче показує, як експортувати DWF малюнки у PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToPDF-ExportToPDF.java" >}}

### **Підтримка шарів у DWF**

Aspose.CAD надає функцію завантаження малюнків AutoCAD DWF і відображення їх як цілого малюнка у формат JPG.

1. Завантажте файл малюнка DWF за допомогою [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) фабричного методу.
1. Створіть об'єкт класу [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Додайте бажані шари.
1. Викликайте [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) передаючи об'єкт [**JPEGOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) як другий параметр.

Приклад коду нижче показує, як перетворити файл за допомогою налаштувань за замовчуванням.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWFDrawings-SupportOfLayers-SupportOfLayers.java" >}}
