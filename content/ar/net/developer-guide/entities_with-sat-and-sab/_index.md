---
title: الكيانات ذات هيكل SAT/SAB
type: docs
weight: 40
url: /ar/net/support-sat-sab/
---

## **الكيانات ذات هيكل SAT/SAB**

تخزن بعض الكيانات بياناتها الهيكلية في تنسيق ACIS SAT/SAB. يمكن تصدير هذه الكيانات جزئيًا في وضع إطار 2D. تشمل الكيانات المدعومة:

*	أجسام 3DSOLID: صندوق، كرة، هرم، إسفين، مخروط، أسطوانة، طوق، بوليسوليد
*	السطح: مسطح، مُستخرج، مُدور، مُعطى
*	المنطقة

فيما يلي مثال على نتيجة التصدير (ملف DWG في الجزء الأيسر، نتيجة PDF في الجزء الأيمن).

![تصدير المخروط والكرات](/_assets/guide/coneAndSpheres.png)

تصدير كيانات ACIS لا يتطلب أي خيارات خاصة. لتحسين حجم الرسم، خاصة عند احتواء الرسم على كيانات ACIS فقط، يُعتبر استخدام دالة cadImage.UpdateSize() لتعديل أبعاد الرسم الأولية بدقة أمرًا ضروريًا.

```csharp
using (CadImage cadImage = (CadImage)Image.Load(sourceFilePath))
{
	cadImage.UpdateSize();
	
	CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
	rasterizationOptions.Layouts = new string[] { "Model" };

	PdfOptions pdfOptions = new PdfOptions
	{
		VectorRasterizationOptions = rasterizationOptions
	};
	cadImage.Save("output.pdf", pdfOptions);
}
```
