---
title: الرسومات SVG
type: docs
weight: 70
url: /ar/net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **تصدير تنسيق SVG إلى PDF**

يتيح Aspose.CAD لمطوري .NET تصدير ملف SVG إلى [PDF](https://docs.fileformat.com/pdf/) بتنسيق. تعمل طريقة تحويل SVG إلى [PDF](https://docs.fileformat.com/pdf/) كما يلي:

1. تحميل ملف رسم SVG باستخدام طريقة المصنع [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. إنشاء كائن من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) وضبط خصائص [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) و [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. إنشاء كائن من فئة [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) وضبط خاصية [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. استدعاء [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) مع تمرير كائن من [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) كمعامل ثانٍ.

## عينة من الكود

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-SVG-to-PDF-Export.cs" >}}
