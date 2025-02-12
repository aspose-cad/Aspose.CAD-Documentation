---
title: رسومات DXB
type: docs
weight: 70
url: /ar/net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **تصدير تنسيق DXB إلى PDF**

تتيح Aspose.CAD لـ .NET للمطورين تصدير ملف DXB إلى [PDF](https://docs.fileformat.com/pdf/)  بتنسيق. يعمل نهج تحويل DXB إلى [PDF](https://docs.fileformat.com/pdf/)  على النحو التالي:

1. تحميل ملف رسومات DXB باستخدام طريقة المصنع [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. إنشاء كائن من الفئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) وضبط خصائص [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) و [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. إنشاء كائن من الفئة [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) وضبط خاصية [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. استدعاء [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) مع تمرير كائن من [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) كمعامل ثانٍ.

## عينة كود

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DXB-to-PDF-Export.cs" >}}
