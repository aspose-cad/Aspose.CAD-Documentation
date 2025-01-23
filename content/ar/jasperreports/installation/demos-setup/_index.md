---
title: إعداد العروض التوضيحية
type: docs
weight: 40
url: /ar/jasperreports/demos-setup/
---

{{% alert color="primary" %}}

يتضمن Aspose.CAD لـ JasperReports عددًا من مشاريع العرض التوضيحي لمساعدتك على البدء.

العروض التوضيحية المقدمة مع Aspose.CAD لـ JasperReports هي عروض توضيحية قياسية لـ JasperReports معدلة لعرض استخدام الناشرين الجدد.

{{% /alert %}}

لتشغيل عروض Aspose.CAD لـ JasperReports، قم بإجراء الخطوات التالية:

1. قم بتنزيل JasperReports (مثل https://sourceforge.net/projects/jasperreports/files/archive/). تأكد من تنزيل المشروع المؤرشف بالكامل مع الشفرة المصدرية والعروض التوضيحية، وليس مجرد ملف JAR واحد.
1. قم بفك ضغط المشروع المؤرشف إلى موقع ما على القرص الصلب لديك، على سبيل المثال C:\.
1. انسخ جميع مجلدات العرض التوضيحي من مجلد \samples في **aspose-cad-xx.x.zip** إلى **\InstallDir\demo\samples**، حيث يمثل "\InstallDir" الموقع الذي قمت بفك ضغط JasperReports فيه. هذه الخطوة مطلوبة لأن نصوص بناء العرض التوضيحي تعتمد على بنية مجلدات JasperReports، وإلا ستحتاج إلى تعديل نصوص البناء.
1. انسخ **aspose-cad-jasperreports-xx.x.jar** من مجلد \lib في **aspose-cad-jasperreports-xx.x.zip** إلى **\InstallDir\lib**.
1. جهز أداة بناء Ant ومدير الاعتماديات Ivy، انظر **\InstallDir\readme.txt**.
1. عدل **build.xml** في **\InstallDir\demo\samples**، وأضف aspose-cad-jasperreports-xx.x.jar إلى classpath:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-jasperreports-xx.xx.jar"/> </path>**.
1. غير الدليل الحالي إلى **\InstallDir\demo\hsqldb** وقم بتشغيل سطر الأوامر التالي:
   **Ant runServer**
1. غير الدليل الحالي إلى أحد عروض Aspose.CAD لـ JasperReports، على سبيل المثال **\InstallDir\demo\samples\charts.ai** وقم بتشغيل الأوامر التالية في سطر الأوامر:
   **ant test** - لإنتاج ملفات التقرير.
1. افتح أحد المستندات الناتجة لعرضها، على سبيل المثال **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
