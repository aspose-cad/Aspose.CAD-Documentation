---
title: طراحی‌های COLLADA
type: docs
weight: 20
url: /fa/python-net/developer-guide/cad-and-bim-drawings/collada-drawings/
---

## **صادرات فرمت COLLADA به PDF**

Aspose.CAD برای Python به توسعه‌دهندگان این امکان را می‌دهد که یک فایل [COLLADA](https://docs.fileformat.com/3d/dae/) را به فرمت [PDF](https://docs.fileformat.com/pdf/) صادر کنند. رویکرد تبدیل [COLLADA](https://docs.fileformat.com/3d/dae/) به [PDF](https://docs.fileformat.com/pdf/) به صورت زیر عمل می‌کند:

1. فایل طراحی [COLLADA](https://docs.fileformat.com/3d/dae/) را با استفاده از متد کارخانه **Image.load** بارگذاری کنید.
1. یک شی از کلاس **CadRasterizationOptions** ایجاد کرده و خواص **page_height** و **page_width** را تنظیم کنید.
1. یک شی از کلاس **PdfOptions** ایجاد کرده و خاصیت **vector_rasterization_options** را تنظیم کنید.
1. **Image.save** را فراخوانی کنید و شی **PdfOptions** را به عنوان پارامتر دوم منتقل کنید.

## کد نمونه

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-COLLADA-to-PDF-Export.py" >}}
