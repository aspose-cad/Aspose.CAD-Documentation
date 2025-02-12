---
title: نقشه‌های DXF
type: docs
weight: 60
url: /fa/java/developer-guide/autocad-drawings/dxf-drawings/
---

## **صادرات نقشه‌های DXF به PDF**

Aspose.CAD قابلیت بارگذاری موجودیت‌های نقشه DXF اتوکد و رندر کردن آن‌ها به عنوان یک نقشه کامل در فرمت PDF را فراهم می‌کند. راه‌کار تبدیل DXF به PDF به شرح زیر عمل می‌کند:

1. فایل نقشه DXF را با استفاده از روش کارخانه [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) بارگذاری کنید.
1. شیئی از کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) ایجاد کنید و ویژگی‌های [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) و [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) را تنظیم کنید.
1. شیئی از کلاس [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) ایجاد کنید و ویژگی [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) را تنظیم کنید.
1. متد Image.Save را با ارسال شیئی از [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) به عنوان پارامتر دوم برای ذخیره فایل فراخوانی کنید.

نمونه کد زیر نشان می‌دهد که چگونه یک فایل را با تنظیمات پیش‌فرض تبدیل کنید.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFDrawingToPDF-.java" >}}

### **فرمت‌های پشتیبانی شده**

در حال حاضر ما به طور کامل از فرمت‌های فایل DXF اتوکد ۲۰۱۰ پشتیبانی می‌کنیم. نسخه‌های قبلی DXF تضمین نمی‌شوند که ۱۰۰٪ معتبر باشند. ما برنامه داریم تا فرمت‌ها و ویژگی‌های بیشتری را در نسخه‌های آینده Aspose.CAD اضافه کنیم.

### **موجودیت‌های پشتیبانی شده**

در حال حاضر ما از تمام موجودیت‌های ۲ بعدی رایج و پارامترهای پیش‌فرض اصلی آن‌ها به شرح زیر پشتیبانی می‌کنیم:

1. ابعاد هم‌راستا
1. ابعاد زاویه‌ای
1. قوس
1. ویژگی
1. مرجع بلوک
1. دایره
1. ابعاد قطر
1. بیضی
1. الگو
1. خط
1. متن چند خطی
1. ابعاد مدول
1. نقطه
1. چندخطی
1. ابعاد شعاعی
1. شعاع
1. ابعاد چرخشی
1. جدول
1. متن
1. Xline

{{% alert color="primary" %}}

اگر در حین تجزیه با موجودیت یا ویژگی‌ای مواجه شویم که از آن پشتیبانی نمی‌کنیم، آن موجودیت یا ویژگی بدون هیچ گونه هشدار خاموش نادیده گرفته می‌شود.

{{% /alert %}}

### **مدیریت حافظه**

ویژگی [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) می‌تواند برای کنترل تخصیص مجدد حافظه استفاده شود. تخصیص مجدد احتمالاً برای حافظه‌های از پیش تخصیص داده شده اتفاق می‌افتد. این امر ممکن است زمانی اتفاق بیفتد که سیستم متوجه شود فضای تخصیص داده شده کافی نخواهد بود.

- اگر [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) بر روی مقدار پیش‌فرض یعنی **False** تنظیم شود، فضا به همان منبع مجدد تخصیص داده می‌شود.
- زمانی که بر روی **True** تنظیم شود، تخصیص مجدد نمی‌تواند از فضای حداکثر تعیین‌شده تجاوز کند. در این صورت، حافظه فعلی که نیاز به تخصیص مجدد دارد آزاد شده و فضای جدیدی بر روی دیسک تخصیص داده می‌شود.

## **صادرات لایه خاصی از نقشه‌های DXF به PDF**

این رویکرد به شرح زیر عمل می‌کند:

1. فایل نقشه DXF را با استفاده از روش کارخانه [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) باز کنید.
1. یک نمونه از [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) ایجاد کنید و ویژگی‌های [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) و [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) را مشخص کنید.
1. لایه‌ها را به شیئی از [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) اضافه کنید.
1. یک نمونه از [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) ایجاد کرده و ویژگی [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) را تنظیم کنید.
1. نقشه را با استفاده از متد [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) به PDF صادر کنید.

نمونه کد زیر نشان می‌دهد که چگونه یک لایه خاص از DXF را به PDF تبدیل کنید.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificLayerOfDXFDrawingToPDF-.java" >}}

## **صادرات لایه خاصی از نقشه‌های DXF به تصویر**

این روش به شرح زیر عمل می‌کند:

1. فایل نقشه DXF را با استفاده از روش کارخانه [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) باز کنید.
1. یک نمونه از [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) ایجاد کنید و ویژگی‌های [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) و [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) را مشخص کنید.
1. لایه‌ها را به شیئی از [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) اضافه کنید.
1. یک نمونه از [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) ایجاد کرده و ویژگی [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) را تنظیم کنید.
1. نقشه را با استفاده از متد [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) به تصویر صادر کنید.

نمونه کد زیر نشان می‌دهد که چگونه یک لایه خاص از DXF را به تصویر تبدیل کنید.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.java" >}}

## **رندر فایل‌های PDF به عنوان بخشی از نقشه‌های DXF**

این روش به شرح زیر عمل می‌کند:

1. فایل نقشه DXF را با استفاده از روش کارخانه [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) بارگذاری کنید.
1. شیئی از کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) ایجاد کرده و فایل‌های PDF را بارگذاری کنید.
1. ویژگی‌های [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) و [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) را تنظیم کنید.
1. متد [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) را فراخوانی کرده و فایل را ذخیره کنید.

نمونه کد زیر نشان می‌دهد که چگونه فایل‌های PDF را به عنوان بخشی از نقشه‌های DXF رندر کنید.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-RenderDXFAsPDF-RenderDXFAsPDF.java" >}}

## **صادرات DXF به WMF**

این رویکرد به شرح زیر عمل می‌کند:

1. فایل نقشه DXF را با استفاده از روش کارخانه [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) بارگذاری کنید.
1. شیئی از کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) ایجاد کرده و فایل‌های PDF را بارگذاری کنید.
1. ویژگی‌های [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) و [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) را تنظیم کنید.
1. متد [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) را فراخوانی کرده و فایل را ذخیره کنید.

نمونه کد زیر نشان می‌دهد که چگونه DXF را به WMF صادر کنید.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFToWMF-ExportDXFToWMF.java" >}}

## **پشتیبانی از ذخیره فایل‌های DXF**

Aspose.CAD قابلیت بارگذاری فایل‌های DXF اتوکد، انجام تغییرات در آن و ذخیره مجدد آن به عنوان یک فایل DXF را فراهم می‌کند. نمونه کد زیر نشان می‌دهد که چگونه الزامات مشخص شده را به دست آورید.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SaveDXFFiles-SaveDXFFiles.java" >}}

## **صادرات DGN زیرلایه جاسازی‌شده برای فرمت DXF**

Aspose.CAD قابلیت بارگذاری فایل‌های DXF اتوکد و صادرات DGN زیرلایه جاسازی‌شده برای فرمت DXF را فراهم می‌کند.

نمونه کد زیر نشان می‌دهد که چگونه الزامات مشخص شده را به دست آورید.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportEmbeddedDGN-ExportEmbeddedDGN.java" >}}

## **صادرات طرح خاص DXF به PDF**

این رویکرد به شرح زیر عمل می‌کند:

1. فایل نقشه DXF را با استفاده از روش کارخانه [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) باز کنید.
1. یک نمونه از [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) ایجاد کنید و ویژگی‌های [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) و [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) را مشخص کنید.
1. نام(های) طرح مورد نظر را با استفاده از ویژگی [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) مشخص کنید.
1. یک نمونه از [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) ایجاد کنید و ویژگی [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) را تنظیم کنید.
1. نقشه را با استفاده از متد [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) به PDF صادر کنید.

نمونه کد زیر نشان می‌دهد که چگونه یک طرح خاص از DXF را به PDF تبدیل کنید.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToPDF-.java" >}}

{{% alert color="primary" %}}

ویژگی [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) از نوع آرایه رشته‌ای است بنابراین شما می‌توانید بیش از یک طرح را به طور همزمان برای تبدیل به فرمت PDF مشخص کنید. هنگام مشخص کردن چندین طرح برای ویژگی [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) ، PDF حاصل دارای چندین صفحه خواهد بود که هر صفحه نمایانگر یک طرح اتوکد جداگانه است.

{{% /alert %}}

## **دسترسی به اشیاء ATTRIB و MTEXT**

این رویکرد به شرح زیر عمل می‌کند:

1. فایل نقشه DXF را با استفاده از روش کارخانه [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) باز کنید.
1. به موجودیت‌های داخل فایل CAD دسترسی پیدا کنید.
1. بر روی اشیاء [**CadEntityTypeName.MTEXT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#MTEXT) و [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT) چک کنید.
1. برای پردازش بیشتر به لیست موقت اضافه کنید.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-AddAttribMText-AddAttribMText.java" >}}

## **تجزیه اشیاء درج CAD**

این روش به شرح زیر عمل می‌کند:

1. فایل **DXF** را با استفاده از روش کارخانه [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) باز کنید.
1. به موجودیت‌های داخل فایل CAD دسترسی پیدا کنید.
1. به اشیاء [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT) چک کنید.
1. به لیست نوع [**CadBlockEntity**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity) چک کنید.
1. موجودیت‌ها را پردازش کنید.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-DecomposeCadInsertObject-DecomposeCadInsertObject.java" >}}

## **پشتیبانی از برش بلوک**

Aspose.CAD قابلیت برش بلوک را فراهم می‌کند. رویکرد برش بلوک به شرح زیر عمل می‌کند:

1. فایل نقشه DXF را با استفاده از روش کارخانه [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) بارگذاری کنید.
1. شیئی از کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) ایجاد کرده و فایل‌های PDF را بارگذاری کنید.
1. ویژگی‌های مورد نظر [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) را تنظیم کنید.
1. متد [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) را فراخوانی کنید و شیئی از [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) را به عنوان پارامتر دوم ارسال کنید و فایل را ذخیره کنید.

نمونه کد زیر نشان می‌دهد که چگونه برش بلوک عمل می‌کند.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SupportOfBlockClipping-SupportOfBlockClipping.java" >}}

## **صادرات تصاویر به DXF**

با استفاده از Aspose.CAD، می‌توانید تصاویر را به فرمت DXF صادر کنید. با استفاده از این رویکرد، می‌توانید اقدامات زیر را انجام دهید:

1. تنظیم فونت جدید
1. پنهان کردن موجودیت‌ها
1. به‌روزرسانی متن

نمونه کد زیر نشان می‌دهد که چگونه اقدامات ذکر شده را انجام دهید.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-ExportImagesToDXF.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-GetFileExtension.java" >}}
