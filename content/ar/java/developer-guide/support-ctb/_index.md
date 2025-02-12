---
title: دعم ملفات CTB
type: docs
weight: 40
url: /ar/java/developer-guide/support-ctb/
---

## **دعم ملفات CTB**

في بعض الأحيان، قد يتم استخدام الألوان ووزن الخطوط وبعض الخيارات الأخرى للرسم ليس فقط من الرسوم نفسها ولكن أيضًا من أنماط الطباعة في ملفات CTB المنفصلة. 
أسهل طريقة لاستخدام هذه المعلومات هي وضع ملفات CTB المقابلة بالقرب من الملف الذي يحتوي على الرسم بتنسيق DWG/DXF وسيم يتم تطبيق المعلومات منها 
بشكل تلقائي أثناء التصدير.

من الممكن أيضًا تحميل جميع ملفات CTB في شكل تدفق باستخدام 
[**setCtbSources**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setCtbSources-java.util.Map-) الخاص ب 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) الكائن.

إليك المثال على كيفية القيام بذلك:
 
{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setCtbSources-example.java">}}
