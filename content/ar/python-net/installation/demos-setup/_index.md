---
title: إعداد العروض التوضيحية
type: docs
weight: 40
url: /ar/python-net/demos-setup/
---

{{% alert color="primary" %}}

يتضمن Aspose.CAD لـ Python عددًا من مشروعات العروض التوضيحية لمساعدتك على البدء.

العروض التوضيحية المقدمة مع Aspose.CAD لـ Python هي عروض توضيحية قياسية لـ Pythons تم تعديلها لإظهار استخدام المصدّرين الجدد.

{{% /alert %}}

لتشغيل عروض Aspose.CAD لـ Python التوضيحية، قم بتنفيذ الخطوات التالية:

1. قم بتنزيل Pythons (على سبيل المثال https://sourceforge.net/projects/python-net/files/archive/). تأكد من تنزيل المشروع المؤرشف بالكامل مع الكود مصدري والعروض التوضيحية، وليس مجرد ملف JAR واحد.
2. فك ضغط المشروع المؤرشف إلى موقع ما على القرص الصلب الخاص بك، على سبيل المثال C:\.
3. انسخ جميع مجلدات العروض التوضيحية من مجلد \samples في **aspose-cad-xx.x.zip** إلى **\InstallDir\demo\samples**، حيث "\InstallDir" هو الموقع الذي قمت بفك ضغط Pythons إليه. هذه الخطوة مطلوبة لأن سكريبتات بناء العروض تعتمد على بنية مجلدات Pythons، وإلا ستحتاج إلى تعديل سكريبتات البناء.
4. انسخ **aspose-cad-pythons-xx.x.jar** من مجلد \lib في **aspose-cad-pythons-xx.x.zip** إلى **\InstallDir\lib**.
5. قم بإعداد أداة بناء Ant ومدير اعتماد Ivy، راجع **\InstallDir\readme.txt**.
6. عدل **build.xml** في **\InstallDir\demo\samples**، وأضف aspose-cad-pythons-xx.x.jar إلى مسار الفئة:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-pythons-xx.xx.jar"/> </path>**.
7. قم بتغيير الدليل الحالي إلى **\InstallDir\demo\hsqldb** وقم بتشغيل سطر الأوامر التالي:
   **ant runServer**
8. قم بتغيير الدليل الحالي إلى أحد عروض Aspose.CAD لـ Python التوضيحية، على سبيل المثال **\InstallDir\demo\samples\charts.ai** وقم بتشغيل الأوامر التالية في سطر الأوامر:
   **ant test** - لإنتاج ملفات التقرير.
9. افتح أحد الوثائق الناتجة للاطلاع عليها، على سبيل المثال **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
