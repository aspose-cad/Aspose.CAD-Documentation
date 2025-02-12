---
title: تصدير رسم DWG/DXF والتخطيطات إلى حجم محدد
type: docs
weight: 40
url: /ar/net/developer-guide/export-into-size/
---

## **تصدير النموذج وجميع التخطيطات إلى حجم PDF A4**

تتيح لك واجهة برمجة تطبيقات Aspose.CAD تصدير جميع أوراق ملف DWG/DXF إلى حجم PDF مادي محدد.

الكود النموذجي التالي يحدد حجم كائن [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) لتحقيق حجم PDF المطلوب. 
حجم ورقة A4 هو 210x297 مليمترًا أو 8.27x11.69 بوصة وتستخدم هذه القيم في الكود.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Calculate sizes for A4.cs">}}

## **تصدير تخطيطات CAD إلى PDF بأحجام مختلفة**

في بعض الأحيان، يكون من الضروري تصدير التخطيط إلى حجمه الفعلي. توضح المثال أدناه تصدير الرسم إلى PDF متعدد الصفحات حيث تحتوي كل صفحة بها محتوى تخطيط على حجم PDF مادي خاص بها. يستخدم هذا المثال خاصية [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/layoutpagesizes/).

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Export to multipage with different pages sizes.cs">}}
