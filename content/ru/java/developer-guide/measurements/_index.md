---
title: Измерения
type: docs
weight: 40
url: /ru/java/developer-guide/measurements/
---

## **Измерения площади и длины**

Некоторые объекты поддерживают расчет площади и длины (периметра): КРУГ, ЭЛЛИПС, ДУГА и LWPOLYLINE. Кроме того, объект POLYLINE поддерживает расчет длины, но не площади. Другие объекты вызывают NotImplementedException.

Вот пример того, как рассчитать длину и площадь:

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
