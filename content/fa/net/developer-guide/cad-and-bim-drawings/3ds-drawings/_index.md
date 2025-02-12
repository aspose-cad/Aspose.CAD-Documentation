---
title:  نقشه های 3DS
type: docs
weight: 70
url: /fa/net/3ds-drawings/
---

## **صادرات فرمت 3DS به PDF**

Aspose.CAD for .NET به توسعه دهندگان اجازه می دهد تا یک فایل [3DS](https://docs.fileformat.com/3d/3ds/) را به فرمت [PDF](https://docs.fileformat.com/pdf/) صادر کنند. رویکرد تبدیل [3DS](https://docs.fileformat.com/3d/3ds/) به [PDF](https://docs.fileformat.com/pdf/) به صورت زیر عمل می کند:

1. بارگذاری فایل نقشه [3DS](https://docs.fileformat.com/3d/3ds/) با استفاده از متد سازنده [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. ایجاد یک شی از کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) و تنظیم ویژگی های [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) و [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. ایجاد یک شی از کلاس [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) و تنظیم ویژگی [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. فراخوانی [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) در حالی که یک شی از [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) را به عنوان پارامتر دوم پاس می دهید.

## نمونه کد

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-3DS-to-PDF-Export.cs" >}}
