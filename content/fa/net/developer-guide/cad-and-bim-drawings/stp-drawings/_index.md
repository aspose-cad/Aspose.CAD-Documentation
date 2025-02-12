---
title: STP Drawings
type: docs
weight: 70
url: /fa/net/stp-drawings/
---

## **صادرات فرمت STP به PDF**

Aspose.CAD برای .NET به توسعه‌دهندگان این امکان را می‌دهد که یک فایل [STP](https://docs.fileformat.com/3d/stp/) را به فرمت [PDF](https://docs.fileformat.com/pdf/) صادر کنند. رویکرد تبدیل [STP](https://docs.fileformat.com/3d/stp/) به [PDF](https://docs.fileformat.com/pdf/) به صورت زیر عمل می‌کند:

1. فایل ترسیم [STP](https://docs.fileformat.com/3d/stp/) را با استفاده از روش کارخانه [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) بارگذاری کنید.
1. یک شیء از کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) ایجاد کنید و ویژگی‌های [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) و [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) را تنظیم کنید.
1. یک شیء از کلاس [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) ایجاد کنید و ویژگی [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) را تنظیم کنید.
1. در حین ارسال یک شیء از [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) به عنوان پارامتر دوم، [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) را فراخوانی کنید.

## کد نمونه

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-STP-to-PDF-Export.cs" >}}
