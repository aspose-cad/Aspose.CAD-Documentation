---
title: Medidas
type: docs
weight: 40
url: /pt/java/developer-guide/measurements/
---

## **Medições de área e comprimento**

Certas entidades suportam o cálculo de área e comprimento (perímetro): CÍRCULO, ELLIPSE, ARC e LWPOLYLINE. Além disso, a entidade POLYLINE suporta o cálculo de comprimento, mas não de área. Outras entidades lançam NotImplementedException.

Aqui está um exemplo de como calcular comprimento e área:

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
