---
title: نقاشی‌های COLLADA
type: docs
weight: 70
url: /fa/net/collada-drawings/
---

## **صادرات فرمت COLLADA به PDF**

Aspose.CAD برای .NET به توسعه‌دهندگان اجازه می‌دهد تا یک فایل [COLLADA](https://docs.fileformat.com/3d/dae/) را به فرمت [PDF](https://docs.fileformat.com/pdf/) صادر کنند. نحوه تبدیل [COLLADA](https://docs.fileformat.com/3d/dae/) به [PDF](https://docs.fileformat.com/pdf/) به صورت زیر است:

1. فایل نقاشی [COLLADA](https://docs.fileformat.com/3d/dae/) را با استفاده از روش کارخانه [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) بارگذاری کنید.
1. یک شی از کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) ایجاد کنید و ویژگی‌های [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) و [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) را تنظیم کنید.
1. یک شی از کلاس [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) ایجاد کنید و ویژگی [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) را تنظیم کنید.
1. متد [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) را فراخوانی کرده و شی [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) را به عنوان پارامتر دوم ارسال کنید.

## کد نمونه

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-COLLADA-to-PDF-Export.cs" >}}
