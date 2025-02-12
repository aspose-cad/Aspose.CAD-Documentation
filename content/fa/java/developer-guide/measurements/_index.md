---
title: Measurements
type: docs
weight: 40
url: /fa/java/measurements/
---

## **اندازه‌گیری‌های سطح و طول**

برخی از موجودیت‌ها از محاسبه سطح و طول (محیط) پشتیبانی می‌کنند: CIRCLE، ELLIPSE، ARC و LWPOLYLINE. به‌علاوه، موجودیت POLYLINE از محاسبه طول پشتیبانی می‌کند، اما نه از سطح. سایر موجودیت‌ها استثنای NotImplementedException را پرتاب می‌کنند.

اینجا نمونه‌ای از چگونگی محاسبه طول و سطح آورده شده است:

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
