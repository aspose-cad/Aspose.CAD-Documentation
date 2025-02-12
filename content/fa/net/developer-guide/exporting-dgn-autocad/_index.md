---
title: صادرات فرمت DGN اتوکد
type: docs
weight: 50
url: /fa/net/exporting-dgn-autocad/
---

## **صادرات فرمت DGN اتوکد به PDF**

API Aspose.CAD برای .NET قابلیت بارگذاری یک فایل DGN اتوکد و تبدیل آن به فرمت PDF را معرفی کرده است. کلاس [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) به این منظور خدمت می‌کند.

شما نیاز دارید که یک فایل DGN موجود را به عنوان [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) بارگذاری کنید. یک نمونه از کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) ایجاد کنید و ویژگی‌های مختلفی را تنظیم کنید. یک نمونه از کلاس [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) ایجاد کرده و نمونه [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) را به آن پاس دهید. اکنون متد [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) را از نمونه کلاس [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) فراخوانی کنید.

### کد نمونه

در زیر یک نمایش کد برای تبدیل/صادرات [DGN](https://docs.fileformat.com/cad/dgn/) به فرمت [PDF](https://docs.fileformat.com/pdf/) آورده شده است.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **صادرات فرمت DGN اتوکد به فرمت تصویر رستر**

API Aspose.CAD برای .NET قابلیت بارگذاری یک فایل DGN اتوکد و تبدیل آن به یک تصویر رستر را معرفی کرده است. کلاس [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) به این منظور خدمت می‌کند.

شما نیاز دارید که یک فایل DGN موجود را به عنوان [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) بارگذاری کنید. یک نمونه از کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) ایجاد کنید و ویژگی‌های مختلفی را تنظیم کنید. یک نمونه از کلاس [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) ایجاد کرده و نمونه [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) را به آن پاس دهید. اکنون متد [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) را از نمونه کلاس [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) فراخوانی کنید.

### کد نمونه

در زیر یک نمایش کد برای تبدیل/صادرات [DGN](https://docs.fileformat.com/cad/dgn/) به تصویر [JPEG](https://docs.fileformat.com/image/jpeg/) آورده شده است.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-ExportDGNToRasterImage-ExportDGNToRasterImage.cs" >}}

## **پشتیبانی از موجودیت‌های 3D برای DGN v7**

API Aspose.CAD برای .NET قابلیت بارگذاری یک فایل [DGN](https://docs.fileformat.com/cad/dgn/) اتوکد و پشتیبانی از موجودیت‌های 3D برای DGN v7 را معرفی کرده است. کلاس [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) به این منظور خدمت می‌کند. هر تصویر [DGN](https://docs.fileformat.com/cad/dgn/) از 9 نمای پیش‌فرض پشتیبانی می‌کند. این نما از 1 تا 9 شماره‌گذاری شده‌اند. اگر نما در صادرات تعریف نشود، برای فرمت‌های خروجی چند صفحه‌ای (مانند PDF) تمام نماها صادر خواهند شد، هرکدام در یک صفحه جداگانه. موجودیت‌های 3D در فرمت فایل DGN پشتیبانی می‌شود، همچنین 2D. برای این کار، [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) استفاده می‌شود، نوع موجودیت‌ها دیگر برای فرمت DGN (هر دو 2D و 3D به طور همزمان پشتیبانی می‌شوند) استفاده نمی‌شود.

### کد نمونه

در زیر کد نمونه‌ای برای مشاهده عناصر پشتیبانی شده DGN آورده شده است.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-SupportOf3DForDGNV7-3DSupportForDGNV7.cs" >}}
