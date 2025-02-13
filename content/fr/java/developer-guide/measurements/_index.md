---
title: Mesures
type: docs
weight: 40
url: /fr/java/developer-guide/measurements/
---

## **Mesures de surface et de longueur**

Certaines entités prennent en charge le calcul de la surface et de la longueur (périmètre) : CIRCLE, ELLIPSE, ARC et LWPOLYLINE. De plus, l'entité POLYLINE prend en charge le calcul de la longueur mais pas de la surface. D'autres entités lancent NotImplementedException.

Voici un exemple sur la façon de calculer la longueur et la surface :

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
