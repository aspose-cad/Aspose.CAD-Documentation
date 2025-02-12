---
title: Μετρήσεις
type: docs
weight: 40
url: /el/java/developer-guide/measurements/
---

## **Μετρήσεις επιφάνειας και μήκους**

Ορισμένες οντότητες υποστηρίζουν τον υπολογισμό της επιφάνειας και του μήκους (περιφέρεια): ΚΥΚΛΟΣ, ΕΛΛΕΙΨΗ, ΤΟΞΟ και LWPOLYLINE. Επιπλέον, η οντότητα POLYLINE υποστηρίζει τον υπολογισμό του μήκους αλλά όχι της επιφάνειας. Άλλες οντότητες ρίχνουν την εξαίρεση NotImplementedException.

Ακολουθεί ένα παράδειγμα για το πώς να υπολογίσετε το μήκος και την επιφάνεια:

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
