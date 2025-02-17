---
title: ייצוא ציור ופריסות DWG/DXF לגודל שנבחר
type: docs
weight: 40
url: /he/java/developer-guide/export-into-size/
---

## **ייצוא מודל וכל הפריסות לגודל PDF A4**

API של Aspose.CAD מאפשר לך לייצא את כל הגליונות של קובץ ה-DWG/DXF לגודל PDF פיזי שנבחר.
הקוד לדוגמה הבא מגדיר את הגודל של פריט ה-[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions/) כדי להשיג את גודל ה-PDF הרצוי.
גודל גיליון הנייר A4 הוא 210x297 מילימטרים או 8.27x11.69 אינצ'ים, וערכים אלה משמשים בקוד.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "set-page-size.java">}}

## **ייצוא פריסות CAD ל-PDF בגודל שונה**

לפעמים יש צורך לייצא את הפריסה לגודל הפיזי שלה. הדוגמה להלן מדגימה את הייצוא של הציור ל-PDF מרובה-pages שבו כל דף עם תוכן הפריסה
יש לו גודל PDF פיזי משלו. דוגמה זו משתמשת בתכונת [**getLayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#getLayoutPageSizes--) . 

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "export-different-pages-sizes.java">}}
