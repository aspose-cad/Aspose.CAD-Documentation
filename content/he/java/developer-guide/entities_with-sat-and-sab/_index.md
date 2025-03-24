---
title: ישויות עם מבנה SAT/SAB
type: docs
weight: 40
url: /he/java/developer-guide/entities_with-sat-and-sab/
---

## **ישויות עם מבנה SAT/SAB**

מספר ישויות מאחסנות את הנתונים המבניים שלהן בפורמט ACIS SAT/SAB. ישויות אלו יכולות להתממשק جزئית במצב מסגרת דו-ממדית. הישויות הנתמכות כוללות:

* אובייקטים מסוג 3DSOLID: קופסה, כדור, פירמידה, פיסוק, חרוט, צילינדר, טורוס, פוליסוליד
* שטח: מישורי, מוארך, סובב, נמשך
* אזור

להלן דוגמה לתוצאת היצוא (קובץ DWG בצד השמאלי, תוצאת PDF בצד הימני).

![ייצוא של חרוט וכדורים](/cad/_assets/guide/coneAndSpheres.png)

ייצוא של ישויות ACIS אינו דורש אפשרויות מיוחדות. כדי למטב את גודל השרטוט, במיוחד כאשר השרטוט מכיל ישויות ACIS בלבד, שקול להשתמש בפונקציה cadImage.updateSize() כדי להתאים את ממדי השרטוט ההתחלתיים במדויק.

```java
CadImage cadImage = (CadImage)Image.load(sourceFilePath);

cadImage.updateSize();
	
CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
rasterizationOptions.setLayouts(new String[]{"Model"});

PdfOptions pdfOptions = new PdfOptions();
pdfOptions.setVectorRasterizationOptions(rasterizationOptions);

cadImage.save("output.pdf", pdfOptions);
```
