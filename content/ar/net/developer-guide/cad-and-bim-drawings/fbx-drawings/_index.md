---
title: رسومات FBX
type: docs
weight: 70
url: /ar/net/fbx-drawings/
---

## **تصدير تنسيق FBX إلى PDF**

تسمح Aspose.CAD لـ .NET للمطورين بتصدير ملف [FBX](https://docs.fileformat.com/3d/fbx/) إلى تنسيق [PDF](https://docs.fileformat.com/pdf/). يعمل نهج تحويل [FBX](https://docs.fileformat.com/3d/fbx/) إلى [PDF](https://docs.fileformat.com/pdf/) كما يلي:

1. قم بتحميل ملف رسومات [FBX](https://docs.fileformat.com/3d/fbx/) باستخدام الطريقة الأساسية [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. أنشئ كائنًا من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) وقم بتعيين خصائص [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) و[**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. أنشئ كائنًا من فئة [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) وقم بتعيين خاصية [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. قم باستدعاء [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) مع تمرير كائن من [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) كمعامل ثانٍ.

## كود العينة

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-FBX-to-PDF-Export.cs" >}}
