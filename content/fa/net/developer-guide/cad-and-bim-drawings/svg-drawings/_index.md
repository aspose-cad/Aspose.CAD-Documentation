---
title: SVG Drawings
type: docs
weight: 70
url: /fa/net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **صادرات فرمت SVG به PDF**

Aspose.CAD برای .NET به توسعه‌دهندگان اجازه می‌دهد تا یک فایل SVG را به فرمت [PDF](https://docs.fileformat.com/pdf/) صادر کنند. روش تبدیل SVG به [PDF](https://docs.fileformat.com/pdf/) به شکل زیر عمل می‌کند:

1. فایل طراحی SVG را با استفاده از روش کارخانه [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) بارگذاری کنید.
1. یک شیء از کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) بسازید و properties [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) و [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) را تنظیم کنید.
1. یک شیء از کلاس [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) بسازید و property [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) را تنظیم کنید.
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) را فراخوانی کنید و یک شیء از [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) را به عنوان دومین پارامتر ارسال کنید.

## کد نمونه

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-SVG-to-PDF-Export.cs" >}}
