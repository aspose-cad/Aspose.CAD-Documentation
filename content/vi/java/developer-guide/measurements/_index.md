---
title: Đo lường
type: docs
weight: 40
url: /vi/java/developer-guide/measurements/
---

## **Đo diện tích và chiều dài**

Một số thực thể hỗ trợ tính toán diện tích và chiều dài (chu vi): CIRCLE, ELLIPSE, ARC và LWPOLYLINE. Thêm vào đó, thực thể POLYLINE hỗ trợ tính toán chiều dài nhưng không tính diện tích. Các thực thể khác sẽ ném ra NotImplementedException.

Dưới đây là ví dụ về cách tính toán chiều dài và diện tích:

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
