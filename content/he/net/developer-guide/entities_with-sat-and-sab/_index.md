---
title: ישויות עם מבנה SAT/SAB
type: docs
weight: 40
url: /he/net/developer-guide/entities_with-sat-and-sab/
---

## **ישויות עם מבנה SAT/SAB**

ישויות מסוימות שומרות את הנתונים המבניים שלהן בפורמט ACIS SAT/SAB. ישויות אלו יכולות להתExport באופן חלקי במצב wireframe דו-ממדי. הישויות הנתמכות כוללות:

*	עצמים 3DSOLID: קופסה, כדור, פירמידה, קצה, חרוט, צילינדר, טורוס, פוליסוליד
*	משטח: מישורי, מוארך, מהפך, מופץ
*	אזור

להלן דוגמה של תוצאת הייצוא (קובץ DWG בחלק השמאלי, תוצאת PDF בחלק הימני).

![ייצוא של חרוט וכדורים](/cad/_assets/guide/coneAndSpheres.png)

ייצוא של ישויות ACIS אינו דורש אפשרויות מיוחדות. כדי לייעל את גודל הציור, במיוחד כאשר הציור מכיל ישויות ACIS בלבד, כדאי להשתמש בפונקציה cadImage.UpdateSize() כדי להתאים את ממדי הציור הראשוניים לאופן מדויק.

```csharp
using (CadImage cadImage = (CadImage)Image.Load(sourceFilePath))
{
	cadImage.UpdateSize();
	
	CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
	rasterizationOptions.Layouts = new string[] { "Model" };

	PdfOptions pdfOptions = new PdfOptions
	{
		VectorRasterizationOptions = rasterizationOptions
	};
	cadImage.Save("output.pdf", pdfOptions);
}
```
