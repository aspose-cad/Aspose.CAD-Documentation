---
title: رسومات DXF
type: docs
weight: 60
url: /ar/java/developer-guide/autocad-drawings/dxf-drawings/
---

## **تصدير رسومات DXF إلى PDF**

توفر Aspose.CAD ميزة تحميل كائنات رسم DXF من AutoCAD ورسمها كالرسم الكامل بتنسيق PDF. تعمل طريقة تحويل DXF إلى PDF على النحو التالي:

1. تحميل ملف رسم DXF باستخدام طريقة [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) المصنّعة.
1. إنشاء كائن من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) وضبط خصائص [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) و[**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. إنشاء كائن من فئة [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) وضبط خاصية [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. استدعاء Image.Save مع تمرير كائن من [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) كمعامل ثانٍ.

توضح عينة الكود أدناه كيفية تحويل ملف باستخدام الإعدادات الافتراضية.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFDrawingToPDF-.java" >}}

### **تنسيقات مدعومة**

في الوقت الحالي، ندعم تمامًا تنسيقات ملفات AutoCAD DXF 2010. النسخ السابقة من DXF لا تضمن أن تكون صالحة بنسبة 100%. نحن نخطط لتضمين المزيد من التنسيقات والميزات في الإصدارات المستقبلية من Aspose.CAD.

### **الكائنات المدعومة**

في الوقت الحالي، ندعم جميع الكائنات ثنائية الأبعاد الشائعة والمعلمات الأساسية الافتراضية الخاصة بها كما يلي:

1. الأبعاد المتوافقة
1. الأبعاد الزاوية
1. القوس
1. السمة
1. مرجع الكائن
1. الدائرة
1. بعد القطر
1. الشكل البيضاوي
1. التظليل
1. الخط
1. النص متعدد الخطوط
1. بعد الإحداثيات
1. النقطة
1. الخط المتعدد
1. بعد شعاعي
1. الأشعة
1. بعد الدوران
1. الجدول
1. النص
1. الخط المستقيم

{{% alert color="primary" %}}

إذا واجهنا أثناء التحليل كائنًا أو خاصية لا ندعمها، فسيتم تجاهل الكائن أو الخاصية بهدوء.

{{% /alert %}}

### **إدارة الذاكرة**

يمكن استخدام خاصية [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) للتحكم في إعادة تخصيص الذاكرة. من المرجح أن يحدث إعادة التخصيص في ذاكرات التخزين المخصصة مسبقًا. يمكن أن يحدث ذلك عندما يكتشف النظام أن المساحة المخصصة لن تكون كافية.

- إذا كانت [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) مضبوطًة على القيمة الافتراضية، **False**، فإن المساحة تُعاد تخصيصها على نفس الوسيط.
- عند ضبطها على **True**، لا يمكن أن تتجاوز إعادة التخصيص المساحة المحددة القصوى. في هذه الحالة، تتم إزالة الكاش المخصص في الذاكرة الموجودة (التي تتطلب إعادة تخصيص) ويتم تخصيص مساحة ممتدة على القرص.

## **تصدير طبقة محددة من رسومات DXF إلى PDF**

تعمل هذه الطريقة على النحو التالي:

1. فتح ملف رسم DXF باستخدام طريقة [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) المصنّعة.
1. إنشاء مثيل من [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) وتحديد خصائص [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) و[**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. إضافة الطبقات إلى كائن [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. إنشاء مثيل من [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) وضبط خاصية [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. تصدير الرسم إلى PDF باستخدام طريقة [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

توضح عينة الكود أدناه كيفية تحويل طبقة محددة من DXF إلى PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificLayerOfDXFDrawingToPDF-.java" >}}

## **تصدير طبقة محددة من رسومات DXF إلى صورة**

تعمل هذه الطريقة على النحو التالي:

1. فتح ملف رسم DXF باستخدام طريقة [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) المصنّعة.
1. إنشاء مثيل من [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) وتحديد خصائص [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) و[**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. إضافة الطبقات إلى كائن [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions)
1. إنشاء مثيل من [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) وضبط خاصية [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. تصدير الرسم إلى PDF باستخدام طريقة [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

توضح عينة الكود أدناه كيفية تحويل طبقة محددة من DXF إلى صورة.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.java" >}}

## **عرض ملفات PDF كجزء من رسومات DXF**

تعمل هذه الطريقة على النحو التالي:

1. تحميل ملف رسم DXF باستخدام طريقة [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) المصنّعة.
1. إنشاء كائن من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) ورفع ملفات PDF.
1. ضبط خصائص [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) و[**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. استدعاء [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) وحفظ الملف.

توضح عينة الكود أدناه كيفية عرض ملفات PDF كجزء من رسومات DXF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-RenderDXFAsPDF-RenderDXFAsPDF.java" >}}

## **تصدير DXF إلى WMF**

تعمل هذه الطريقة على النحو التالي:

1. تحميل ملف رسم DXF باستخدام طريقة [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) المصنّعة.
1. إنشاء كائن من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) ورفع ملفات PDF.
1. ضبط خصائص [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) و[**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. استدعاء [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) وحفظ الملف.

توضح عينة الكود أدناه كيفية تصدير DXF إلى WMF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFToWMF-ExportDXFToWMF.java" >}}

## **دعم حفظ ملفات DXF**

توفر Aspose.CAD ميزة تحميل ملفات DXF من AutoCAD وإجراء تغييرات عليها وحفظها مرة أخرى كملف DXF. توضح عينة الكود أدناه كيفية تحقيق المتطلبات المحددة

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SaveDXFFiles-SaveDXFFiles.java" >}}

## **تصدير DGN متضمن تحت لوضع DXF**

توفر Aspose.CAD ميزة تحميل ملفات DXF من AutoCAD وتصدير DGN المضمن لوضع DXF.

توضح عينة الكود أدناه كيفية تحقيق المتطلبات المحددة.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportEmbeddedDGN-ExportEmbeddedDGN.java" >}}

## **تصدير تخطيط DXF محدد إلى PDF**

تعمل هذه الطريقة على النحو التالي:

1. فتح ملف رسم DXF باستخدام طريقة [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) المصنّعة.
1. إنشاء مثيل من [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) وتحديد خصائص [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) و[**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. تحديد اسم التخطيط المرغوب (الأسماء) باستخدام خاصية [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-).
1. إنشاء مثيل من [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) وضبط خاصية [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. تصدير الرسم إلى PDF باستخدام الطريقة [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

توضح عينة الكود أدناه كيفية تحويل تخطيط معين من DXF إلى PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToPDF-.java" >}}

{{% alert color="primary" %}}

خاصية [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) هي من نوع مصفوفة سلاسل النصوص، لذا يمكنك تحديد أكثر من تخطيط واحد في وقت واحد للتحويل المحتمل إلى تنسيق PDF. عند تحديد تخطيطات متعددة لخاصية [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-)، سيكون الملف PDF الناتج متعدد الصفحات، حيث تمثل كل صفحة تخطيط AutoCAD فردي.

{{% /alert %}}

## **الوصول إلى كائنات ATTRIB و MTEXT**

تعمل هذه الطريقة على النحو التالي:

1. فتح ملف رسم DXF باستخدام طريقة [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) المصنّعة.
1. الوصول إلى الكائنات داخل ملف CAD.
1. التحقق من كائنات [**CadEntityTypeName.MTEXT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#MTEXT) و [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT).
1. الإضافة إلى قائمة مؤقتة لمزيد من المعالجة.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-AddAttribMText-AddAttribMText.java" >}}

## **تجزئة كائنات إدراج CAD**

تعمل هذه الطريقة على النحو التالي:

1. فتح ملف **DXF** باستخدام طريقة [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) المصنّعة.
1. الوصول إلى الكائنات داخل ملف CAD.
1. التحقق من كائنات [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT).
1. التحقق من قائمة نوع [**CadBlockEntity**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity).
1. معالجة الكائنات.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-DecomposeCadInsertObject-DecomposeCadInsertObject.java" >}}

## **دعم قص الكتل**

توفر Aspose.CAD ميزة قص الكتل. تعمل طريقة قص الكتل على النحو التالي:

1. تحميل ملف رسم DXF باستخدام طريقة [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) المصنّعة.
1. إنشاء كائن من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) ورفع ملفات PDF.
1. ضبط الخصائص المرغوبة لـ [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. استدعاء [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) مع تمرير كائن من [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) كمعامل ثانٍ وحفظ الملف.

توضح عينة الكود أدناه كيفية عمل قص الكتل.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SupportOfBlockClipping-SupportOfBlockClipping.java" >}}

## **تصدير الصور إلى DXF**

باستخدام Aspose.CAD، يمكنك تصدير الصور إلى تنسيق DXF. باستخدام هذه الطريقة، يمكنك القيام بالإجراءات التالية:

1. ضبط خط جديد
1. إخفاء الكائنات
1. تحديث النص

توضح عينة الكود التالية كيفية تنفيذ الإجراءات المذكورة أعلاه.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-ExportImagesToDXF.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-GetFileExtension.java" >}}