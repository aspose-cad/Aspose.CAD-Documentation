---
title: نقشه‌های DXF
type: docs
weight: 60
url: /fa/net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **صادرات نقشه‌های DXF به PDF**

Aspose.CAD این امکان را فراهم می‌آورد که موجودیت‌های نقشه DXF اتوکد را بارگذاری کرده و آنها را به صورت یک نقشه کامل به فرمت PDF رندر کند. روش تبدیل DXF به PDF به صورت زیر عمل می‌کند:

1. بارگذاری فایل نقشه DXF با استفاده از متد کارخانه [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. ایجاد یک شی از کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) و تنظیم خواص [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) و [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. ایجاد یک شی از کلاس [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) و تنظیم خواص [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. فراخوانی [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) و ارسال یک شی از [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) به عنوان پارامتر دوم.

نمونه کد زیر نشان می‌دهد که چگونه می‌توان یک فایل را با استفاده از تنظیمات پیش‌فرض تبدیل کرد.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFToPDF-ExportDXFToPDF.cs" >}}

### **فرمت‌های پشتیبانی‌شده**

در حال حاضر ما به طور کامل از فرمت‌های فایل DXF اتوکد 2010 پشتیبانی می‌کنیم. نسخه‌های قبلی DXF تضمین نمی‌شوند که 100% معتبر باشند. ما برنامه‌ریزی می‌کنیم که در نسخه‌های آینده Aspose.CAD فرمت‌ها و ویژگی‌های بیشتری را شامل شویم.

### **موجودیت‌های پشتیبانی‌شده**

در حال حاضر ما از تمامی موجودیت‌های 2D رایج و پارامترهای پیش‌فرض پایه آنها به شرح زیر پشتیبانی می‌کنیم:

1. ابعاد هم‌راستا
1. ابعاد زاویه‌ای
1. قوس
1. ویژگی
1. مرجع بلوک
1. دایره
1. ابعاد قطر
1. بیضی
1. الگوی هاش
1. خط
1. متن چندخطی
1. ابعاد مختصات
1. نقطه
1. چندخط
1. ابعاد شعاعی
1. پرتو
1. ابعاد چرخشی
1. جدول
1. متن
1. خط X

{{% alert color="primary" %}}

اگر در حین تجزیه با موجودیت یا خواصی مواجه شویم که پشتیبانی نمی‌شود، موجودیت یا ویژگی مورد نظر به طور خاموش نادیده گرفته خواهد شد.

{{% /alert %}}

### **مدیریت حافظه**

خواص [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) از کلاس [**Cache**](https://reference.aspose.com/cad/net/aspose.cad/cache) می‌تواند برای کنترل مجدداً تخصیص حافظه استفاده شود. این بارگذاری مجدد بیشتر برای کش‌های از پیش تخصیص‌یافته احتمال وقوع دارد. این می‌تواند زمانی اتفاق بیفتد که سیستم متوجه شود فضایی که تخصیص داده شده کافی نخواهد بود.

- اگر [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) به مقدار پیش‌فرض، **False**، تنظیم شود، فضا به همان رسانه دوباره تخصیص داده می‌شود.
- وقتی در وضعیت **True** تنظیم شده باشد، مجدداً تخصیص نمی‌تواند از حداکثر فضای مشخص‌شده فراتر رود. در این مورد، کش موجود در حافظه (که نیاز به مجدداً تخصیص دارد) آزاد شده و فضای جدیدی روی دیسک تخصیص داده می‌شود.

## **صادرات لایه خاص نقشه‌های DXF به PDF**

این روش به صورت زیر عمل می‌کند:

1. باز کردن فایل نقشه DXF با استفاده از متد کارخانه [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. ایجاد یک نمونه از [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) و مشخص کردن خواص [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) و [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. افزودن لایه‌ها به شی [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. ایجاد یک نمونه از [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) و تنظیم خواص [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. فراخوانی متد [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) و ارسال شی [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) به عنوان پارامتر دوم.

نمونه کد زیر نشان می‌دهد که چگونه می‌توان یک لایه خاص از DXF را به PDF تبدیل کرد.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayerToPDF-ExportDXFSpecificLayerToPDF.cs" >}}

## **رندر فایل‌های PDF به عنوان بخشی از نقشه‌های DXF**

این روش به صورت زیر عمل می‌کند:

1. بارگذاری فایل نقشه DXF با استفاده از متد [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. ایجاد یک شی از کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) و بارگذاری فایل‌های PDF.
1. تنظیم خواص [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) و [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. فراخوانی [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) و ذخیره فایل.

نمونه کد زیر نشان می‌دهد که چگونه می‌توان فایل‌های PDF را به عنوان بخشی از نقشه‌های DXF رندر کرد.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

## **صادرات زیرلایه DGN جاسازی‌شده برای فرمت DXF**

Aspose.CAD امکان بارگذاری فایل‌های DXF اتوکد و صادرات زیرلایه DGN جاسازی‌شده برای فرمت DXF را فراهم می‌کند.

نمونه کد زیر نشان می‌دهد که چگونه می‌توان الزامات مشخص‌شده را برآورده کرد.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **پشتیبانی از ذخیره‌سازی فایل‌های DXF**

Aspose.CAD این امکان را فراهم می‌آورد که فایل‌های DXF اتوکد را بارگذاری کرده و در آنها تغییراتی ایجاد کرده و دوباره به عنوان یک فایل DXF ذخیره کنید.

نمونه کد زیر نشان می‌دهد که چگونه می‌توان الزامات مشخص‌شده را برآورده کرد.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-SaveDXFFiles-SaveDXFFiles.cs" >}}

## **صادرات DXF به WMF**

این روش به صورت زیر عمل می‌کند:

1. بارگذاری فایل نقشه DXF با استفاده از متد [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. ایجاد یک شی از کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) و بارگذاری فایل‌های PDF.
1. تنظیم خواص [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) و [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. فراخوانی [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) و ذخیره فایل.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportDXFToWMF-ExportDXFToWMF.cs" >}}

## **صادرات لایه خاص DXF به PDF**

این روش به صورت زیر عمل می‌کند:

1. باز کردن یک فایل نقشه DXF با استفاده از متد [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. ایجاد یک نمونه از [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) و مشخص کردن خواص [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) و [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. مشخص کردن نام لایه‌های مورد نظر با استفاده از خواص [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts).
1. ایجاد یک نمونه از [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) و تنظیم خواص [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. صادرات نقشه به PDF با فراخوانی متد [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) و ارسال شی [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) به عنوان پارامتر دوم.

نمونه کد زیر نشان می‌دهد که چگونه می‌توان یک لایه خاص از DXF را به PDF تبدیل کرد.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

{{% alert color="primary" %}}

خواص [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) از نوع آرایه رشته‌ای است، بنابراین می‌توانید بیش از یک لایه را به طور همزمان برای تبدیل به فرمت PDF مشخص کنید. هنگام مشخص کردن چندین لایه برای خواص [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts)، PDF حاصل دارای صفحات متعددی خواهد بود، که هر صفحه نمایانگر یک لایه اتوکد جداگانه است.

{{% /alert %}}

## **پشتیبانی از قطعه‌برداری بلوک**

Aspose.CAD امکان استفاده از قطعه‌برداری بلوک را فراهم می‌کند. روش قطعه‌برداری بلوک به صورت زیر عمل می‌کند:

1. بارگذاری فایل نقشه DXF با استفاده از متد [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. ایجاد یک شی از کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) و بارگذاری فایل‌های PDF.
1. تنظیم خواص مورد نظر [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. فراخوانی [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) و ارسال شی [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) به عنوان پارامتر دوم و ذخیره فایل.

نمونه کد زیر نشان می‌دهد که چگونه قطعه‌برداری بلوک کار می‌کند.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DXF-Drawings-SupportOfBlockClipping-SupportOfBlockClipping.cs" >}}

## **صادرات تصاویر به DXF**

با استفاده از Aspose.CAD، شما می‌توانید تصاویر را به فرمت DXF صادر کنید. با استفاده از این روش، می‌توانید اقدامات زیر را انجام دهید:

1. تنظیم فونت جدید
1. پنهان کردن موجودیت‌ها
1. به‌روزرسانی متن

نمونه کد زیر نشان می‌دهد که چگونه می‌توان اقدامات ذکر شده را انجام داد.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportImagesToDXF-ExportImagesToDXF.cs" >}}

## **صادرات لایه خاص نقشه‌های DXF به تصویر**

این روش به صورت زیر عمل می‌کند:

1. باز کردن یک فایل نقشه DXF با استفاده از متد [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. ایجاد یک نمونه از [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) و مشخص کردن خواص [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) و [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. افزودن لایه‌ها به شی [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. ایجاد یک نمونه از [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) و تنظیم خواص [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. صادرات نقشه به PDF با استفاده از متد [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

نمونه کد زیر نشان می‌دهد که چگونه می‌توان یک لایه خاص از DXF را به تصویر تبدیل کرد.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.cs" >}}
