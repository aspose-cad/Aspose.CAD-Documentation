---
title: Měření
type: docs
weight: 40
url: /cs/měření/
---

## **Měření plochy a délky**

Některé entity podporují výpočet plochy a délky (obvodu): KRUŽNICE, ELIPSA, ÚHEL A LWPOLYLINE. Navíc, entita POLYLINE podporuje výpočet délky, ale ne plochy. Jiné entity vyvolají NotImplementedException.

Zde je příklad, jak vypočítat délku a plochu:

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
