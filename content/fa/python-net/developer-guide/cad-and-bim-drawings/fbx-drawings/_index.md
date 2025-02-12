---
title: نقشه‌های FBX
type: docs
weight: 110
url: /fa/python-net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **صادرات فرمت FBX به PDF**

Aspose.CAD برای Python به توسعه‌دهندگان اجازه می‌دهد تا یک فایل [FBX](https://docs.fileformat.com/3d/fbx/) را به فرمت [PDF](https://docs.fileformat.com/pdf/) صادر کنند. رویکرد تبدیل [FBX](https://docs.fileformat.com/3d/fbx/) به [PDF](https://docs.fileformat.com/pdf/) به شرح زیر عمل می‌کند:

1. فایل نقاشی [FBX](https://docs.fileformat.com/3d/fbx/) را با استفاده از متد کارخانه **Image.load** بارگذاری کنید.
1. یک شی از کلاس **CadRasterizationOptions** ایجاد کنید و ویژگی‌های **PageHeight** و **PageWidth** را تنظیم کنید.
1. یک شی از کلاس **PdfOptions** ایجاد کنید و ویژگی **vector_rasterization_options** را تنظیم کنید.
1. با عبور یک شی از **PdfOptions** به عنوان پارامتر دوم، **Image.save** را فراخوانی کنید.

## کد نمونه

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-FBX-to-PDF-Export.py" >}}
