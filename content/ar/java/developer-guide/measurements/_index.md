---
title: القياسات
type: docs
weight: 40
url: /ar/java/measurements/
---

## **قياسات المساحة والطول**

تدعم كيانات معينة حساب المساحة والطول (المحيط): الدائرة، الإهليلجي، القوس و LWPOLYLINE. بالإضافة إلى ذلك، تدعم كيان POLYLINE حساب الطول ولكن ليس المساحة. الكيانات الأخرى ترمي استثناء NotImplementedException.

إليك المثال حول كيفية حساب الطول والمساحة:

```java
CadImage cadImage = (CadImage)Image.load(sourceFilePath);

for (CadEntityBase cadEntityBase : cadImage.getEntities())
{
	try
	{
		System.out.println(cadEntityBase.getTypeName() + " " + cadEntityBase.getArea() + " " + cadEntityBase.getLength());
	}
	catch (NotImplementedException ex)
	{
		...
	}
}
```
