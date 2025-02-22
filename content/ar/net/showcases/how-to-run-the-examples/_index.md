---
title: كيفية تشغيل الأمثلة
type: docs
weight: 70
url: /ar/net/showcases/how-to-run-the-examples/
---

## **متطلبات البرنامج**

يرجى التأكد من أنك تلبي المتطلبات التالية قبل تنزيل وتشغيل الأمثلة.

1. Visual Studio 2010 أو أعلى
1. مثبت حزمة NuGet في Visual Studio. تأكد من تثبيت أحدث إصدار من واجهة برمجة تطبيقات NuGet في Visual Studio. للحصول على تفاصيل حول كيفية تثبيت مثبت حزمة NuGet، يرجى مراجعة https://docs.microsoft.com/en-gb/nuget/install-nuget-client-tools
1. انتقل إلى Tools->Options->NuGet Package Manager->Package Sources وتأكد من تحديد الخيار **nuget.org**
1. يستخدم مشروع المثال ميزة استعادة الحزمة التلقائية من NuGet، لذلك يجب أن يكون لديك اتصال نشط بالإنترنت. إذا لم يكن لديك اتصال نشط بالإنترنت على الجهاز الذي سيتم تشغيل الأمثلة عليه، يرجى مراجعة [التثبيت](/ar/net/installation/) لإضافة مرجع إلى Aspose.CAD.dll في مشروع المثال.

## **تنزيل من GitHub**

توجد جميع أمثلة Aspose.CAD لـ .NET على [GitHub](https://github.com/aspose-cad/Aspose.CAD-for-.NET).

- يمكنك إما استنساخ المستودع باستخدام عميل GitHub المفضل لديك أو تنزيل ملف ZIP من [هنا](https://github.com/aspose-cad/Aspose.CAD-for-.NET/archive/master.zip).
- استخراج محتويات ملف ZIP إلى أي مجلد على جهاز الكمبيوتر الخاص بك. تقع جميع الأمثلة في مجلد **Examples**.
- هناك ملف حل Visual Studio لـ C#.
- تم إنشاء المشاريع في Visual Studio 2013، لكن ملفات الحل متوافقة مع Visual Studio 2010 SP1 أو أعلى.
- افتح ملف الحل في Visual Studio وقم ببناء المشروع.
- في التشغيل الأول، سيتم تحميل التبعيات تلقائيًا عبر NuGet.
- يحتوي مجلد **Data** في المجلد الجذر لـ **Examples** على ملفات الإدخال التي تستخدمها أمثلة CSharp. من الضروري أن تقوم بتنزيل مجلد **Data** جنبًا إلى جنب مع مشروع الأمثلة.
- افتح ملف RunExamples.cs، جميع الأمثلة يتم استدعاؤها من هنا.
- قم بإلغاء تعليق الأمثلة التي ترغب في تشغيلها من داخل المشروع.

يرجى عدم التردد في التواصل معنا عبر منتدياتنا إذا كنت تواجه أي مشكلات في إعداد أو تشغيل الأمثلة.

## **المساهمة**

إذا كنت ترغب في إضافة أو تحسين أحد الأمثلة، نشجعك على المساهمة في المشروع. جميع الأمثلة ومشاريع العرض في هذا المستودع هي مفتوحة المصدر ويمكن استخدامها بحرية في تطبيقاتك الخاصة.

للمساهمة، يمكنك عمل فورك للمستودع، وتحرير كود المصدر وإنشاء طلب سحب. سنقوم بمراجعة التغييرات وسنقوم بتضمينها في المستودع إذا كانت مفيدة.
