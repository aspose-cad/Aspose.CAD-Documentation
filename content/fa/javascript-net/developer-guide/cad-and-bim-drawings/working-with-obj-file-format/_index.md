---
title: کار با فرمت فایل OBJ
type: docs
weight: 120
url: /fa/javascript-net/working-with-obj-file-format/
---

{{% alert color="primary" %}}

Aspose.CAD اکنون از فرمت فایل OBJ پشتیبانی می‌کند. فرمت فایل OBJ یک هندسه 3 بعدی است که شامل نقشه‌های بافت، مختصات 3 بعدی، صورت‌های چندضلعی و اطلاعات دیگر اشیا است.

{{% /alert %}}

## **صادرات فرمت OBJ به PNG**

Aspose.CAD برای جاوا اسکریپت در Angular به توسعه دهندگان این امکان را می‌دهد که یک فایل [OBJ](https://docs.fileformat.com/3d/obj/) را به فرمت [PNG](https://docs.fileformat.com/image/png/) صادر کنند. رویکرد تبدیل [OBJ](https://docs.fileformat.com/3d/obj/) به [PNG](https://docs.fileformat.com/image/png/) به صورت زیر عمل می‌کند:

1. بارگذاری فایل ترسیم [OBJ](https://docs.fileformat.com/3d/obj/) با استفاده از روش **Image.load**.
1. فراخوانی **Image.save** در حالی که یک شی از **PngOptions** را به عنوان پارامتر دوم منتقل می‌کنید.

## کد نمونه

کد زیر نشان می‌دهد که چگونه می‌توان به همان هدف با استفاده از Aspose.CAD برای جاوا اسکریپت دست یافت.

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-OBJ-to-PNG-Export.js" >}}
