---
title: Maße
type: docs
weight: 40
url: /de/java/developer-guide/measurements/
---

## **Flächen- und Längenmessungen**

Bestimmte Entitäten unterstützen die Berechnung von Fläche und Länge (Umfang): KREIS, ELLIPSE, BOGEN und LWPOLYLINE. Zusätzlich unterstützt die POLYLINE-Entität die Berechnung der Länge, jedoch nicht der Fläche. Andere Entitäten werfen NotImplementedException.

Hier ist ein Beispiel, wie Länge und Fläche berechnet werden:

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
