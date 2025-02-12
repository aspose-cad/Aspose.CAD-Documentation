---
title: تصدير رسم DWG/DXF والتخطيطات إلى حجم محدد
type: docs
weight: 40
url: /ar/java/developer-guide/export-into-size/
---

## **تصدير النموذج وجميع التخطيطات إلى حجم PDF A4**

يتيح لك واجهة برمجة تطبيقات Aspose.CAD تصدير جميع أوراق ملف DWG/DXF إلى حجم PDF المادي المحدد.
يحدد الكود المثال التالي حجم كائن [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions/) لتحقيق حجم PDF المطلوب.
حجم ورقة A4 هو 210x297 مليمتر أو 8.27x11.69 بوصة وتستخدم هذه القيم في الشفرة.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "set-page-size.java">}}

## **تصدير تخطيطات CAD إلى PDF بحجم مختلف**

أحياناً يتطلب الأمر تصدير التخطيط إلى حجمه المادي. المثال أدناه يوضح تصدير الرسم إلى PDF متعدد الصفحات حيث تحتوي كل صفحة على محتوى التخطيط
حجم PDF المادي الخاص بها. يستخدم هذا المثال خاصية [**getLayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#getLayoutPageSizes--).

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "export-different-pages-sizes.java">}}
