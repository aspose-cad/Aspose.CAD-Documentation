---
title: Экспорт чертежей DWF в PDF
type: docs
weight: 20
url: /ru/java/developer-guide/autocad-drawings/dwf-drawings/
---

## **Экспорт чертежей DWF в PDF**

Aspose.CAD для Java API может загружать чертежи AutoCAD в формате DWF и конвертировать их в PDF. Эта тема объясняет использование API Aspose.CAD для достижения преобразования DWF в формат PDF с помощью простых шагов, определенных ниже.

### **Преобразование файлов DWF в PDF**

Для преобразования DWF в PDF необходимы следующие простые шаги.

1. Загрузите файл DWF в экземпляр [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Создайте объект класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) и установите свойства [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) и [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Создайте объект класса [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) и установите свойство [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Вызовите [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) и передайте объект [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) в качестве второго параметра.

Пример кода ниже показывает, как экспортировать чертежи DWF в PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToPDF-ExportToPDF.java" >}}

### **Поддержка слоев в DWF**

Aspose.CAD обеспечивает возможность загружать сущности чертежей AutoCAD DWF и отображать их как целый чертеж в формате JPG.

1. Загрузите файл чертежа DWF, используя метод [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) фабрики.
1. Создайте объект класса [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Добавьте необходимые слои.
1. Вызовите [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) и передайте объект [**JPEGOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) в качестве второго параметра.

Пример кода ниже показывает, как преобразовать файл с использованием настроек по умолчанию.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWFDrawings-SupportOfLayers-SupportOfLayers.java" >}}
