---
title: رسومات DRC
type: docs
weight: 15
url: /ar/net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **تصميم رسومات DRC إلى PDF**

توفر Aspose.CAD ميزة تحميل كائنات رسم AutoCAD [DRC](https://docs.fileformat.com/3d/drc/) وعرضها كرسمة كاملة بصيغة [PDF](https://docs.fileformat.com/pdf/). تعمل طريقة تحويل [DRC](https://docs.fileformat.com/3d/drc/) إلى [PDF](https://docs.fileformat.com/pdf/) كما يلي:

1. قم بتحميل ملف رسم [DRC](https://docs.fileformat.com/3d/drc/) باستخدام طريقة المصنع [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. أنشئ كائن من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) وقم بتعيين خصائص [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) و [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. أنشئ كائن من فئة [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) وقم بتعيين خاصية [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. قم باستدعاء [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) مع تمرير كائن من [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) كمعامل ثانٍ.

### عينة من الشيفرة

توضح عينة الشيفرة أدناه كيفية تحويل ملف باستخدام الإعدادات الافتراضية.


{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DRC-to-PDF-Export.cs" >}}
