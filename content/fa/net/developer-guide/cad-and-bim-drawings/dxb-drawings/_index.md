---
title: نقشه های DXB
type: docs
weight: 70
url: /fa/net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **صادرات فرمت DXB به PDF**

Aspose.CAD برای .NET به توسعه‌دهندگان این امکان را می‌دهد که یک فایل DXB را به فرمت [PDF](https://docs.fileformat.com/pdf/) صادر کنند. روش تبدیل DXB به [PDF](https://docs.fileformat.com/pdf/) به صورت زیر کار می‌کند:

1. فایل نقشه DXB را با استفاده از روش کارخانه [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) بارگذاری کنید.
1. یک شیء از کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) ایجاد کنید و ویژگی‌های [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) و [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) را تنظیم کنید.
1. یک شیء از کلاس [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) ایجاد کنید و ویژگی [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) را تنظیم کنید.
1. از [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) استفاده کنید و شیء [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) را به عنوان پارامتر دوم منتقل کنید.

## کد نمونه

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DXB-to-PDF-Export.cs" >}}
