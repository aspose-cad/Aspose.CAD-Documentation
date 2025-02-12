---
title: نقشه های DRC
type: docs
weight: 15
url: /fa/net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **صادرات نقشه های DRC به PDF**

Aspose.CAD ویژگی بارگذاری موجودیت های نقشه کشی [DRC](https://docs.fileformat.com/3d/drc/) را فراهم می‌کند و آن‌ها را به عنوان یک نقشه کامل به فرمت [PDF](https://docs.fileformat.com/pdf/) رندر می‌کند. روش تبدیل [DRC](https://docs.fileformat.com/3d/drc/) به [PDF](https://docs.fileformat.com/pdf/) به صورت زیر عمل می‌کند:

1. فایل نقشه [DRC](https://docs.fileformat.com/3d/drc/) را با استفاده از روش کارخانه [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) بارگذاری کنید.
1. یک شی از کلاس [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) ایجاد کنید و ویژگی های [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) و [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) را تنظیم کنید.
1. یک شی از کلاس [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) ایجاد کنید و ویژگی [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) را تنظیم کنید.
1. با استفاده از [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) و عبور دادن یک شی از [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) به عنوان پارامتر دوم، این متد را فراخوانی کنید.

### نمونه کد

نمونه کد زیر نشان می‌دهد چگونه یک فایل را با استفاده از تنظیمات پیش فرض تبدیل کنید.


{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DRC-to-PDF-Export.cs" >}}
