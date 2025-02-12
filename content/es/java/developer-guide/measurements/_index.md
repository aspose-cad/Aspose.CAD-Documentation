---
title: Medidas
type: docs
weight: 40
url: /es/java/developer-guide/measurements/
---

## **Mediciones de área y longitud**

Ciertas entidades soportan el cálculo de área y longitud (perímetro): CÍRCULO, ELIPSE, ARCO y LWPOLYLINE. Además, la entidad POLYLINE soporta el cálculo de longitud pero no de área. Otras entidades lanzan NotImplementedException.

Aquí hay un ejemplo de cómo calcular longitud y área:

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
