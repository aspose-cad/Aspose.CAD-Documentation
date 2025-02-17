---
title: מדידות
type: docs
weight: 40
url: /he/java/developer-guide/measurements/
---

## **מדידות שטח ואורך**

ישויות מסוימות תומכות בחישוב שטח ואורך (היקף): מעגל, אליפסה, קשת ו-LWPOLYLINE. בנוסף, ישות POLYLINE תומכת בחישוב אורך אך לא בשטח. ישויות אחרות זורקות NotImplementedException.

הנה דוגמה כיצד לחשב אורך ושטח:

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
