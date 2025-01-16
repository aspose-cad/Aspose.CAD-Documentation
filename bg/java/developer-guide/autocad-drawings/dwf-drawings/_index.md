---
title: Илюстрации DWF
type: документация
weight: 20
url: /bg/java/dwf-drawings/
---

## **Експортиране на илюстрации DWF към PDF**

Aspose.CAD за Java API може да зареди илюстрации на AutoCAD във формат DWF и да ги преобразува в PDF. Тази тема обяснява използването на Aspose.CAD API за постигане на конверсията на DWF към формат PDF чрез определени стъпки, както е посочено по-долу.

### **Конвертиране на DWF файлове в PDF**

За конвертирането на DWF в PDF са необходими следните прости стъпки.

1. Заредете DWF файла в екземпляр на [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Създайте обект на класа [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) и задайте свойствата [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) и [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Създайте обект на класа [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) и задайте свойството [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Извикайте [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) като подадете обект от [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) като втори параметър.

По-долу е показан образец код, който показва как да се експортира илюстрация DWF в PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToPDF-ExportToPDF.java" >}}

### **Поддръжка на слоеве в DWF**

Aspose.CAD предоставя възможността за зареждане на същностите на AutoCAD DWF илюстрации и да ги визуализира като цяло изображение в JPG формат.

1. Заредете DWF файл за илюстрация чрез фабричния метод [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Създайте обект на класа [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Добавете желаните слоеве.
1. Извикайте [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) като подадете обект от [**JPEGOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) като втори параметър.

По-долу е показан образец код, който показва как да се конвертира файл по подразбиране.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWFDrawings-SupportOfLayers-SupportOfLayers.java" >}}
