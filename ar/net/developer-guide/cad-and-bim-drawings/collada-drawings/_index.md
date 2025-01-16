---
title: رسومات COLLADA
type: docs
weight: 70
url: /ar/net/collada-drawings/
---

## **تصدير تنسيق COLLADA إلى PDF**

تسمح Aspose.CAD لـ .NET للمطورين بتصدير ملف [COLLADA](https://docs.fileformat.com/3d/dae/) إلى تنسيق [PDF](https://docs.fileformat.com/pdf/). تعمل طريقة تحويل [COLLADA](https://docs.fileformat.com/3d/dae/) إلى [PDF](https://docs.fileformat.com/pdf/) كما يلي:

1. قم بتحميل ملف رسم [COLLADA](https://docs.fileformat.com/3d/dae/) باستخدام طريقة المصنع [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. أنشئ كائنًا من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) واضبط خصائص [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) و [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. أنشئ كائنًا من فئة [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) واضبط خاصية [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. قم باستدعاء [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) مع تمرير كائن من [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) كمعامل ثانٍ.

## عينة من الكود

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-COLLADA-to-PDF-Export.cs" >}}
