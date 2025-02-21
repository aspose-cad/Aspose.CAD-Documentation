---
title: Misure
type: docs
weight: 40
url: /it/java/developer-guide/measurements/
---

## **Misure di area e lunghezza**

Alte entità supportano il calcolo di area e lunghezza (perimetro): CIRCLE, ELLIPSE, ARC e LWPOLYLINE. Inoltre, l'entità POLYLINE supporta il calcolo della lunghezza ma non dell'area. Altre entità generano NotImplementedException.

Ecco un esempio di come calcolare lunghezza e area:

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
