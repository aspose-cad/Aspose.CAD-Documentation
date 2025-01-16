---
title: رسومات 3DS
type: docs
weight: 70
url: /ar/net/3ds-drawings/
---

## **تصدير تنسيق 3DS إلى PDF**

تسمح Aspose.CAD لـ .NET للمطورين بتصدير ملف [3DS](https://docs.fileformat.com/3d/3ds/) إلى تنسيق [PDF](https://docs.fileformat.com/pdf/). يعمل نهج تحويل [3DS](https://docs.fileformat.com/3d/3ds/) إلى [PDF](https://docs.fileformat.com/pdf/) على النحو التالي:

1. قم بتحميل ملف رسم [3DS](https://docs.fileformat.com/3d/3ds/) باستخدام طريقة المصنع [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. أنشئ كائنًا من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) واضبط خاصيتي [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) و [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. أنشئ كائنًا من فئة [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) واضبط خاصية [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. استدعِ [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) مع تمرير كائن من [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) كمعامل ثانٍ.

## عينة من التعليمات البرمجية

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-3DS-to-PDF-Export.cs" >}}
