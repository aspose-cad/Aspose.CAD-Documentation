---
title: تصدير خطوط SHX
type: docs
weight: 40
url: /ar/net/export-shx-fonts/
---

## **تصدير خطوط SHX لرسومات DXF/DWG**

بعض الرسومات قد تحتوي على خطوط بتنسيق SHX الخاص، والذي يخزن رموز الخط في شكل أشكال. يتطلب هذا التنسيق إجراء تحميل إضافي لكل خط مستخدم في الرسم. يمكن لـ Apose.CAD تصدير الرسومات مع نص مكتوب بخط SHX ويوفر خيارات مختلفة للقيام بذلك. أسهل طريقة للقيام بذلك هي استخدام 
[**ShxFonts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/shxfonts/) الخاصية من 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) كائن.
				

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "مثال ShxFonts.cs">}}


يمكن تجنب إعداد جميع المسارات إلى خطوط SHX المتعددة مع المثال التالي:

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "مثال ShxFonts مع المجلد.cs">}}
	
كل خط SHX يأتي مع ملف التعريف المناسب المرتبط به. هذه الارتباطات معروفة وجزئياً مضمنة في Aspose.CAD لخطوط SHX المعروفة.
في حالة استخدام خط SHX مخصص، من الممكن تطبيق خاصية ShxCodePages وإعداد المسار إلى ملف SHX و ملف التعريف المقابل. 
	
{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "مثال ShxCodePages.cs">}}
