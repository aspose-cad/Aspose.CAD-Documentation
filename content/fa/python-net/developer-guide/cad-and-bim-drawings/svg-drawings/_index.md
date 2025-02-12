---
title: نقاشی‌های SVG
type: docs
weight: 170
url: /fa/python-net/svg-drawings/
---

## **صادرات فرمت SVG به PDF**

Aspose.CAD برای Python به توسعه‌دهندگان اجازه می‌دهد تا یک فایل [SVG](https://docs.fileformat.com/page-description-language/svg/) را به فرمت [PDF](https://docs.fileformat.com/pdf/) صادر کنند. روش تبدیل [SVG](https://docs.fileformat.com/page-description-language/svg/) به [PDF](https://docs.fileformat.com/pdf/) به شرح زیر است:

1. فایل نقاشی SVG را با استفاده از متد کارخانه **Image.load** بارگذاری کنید.
1. یک شی از کلاس **CadRasterizationOptions** ایجاد کرده و ویژگی‌های **page_height** و **page_width** را تنظیم کنید.
1. یک شی از کلاس **PdfOptions** ایجاد کرده و ویژگی **VectorRasterizationOptions** را تنظیم کنید.
1. در حالی که شی **PdfOptions** را به عنوان پارامتر دوم منتقل می‌کنید، **Image.save** را فراخوانی کنید.

## کد نمونه

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-SVG-to-PDF-Export.py" >}}
