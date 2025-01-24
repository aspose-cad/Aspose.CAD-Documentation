---
title: التثبيت
type: docs
weight: 30
url: /ar/net/installation/
---

## **تثبيت Aspose.CAD لـ .NET من خلال NuGet**

NuGet هو أسهل طريقة لتنزيل وتثبيت واجهات برمجة تطبيقات Aspose لـ .NET. افتح Microsoft Visual Studio ومدير حزمة NuGet. ابحث عن "aspose" للعثور على واجهة برمجة تطبيقات Aspose المرغوبة. انقر على "تثبيت"، سيتم تنزيل الواجهة المحددة وإضافتها إلى مشروعك.

![todo:image_alt_text](installation_1.png)

## **الإشارة إلى Aspose.CAD من مشروع .NET**

اتبع هذه الخطوات (بافتراض أنك تستخدم Microsoft Visual Studio):

1. في **مستكشف الحلول**، قم بتوسيع عقدة المشروع الذي تريد إضافة إشارة إليه.
1. انقر بزر الماوس الأيمن على عقدة **المراجع** للمشروع واختر **إضافة مرجع** من قائمة السياق.
1. في مربع حوار **إضافة مرجع**، انتقل إلى موقع ملف DLL.
1. حدد ملف *Aspose.CAD* DLL وانقر على زر **موافق**.
1. ستظهر إشارة *Aspose.CAD* تحت عقدة **المراجع** في مشروعك.

![todo:image_alt_text](installation_2.png)

### **تثبيت أو تحديث Aspose.CAD باستخدام وحدة تحكم مدير الحزم**

يمكنك اتباع الخطوات أدناه للإشارة إلى [واجهة برمجة تطبيقات Aspose.CAD](https://www.nuget.org/packages/Aspose.CAD/) باستخدام وحدة تحكم مدير الحزم:

1. افتح الحل / المشروع الخاص بك في Visual Studio.
1. اختر أدوات -> مدير حزمة المكتبة -> وحدة تحكم مدير الحزم من القائمة لفتح وحدة تحكم مدير الحزم.

![todo:image_alt_text](installation_3.png)

اكتب الأمر “**Install-Package Aspose.CAD**” واضغط على Enter لتثبيت أحدث إصدار كامل في تطبيقك. بدلاً من ذلك، يمكنك إضافة لاحقة "**-prerelease**" للأمر لتحديد أنه يجب تثبيت الإصدار الأخير بما في ذلك الإصلاحات العاجلة أيضًا.

![todo:image_alt_text](installation_4.png)

سترى أن نص "جارٍ تنزيل Aspose.CAD..." يظهر في أسفل يسار النافذة، مما يدل على أن التنزيل قيد التقدم.

![todo:image_alt_text](installation_5.png)

بمجرد الانتهاء من التنزيل، سترى رسائل التأكيد التالية. إذا لم تكن لديك دراية بـ [اتفاقية ترخيص Aspose](https://about.aspose.com/legal/eula)، فمن الجيد أن تقرأ الترخيص المشار إليه في الرابط.

![todo:image_alt_text](installation_6.png)

يجب عليك الآن العثور على أن Aspose.CAD قد تمت إضافته وإشارته بنجاح في تطبيقك.

![todo:image_alt_text](installation_7.png)

في وحدة تحكم مدير الحزم، يمكنك أيضًا استخدام الأمر “**Update-Package Aspose.CAD**” واضغط على Enter للتحقق من أي تحديثات لحزمة Aspose.CAD وتثبيتها إذا كانت موجودة. يمكنك أيضًا إضافة لاحقة "-prerelease" لتحديث الإصدار الأخير.

## **الاعتبارات عند التشغيل في بيئة خادم مشتركة**

يُنصح بتشغيل كل مكونات Aspose .NET بإعداد أذونات Full Trust. وذلك لأن مكونات Aspose .NET تحتاج أحيانًا إلى الوصول إلى إعدادات السجل والملفات الموجودة في أماكن أخرى غير الدليل الافتراضي، مثل قراءة الخطوط وما إلى ذلك. علاوة على ذلك، تعتمد مكونات Aspose.NET على الفئات الأساسية لنظام .NET، والتي تتطلب أيضًا في بعض الحالات أذونات Full Trust للتشغيل.

موفرو خدمات الإنترنت الذين يستضيفون تطبيقات متعددة من شركات مختلفة يفرضون في الغالب مستوى أمان Medium Trust. في حالة .NET 2.0، قد يتسبب مستوى الأمان هذا في وضع القيود التالية التي قد تؤثر على قدرة Aspose.CAD على العمل بشكل صحيح.

- **RegistryPermission** غير متاح. هذا يعني أنك لا تستطيع الوصول إلى السجل، وهو مطلوب لعداد الخطوط المثبتة عند عرض الوثائق.
- **FileIOPermission** مقيد. هذا يعني أنه يمكنك فقط الوصول إلى الملفات في تسلسل دليل التطبيق الخاص بك الافتراضي. وهذا يعني أنه قد لا يمكن قراءة الخطوط أثناء التصدير.

لذلك، يُنصح بتشغيل Aspose.CAD بإعدادات أذونات Full Trust. قد تجد أن بعض ميزات المكتبة ستعمل عند تنفيذ مهام مختلفة في مستوى trust المتوسط بينما لن تعمل بعض الميزات الأخرى (مثل العرض)، وهذا قد يرجع إلى المكالمات إلى معالجة الصور باستخدام GDI+.

## **متطلبات النظام**

### **أنظمة التشغيل**

يدعم Aspose.CAD لـ .NET أي نظام تشغيل 32-بت أو 64-بت حيث يتم تثبيت إطار عمل .NET أو Mono، بما في ذلك، على سبيل المثال لا الحصر:

- أنظمة تشغيل سطح مكتب Microsoft Windows (XP، Vista، 7، 8، 10) وأنظمة تشغيل الخادم (2003، 2008، 2012)
- Windows Azure
- Linux (Ubuntu، openSUSE، CentOS وغيرها)
- Mac OS X

### **الأطر**

يدعم Aspose.CAD لـ .NET:

- إصدارات إطار عمل .NET من 2.0 إلى 4.5 بما في ذلك إصدارات ملف التعريف العميل
- .NET Core
- Mono 2.6.7 أو أحدث

### **بيئات التطوير**

يمكنك استخدام Aspose.CAD لـ .NET لتطوير التطبيقات في أي بيئة تطوير تستهدف منصة .NET، لكن البيئات التالية مدعومةExplicitly:

- Microsoft Visual Studio 2010 أو أعلى
- MonoDevelop 2.4 وأحدث