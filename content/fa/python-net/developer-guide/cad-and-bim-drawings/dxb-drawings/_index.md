---
title: نقشه های DXB
type: docs
weight: 90
url: /fa/python-net/dxb-drawings/
---

## **صادرات فرمت DXB به PDF**

Aspose.CAD برای پایتون به توسعه‌دهندگان این امکان را می‌دهد که فایل DXB را به فرمت [PDF](https://docs.fileformat.com/pdf/) صادر کنند. روش تبدیل DXB به [PDF](https://docs.fileformat.com/pdf/) به صورت زیر عمل می‌کند:

1. فایل نقشه DXB را با استفاده از متد کارخانه **Image.load** بارگذاری کنید.
1. یک شی از کلاس **CadRasterizationOptions** ایجاد کنید و خصوصیات **page_height** و **page_width** را تنظیم کنید.
1. یک شی از کلاس **PdfOptions** ایجاد کنید و خصوصیت **vector_rasterization_options** را تنظیم کنید.
1. با تماس به **Image.save** در حالی که شی **PdfOptions** را به عنوان پارامتر دوم منتقل می‌کنید.

## نمونه کد

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXB-to-PDF-Export.py" >}}
