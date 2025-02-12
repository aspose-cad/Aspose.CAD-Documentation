---
title: صادرات فرمت DGN AutoCAD
type: docs
weight: 50
url: /fa/python-net/exporting-dgn-autocad/
---

## **صادرات فرمت DGN AutoCAD به PDF**

Aspose.CAD برای API پایتون قابلیت بارگذاری فایل DGN AutoCAD و تبدیل آن به فرمت PDF را معرفی کرده است. کلاس **CadImage** برای این منظور استفاده می‌شود.

شما نیاز دارید که یک فایل DGN موجود را به عنوان **CadImage** بارگذاری کنید. یک نمونه از کلاس **CadRasterizationOptions** ایجاد کنید و ویژگی‌های مختلف را تنظیم کنید. یک نمونه از کلاس **PdfOptions** ایجاد کنید و نمونه **CadRasterizationOptions** را به آن پاس دهید. اکنون متد **save** را از نمونه کلاس **CadImage** فراخوانی کنید.

### کد نمونه

در زیر یک نمایش کد برای تبدیل/صادرات [DGN](https://docs.fileformat.com/cad/dgn/) به [PDF](https://docs.fileformat.com/pdf/) آورده شده است.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-PDF-Export.py" >}}

## **صادرات فرمت DGN AutoCAD به فرمت تصویر Raster**

Aspose.CAD برای API پایتون قابلیت بارگذاری فایل DGN AutoCAD و تبدیل آن به یک تصویر Raster را معرفی کرده است. کلاس **CadImage** برای این منظور استفاده می‌شود.

شما نیاز دارید که یک فایل DGN موجود را به عنوان **CadImage** بارگذاری کنید. یک نمونه از کلاس **CadRasterizationOptions** ایجاد کنید و ویژگی‌های مختلف را تنظیم کنید. یک نمونه از کلاس **JpegOptions** ایجاد کنید و نمونه **CadRasterizationOptions** را به آن پاس دهید. اکنون متد **save** را از نمونه کلاس **CadImage** فراخوانی کنید.

### کد نمونه

در زیر یک نمایش کد برای تبدیل/صادرات [DGN](https://docs.fileformat.com/cad/dgn/) به تصویر [JPEG](https://docs.fileformat.com/image/jpeg/) آورده شده است.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-JPEG-Export.py" >}}

## **پشتیبانی از موجودیت‌های 3D برای DGN v7**

Aspose.CAD برای API پایتون قابلیت بارگذاری یک فایل [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD و پشتیبانی از موجودیت‌های 3D برای DGN v7 را معرفی کرده است. کلاس **CadImage** برای این منظور استفاده می‌شود. هر تصویر [DGN](https://docs.fileformat.com/cad/dgn/) از 9 نمای پیش‌تعریف شده پشتیبانی می‌کند. این نمای‌ها از 1 تا 9 شماره‌گذاری شده‌اند. اگر نمایی در زمان صادرات تعریف نشده باشد، برای فرمت‌های خروجی چند صفحه‌ای (مانند PDF) تمام نماها صادر خواهند شد که هر کدام در یک صفحه جداگانه قرار می‌گیرند. موجودیت‌های 3D در فرمت فایل DGN پشتیبانی شده‌اند، به علاوه 2D. برای این منظور، **VectorRasterizationOptions** استفاده می‌شود و نوع موجودیت‌ها دیگر برای فرمت DGN استفاده نمی‌شود (هر دو 2D و 3D به صورت همزمان پشتیبانی می‌شوند).

### کد نمونه

در زیر کد نمونه‌ای برای مشاهده عناصر پشتیبانی شده DGN آورده شده است.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DGN-Drawings-SupportOf3DForDGNV7.py" >}}
