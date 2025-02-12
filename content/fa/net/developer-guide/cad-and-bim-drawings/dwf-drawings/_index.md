---
title: ترسیمات DWF
type: docs
weight: 20
url: /fa/net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **صادرات ترسیمات DWF به PDF**

Aspose.CAD این امکان را فراهم می‌کند تا موجودیت‌های ترسیمی AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) را بارگذاری کرده و آنها را به عنوان یک ترسیم کامل به فرمت [PDF](https://docs.fileformat.com/pdf/) رندر کند. روش تبدیل [DWF](https://docs.fileformat.com/cad/dwf/) به [PDF](https://docs.fileformat.com/pdf/) به شرح زیر عمل می‌کند:

1. بارگذاری فایل ترسیم [DWF](https://docs.fileformat.com/cad/dwf/) با استفاده از متد کارخانه [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
2. ایجاد یک شی از کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) و تنظیم پروپرتی‌های [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) و [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
3. ایجاد یک شی از کلاس [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) و تنظیم پروپرتی [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
4. فراخوانی [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) با عبور دادن یک شی از [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) به عنوان پارامتر دوم.

### نمونه کد

نمونه کد زیر نشان می‌دهد که چگونه یک فایل را با استفاده از تنظیمات پیش‌فرض تبدیل کنید.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **استخراج لایه‌ها از ترسیم DWF**

Aspose.CAD این امکان را فراهم می‌کند تا موجودیت‌های ترسیمی AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) را بارگذاری کرده و آنها را به عنوان یک ترسیم کامل به فرمت [JPEG](https://docs.fileformat.com/image/jpeg/) رندر کند.

1. بارگذاری فایل ترسیم [DWF](https://docs.fileformat.com/cad/dwf/) با استفاده از متد کارخانه [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
2. ایجاد یک شی از کلاس [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions).
3. ایجاد یک شی از کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
4. استخراج نام لایه‌ها با استفاده از شی [JPEG](https://docs.fileformat.com/image/jpeg/).
5. فراخوانی [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) با عبور دادن یک شی از [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) به عنوان پارامتر دوم.

### نمونه کد

نمونه کد زیر نشان می‌دهد که چگونه یک فایل را با استفاده از تنظیمات پیش‌فرض تبدیل کنید.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **پشتیبانی از لایه‌ها در DWF**

Aspose.CAD این امکان را فراهم می‌کند تا موجودیت‌های ترسیمی AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) را بارگذاری کرده و آنها را به عنوان یک ترسیم کامل به فرمت [JPEG](https://docs.fileformat.com/image/jpeg/) رندر کند.

1. بارگذاری فایل ترسیم [DWF](https://docs.fileformat.com/cad/dwf/) با استفاده از متد کارخانه [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
2. ایجاد یک شی از کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
3. افزودن لایه‌های مورد نظر.
4. فراخوانی [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) در حالی که یک شی از [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) را به عنوان پارامتر دوم عبور می‌دهید.

### نمونه کد

نمونه کد زیر نشان می‌دهد که چگونه یک فایل را با استفاده از تنظیمات پیش‌فرض تبدیل کنید.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWF-Drawings-SupportOfLayers-SupportOfLayers.cs" >}}

## **صادرات ترسیمات DWF به BMP**

Aspose.CAD این امکان را فراهم می‌کند تا موجودیت‌های ترسیمی AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) را بارگذاری کرده و آنها را به عنوان یک ترسیم کامل به فرمت [BMP](https://docs.fileformat.com/image/bmp/) رندر کند. روش تبدیل [DWF](https://docs.fileformat.com/cad/dwf/) به [BMP](https://docs.fileformat.com/image/bmp/) به شرح زیر عمل می‌کند:

1. بارگذاری فایل ترسیم [DWF](https://docs.fileformat.com/cad/dwf/) با استفاده از متد کارخانه [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
2. ایجاد یک شی از کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) و تنظیم پروپرتی‌های [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) و [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
3. ایجاد یک شی از کلاس [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) و تنظیم پروپرتی [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
4. فراخوانی [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) در حالی که یک شی از [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) را به عنوان پارامتر دوم عبور می‌دهید.

### نمونه کد

نمونه کد زیر نشان می‌دهد که چگونه یک فایل [DWF](https://docs.fileformat.com/cad/dwf/) را به [BMP](https://docs.fileformat.com/image/bmp/) با استفاده از تنظیمات پیش‌فرض تبدیل کنید.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}
