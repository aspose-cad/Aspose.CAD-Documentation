---
title: ייצוא של שרטוטים ופריסות DWG/DXF לגודל ספציפי
type: docs
weight: 40
url: /he/net/developer-guide/export-into-size/
---

## **ייצוא מודל וכל הפריסות לגודל PDF A4**

ממשק ה-API של Aspose.CAD מאפשר לך לייצא את כל הגליונות של קובץ DWG/DXF לגודל PDF פיזי ספציפי.

הקוד לדוגמה הבא קובע את גודל האובייקט [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) כדי להשיג את גודל ה-PDF הרצוי.
הגודל של דף נייר A4 הוא 210x297 מילימטרים או 8.27x11.69 אינצ'ים וערכים אלו משמשים בקוד.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Calculate sizes for A4.cs">}}

## **ייצוא פריסות CAD ל-PDF בגודל שונה**

לעיתים נדרש לייצא פריסה לגודלה הפיזי. הדוגמה להלן ממחישה את ייצוא השרטוט ל-PDF רב-עמודי שבו כל עמוד עם תוכן פריסה
יש לו גודל PDF פיזי משלו. דוגמה זו משתמשת בנכס [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/layoutpagesizes/)
.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Export to multipage with different pages sizes.cs">}}
