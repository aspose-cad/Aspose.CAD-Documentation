---
title: Measurements
type: docs
weight: 40
url: /java/measurements/
---

## **Area and length measurements**

Certain entities support calculation of area and length (perimeter): CIRCLE, ELLIPSE, ARC and LWPOLYLINE. Additionally, POLYLINE entity supports calculation of length but not the area. Other entities throw NotImplementedException.

Here is the example how to calculate length and area:

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

