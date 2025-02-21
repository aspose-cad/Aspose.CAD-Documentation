---
title: Metingen
type: docs
weight: 40
url: /nl/java/developer-guide/measurements/
---

## **Oppervlakte- en lengtemetingen**

Bepaalde entiteiten ondersteunen de berekening van oppervlakte en lengte (omtrek): CIRCLE, ELLIPSE, ARC en LWPOLYLINE. Daarnaast ondersteunt de POLYLINE-entiteit de berekening van lengte, maar niet van oppervlakte. Andere entiteiten werpen een NotImplementedException.

Hier is een voorbeeld van hoe je lengte en oppervlakte kunt berekenen:

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
