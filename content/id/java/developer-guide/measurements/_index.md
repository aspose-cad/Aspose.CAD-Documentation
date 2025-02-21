---
title: Pengukuran
type: docs
weight: 40
url: /id/java/developer-guide/measurements/
---

## **Pengukuran area dan panjang**

Entitas tertentu mendukung perhitungan area dan panjang (perimeter): CIRCLE, ELLIPSE, ARC dan LWPOLYLINE. Selain itu, entitas POLYLINE mendukung perhitungan panjang tetapi tidak area. Entitas lain melempar NotImplementedException.

Berikut adalah contoh cara menghitung panjang dan area:

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
