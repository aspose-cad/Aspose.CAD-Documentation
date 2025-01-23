---
title: أخطاء الاستدعاء أثناء التصدير والتحميل
type: docs
weight: 40
url: /ar/net/callback-errors-during-export-and-loading/
---

## **مراجعة أخطاء الاستدعاء أثناء التصدير والتحميل**

من الممكن أنه أثناء تصدير أو تحميل الرسمة قد نواجه أخطاء تتعلق ببنية الملف 
(على سبيل المثال: الأقسام في الملف مطلوبة الآن ولكن لم تكن كذلك سابقًا). 
بعضها حرج وفي هذه الحالة يتم رمي الاستثناء، ولكن يمكننا أيضًا تجاهل البعض منها داخليًا وإخطار بذلك باستخدام رسائل الاستدعاء.
على أي حال، تتطلب كل هذه الرسائل انتباهًا لأنها قد تفسر على سبيل المثال الكيانات المفقودة في نتائج التصدير أو تأثيرات أخرى.


### **الأخطاء أثناء التصدير**

هناك حقل RenderResult في [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/)،
الذي يتضمن IsRenderComplete لمعرفة ما إذا كانت هناك أخطاء أثناء التصدير وطباعة معلومات حولها:

{{< gist aspose-com-gists 90b8a0a5ce7d0fc5d8d9a8c5bf4b816d "Render-result-error-messages.cs">}}

### **الأخطاء أثناء التحميل**

قد يتم ملاحظة بعض المشاكل مع الرسومات في وقت سابق من بدء عملية التصدير. 
تُستخدم خاصية [**Errors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/errors/) في
 [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/) لتخزين الرسائل حولها.
تكون خاصية [**IgnoreErrors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/ignoreerrors/) مفيدة لتحديد ما إذا كان 
يجب رمي استثناء على أخطاء التحميل أم لا. 

إليك مثال على استخدام خاصية Errors:

{{< gist aspose-com-gists b4f8af514a57a37e260cf1128011d34d "Errors-in-load-options.cs">}}
