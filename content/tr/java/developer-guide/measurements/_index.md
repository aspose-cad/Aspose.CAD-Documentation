---
title: Ölçümler
type: docs
weight: 40
url: /tr/java/developer-guide/measurements/
---

## **Alan ve uzunluk ölçümleri**

Belirli varlıklar alan ve uzunluk (çevre) hesaplamasını destekler: DİKDAĞ, ELİPSE, KÜRE ve LWPOLYLINE. Ayrıca, POLYLINE varlığı alanı değil, uzunluğu hesaplamayı destekler. Diğer varlıklar NotImplementedException atar.

İşte uzunluk ve alan hesaplamanın nasıl yapılacağına dair bir örnek:

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
