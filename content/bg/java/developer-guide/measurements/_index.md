---
title: Измервания
type: docs
weight: 40
url: /bg/java/developer-guide/measurements/
---

## **Измервания на площ и дължина**

Определени единици поддържат изчисление на площ и дължина (периметър): CIRCLE, ELLIPSE, ARC и LWPOLYLINE. Допълнително, единицата POLYLINE поддържа изчисление на дължина, но не и на площ. Други единици хвърлят NotImplementedException.

Ето пример как да се изчисли дължина и площ:

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
