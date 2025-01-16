---
title: رسومات DWG
type: docs
weight: 40
url: /ar/net/dwg-drawings/
---

## **تصدير رسومات DWG إلى PDF**

يمكن لـ Aspose.CAD لـ .NET API تحميل رسومات AutoCAD بتنسيق [DWG](https://docs.fileformat.com/cad/dwg/) وتحويلها إلى [PDF](https://docs.fileformat.com/pdf/). يشرح هذا الموضوع كيفية استخدام واجهة برمجة تطبيقات Aspose.CAD لتحقيق تحويل DWG إلى تنسيق PDF من خلال خطوات بسيطة كما هو موضح أدناه.

{{% alert color="primary" %}}

تدعم واجهة برمجة التطبيقات مراجعات DWG التالية من AutoCAD:

- إصدار DWG 2004 الإصدار 16.0 الإصدار 18
- إصدار DWG 2005 الإصدار 16.1
- إصدار DWG 2010 الإصدار 18.0
- إصدار DWG 2013 الإصدار 19.0

{{% /alert %}}

### **تنسيق ملف DWG**

[DWG](https://docs.fileformat.com/cad/dwg/) هو ملف ثنائي يحتوي على بيانات صورة متجهية وبيانات وصفية. توفر بيانات الصورة المتجهية تعليمات لتطبيق CAD حول كيفية عرض DWG؛ قد تحتوي البيانات الوصفية على معلومات متنوعة حول الملف بما في ذلك بيانات محددة بالموقع وبيانات العميل أيضًا. يمكن العثور على المواصفات المفتوحة لتنسيق ملف DWG [في هذا PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **تحويل ملفات DWG إلى PDF**

الخطوات البسيطة التالية مطلوبة لتحويل [DWG](https://docs.fileformat.com/cad/dwg/) إلى [PDF](https://docs.fileformat.com/pdf/).

1. تحميل ملف DWG في مثيل من [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. إنشاء كائن من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) وتعيين الخصائص [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) و[**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. إنشاء كائن من فئة [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) وتعيين خاصية [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. استدعاء [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) مع تمرير كائن من [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) كمعامل ثان.

يوضح نموذج الكود أدناه كيفية تصدير رسومات DWG إلى PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToPDF-ExportToPDF.cs" >}}

### **إنشاء PDF واحد بأحجام تخطيط مختلفة**

يسمح لك Aspose.CAD لـ .NET بتحويل ملف DWG إلى PDF واحد بأحجام تخطيط مختلفة. تعمل هذه الطريقة على النحو التالي:

1. تحميل ملف DWG باستخدام طريقة المصنع [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. إنشاء مثيل من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) وتعيين ارتفاع الصفحة الناتج وعرضها.
1. إضافة [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/layoutpagesizes) المطلوبة لكائن [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. إنشاء مثيل من فئة [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) وتعيين خاصية [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. تصدير الصورة إلى PDF باستخدام طريقة [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

يوضح نموذج الكود أدناه كيفية إنشاء [PDF](https://docs.fileformat.com/pdf/) واحد بتخطيطات مختلفة.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.cs" >}}

### **البدائل المدعومة في AutoCAD**

تدعم البدائل التالية من AutoCAD.

- TEXT
- MTEXT
- ATTDEF
- ATTRIB
- ARC
- ELLIPSE
- HATCH
- LEADER
- POINT
- VERTEX 2D
- VERTEX 3D
- POLYLINE 2D
- LWPOLYLINE
- RAY
- CIRCLE
- DIMENSION ORDINATE
- DIMENSION LINEAR
- DIMENSION ALIGNED
- DIMENSION ANG 3Pt
- DIMENSION ANG 2Ln
- DIMENSION RADIUS
- DIMENSION DIAMETER
- SHAPE
- SOLID
- SPLINE
- MLINE
- LINE
- XLINE
- STYLE
- DIMSTYLE
- LTYPE
- MLINESTYLE
- LAYER
- VIEWPORT
- LAYOUT

## **تصدير تخطيط DWG محدد إلى PDF**

تعمل هذه الطريقة على النحو التالي:

1. تحميل ملف DWG باستخدام طريقة المصنع [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. إنشاء مثيل من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) وتعيين ارتفاع الصفحة الناتج وعرضها.
1. تعيين خاصية [**Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) لكائن [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. إنشاء مثيل من فئة [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) وتعيين خاصية [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. تصدير الصورة إلى PDF باستخدام طريقة [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

يوضح نموذج الكود أدناه كيفية تحويل تخطيط معين من DWG إلى PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **عرض مستند DWG عن طريق تحديد الإحداثيات**

يوفر Aspose.CAD لـ .NET API الآن ميزة عرض مستندات DWG من خلال تقديم إحداثيات عرض وارتفاع المستند.

يوضح نموذج الكود أدناه كيفية عرض مستند DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-RenderDWGDocument-RenderDWGDocument.cs" >}}

## **تصدير DWG إلى صورة نقطية أو PDF باستخدام حجم ثابت**

يمكن لـ Aspose.CAD لـ .NET API تحميل رسومات AutoCAD بتنسيق DWG وتحويلها إلى PDF أو صورة نقطية باستخدام حجم ثابت.

يوضح نموذج الكود أدناه كيفية تنفيذ هذه الميزة.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.cs" >}}

## **تصدير DWG إلى PDF/A و PDF/E**

تعمل هذه الطريقة على النحو التالي:

1. تحميل ملف DWG باستخدام طريقة المصنع [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. إنشاء مثيل من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. إنشاء مثيل من فئة [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) وتعيين خاصية [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. تعيين خاصية الامتثال لـ PDF وحفظها.
1. تصدير الصورة إلى PDF باستخدام طريقة [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

يوضح نموذج الكود أدناه كيفية تحويل ملف DWG إلى PDF/A و PDF/E.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-DWGToCompliancePDF-DWGToCompliancePDF.cs" >}}

## **دعم الخطوط المخفية المنحنية عند تصدير DWG/DXF إلى BMP و PDF**

تعمل هذه الطريقة على النحو التالي:

1. تحميل ملف DWG باستخدام طريقة المصنع [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. إنشاء مثيل من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) وتعيين ارتفاع الصفحة الناتج وعرضها.
1. إنشاء مثيل من فئة [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) وتعيين خاصية [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. تصدير الصورة إلى PDF باستخدام طريقة [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

يوضح نموذج الكود أدناه كيفية تنفيذ هذه الميزة.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-SupportForHiddenLines-SupportForHiddenLines.cs" >}}

## **دعم تعيين منطقة الطباعة لصورة DWG في PDF المصدرة**

يمكن لـ Aspose.CAD لـ .NET API تحميل رسومات AutoCAD بتنسيق DWG وتحويلها إلى PDF. يشرح هذا الموضوع استخدام واجهة برمجة تطبيقات Aspose.CAD لتحقيق الدعم لتعيين منطقة الطباعة لصورة DWG في PDF المصدرة.

يوضح نموذج الكود أدناه كيفية تنفيذ هذه الميزة.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **دعم قراءة بيانات XREF الوصفية لملف DWG**

1. تحميل ملف DWG باستخدام طريقة المصنع [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. التنقل من خلال كل كيان صورة.
1. إذا كان الكائن هو CadUnderlay، فإن كائن XREF مع البيانات الوصفية.

يوضح نموذج الكود أدناه كيفية تحقيق هذه الميزة.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ReadXREEFMetaData-ReadXREEFMetaData.cs" >}}

خاصية [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) هي من نوع مصفوفة سلسلة لذا يمكنك تحديد أكثر من تخطيط واحد في نفس الوقت للتحويل المحتمل إلى تنسيق PDF. عند تحديد تخطيطات متعددة لخاصية [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts)، سيكون لدى PDF الناتج صفحات متعددة، حيث تمثل كل صفحة تخطيط AutoCAD فردي.

### **قائمة جميع التخطيطات**

يمكنك إدراج جميع التخطيطات الموجودة في رسم AutoCAD باستخدام نموذج الكود التالي.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-ListLayouts-ListLayouts.cs" >}}

### **الوصول إلى علامات تحتية لتنسيق DWG**

لقد نفذ Aspose.CAD لـ .NET علامات تحتية لتنسيق DWG ويسمح للمطورين بالوصول إليها. فيما يلي توضيح بسيط بالشفرة.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.cs" >}}

## **دعم كيانات DWG**

يمكن لـ Aspose.CAD لـ .NET API تحميل رسومات AutoCAD بتنسيق DWG ودعم كيانات مختلفة للعمل معها.

### **دعم كيان MLeader**

يعتبر DWG ملفًا ثنائيًا يحتوي على بيانات صورة متجهية وبيانات وصفية. هناك كيانات مختلفة في ملف DWG. يصف القسم التالي مثالاً للعمل مع كيان MLeader داخل ملف DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.cs" >}}

### **دعم تصدير كيان DWG إلى صورة**

يعتبر DWG ملفًا ثنائيًا يحتوي على بيانات صورة متجهية وبيانات وصفية. هناك كيانات مختلفة في ملف DWG. يصف القسم التالي مثالاً لتصدير كيان DWG معين إلى صورة.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ParticularDWGToImage-ParticularDWGToImage.cs" >}}

## **دعم إضافة نص إلى DWG**

يمكن لـ Aspose.CAD لـ .NET API تحميل رسومات AutoCAD بتنسيق DWG ودعم كيانات مختلفة للعمل معها. يُعتبر DWG ملفًا ثنائيًا يحتوي على بيانات صورة متجهية وبيانات وصفية. هناك كيانات مختلفة في ملف DWG. يصف القسم التالي كيف يمكننا إضافة نص داخل ملف DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-AddTextInDWG-AddTextInDWG.cs" >}}

## **دعم استيراد صورة إلى ملف DWG**

يمكن لـ Aspose.CAD لـ .NET API تحميل رسومات AutoCAD بتنسيق DWG ودعم كيانات مختلفة للعمل معها. يُعتبر DWG ملفًا ثنائيًا يحتوي على بيانات صورة متجهية وبيانات وصفية. هناك كيانات مختلفة في ملف DWG. يصف القسم التالي كيف يمكننا استيراد الصور داخل ملف DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DWG-Drawings-ImportImageToDWG-ImportImageToDWG.cs" >}}

## **دعم الشبكة في DWG**

يمكن لـ Aspose.CAD لـ .NET API الآن الوصول إلى الكيانات التي تدعم الشبكة والتي تشمل نوع [**CadPolyFaceMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolyfacemesh) ونوع [**CadPolygonMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolygonmesh). يصف المثال التالي كيف يمكننا الوصول إلى أنواع الشبكة.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-MeshSupportForDWG-MeshSupportForDWG.cs" >}}

## **تحويل رسومات DWG إلى DXF**

توفر Aspose.CAD ميزة تحميل ملف AutoCAD DWG وتصديره إلى تنسيق DXF. تعمل طريقة تحويل DWG إلى DXF كما يلي:

1. تحميل ملف رسم DWG باستخدام طريقة المصنع [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. تصدير الرسم DWG إلى DXF باستخدام طريقة [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

يوضح نموذج الكود أدناه كيفية تحويل ملف DWG إلى تنسيق DXF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-DWGToDXF-DWGToDXF.cs" >}}

## **تحويل رسومات DWG إلى SVG**

يمكن لـ Aspose.CAD لـ .NET API تحميل رسومات AutoCAD بتنسيق DWG وتحويلها إلى SVG. يشرح هذا الموضوع استخدام واجهة برمجة تطبيقات Aspose.CAD لتحقيق تحويل DWG إلى تنسيق SVG من خلال خطوات بسيطة كما هو موضح أدناه.

1. تحميل ملف DWG في مثيل من [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. إنشاء كائن من فئة [**SvgOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/svgoptions) وتعيين الخصائص المطلوبة.
1. تصدير رسم DWG إلى SVG باستخدام طريقة [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

يوضح نموذج الكود أدناه كيفية تحويل ملف DWG إلى تنسيق SVG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToSVG-ExportToSVG.cs" >}}

## **تحميل ملف DWG كبير**

يوفر Aspose.CAD لـ .NET وسيلة لفتح ملفات DWG كبيرة جدًا باستخدام فئة [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image). يمكنك الآن فتح الملفات الكبيرة بسهولة بمساعدة نموذج الشيفرة المعطى أدناه.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-LargeDWGToPDF-LargeDWGToPDF.cs" >}}