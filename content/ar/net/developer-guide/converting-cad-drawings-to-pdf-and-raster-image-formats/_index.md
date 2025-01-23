---
title: DWG DXF إلى PDF C# | تحويل ملفات أوتوكاد إلى PDF JPEG PNG في C# .NET
type: docs
weight: 30
url: /ar/net/converting-cad-drawings-to-pdf-and-raster-image-formats/
keywords: "DWG إلى PDF C#, DXF إلى PDF C#, DWF DWT إلى PDF C#, تحويل أوتوكاد, تحويل DWG, تحويل DWF, تحويل DWT, تحويل DXF, تحويل أوتوكاد إلى PDF, تحويل DWG إلى PDF, تحويل DWG إلى PNG, تحويل DWG إلى TIFF, تحويل DWG إلى JPG"
description: استخدم محول C# .NET أوتوكاد إلى PDF لتحويل DWG أو DXF إلى PDF في C#. يمكنك تحويل DWG و DWF و DWT و DXF إلى PDF و JPEG و PNG و BMP و GIF و TIFF في C# .NET أيضًا.
---

## **تحويل DWG أو DXF إلى PNG JPEG BMP GIF أو TIFF في C#**

يمكن لـ Aspose.CAD لـ .NET تحويل تنسيقات رسومات أوتوكاد مثل [DXF](https://docs.fileformat.com/cad/dxf/) و [DWG](https://docs.fileformat.com/cad/dwg/) إلى [PNG](https://docs.fileformat.com/image/png/)، [BMP](https://docs.fileformat.com/image/bmp/)، [TIFF](https://docs.fileformat.com/image/tiff/)، [JPEG](https://docs.fileformat.com/image/jpeg/) و [GIF](https://docs.fileformat.com/image/gif/). لديها واجهة برمجة تطبيقات فعالة وسهلة الاستخدام لتحقيق هذا الهدف.

يمكنك تحويل أي تنسيق رسم أوتوكاد مدعوم إلى تنسيقات صور نقطية باستخدام الخطوات البسيطة التي توضح أدناه.

1. قم بتحميل ملف DWG أو DXF لأوتوكاد في فئة [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. أنشئ مثيلًا من [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. قم بتعيين/تغيير حجم الصورة باستخدام [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) و [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight)
1. أنشئ مثيلًا من [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase)
1. قم بتعيين خاصية [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) إلى [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) التي تم إنشاؤها في الخطوة السابقة.
1. احفظ رسم أوتوكاد كـ PDF باستخدام [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) عن طريق تمرير مسار الملف (أو كائن من نوع MemoryStream) بالإضافة إلى مثيل من [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase) تم إنشاؤه في الخطوة السابقة.

إليك الرمز المصدر الكامل.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertDrawingToRasterImage-ConvertDrawingToRasterImage.cs" >}}

بشكل افتراضي، تقوم واجهة برمجة التطبيقات برسم فقط تخطيط "النموذج". ومع ذلك، يمكنك أيضًا تحديد تخطيطات من اختيارك أثناء تحويل رسومات CAD إلى تنسيقات صور.

## **تخصيص تحويل CAD**

إجراءات تحويل CAD إلى [PDF](https://docs.fileformat.com/pdf/) و CAD إلى صور نقطية قابلة للتكوين بدرجة كبيرة لأن فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) تم تنفيذها بطريقة توفر العديد من الميزات الاختيارية التي عند ضبطها يمكن أن تتجاوز عملية الرسم وفقًا لاحتياجات التطبيق.

### **فئة CadRasterizationOptions**

فئة **CadRasterizationOptions** شائعة لجميع التنسيقات المدعومة لـ CAD مثل DWG و DXF لذلك، المعلومات المشتركة في هذه المقالة صحيحة لكلا التنسيقتين السابقتين.

أكثر الخصائص المفيدة لفئة **CadRasterizationOptions** هي:

|**الخاصية**|**القيمة الافتراضية**|**مطلوب**|**الوصف**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|نعم|تحدد عرض الصفحة.|
|**PageHeight**|**0**|نعم|تحدد ارتفاع الصفحة|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|لا|تحدد ما إذا كان يجب تغيير حجم الرسم تلقائيًا. القيمة الافتراضية تقلل حجم الصورة تلقائيًا لتناسب حجم اللوحة. انتقل إلى وضع **GrowToFit**، أو استخدم إعداد **None** لتعطيل تغيير الحجم التلقائي.|
|**BackgroundColor**|**Color.White**|لا|تحدد لون خلفية الصورة الناتجة.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|لا|تحدد وضع تلوين الكيان. حدد الخيار **UseObjectColor** لرسم الكيانات باستخدام لونها الأصلي، أو الخيار **UseDrawColor** لتجاوز الألوان الأصلية.|
|**DrawColor**|**Color.Black**|لا|تحدد لون الكيان المعطى (فقط إذا كانت **DrawType** تعيين إلى قيمة خاصية **UseDrawColor**).|
|**AutomaticLayoutsScaling**|False|لا|تحدد ما إذا كان يجب إجراء تغيير حجم تلقائي لضبط تخطيط النموذج.|

### **تعيين حجم اللوحة ووضع الرسم**

التصدير من CAD إلى PDF أو CAD إلى تنسيقات الصور النقطية ليس مهمة بسيطة. نظرًا لأن PDF الناتج أو الصورة يتطلب تحديد حجم اللوحة، نحتاج إلى تحديد أبعاد الإخراج لصفحة PDF لرسم الصورة بشكل صحيح. قم بتعيين خصائص **CadRasterizationOptions.PageWidth** و **CadRasterizationOptions.PageHeight** بشكل صريح، أو قد تحصل على **ImageSaveException**.

بالإضافة إلى ذلك، يمكنك تحديد خيارات مقياس البعد. يتم تعيين خيارات تغيير الحجم بواسطة خاصية **CadRasterizationOptions.ScaleMethod**. استخدم هذا الخيار لضبط أبعاد الصورة تلقائيًا وفقًا للقيم **CadRasterizationOptions.PageWidth** و **CadRasterizationOptions.PageHeight**. بشكل افتراضي، يتم تعيين **CadRasterizationOptions.ScaleMethod** على وضع **ScaleType.ShrinkToFit**. تعرف هذه الخاصية على السلوك التالي:

- إذا كانت أبعاد رسم CAD أكبر من حجم اللوحة الناتج، فسيتم تقليل أبعاد الرسم لتناسب حجم اللوحة الناتج مع الحفاظ على نسبة العرض إلى الارتفاع.
- إذا كانت أبعاد رسم CAD أصغر من حجم اللوحة الناتج، قم بتعيين خاصية **CadRasterizationOptions.ScaleMethod** إلى **ScaleType.GrowToFit** لزيادة حجم الرسم ليتناسب مع لوحة PDF مع الحفاظ على نسبة العرض إلى الارتفاع.
- أو تعطيل تغيير الحجم التلقائي باستخدام خيار **ScaleType.None**.

يعرض نموذج التعليمات البرمجية أدناه خيار تغيير الحجم التلقائي قيد الاستخدام.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingCanvasSizeAndMode-SettingCanvasSizeAndMode.cs" >}}

### **تعيين ألوان الخلفية والرسم**

بشكل افتراضي، يتم تعيين لوحة الألوان للوحة الناتجة على المخطط المشترك للمستند. وهذا يعني أن جميع الكيانات داخل رسم CAD يتم رسمها بقلم باللون الأسود على خلفية بيضاء صلبة. يمكن تغيير هذه الإعدادات باستخدام خصائص **CadRasterizationOptions.BackgroundColor** و **CadRasterizationOptions.DrawColor**. يتطلب تغيير خاصية **CadRasterizationOptions.DrawColor** أيضًا تعيين خاصية **CadRasterizationOptions.DrawType** للاستفادة من لون الرسم المستخدم. تتحكم خاصية **CadRasterizationOptions.DrawType** في ما إذا كانت كيانات CAD تحتفظ بألوانها أم يتم تحويلها إلى ألوان مخصصة. للحفاظ على ألوان الكيانات، حدد **CadRasterizationOptions.DrawType** كـ **CadDrawTypeMode.UseObjectColor**، خلاف ذلك حدد قيمة **CadDrawTypeMode.UseDrawColor**.

يعرض نموذج التعليمات البرمجية أدناه كيفية استخدام خصائص اللون المختلفة.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingBackgroundAndDrawingColors-SettingBackgroundAndDrawingColors.cs" >}}

### **تعيين تغيير الحجم التلقائي للتخطيط**

معظم رسومات CAD تحتوي على أكثر من مخطط واحد مخزنة في ملف واحد، ويمكن أن يحتوي كل تخطيط على أبعاد مختلفة. أثناء رسم مثل هذه الرسومات CAD إلى PDF، قد يحتوي كل صفحة من PDF على تغيير حجم مختلف وفقًا لحجم التخطيط. من أجل جعل عملية الرسم متجانسة، قدمت واجهات برمجة التطبيقات Aspose.CAD خاصية **CadRasterizationOptions.AutomaticLayoutsScaling**. القيمة الافتراضية لها هي **false** ولكن عند تعيينها إلى true، ستحاول واجهة برمجة التطبيقات البحث عن مقياس مناسب لكل تخطيط منفصل ورسمها بطريقة مناسبة من خلال إجراء عملية تغيير حجم تلقائية وفقًا لحجم الصفحة.

إليك كيفية عمل خاصية **CadRasterizationOptions.AutomaticLayoutsScaling** بالتعاون مع خاصية **CadRasterizationOptions.ScaleMethod**.

1. إذا كانت **ScaleMethod** تعيين إلى **ScaleType.ShrinkToFit** أو **ScaleType.GrowToFit** مع تعيين **AutomaticLayoutsScaling** إلى false، فسيتم معالجة جميع المخططات (بما في ذلك النموذج) وفقًا للخيار الأول.
1. إذا كانت **ScaleMethod** تعيين إلى **ScaleType.ShrinkToFit** أو **ScaleType.GrowToFit** مع تعيين **AutomaticLayoutsScaling** إلى true، فسيتم معالجة جميع المخططات (باستثناء النموذج) وفقًا لأبعادها بينما سيتم معالجة النموذج وفقًا للخيار الأول.
1. إذا كانت **ScaleMethod** تعيين إلى **ScaleType.None** مع تعيين **AutomaticLayoutsScaling** إلى true أو false، فلن يتم تنفيذ أي تغيير حجم.

يعرض نموذج التعليمات البرمجية أدناه كيفية تعيين تغيير الحجم التلقائي لتحويل CAD إلى PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingAutoLayoutScaling-SettingAutoLayoutScaling.cs" >}}

## **تحويل تخطيطات أوتوكاد DXF أو DWG إلى PNG أو تنسيقات صور أخرى في C#**

يمكن لواجهة برمجة التطبيقات Aspose.CAD لـ .NET تحويل تخطيطات CAD من التنسيقات المدعومة مثل DXF و DWG إلى PNG BMP TIFF JPEG و GIF. كما توفر واجهة برمجة التطبيقات الدعم لرسم التخطيطات المحددة لرسم CAD إلى طبقات PSD مختلفة.

إليك كيف يمكنك تحقيق ذلك في الخطوات البسيطة التالية.

- قم بتحميل ملف DWG أو DXF لأوتوكاد باستخدام فئة **Image**.
- قم بتعيين/تغيير عرض وارتفاع الصورة.
- قم بتعيين أسماء التخطيط المطلوبة باستخدام خاصية CadRasterizationOptions.Layouts.
- أنشئ مثيلًا من **ImageOptionsBase** وقم بتعيين خاصية **VectorRasterizationOptions** إلى مثيل من **CadRasterizationOptions** الذي تم إنشاؤه في الخطوة السابقة.
- احفظ تخطيط CAD كـ TIFF أو صورة.

إليك الرمز المصدر الكامل.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertLayoutsToRasterImage-ConvertLayoutsToRasterImage.cs" >}}

{{% alert color="primary" %}} 

الخاصية **CadRasterizationOptions.Layouts** هي من نوع مصفوفة سلسلة بحيث يمكنك تعيين أكثر من تخطيط واحد في وقت واحد للتحويل الممكن إلى تنسيقات الصور. عند تحديد عدة تخطيطات لخاصية **CadRasterizationOptions.Layouts**، ستحتوي صورة TIFF الناتجة على صفحات متعددة، وستحتوي صورة GIF على إطارات متعددة وسيكون تنسيق [PSD](https://docs.fileformat.com/image/psd/) له طبقات متعددة، حيث تمثل كل صفحة/إطار/طبقة تخطيط أوتوكاد فرديًا. في حالة اختيار أي تنسيق صورة آخر مثل PNG أو BMP أو JPEG لتخزين النتيجة، فستقوم واجهة برمجة التطبيقات برسم التخطيط الافتراضي فقط؛ وهو "النموذج".

{{% /alert %}}

## **تمكين تتبع عملية رسم CAD**

أدخلت Aspose.CAD سلسلة من الفئات والحقول التعداد الداعمة للمساعدة في تتبع عملية رسم CAD. مع هذه التغييرات، يمكن الآن تحقيق تحويل CAD إلى PDF كما يلي مع تمكين التتبع.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-EnableTrackingForCADRendering-EnableTrackingForCADRendering.cs" >}}

يمكن لتتبع عملية رسم CAD اكتشاف المشكلات المحتملة التالية.

1. معلومات العنوان المفقودة أو التالفة.
1. معلومات التخطيط المفقودة.
1. كيانات الكتلة المفقودة.
1. أنماط الأبعاد المفقودة.
1. الأنماط المفقودة.

## **استبدال الخطوط أثناء تحويل رسومات CAD**

من الممكن تمامًا أن يستخدم رسم CAD معين خطًا محددًا لا يتوفر على الجهاز حيث يتم تحويل CAD إلى PDF أو CAD إلى صورة نقطية. في مثل هذه الحالات، ستقوم واجهة برمجة التطبيقات Aspose.CAD بإثارة استثناء مناسب لتسليط الضوء على الخطوط المفقودة ووقف عملية التحويل لأن واجهة برمجة التطبيقات تتطلب هذه الخطوط لرسم المحتويات بشكل صحيح على PDF أو الصور الناتجة.

تقدم واجهة برمجة التطبيقات Aspose.CAD وسيلة سهلة لاستخدام الآلية لاستبدال الخطوط المطلوبة بالخطوط المتاحة. تعيد خاصية **CadImage.Styles** مثيلًا من **CadStylesDictionary** الذي يحتوي بدوره على **CadStyleTableObject** لكل نمط في رسم CAD، في حين يمكن استخدام **CadStyleTableObject.PrimaryFontName** لتحديد اسم الخط المتاح.

يعرض نموذج التعليمات البرمجية التالي استخدام واجهة برمجة التطبيقات Aspose.CAD لـ .NET لتغيير خط جميع الأنماط في رسم CAD.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SubstitutingFonts-SubstitutingFonts.cs" >}}

من الممكن أيضًا تغيير خط نمط واحد محدد فقط عن طريق الوصول إليه عبر اسم النمط. يعرض نموذج التعليمات البرمجية التالي استخدام هذه الطريقة.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-SubstitutingFonts-SubstitutingFontByName.cs" >}}

## **تحويل طبقات CAD إلى تنسيقات صور نقطية**

قدم Aspose.CAD لـ .NET واجهة فعالة وسهلة الاستخدام لتحديد اسم طبقة CAD المطلوبة ورسمها إلى تنسيقات صور نقطية. إليك كيفية تحقيق ذلك في 5 خطوات بسيطة كما هو موضح أدناه.

1. قم بتحميل ملف CAD في مثيل من **Image** باستخدام الطريقة المصنِعة **Load**.
1. أنشئ مثيلًا من **CadRasterizationOptions** وقم بتعيين خصائصه الإلزامية مثل **PageWidth** و **PageHeight**.
1. أضف اسم الطبقة المطلوب باستخدام طريقة **CadRasterizationOptions.Layers.Add**.
1. أنشئ مثيلًا من **ImageOptionsBase** وقم بتعيين خاصية **VectorRasterizationOptions** إلى مثيل **CadRasterizationOptions** الذي تم إنشاؤه في الخطوة السابقة.
1. استدعِ طريقة **Image.Save** من خلال تمرير مسار الملف (أو كائن من نوع MemoryStream) بالإضافة إلى مثيل **ImageOptionsBase** الذي تم إنشاؤه في الخطوة السابقة.

إليك الرمز المصدر الكامل.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-CADLayersToRasterImageFormats-CADLayersToRasterImageFormats.cs" >}}

### **تحويل جميع طبقات CAD إلى صور منفصلة**

يمكنك الحصول على جميع الطبقات من رسم CAD باستخدام **CadImage.Layers** ورسم كل طبقة إلى صورة منفصلة كما هو موضح أدناه.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-CADLayersToRasterImageFormats-ConvertAllLayersToRasterImageFormats.cs" >}}

## **تحويل طبقات DWF CAD إلى تنسيقات صور نقطية**

قدمت Aspose.CAD لـ .NET وسيلة فعالة وسهلة الاستخدام لتحديد اسم طبقة CAD المطلوبة ورسمها إلى تنسيقات صور نقطية. إليك كيفية تحقيق ذلك في 5 خطوات بسيطة كما هو موضح أدناه.

1. قم بتحميل ملف CAD DWF في مثيل من **Image** باستخدام الطريقة المصنِعة **Load**.
1. أنشئ مثيلًا من **CadRasterizationOptions** وقم بتعيين خصائصه الإلزامية مثل **PageWidth** و **PageHeight**.
1. أضف اسم الطبقة المطلوب باستخدام طريقة **CadRasterizationOptions.Layers.Add**.
1. أنشئ مثيلًا من **ImageOptionsBase** وقم بتعيين خاصية **VectorRasterizationOptions** إلى مثيل من **CadRasterizationOptions** الذي تم إنشاؤه في الخطوة السابقة.
1. استدعِ طريقة **Image.Save** من خلال تمرير مسار الملف (أو كائن من نوع MemoryStream) بالإضافة إلى مثيل **ImageOptionsBase** الذي تم إنشاؤه في الخطوة السابقة.

إليك الرمز المصدر الكامل.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}

تقوم Aspose.CAD لـ .NET مباشرةً بكتابة المعلومات حول واجهة برمجة التطبيقات ورقم الإصدار في المستندات الناتجة. على سبيل المثال، عند رسم المستند إلى PDF، تقوم Aspose.CAD لـ .NET بملء حقل التطبيق بالقيمة 'Aspose.CAD' وحقل منتج PDF بالقيمة، على سبيل المثال، 'Aspose.CAD v 17.10'.

يرجى ملاحظة أنه لا يمكنك توجيه Aspose.CAD لـ .NET لتغيير أو إزالة هذه المعلومات من المستندات الناتجة.