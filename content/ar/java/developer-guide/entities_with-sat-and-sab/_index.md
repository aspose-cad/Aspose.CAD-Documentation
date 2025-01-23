---
title: الكيانات ذات بنية SAT/SAB
type: docs
weight: 40
url: /ar/java/support-sat-sab/
---

## **الكائنات ذات بنية SAT/SAB**

تقوم بعض الكيانات بتخزين بياناتها الهيكلية في تنسيق ACIS SAT/SAB. يمكن تصدير هذه الكيانات جزئيًا في وضع السلك ثنائي الأبعاد. تشمل الكيانات المدعومة:

*	أجسام 3DSOLID: صندوق، كرة، هرم، إسفين، مخروط، أسطوانة، حلقة، بوليسوليد
*	سطح: مسطح، ممدد، مقلوب، مسحوب
*	منطقة

فيما يلي مثال على نتيجة التصدير (ملف DWG في الجزء الأيسر، ونتيجة PDF في الجزء الأيمن).

![تصدير مخروط وكريات](coneAndSpheres.png)

لا يتطلب تصدير كيانات ACIS أي خيارات خاصة. لتحسين حجم الرسم، خاصة عندما يحتوي الرسم على كيانات ACIS فقط، يجب النظر في استخدام الدالة cadImage.updateSize() لضبط أبعاد الرسم الأولية بدقة.

```java
CadImage cadImage = (CadImage)Image.load(sourceFilePath);

cadImage.updateSize();
	
CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
rasterizationOptions.setLayouts(new String[]{"Model"});

PdfOptions pdfOptions = new PdfOptions();
pdfOptions.setVectorRasterizationOptions(rasterizationOptions);

cadImage.save("output.pdf", pdfOptions);
```
