---
title: 測定
type: docs
weight: 40
url: /ja/java/developer-guide/measurements/
---

## **面積と長さの測定**

特定のエンティティは、面積と長さ（周囲）の計算をサポートしています：CIRCLE、ELLIPSE、ARC、および LWPOLYLINE。さらに、POLYLINE エンティティは長さの計算をサポートしていますが、面積の計算はサポートしていません。他のエンティティは NotImplementedException をスローします。

以下は、長さと面積を計算する方法の例です：

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
		// このエンティティは実装されていません
	}
}
```
