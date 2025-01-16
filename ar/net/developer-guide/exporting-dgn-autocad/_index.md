---
title: تصدير تنسيق DGN AutoCAD
type: docs
weight: 50
url: /ar/net/exporting-dgn-autocad/
---

## **تصدير تنسيق DGN AutoCAD إلى PDF**

أدخل Aspose.CAD لـ .NET الوظيفة لتحميل ملف DGN AutoCAD وتحويله إلى تنسيق PDF. تقوم فئة [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) بهذه الغرض.

يجب عليك تحميل ملف DGN الموجود كـ [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage). قم بإنشاء مثيل من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) وقم بتعيين خصائص مختلفة. قم بإنشاء مثيل من فئة [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) ومرر مثيل [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions). الآن قم باستدعاء طريقة [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) لمثيل فئة [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage).

### كود عينة

فيما يلي عرض الكود لتحويل/تصدير [DGN](https://docs.fileformat.com/cad/dgn/) إلى [PDF](https://docs.fileformat.com/pdf/) .

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **تصدير تنسيق DGN AutoCAD إلى تنسيق صورة متجهة**

أدخل Aspose.CAD لـ .NET الوظيفة لتحميل ملف DGN AutoCAD وتحويله إلى صورة متجهة. تقوم فئة [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) بهذه الغرض.

يجب عليك تحميل ملف DGN الموجود كـ [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage). قم بإنشاء مثيل من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) وقم بتعيين خصائص مختلفة. قم بإنشاء مثيل من فئة [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) ومرر مثيل [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions). الآن قم باستدعاء طريقة [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) لمثيل فئة [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage).

### كود عينة

فيما يلي عرض الكود لتحويل/تصدير [DGN](https://docs.fileformat.com/cad/dgn/) إلى صورة [JPEG](https://docs.fileformat.com/image/jpeg/) .

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-ExportDGNToRasterImage-ExportDGNToRasterImage.cs" >}}

## **دعم الكيانات الثلاثية الأبعاد لتنسيق DGN v7**

أدخل Aspose.CAD لـ .NET الوظيفة لتحميل ملف [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD ودعم الكيانات الثلاثية الأبعاد لتنسيق DGN v7. تقوم فئة [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) بهذه الغرض. يدعم كل صورة [DGN](https://docs.fileformat.com/cad/dgn/) 9 من المناظر المحددة مسبقًا. يتم تعدادها من 1 إلى 9. إذا لم يتم تعريف المنظر عند التصدير، فسيتم تصدير جميع المناظر لصيغ الإخراج متعددة الصفحات (مثل PDF)، كل منها في صفحة منفصلة. يتم دعم الكيانات الثلاثية الأبعاد على تنسيق ملف DGN، بالإضافة إلى 2D. لهذا، يتم استخدام [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) ، لم تعد تستخدم TypeOfEntities لتنسيق DGN (يدعم كل من 2D و3D في نفس الوقت).

### كود عينة

فيما يلي عينة من الكود للنظر في عناصر DGN المدعومة.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-SupportOf3DForDGNV7-3DSupportForDGNV7.cs" >}}
