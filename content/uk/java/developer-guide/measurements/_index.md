---
title: Вимірювання
type: docs
weight: 40
url: /uk/java/developer-guide/measurements/
---

## **Вимірювання площі та довжини**

Деякі сутності підтримують обчислення площі та довжини (периметр): КРУГ, ЕЛЛІПС, ДУГА та LWPOLYLINE. Додатково, сутність POLYLINE підтримує обчислення довжини, але не площі. Інші сутності викликають NotImplementedException.

Ось приклад, як обчислити довжину та площу:

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
