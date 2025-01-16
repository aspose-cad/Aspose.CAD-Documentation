---
title: رسومات STP
type: docs
weight: 70
url: /ar/net/stp-drawings/
---

## **تصدير تنسيق STP إلى PDF**

تسمح Aspose.CAD لـ .NET للمطورين بتصدير ملف [STP](https://docs.fileformat.com/3d/stp/) إلى تنسيق [PDF](https://docs.fileformat.com/pdf/). تعمل عملية تحويل [STP](https://docs.fileformat.com/3d/stp/) إلى [PDF](https://docs.fileformat.com/pdf/) كما يلي:

1. قم بتحميل ملف رسم [STP](https://docs.fileformat.com/3d/stp/) باستخدام طريقة مصنع [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
2. أنشئ كائن من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) وقم بتعيين خصائص [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) و [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
3. أنشئ كائن من فئة [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) وقم بتعيين خاصية [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
4. استدعِ [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) مع تمرير كائن من فئة [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) كمعامل ثانٍ.

## نموذج الكود

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-STP-to-PDF-Export.cs" >}}
