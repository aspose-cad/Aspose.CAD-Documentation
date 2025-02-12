---
title: نقشه‌های STP
type: docs
weight: 160
url: /fa/python-net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **صادرات فرمت STP به PDF**

Aspose.CAD برای Python به توسعه‌دهندگان اجازه می‌دهد تا یک فایل [STP](https://docs.fileformat.com/3d/stp/) را به فرمت [PDF](https://docs.fileformat.com/pdf/) صادرات کنند. رویکرد تبدیل [STP](https://docs.fileformat.com/3d/stp/) به [PDF](https://docs.fileformat.com/pdf/) به صورت زیر عمل می‌کند:

1. فایل نقشه [STP](https://docs.fileformat.com/3d/stp/) را با استفاده از روش کارخانه **Image.load** بارگذاری کنید.
1. یک شی از کلاس **CadRasterizationOptions** ایجاد کنید و مقادیر ویژگی‌های **page_height** و **page_width** را تنظیم کنید.
1. یک شی از کلاس **PdfOptions** ایجاد کنید و ویژگی **vector_rasterization_options** را تنظیم کنید.
1. **Image.save** را فراخوانی کنید و یک شی از **PdfOptions** را به عنوان پارامتر دوم منتقل کنید.

## نمونه کد

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-STP-to-PDF-Export.py" >}}
