---
title: 측정
type: docs
weight: 40
url: /ko/java/developer-guide/measurements/
---

## **면적 및 길이 측정**

특정 엔티티는 면적 및 길이(주변)의 계산을 지원합니다: 원, 타원, 호 및 LWPOLYLINE. 추가로, POLYLINE 엔티티는 길이 계산을 지원하지만 면적은 지원하지 않습니다. 다른 엔티티는 NotImplementedException을 발생시킵니다.

다음은 길이와 면적을 계산하는 방법의 예입니다:

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
