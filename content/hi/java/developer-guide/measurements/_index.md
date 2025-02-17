---
title: माप
type: docs
weight: 40
url: /hi/java/developer-guide/measurements/
---

## **क्षेत्रफल और लंबाई माप**

कुछ इकाइयाँ क्षेत्रफल और लंबाई (परिमित) की गणना का समर्थन करती हैं: CIRCLE, ELLIPSE, ARC और LWPOLYLINE। इसके अतिरिक्त, POLYLINE इकाई लंबाई की गणना का समर्थन करती है लेकिन क्षेत्रफल की नहीं। अन्य इकाइयाँ NotImplementedException फेंकती हैं।

यहां लंबाई और क्षेत्रफल की गणना करने का उदाहरण है:

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
		// यहाँ कुछ कार्यवाही की जा सकती है
	}
}
```
