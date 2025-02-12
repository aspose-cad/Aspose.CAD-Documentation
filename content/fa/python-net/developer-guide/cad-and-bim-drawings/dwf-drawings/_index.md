---
title: نقاشی‌های DWF
type: docs
weight: 50
url: /fa/python-net/dwf-drawings/
---

## **صادرات نقاشی‌های DWF به PDF**

Aspose.CAD قابلیت بارگذاری اشیاء نقاشی AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) و رندر کردن آن‌ها به عنوان یک نقاشی کامل به فرمت [PDF](https://docs.fileformat.com/pdf/) را فراهم می‌کند. رویکرد تبدیل [DWF](https://docs.fileformat.com/cad/dwf/) به [PDF](https://docs.fileformat.com/pdf/) به صورت زیر کار می‌کند:

1. بارگذاری فایل نقاشی [DWF](https://docs.fileformat.com/cad/dwf/) با استفاده از متد کارخانه **Image.load**.
1. ایجاد یک شی از کلاس **CadRasterizationOptions** و تنظیم ویژگی‌های **page_height** و **page_width**.
1. ایجاد یک شی از کلاس **PdfOptions** و تنظیم ویژگی **vector_rasterization_options**.
1. فراخوانی **Image.save** در حالی که یک شی از **PdfOptions** را به عنوان پارامتر دوم منتقل می‌کنید.

### کد نمونه

کد نمونه زیر نشان می‌دهد که چگونه یک فایل را با استفاده از تنظیمات پیش‌فرض تبدیل کنید.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-PDF-Export.py" >}}

## **صادرات نقاشی‌های DWF به BMP**

Aspose.CAD قابلیت بارگذاری اشیاء نقاشی AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) و رندر کردن آن‌ها به عنوان یک نقاشی کامل به فرمت [BMP](https://docs.fileformat.com/image/bmp/) را فراهم می‌کند. رویکرد تبدیل [DWF](https://docs.fileformat.com/cad/dwf/) به [BMP](https://docs.fileformat.com/image/bmp/) به صورت زیر کار می‌کند:

1. بارگذاری فایل نقاشی [DWF](https://docs.fileformat.com/cad/dwf/) با استفاده از متد کارخانه **Image.load**.
1. ایجاد یک شی از کلاس **CadRasterizationOptions** و تنظیم ویژگی‌های **page_height** و **page_width**.
1. ایجاد یک شی از کلاس **BmpOptions** و تنظیم ویژگی **vector_rasterization_options**.
1. فراخوانی **Image.save** در حالی که یک شی از **BmpOptions** را به عنوان پارامتر دوم منتقل می‌کنید.

### کد نمونه

کد نمونه زیر نشان می‌دهد که چگونه یک فایل [DWF](https://docs.fileformat.com/cad/dwf/) را به [BMP](https://docs.fileformat.com/image/bmp/) تبدیل کنید، با استفاده از تنظیمات پیش‌فرض.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-BMP-Export.py" >}}
