---
title: رسومات DWG
type: docs
weight: 40
url: /ar/java/developer-guide/autocad-drawings/dwg-drawings/
---

## **تصدير رسومات DWG إلى PDF**

يمكن لواجهة برمجة التطبيقات Aspose.CAD الخاصة بجافا تحميل رسومات AutoCAD بتنسيق DWG وتحويلها إلى PDF. يشرح هذا الموضوع استخدام واجهة برمجة التطبيقات Aspose.CAD لتحقيق تحويل DWG إلى تنسيق PDF من خلال خطوات بسيطة تم تعريفها لاحقًا.

{{% alert color="primary" %}}

تدعم واجهة برمجة التطبيقات الإصدارات التالية من AutoCAD DWG:

- إصدار DWG 2004 النسخة 16.0 الإصدار 18
- إصدار DWG 2005 النسخة 16.1
- إصدار DWG 2010 النسخة 18.0
- إصدار DWG 2013 النسخة 19.0

{{% /alert %}}

### **تنسيق ملف DWG**

DWG هو ملف ثنائي يحتوي على بيانات صورة متجهة وبيانات وصفية. توفر بيانات الصورة المتجهة تعليمات لتطبيق CAD حول كيفية عرض DWG؛ قد تحتوي البيانات الوصفية على مجموعة متنوعة من المعلومات حول الملف بما في ذلك البيانات المحددة بالموقع وكذلك بيانات العميل. يمكن العثور على المواصفات المفتوحة لتنسيق ملف DWG [في هذا PDF](https://www.opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **تحويل ملفات DWG إلى PDF**

تتطلب الخطوات البسيطة التالية تحويل DWG إلى PDF.

1. قم بتحميل ملف DWG في مثيل من [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. أنشئ كائن من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) واضبط خصائص [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) و[**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. أنشئ كائن من فئة [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) واضبط خاصية [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. استدعاء [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) وتمرير كائن من [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) كمعامل ثانٍ.

يظهر مثال الكود أدناه كيفية تصدير رسومات DWG إلى PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ConvertDWGFileToPDF-ConvertDWGFileToPDF.java" >}}

### **إنشاء PDF واحد بأحجام تخطيط مختلفة**

يسمح لك Aspose.CAD لجافا بتحويل ملف DWG إلى PDF واحد بأحجام تخطيط مختلفة. تعمل هذه الطريقة على النحو التالي:

1. قم بتحميل ملف DWG باستخدام طريقة المصنع [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. أنشئ مثيل من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) واضبط ارتفاع الصفحة وعرضها الناتج.
1. إضافة [**LayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setLayoutPageSizes-com.aspose.ms.System.Collections.Generic.Dictionary-) المطلوبة لكائن [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. أنشئ مثيل من فئة [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) و اضبط خاصية [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. تصدير الصورة إلى PDF باستخدام الطريقة [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

يظهر مثال الكود أدناه كيفية إنشاء PDF واحد مع تخطيطات مختلفة.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.java" >}}

### **تصدير DWG إلى PDF/A و PDF/E**

تتطلب الخطوات البسيطة التالية تحويل DWG إلى PDF.

1. قم بتحميل ملف DWG في مثيل من [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. أنشئ كائنًا من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) واضبط [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) و [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) .
1. أنشئ كائنًا من فئة [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) واضبط خاصية [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. استدعاء [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) وتمرير كائن من [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) كمعامل ثانٍ.

يظهر مثال الكود أدناه كيفية تصدير رسومات DWG إلى PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToCompliancePDF-DWGToCompliancePDF.java" >}}

### **الكائنات الأساسية المدعومة من AutoCAD**

تدعم الكائنات الأساسية التالية من AutoCAD.

- نص
- نص متعدد
- تعريف الجدول
- خاصية الجدول
- قوس
- بيضاوي
- نمط
- قائد
- نقطة
- رأس 2D
- رأس 3D
- بوليلاين 2D
- بوليلاين خفيفة الوزن
- شعاع
- دائرة
- بعد الترتيب
- بعد خطي
- بعد متوازي
- بعد زاوية 3 نقاط
- بعد زاوية 2 خطوط
- بعد نصف القطر
- بعد القطر
- شكل
- صلب
- منحنى
- خط متعدد
- خط
- خط مؤقت
- نمط
- نمط البعد
- نوع الخط
- نمط خط متعدد
- طبقة
- نقطة العرض
- تخطيط

## **تصدير تخطيط DWG المحدد إلى PDF**

تعمل هذه الطريقة على النحو التالي:

1. قم بتحميل ملف DWG باستخدام طريقة المصنع [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. أنشئ مثيلًا من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) واحدد ارتفاع الصفحة وعرضها الناتجين.
1. اضبط خاصية [**Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) لكائن [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. أنشئ مثيلًا من فئة [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) واحدد خاصية [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. صدّر الصورة إلى PDF باستخدام الطريقة [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

يظهر مثال الكود أدناه كيفية تحويل تخطيط محدد من DWG إلى PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportSpecificDWGLayoutToPDF-ExportSpecificDWGLayoutToPDF.java" >}}

## **تصدير DWG إلى صورة أو PDF باستخدام حجم ثابت**

يمكن لواجهة برمجة التطبيقات Aspose.CAD لجافا تحميل رسومات AutoCAD بتنسيق DWG وتحويلها إلى PDF أو صورة باستخدام حجم ثابت.

يوضح مثال الكود أدناه كيفية تنفيذ هذه الخاصية.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.java" >}}

## **دعم الخطوط المخفية المدورة عند تصدير DWG / DXF إلى BMP و PDF**

تعمل هذه الطريقة على النحو التالي:

1. قم بتحميل ملف DWG باستخدام [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) .
1. أنشئ مثيلًا من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. أنشئ مثيلًا من فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) واضبط ارتفاع الصفحة وعرضها الناتجين.
1. أنشئ مثيلًا من فئة [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) واحدد خاصية [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. صدّر الصورة إلى PDF باستخدام [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

يوضح مثال الكود أدناه كيفية تنفيذ هذه الخاصية.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportForHiddenLines-SupportForHiddenLines.java" >}}

## **دعم تحديد منطقة الطباعة لصورة DWG في PDF المُصدَّر**

يمكن لواجهة برمجة التطبيقات Aspose.CAD لجافا تحميل رسومات AutoCAD بتنسيق DWG وتحويلها إلى PDF. يشرح هذا الموضوع استخدام واجهة برمجة التطبيقات Aspose.CAD لتحقيق دعم تحديد منطقة الطباعة لصورة DWG في PDF المُصدَّر.

يوضح مثال الكود أدناه كيفية تنفيذ هذه الخاصية.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **دعم قراءة بيانات XREF الوصفية لملف DWG**

1. قم بتحميل ملف DWG باستخدام [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) .
1. انتقل عبر كل كيان صورة.
1. إذا كان الكيان هو [**CadUnderlay**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadUnderlay) فإنه يمثل كيان XREF مع بيانات وصفية.

يوضح مثال الكود أدناه كيفية تحقيق هذه الخاصية.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ReadXREEFMetaData-ReadXREEFMetaData.java" >}}

## **مستند DWG بتحديد الإحداثيات**

توفر واجهة برمجة التطبيقات Aspose.CAD لجافا الآن ميزة لتقديم مستندات DWG من خلال تقديم إحداثيات العرض وارتفاع المستند.

يوضح مثال الكود أدناه كيفية تقديم مستند DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-RenderDWGDocument-RenderDWGDocument.java" >}}

تكون خاصية [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#getLayouts--) من نوع مصفوفة سلسلة، لذلك يمكنك تحديد أكثر من تخطيط في وقت واحد للتحويل المحتمل إلى تنسيق PDF. عند تحديد تخطيطات متعددة لخاصية [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) ستحتوي PDF الناتجة على صفحات متعددة، حيث تمثل كل صفحة تخطيط AutoCAD فردي.

### **قائمة جميع التخطيطات**

يمكنك سرد جميع التخطيطات الموجودة في رسم AutoCAD باستخدام مقتطف الكود التالي.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ListAllLayoutsInAnAutoCADDrawing-ListAllLayoutsInAnAutoCADDrawing.java" >}}

## **الحصول على قيمة خاصية الكتلة من المرجع الخارجي**

تسمح واجهة برمجة التطبيقات Aspose.CAD لجافا لك بالحصول على المرجع الخارجي لخاصية الكتلة. تعرض واجهة برمجة التطبيقات Aspose.CAD خاصية [**getXRefPathName()**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity#getXRefPathName--) للحصول على المرجع الخارجي لخاصية كتلة في مجموعة [**CadBlockDictionary**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadBlockDictionary).

يوضح الكود أدناه كيفية الحصول على المرجع الخارجي لخاصية كتلة.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-GetBlockAttributeValueOfExternalReference-GetBlockAttributeValueOfExternalReference.java" >}}

## **البحث عن النص في ملف DWG AutoCAD**

تسمح واجهة برمجة التطبيقات Aspose.CAD لجافا لك بالبحث عن نص في ملف DWG AutoCAD. تعرض واجهة برمجة التطبيقات Aspose.CAD فئة [**CadText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadText) التي تمثل كائنات نصية في ملف DWG AutoCAD. تم تضمين الفئة [**CadMText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadMText) أيضًا في واجهة برمجة التطبيقات Aspose.CAD، حيث قد تحتوي بعض الكائنات الأخرى أيضًا على نص.

يوضح الكود أدناه كيفية البحث عن نص في ملف DWG AutoCAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchTextInDWGAutoCADFile.java" >}}

### **البحث عن النص في تخطيط محدد**

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchForTextInSpecificLayout.java" >}}

### **الوصول إلى علامات المتراكب لتنسيق DWG**

قامت Aspose.CAD لجافا بتنفيذ العلامات المتراكبة لتنسيق DWG وتسمح للمطورين بالوصول إليها. هذه هي عرض الكود البسيط.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.java" >}}

## **دعم كائنات DWG**

يمكن لواجهة برمجة التطبيقات Aspose.CAD لجافا تحميل رسومات AutoCAD بتنسيق DWG ودعم كائنات مختلفة للعمل معها.

### **دعم كائن MLeader**

DWG هو ملف ثنائي يحتوي على بيانات صورة متجهة وبيانات وصفية. هناك كائنات مختلفة في ملف DWG. يصف القسم التالي مثالًا للعمل مع كائن MLeader داخل ملف DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.java" >}}

### **دعم تصدير كائن DWG إلى صورة**

DWG هو ملف ثنائي يحتوي على بيانات صورة متجهة وبيانات وصفية. هناك كائنات مختلفة في ملف DWG. يصف القسم التالي مثالًا لتصدير كائن DWG معين إلى صورة.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ParticularDWGToImage-ParticularDWGToImage.java" >}}

## **دعم استيراد صورة إلى ملف DWG**

يمكن لواجهة برمجة التطبيقات Aspose.CAD لجافا تحميل رسومات AutoCAD بتنسيق DWG ودعم كائنات مختلفة للعمل معها. DWG هو ملف ثنائي يحتوي على بيانات صورة متجهة وبيانات وصفية. هناك كائنات مختلفة في ملف DWG. يصف القسم التالي كيفية استيراد الصور داخل ملف DWG.

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ImportImageToDWG-ImportImageToDWG.java" >}}

## **دعم إضافة نص في DWG**

يمكن لواجهة برمجة التطبيقات Aspose.CAD لجافا تحميل رسومات AutoCAD بتنسيق DWG ودعم كائنات مختلفة للعمل معها. DWG هو ملف ثنائي يحتوي على بيانات صورة متجهة وبيانات وصفية. هناك كائنات مختلفة في ملف DWG. يصف القسم التالي كيفية إضافة نص داخل ملف DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-AddTextInDWG-AddTextInDWG.java" >}}

## **دعم الشبكة في DWG**

يمكن لواجهة برمجة التطبيقات Aspose.CAD لجافا الآن الوصول إلى الكائنات التي تدعم الشبكة والتي تشمل أنواع [**CadPolyFaceMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolyFaceMesh) و[**CadPolygonMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolygonMesh). يصف المثال التالي كيفية الوصول إلى أنواع الشبكة.

## **تحويل رسومات DWG إلى DXF**

توفر Aspose.CAD ميزة تحميل ملف AutoCAD DWG وتصديره إلى تنسيق DXF. تعمل طريقة التحويل من DWG إلى DXF على النحو التالي:

1. قم بتحميل ملف رسم DWG باستخدام طريقة [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) .
1. صدّر رسم DWG إلى DXF باستخدام الطريقة [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

يظهر مثال الكود أدناه كيفية تحويل ملف DWG إلى تنسيق DXF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToDXF-DWGToDXF.java" >}}

## **تحويل رسومات DWG إلى SVG**

يمكن لواجهة برمجة التطبيقات Aspose.CAD تحميل رسومات AutoCAD بتنسيق DWG، وتحويلها إلى SVG. يوضح هذا الموضوع استخدام واجهة برمجة التطبيقات Aspose.CAD لتحقيق تحويل DWG إلى تنسيق SVG من خلال خطوات بسيطة كما هو موضح أدناه.

1. قم بتحميل ملف DWG في مثيل من [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. أنشئ كائنًا من فئة [**SvgOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/SvgOptions) واضبط الخصائص المطلوبة.
1. صدّر الرسم DWG إلى SVG باستخدام الطريقة [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

يوضح مثال الكود أدناه كيفية تحويل ملف DWG إلى تنسيق SVG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportToSVG-ExportToSVG.java" >}}