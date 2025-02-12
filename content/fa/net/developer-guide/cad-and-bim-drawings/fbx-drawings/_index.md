---
title: نقشه‌های FBX
type: docs
weight: 70
url: /fa/net/fbx-drawings/
---

## **صادرات فرمت FBX به PDF**

Aspose.CAD برای .NET به توسعه‌دهندگان این امکان را می‌دهد که یک فایل [FBX](https://docs.fileformat.com/3d/fbx/) را به فرمت [PDF](https://docs.fileformat.com/pdf/) صادرات کنند. روش تبدیل [FBX](https://docs.fileformat.com/3d/fbx/) به [PDF](https://docs.fileformat.com/pdf/) به شرح زیر است:

1. بارگذاری فایل نقشه [FBX](https://docs.fileformat.com/3d/fbx/) با استفاده از روش کارخانه [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. ایجاد یک شی از کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) و تنظیم ویژگی‌های [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) و [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. ایجاد یک شی از کلاس [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) و تنظیم ویژگی [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. فراخوانی [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) در حالی که یک شی از [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) را به عنوان پارامتر دوم منتقل می‌کنید.

## نمونه کد

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-FBX-to-PDF-Export.cs" >}}
