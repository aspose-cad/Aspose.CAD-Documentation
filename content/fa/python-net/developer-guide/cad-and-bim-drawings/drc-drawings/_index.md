---
title: نقشه‌های DRC
type: docs
weight: 40
url: /fa/python-net/drc-drawings/
---

## **اکسپورت فرمت DRC به PDF**

Aspose.CAD برای Python به توسعه‌دهندگان این امکان را می‌دهد که یک فایل [DRC](https://docs.fileformat.com/3d/drc/) را به فرمت [PDF](https://docs.fileformat.com/pdf/) اکسپورت کنند. روش تبدیل [DRC](https://docs.fileformat.com/3d/drc/) به [PDF](https://docs.fileformat.com/pdf/) به شرح زیر است:

1. فایل نقشه DRC را با استفاده از متد کارخانه **Image.load** بارگذاری کنید.
1. یک شی از کلاس **CadRasterizationOptions** ایجاد کرده و ویژگی‌های **page_height** و **page_width** را تنظیم کنید.
1. یک شی از کلاس **PdfOptions** ایجاد کرده و ویژگی **VectorRasterizationOptions** را تنظیم کنید.
1. با فراخوانی **Image.save** و ارسال شی **PdfOptions** به عنوان پارامتر دوم، عملیات را انجام دهید.

## کد نمونه


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "convert-drc-to-pdf.py" >}}
