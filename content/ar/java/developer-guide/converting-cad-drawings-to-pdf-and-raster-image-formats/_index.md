---
title: تحويل رسومات CAD إلى PDF وصيغ صور raster
type: docs
weight: 30
url: /ar/java/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
---

{{% alert color="primary" %}} 

Aspose.CAD لـ Java يكتب مباشرة المعلومات حول API ورقم الإصدار في الوثائق الناتجة. على سبيل المثال، عند تحويل المستند إلى PDF، يقوم Aspose.CAD لـ Java بتعبئة حقل التطبيق بقيمة 'Aspose.CAD' وحقل منتج PDF بقيمة، على سبيل المثال 'Aspose.CAD v 17.9'.

يرجى ملاحظة أنه لا يمكنك إرشاد Aspose.CAD لـ Java لتغيير أو إزالة هذه المعلومات من الوثائق الناتجة.

{{% /alert %}} 
## **تحويل رسومات CAD إلى صيغ صور Raster**
Aspose.CAD لـ Java قادر على تحويل تنسيقات رسومات CAD مثل [**DXF**](https://docs.fileformat.com/cad/dxf/) و [**DWG**](https://docs.fileformat.com/cad/dwg/) إلى صيغ صور raster المدعومة مثل [**PNG**](https://docs.fileformat.com/image/png/)، [**BMP**](https://docs.fileformat.com/image/bmp/)، [**TIFF**](https://docs.fileformat.com/image/tiff/)، [**JPEG**](https://docs.fileformat.com/image/jpeg/) و [**GIF**](https://docs.fileformat.com/image/gif/). لقد استخدم Aspose.CAD لـ Java API وسائل فعالة وسهلة الاستخدام لتحقيق هذا الهدف.
يمكنك تحويل أي تنسيق رسومات CAD مدعوم إلى صيغ صور raster باستخدام الخطوات البسيطة الموضحة أدناه.

1. قم بتحميل ملف CAD في مثيل من [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. أنشئ مثيلًا من [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) واضبط خصائصه الإلزامية مثل [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) و [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. أنشئ مثيلًا من **ImageOptionsBase** واضبط خاصية [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) على مثيل **CadRasterizationOptions** الذي تم إنشاؤه في الخطوة السابقة.
1. استدعِ **Image.save** مررًا مسار الملف (أو كائن MemoryStream) بالإضافة إلى مثيل [**ImageOptionsBase**](https://reference.aspose.com/cad/java/com.aspose.cad.class-use/ImageOptionsBase) الذي تم إنشاؤه في الخطوة السابقة.

إليك الشيفرة المصدرية الكاملة.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADDrawingToRasterImageFormat-ConvertCADDrawingToRasterImageFormat.java" >}}



بشكل افتراضي، يقوم API بعرض فقط تخطيط "النموذج". ومع ذلك، يمكنك أيضًا تحديد التخطيطات حسب اختيارك أثناء تحويل رسومات CAD إلى صيغ الصور.
## **تخصيص تحويل CAD**
إجراءات تحويل CAD إلى [PDF](https://docs.fileformat.com/pdf/) وتحويل CAD إلى صورة raster قابلة للتكوين بشكل كبير لأن الفصل [**CadRasterizationOptions**](https://reference.aspose.com/java/cad/com.aspose.cad.imageoptions/CadRasterizationOptions) قد تم تنفيذه بطريقة تقدم العديد من الخصائص الاختيارية التي عند ضبطها يمكن أن تتجاوز عملية العرض وفقًا لاحتياجات التطبيق.
### **فئة CadRasterizationOptions**
فئة [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) شائعة لجميع تنسيقات CAD المدعومة مثل [**DWG**](https://docs.fileformat.com/cad/dwg/) و [DXF](https://docs.fileformat.com/cad/dxf/)، لذلك، المعلومات التي تم مشاركتها في هذه المقالة صالحة لكلا التنسيقين المذكورين أعلاه.

أكثر خصائص **CadRasterizationOptions** فائدة هي:

|**الخاصية**|**القيمة الافتراضية**|**مطلوب**|**الوصف**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|نعم|تحدد عرض الصفحة.|
|**PageHeight**|**0**|نعم|تحدد ارتفاع الصفحة|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|لا|تحدد ما إذا كان ينبغي ضبط الرسم تلقائيًا. القيمة الافتراضية تقوم تلقائيًا بتصغير الصورة لتناسب حجم اللوحة. انتقل إلى وضع **GrowToFit**، أو استخدم الإعداد **None** لتعطيل الضبط التلقائي.|
|**BackgroundColor**|**Color.White**|لا|تحدد لون خلفية الصورة الناتجة.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|لا|تحدد وضع تلوين الكيان. حدد خيار **UseObjectColor** لرسم الكيانات باستخدام لونها الأصلي، أو خيار **UseDrawColor** لتجاوز الألوان الأصلية.|
|**DrawColor**|**Color.Black**|لا|تحدد لون الكيان الذي تم تجاوزه (فقط إذا تم ضبط **DrawType** على قيمة خاصية **UseDrawColor**).|
|**AutomaticLayoutsScaling**|خطأ|لا|تحدد ما إذا كان يجب إجراء ضبط تلقائي لحجم التخطيط ليتناسب مع تخطيط النموذج.|
### **تعيين حجم اللوحة والوضع**
التصدير من CAD إلى PDF أو CAD إلى صيغ صور raster ليس مهمة بسيطة. نظرًا لأن PDF الناتج أو الصورة يحتاج إلى تعريف حجم اللوحة، نحتاج إلى تحديد الأبعاد الناتجة لصفحة PDF لعرض الرسم بشكل صحيح. اضبط خصائص **CadRasterizationOptions.PageWidth** و **CadRasterizationOptions.PageHeight** بشكل صريح، أو قد تحصل على **ImageSaveException**.

بالإضافة إلى ذلك، يمكنك تحديد خيارات مقياس الأبعاد. يتم تعيين خيارات المقياس من خلال خاصية **CadRasterizationOptions.ScaleMethod**. استخدم هذه الخيار لضبط أبعاد الصورة تلقائيًا وفقًا لقيم **CadRasterizationOptions.PageWidth** و **CadRasterizationOptions.PageHeight**. بشكل افتراضي، يتم تعيين **CadRasterizationOptions.ScaleMethod** إلى وضع **ScaleType.ShrinkToFit**. تعرف هذه الخاصية السلوك التالي:

- إذا كانت أبعاد الرسم CAD أكبر من حجم اللوحة الناتج، فإن أبعاد الرسم يتم تقليصها لتناسب في اللوحة الناتجة مع الحفاظ على نسبة الطول إلى العرض.
- إذا كانت أبعاد الرسم CAD أصغر من حجم اللوحة الناتج، اضبط خاصية **CadRasterizationOptions.ScaleMethod** إلى **ScaleType.GrowToFit** لزيادة حجم الرسم ليتناسب مع اللوحة PDF مع الحفاظ على نسبة الطول إلى العرض.
- أو تعطيل الضبط التلقائي باستخدام خيار **ScaleType.None**.

توضح الشيفرة المثال أدناه خيار الضبط التلقائي قيد الاستخدام.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetCanvasSizeAndMode-SetCanvasSizeAndMode.java" >}}




### **تعيين ألوان الخلفية والرسم**
بشكل افتراضي، يتم تعيين لوح الألوان للوحة الناتجة على مخطط وثيقة مشترك. هذا يعني أن جميع الكيانات داخل رسم CAD يتم رسمها بقلم لون أسود على خلفية بيضاء ثابتة. يمكن تغيير هذه الإعدادات باستخدام خصائص **CadRasterizationOptions.BackgroundColor** و **CadRasterizationOptions.DrawColor**. يتطلب تغيير خاصية **CadRasterizationOptions.DrawColor** أيضًا تعيين خاصية **CadRasterizationOptions.DrawType** للاستفادة من لون الرسم الذي سيتم استخدامه. تتحكم خاصية **CadRasterizationOptions.DrawType** فيما إذا كانت كيانات CAD تحتفظ بألوانها الأصلية أو يتم تحويلها إلى ألوان مخصصة. للحفاظ على ألوان الكيانات، حدد **CadRasterizationOptions.DrawType** كـ **CadDrawTypeMode.UseObjectColor**، وإلا، حدد قيمة **CadDrawTypeMode.UseDrawColor**.

توضح الشيفرة المثال أدناه كيفية استخدام خصائص الألوان المختلفة.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetBackgroundAndDrawingColor-SetBackgroundAndDrawingColor.java" >}}




### **تعيين ضبط التخطيط التلقائي**
معظم رسومات CAD تحتوي على أكثر من تخطيط مخزن في ملف واحد، وقد يكون لكل تخطيط أبعاد مختلفة. أثناء تحويل مثل هذه الرسومات CAD إلى PDF، قد يحتوي كل صفحة من PDF على مقياس مختلف وفقًا لحجم التخطيط. لجعل العرض متجانسًا، لقد عرضت Aspose.CAD APIs خاصية **CadRasterizationOptions.AutomaticLayoutsScaling**. قيمتها الافتراضية هي **false** ولكن عند تعيينها على **true**، سيقوم API بمحاولة البحث عن مقياس مطابق لكل تخطيط منفصل ورسمها بطريقة مناسبة من خلال إجراء عملية تغيير الحجم التلقائي وفقًا لحجم الصفحة.

إليك كيفية عمل خاصية **CadRasterizationOptions.AutomaticLayoutsScaling** بالتعاون مع خاصية **CadRasterizationOptions.ScaleMethod**.

1. إذا كانت **ScaleMethod** قيد التعيين إلى **ScaleType.ShrinkToFit** أو **ScaleType.GrowToFit** مع تعيين **AutomaticLayoutsScaling** إلى false، فسيتم معالجة جميع التخطيطات (بما في ذلك النموذج) وفقًا للخيار الأول.
1. إذا كانت **ScaleMethod** قيد التعيين إلى **ScaleType.ShrinkToFit** أو **ScaleType.GrowToFit** مع تعيين **AutomaticLayoutsScaling** إلى true، فسيتم معالجة جميع التخطيطات (باستثناء النموذج) وفقًا لحجمها بينما سيتم معالجة النموذج وفقًا للخيار الأول.
1. إذا كانت **ScaleMethod** قيد التعيين إلى **ScaleType.None** مع تعيين **AutomaticLayoutsScaling** إلى true أو false، فلن يتم إجراء أي تغيير في القياس.

توضح الشيفرة المثال أدناه كيفية تعيين ضبط التخطيط التلقائي لتحويل CAD إلى PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SettingAutoLayoutScaling-SettingAutoLayoutScaling.java" >}}




## **تحويل تخطيطات CAD إلى صيغ صور Raster**
Aspose.CAD لـ Java API قادر على تحويل تخطيطات CAD من التنسيقات المدعومة مثل DXF و DWG إلى صور raster مثل PNG و BMP و TIFF و JPEG و GIF. يوفر API أيضًا الدعم لعرض التخطيطات المحددة لرسم CAD إلى طبقات PSD مختلفة. 
لقد استخدم Aspose.CAD لـ Java API وسائل فعالة وسهلة الاستخدام لتحديد قائمة التخطيطات CAD المطلوبة وعرضها إلى صيغ صور raster. إليك كيفية تحقيق نفس الشيء في 5 خطوات بسيطة كما هو موضح أدناه.

1. قم بتحميل ملف CAD في مثيل من **Image** باستخدام طريقة المصنع **load**.
1. أنشئ مثيلًا من **CadRasterizationOptions** واضبط خصائصه الإلزامية مثل **PageWidth** و **PageHeight**.
1. حدد اسم/أسماء التخطيط المرغوب باستخدام خاصية CadRasterizationOptions.Layouts.
1. أنشئ مثيلًا من **ImageOptionsBase** واضبط خاصيته **VectorRasterizationOptions** على مثيل **CadRasterizationOptions** الذي تم إنشاؤه في الخطوة السابقة.
1. استدعِ **Image.Save** عن طريق تمرير مسار الملف (أو كائن MemoryStream) بالإضافة إلى مثيل **ImageOptionsBase** الذي تم إنشاؤه في الخطوة السابقة.

إليك الشيفرة المصدرية الكاملة.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayoutToRasterImageFormat-ConvertCADLayoutToRasterImageFormat.java" >}}

`  `{{% alert color="primary" %}} 

خاصية **CadRasterizationOptions.Layouts** هي من نوع مصفوفة سلاسل، لذا يمكنك تحديد أكثر من تخطيط في وقت واحد للتحويل المحتمل إلى صيغ الصور. عند تحديد تخطيطات متعددة لخاصية **CadRasterizationOptions.Layouts**، ستكون الصورة الناتجة من نوع TIFF تحتوي على صفحات متعددة، وستكون صورة GIF تحتوي على إطارات متعددة، وسيكون تنسيق PSD يحتوي على طبقات متعددة، حيث تمثل كل صفحة/إطار/طبقة تخطيط AutoCAD الفردي. في حالة تحديد أي تنسيق صورة آخر مثل PNG أو BMP أو JPEG لتخزين النتيجة، فسيقوم API بعرض التخطيط الافتراضي فقط؛ وهو "النموذج".

{{% /alert %}} 
## **تمكين التتبع لعملية عرض CAD**
لقد قدمت Aspose.CAD سلسلة من الفئات وحقول التعداد المساندة للمساعدة في تتبع عملية عرض CAD. مع وضع هذه التغييرات في الاعتبار، يمكن الآن تحقيق تحويل CAD إلى PDF كما يلي مع تمكين التتبع.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-EnableTracking.java" >}}



{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-CadRenderHandler.java" >}}



يمكن أن يكتشف تتبع عملية عرض CAD المشاكل المحتملة التالية.

1. معلومات الرأس المفقودة أو التالفة.
1. معلومات التخطيط المفقودة.
1. كيانات الكتل المفقودة.
1. أنماط الأبعاد المفقودة.
1. الأنماط المفقودة.
## **استبدال الخطوط أثناء تحويل رسومات CAD**
من الممكن تمامًا أن تستخدم رسمة CAD معينة خطًا محددًا غير متوفر على الجهاز حيث تتم عملية تحويل CAD إلى PDF أو CAD إلى صورة raster. في مثل هذه الحالات، ستقوم واجهة برمجة التطبيقات Aspose.CAD بإطلاق استثناء مناسب لتسليط الضوء على الخطوط المفقودة وإيقاف عملية التحويل لأن الواجهة تطلب هذه الخطوط لعرض المحتويات بشكل صحيح على PDF الناتج و/أو الصور.
توفر واجهة برمجة التطبيقات Aspose.CAD طريقة سهلة لاستخدام آلية لاستبدال الخطوط المطلوبة مع الخطوط المتاحة. خاصية **CadImage.Styles** ترجع مثيلًا من **CadStylesDictionary** الذي يحتوي بدوره على **CadStyleTableObject** لكل نمط في رسم CAD، بينما يمكن استخدام **CadStyleTableObject.PrimaryFontName** لتحديد اسم الخط المتاح.

توضح الشيفرة المثال أدناه كيفية استخدام Aspose.CAD لـ Java API لتغيير خط جميع الأنماط في رسم CAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFont-SubstituteFont.java" >}}




من الممكن أيضًا تغيير الخط لنمط معين واحد فقط من خلال الوصول إليه عبر اسم النمط. توضح الشيفرة المثال أدناه كيفية استخدام هذا النهج.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFontOfAParticularStyle-SubstituteFontOfAParticularStyle.java" >}}




## **تحويل طبقات CAD إلى صيغ صور Raster**
قدمت Aspose.CAD لـ Java API وسيلة فعالة وسهلة الاستخدام لتحديد اسم طبقة CAD المطلوبة وعرضها إلى صيغ صور raster. إليك كيفية تحقيق نفس الشيء في 5 خطوات بسيطة كما هو موضح أدناه.

1. قم بتحميل ملف CAD في مثيل من **Image** باستخدام طريقة المصنع **load**.
1. أنشئ مثيلًا من **CadRasterizationOptions** واضبط خصائصه الإلزامية مثل **PageWidth** و **PageHeight**.
1. أضف اسم الطبقة المرغوبة باستخدام الطريقة **CadRasterizationOptions.Layers.add**.
1. أنشئ مثيلًا من **ImageOptionsBase** واضبط خاصيته **VectorRasterizationOptions** على مثيل **CadRasterizationOptions** الذي تم إنشاؤه في الخطوة السابقة.
1. استدعِ الدالة **Image.save** عن طريق تمرير مسار الملف (أو كائن MemoryStream) بالإضافة إلى مثيل **ImageOptionsBase** الذي تم إنشاؤه في الخطوة السابقة.

إليك الشيفرة المصدرية الكاملة.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayerToRasterImageFormat-ConvertCADLayerToRasterImageFormat.java" >}}




### **تحويل جميع طبقات CAD إلى صور منفصلة**
يمكنك الحصول على جميع الطبقات من رسم CAD باستخدام **CadImage.Layers** وتحويل كل طبقة إلى صورة منفصلة كما هو موضح أدناه.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertAllCADLayersToSeparateImages-ConvertAllCADLayersToSeparateImages.java" >}}


## **تحويل طبقات DWF CAD إلى صيغ صور Raster**
قدمت Aspose.CAD لـ Java API وسيلة فعالة وسهلة الاستخدام لتحديد اسم طبقة CAD المطلوبة وعرضها إلى صيغ صور raster. إليك كيفية تحقيق نفس الشيء في 5 خطوات بسيطة كما هو موضح أدناه.

1. قم بتحميل ملف DWF CAD في مثيل من **Image** باستخدام طريقة المصنع **Load**.
1. أنشئ مثيلًا من **CadRasterizationOptions** واضبط خصائصه الإلزامية مثل **PageWidth** و **PageHeight**.
1. أضف اسم الطبقة المرغوبة باستخدام الطريقة **CadRasterizationOptions.Layers.Add**.
1. أنشئ مثيلًا من **ImageOptionsBase** واضبط خاصيته **VectorRasterizationOptions** على مثيل **CadRasterizationOptions** الذي تم إنشاؤه في الخطوة السابقة.
1. استدعِ الدالة **Image.Save** عن طريق تمرير مسار الملف (أو كائن MemoryStream) بالإضافة إلى مثيل **ImageOptionsBase** الذي تم إنشاؤه في الخطوة السابقة.

إليك الشيفرة المصدرية الكاملة.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToBMP-ExportToBMP.java" >}}