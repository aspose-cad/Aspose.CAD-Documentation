---
title: การวัด
type: docs
weight: 40
url: /th/java/developer-guide/measurements/
---

## **การวัดพื้นที่และความยาว**

เอนทิตีบางตัวสนับสนุนการคำนวณพื้นที่และความยาว (เส้นรอบรูป): CIRCLE, ELLIPSE, ARC และ LWPOLYLINE นอกจากนี้ เอนทิตี POLYLINE ยังสนับสนุนการคำนวณความยาวแต่ไม่ใช่พื้นที่ เอนทิตีอื่น ๆ จะก่อให้เกิด NotImplementedException

นี่คือตัวอย่างการคำนวณความยาวและพื้นที่:

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
