---
title: Mått
type: docs
weight: 40
url: /sv/java/developer-guide/measurements/
---

## **Area- och längdmätningar**

Vissa entiteter stöder beräkning av area och längd (omkrets): CIRKEL, ELLIPS, BÅGE och LWPOLYLINE. Dessutom stöder POLYLINE-entiteten beräkning av längd men inte area. Andra entiteter kastar NotImplementedException.

Här är ett exempel på hur man beräknar längd och area:

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
