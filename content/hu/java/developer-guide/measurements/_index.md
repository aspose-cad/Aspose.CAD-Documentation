---
title: Mérések
type: docs
weight: 40
url: /hu/java/developer-guide/measurements/
---

## **Terület- és hosszúságmérések**

Bizonyos entitások támogatják a terület és hosszúság (kerület) kiszámítását: KÖR, ELIPSZIS, ÍV és LWPOLYLINE. Ezenkívül a POLYLINE entitás támogatja a hosszúság kiszámítását, de nem a területét. Más entitások NotImplementedException kivételt dobják.

Íme egy példa a hosszúság és terület kiszámítására:

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
