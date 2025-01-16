---
title: رسومات DXF
type: docs
weight: 60
url: /ar/net/dxf-drawings/
---

## **تصدير رسومات DXF إلى PDF**

توفر Aspose.CAD ميزة تحميل كائنات رسومات AutoCAD DXF وعرضها كرسومات كاملة بتنسيق PDF. تعمل طريقة تحويل DXF إلى PDF كما يلي:

1. تحميل ملف رسومات DXF باستخدام طريقة المصنع [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. إنشاء كائن من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) وتعيين خصائص [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) و[**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. إنشاء كائن من فئة [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) وتعيين خاصية [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. استدعاء [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) مع تمرير كائن من [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) كمعامل ثاني.

مثال الكود أدناه يوضح كيفية تحويل ملف باستخدام الإعدادات الافتراضية.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFToPDF-ExportDXFToPDF.cs" >}}

### **التنسيقات المدعومة**

في الوقت الحالي، ندعم بالكامل تنسيقات ملفات AutoCAD DXF 2010. الإصدارات السابقة من DXF لا تضمن كونها صحيحة بنسبة 100%. نحن نخطط لتضمين المزيد من التنسيقات والميزات في الإصدارات المستقبلية من Aspose.CAD.

### **الكيانات المدعومة**

في الوقت الحالي، نحن ندعم جميع الكيانات ثنائية الأبعاد الشائعة ومعلماتها الافتراضية الأساسية كما يلي:

1. بعد متوافق
1. بعد زاوي
1. قوس
1. سمة
1. مرجع كتلة
1. دائرة
1. بُعد قطر
1. بيضاوي
1. حشو
1. خط
1. نص متعدد الأسطر
1. بعد متمايز
1. نقطة
1. خط متنوع
1. بعد شعاعي
1. شعاع
1. بعد مدور
1. جدول
1. نص
1. Xline

{{% alert color="primary" %}}

إذا واجهنا أثناء التحليل كيان أو خاصية لا ندعمها، فسيتم تجاهل الكيان أو الخاصية بهدوء.

{{% /alert %}}

### **إدارة الذاكرة**

يمكن استخدام خاصية [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) من فئة [**Cache**](https://reference.aspose.com/cad/net/aspose.cad/cache) للتحكم في إعادة تخصيص الذاكرة. من المرجح أن تحدث إعادة التخصيص للذاكرات مسبقة التخصيص. يمكن أن يحدث ذلك عندما يكتشف النظام أن المساحة المخصصة لن تكون كافية.

- إذا كانت [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) كانت القيمة الافتراضية، **False**، فسيتم إعادة تخصيص المساحة إلى نفس الوسيط.
- عند تعيينها على **True**، لا يمكن أن تتجاوز إعادة التخصيص المساحة القصوى المحددة. في هذه الحالة، يتم تحرير الذاكرة المخصصة الموجودة (التي تتطلب إعادة تخصيص) وتخصيص مساحة ممتدة على القرص.

## **تصدير طبقة معينة من رسومات DXF إلى PDF**

تعمل هذه الطريقة كما يلي:

1. فتح ملف رسومات DXF باستخدام طريقة المصنع [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. إنشاء مثيل من [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) وتحديد الخصائص [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) و[**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. إضافة الطبقات إلى كائن [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. إنشاء مثيل من [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) وتعيين خاصية [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. استدعاء طريقة [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) وتمرير كائن من [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) كمعامل ثانٍ.

مثال الكود أدناه يوضح كيفية تحويل طبقة معينة من DXF إلى PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayerToPDF-ExportDXFSpecificLayerToPDF.cs" >}}

## **عرض ملفات PDF كجزء من رسوم DXF**

تعمل هذه الطريقة كما يلي:

1. تحميل ملف رسومات DXF باستخدام طريقة المصنع [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. إنشاء كائن من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) وتحميل ملفات PDF.
1. تعيين خصائص [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) و[**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. استدعاء [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) وحفظ الملف.

مثال الكود أدناه يوضح كيفية عرض ملفات PDF كجزء من رسومات DXF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

## **تصدير DGN تحت الأرض المضمنة لتنسيق DXF**

توفر Aspose.CAD ميزة تحميل ملفات AutoCAD DXF وتصدير DGN تحت الأرض المضمنة لتنسيق DXF.

مثال الكود أدناه يوضح كيفية تحقيق المتطلبات المحددة.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **الدعم لحفظ ملفات DXF**

توفر Aspose.CAD ميزة تحميل ملفات AutoCAD DXF وإجراء تغييرات عليها وحفظها مرة أخرى كملف DXF.

مثال الكود أدناه يوضح كيفية تحقيق المتطلبات المحددة.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-SaveDXFFiles-SaveDXFFiles.cs" >}}

## **تصدير DXF إلى WMF**

تعمل هذه الطريقة كما يلي:

1. تحميل ملف رسومات DXF باستخدام طريقة المصنع [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. إنشاء كائن من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) وتحميل ملفات PDF.
1. تعيين الخصائص [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) و[**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. استدعاء [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) وحفظ الملف.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportDXFToWMF-ExportDXFToWMF.cs" >}}

## **تصدير تخطيط DXF معين إلى PDF**

تعمل هذه الطريقة كما يلي:

1. فتح ملف رسومات DXF باستخدام طريقة المصنع [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. إنشاء مثيل من [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) وتحديد الخصائص [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) و[**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. تحديد اسم (أسماء) التخطيط المطلوب باستخدام خاصية [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts).
1. إنشاء مثيل من [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) وتعيين خاصية [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. تصدير الرسم إلى PDF من خلال استدعاء الطريقة [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) وتمرير كائن من [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) كمعامل ثانٍ.

مثال الكود أدناه يوضح كيفية تحويل تخطيط معين من DXF إلى PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

{{% alert color="primary" %}}

خاصية [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) من نوع مصفوفة سلسلة لذا يمكنك تحديد أكثر من تخطيط في آن واحد للتحويل المحتمل إلى تنسيق PDF. عند تحديد تخطيطات متعددة لخاصية [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts)، سيكون لدى PDF الناتج صفحات متعددة، حيث تمثل كل صفحة تخطيط AutoCAD فردي.

{{% /alert %}}

## **دعم قطع الكتل**

توفر Aspose.CAD ميزة قطع الكتل. تعمل طريقة قطع الكتل كما يلي:

1. تحميل ملف رسومات DXF باستخدام طريقة المصنع [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. إنشاء كائن من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) وتحميل ملفات PDF.
1. تعيين الخصائص المرغوبة ل [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. استدعاء [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) مع تمرير كائن من [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) كمعامل ثاني وحفظ الملف.

مثال الكود أدناه يوضح كيفية عمل قطع الكتل.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DXF-Drawings-SupportOfBlockClipping-SupportOfBlockClipping.cs" >}}

## **تصدير الصور إلى DXF**

باستخدام Aspose.CAD، يمكنك تصدير الصور إلى تنسيق DXF. باستخدام هذه الطريقة، يمكنك تنفيذ الإجراءات التالية:

1. تعيين خط جديد
1. إخفاء الكيانات
1. تحديث النص

يظهر لك مثال الكود التالي كيفية تنفيذ الإجراءات المذكورة أعلاه.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportImagesToDXF-ExportImagesToDXF.cs" >}}

## **تصدير طبقة معينة من رسومات DXF إلى صورة**

تعمل هذه الطريقة كما يلي:

1. فتح ملف رسومات DXF باستخدام طريقة المصنع [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. إنشاء مثيل من [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) وتحديد الخصائص [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) و[**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. إضافة الطبقات إلى كائن [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. إنشاء مثيل من [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) وتعيين خاصية [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. تصدير الرسم إلى PDF باستخدام الطريقة [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

مثال الكود أدناه يوضح كيفية تحويل طبقة معينة من DXF إلى صورة.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.cs" >}}