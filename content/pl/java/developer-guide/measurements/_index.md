---
title: Pomiary
type: docs
weight: 40
url: /pl/java/developer-guide/measurements/
---

## **Pomiary powierzchni i długości**

Niektóre encje obsługują obliczenie powierzchni i długości (obwodu): CIRCLE, ELLIPSE, ARC i LWPOLYLINE. Dodatkowo encja POLYLINE obsługuje obliczenie długości, ale nie powierzchni. Inne encje zgłaszają NotImplementedException.

Oto przykład, jak obliczyć długość i powierzchnię:

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
