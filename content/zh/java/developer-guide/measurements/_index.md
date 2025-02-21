---
title: 测量
type: docs
weight: 40
url: /zh/java/developer-guide/measurements/
---

## **面积和长度测量**

某些实体支持计算面积和长度（周长）：圆形、椭圆、弧和 LWPOLYLINE。此外，POLYLINE 实体支持计算长度但不支持面积。其他实体会抛出 NotImplementedException。

以下是计算长度和面积的示例：

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
