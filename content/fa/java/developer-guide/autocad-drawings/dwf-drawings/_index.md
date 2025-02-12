---
title: نقشه‌های DWF
type: docs
weight: 20
url: /fa/java/dwf-drawings/
---

## **صادر کردن نقشه‌های DWF به PDF**

Aspose.CAD برای Java API می‌تواند نقشه‌های AutoCAD را با فرمت DWF بارگذاری کرده و آن را به PDF تبدیل کند. این موضوع استفاده از API Aspose.CAD را برای دستیابی به تبدیل DWF به فرمت PDF از طریق مراحل ساده‌ای که در ادامه تعریف شده است توضیح می‌دهد.

### **تبدیل فایل‌های DWF به PDF**

مراحل ساده زیر برای تبدیل DWF به PDF لازم است.

1. فایل DWF را به یک نمونه از [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image) بارگذاری کنید.
1. یک شی از کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) ایجاد کرده و خواص [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) و [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) را تنظیم کنید.
1. یک شی از کلاس [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) ایجاد کرده و خواص [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) را تنظیم کنید.
1. در حین پاس دادن یک شی از [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) به عنوان پارامتر دوم، [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) را فراخوانی کنید.

نمونه کد زیر نشان می‌دهد که چگونه نقشه‌های DWF را به PDF صادر کنید.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToPDF-ExportToPDF.java" >}}

### **پشتیبانی از لایه‌ها در DWF**

Aspose.CAD قابلیت بارگذاری موجودیت‌های نقشه‌کشی DWF AutoCAD و رندر کردن آن‌ها به عنوان یک نقشه کامل در فرمت JPG را فراهم می‌کند.

1. فایل نقشه DWF را با استفاده از روش کارخانه [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) بارگذاری کنید.
1. یک شی از کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) ایجاد کنید.
1. لایه‌های مورد نظر را اضافه کنید.
1. در حین پاس دادن یک شی از [**JPEGOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) به عنوان پارامتر دوم، [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) را فراخوانی کنید.

نمونه کد زیر نشان می‌دهد که چگونه یک فایل را با استفاده از تنظیمات پیش‌فرض تبدیل کنید.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWFDrawings-SupportOfLayers-SupportOfLayers.java" >}}
