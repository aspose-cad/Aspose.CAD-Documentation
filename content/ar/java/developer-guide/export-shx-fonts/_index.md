---
title: تصدير خطوط SHX
type: docs
weight: 40
url: /ar/java/developer-guide/export-shx-fonts/
---

## **تصدير خطوط SHX لرسومات DXF/DWG**

قد تحتوي بعض الرسومات على خطوط بتنسيق SHX الخاص، الذي يخزن رموز الخط في شكل أشكال.
يتطلب هذا التنسيق إجراء تحميل إضافي لكل خط مستخدم في الرسم.
يمكن لـ Apose.CAD تصدير الرسومات التي تحتوي على نص مكتوب بخط SHX ولها خيارات مختلفة للقيام بذلك.
أسهل طريقة للقيام بذلك هي استخدام خاصية [**setShxFonts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setShxFonts-java.lang.String:A-) من كائن [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).	

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxFonts-example.java">}}

يأتي كل خط SHX مع صفحة رموز مناسبة مرتبطة به. هذه الروابط معروفة وجزئياً مدمجة في Aspose.CAD لخطوط SHX المعروفة.
في حالة استخدام خط SHX مخصص، من الممكن تطبيق خاصية **setShxCodePages** وتحديد المسار إلى ملف SHX والصفحة الرمزية المقابلة.	
	
{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxCodePages-example.java">}}
