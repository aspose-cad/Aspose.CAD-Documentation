---
title: שרטוטי DWG
type: docs
weight: 70
url: /he/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **ייצוא שרטוטי DWG ל-PDF**

Aspose.CAD עבור API Python יכול לטעון שרטוטי AutoCAD בפורמט [DWG](https://docs.fileformat.com/cad/dwg/) ולהמיר אותו ל-[PDF](https://docs.fileformat.com/pdf/). נושא זה מסביר את השימוש ב-API של Aspose.CAD כדי להשיג את המרה מ-DWG לפורמט PDF באמצעות צעדים פשוטים כפי שהוגדרו בהמשך.

{{% alert color="primary" %}}

ה-API תומך בגרסאות DWG של AutoCAD הבאות:

- גרסה 16.0 של DWG 2004 שחרור 18
- גרסה 16.1 של DWG 2005
- גרסה 18.0 של DWG 2010
- גרסה 19.0 של DWG 2013

{{% /alert %}}

### **פורמט קובץ DWG**

[DWG](https://docs.fileformat.com/cad/dwg/) הוא קובץ בינארי המכיל נתוני תמונה וקטוריים ומטadata. נתוני התמונה הווקטוריים מספקים הוראות ליישום CAD לגבי כיצד להציג את ה-DWG; המטאדאטה עשויה לכלול מידע מגוון על הקובץ כולל נתונים ספציפיים למיקום ונתוני לקוח. ניתן למצוא את המפרטים הפתוחים לפורמט קובץ DWG [ב-PDF הזה](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **המרת קבצי DWG ל-PDF**

הצעדים הפשוטים הבאים דרושים להמיר [DWG](https://docs.fileformat.com/cad/dwg/) ל-[PDF](https://docs.fileformat.com/pdf/).

1. טען את קובץ DWG למופע של **Image**.
1. צור אובייקט של מחלקת **CadRasterizationOptions** והגדר את המאפיינים **page_height** & **page_width**.
1. צור אובייקט של מחלקת **PdfOptions** והגדר את מאפיין **VectorRasterizationOptions**.
1. קרא ל**Image.save** בזמן שמעביר אובייקט של **PdfOptions** כפרמטר השני.

מדגם הקוד למטה מציג כיצד לייצא שרטוטי DWG ל-PDF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-PDF-Export.py" >}}

### **פרימיטיבים נתמכים של AutoCAD**

הפרימיטיבים הבאים של AutoCAD נתמכים.

- טקסט
- MTEXT
- ATTDEF
- ATTRIB
- ARC
- ELLIPSE
- HATCH
- LEADER
- POINT
- VERTEX 2D
- VERTEX 3D
- POLYLINE 2D
- LWPOLYLINE
- RAY
- CIRCLE
- DIMENSION ORDINATE
- DIMENSION LINEAR
- DIMENSION ALIGNED
- DIMENSION ANG 3Pt
- DIMENSION ANG 2Ln
- DIMENSION RADIUS
- DIMENSION DIAMETER
- SHAPE
- SOLID
- SPLINE
- MLINE
- LINE
- XLINE
- STYLE
- DIMSTYLE
- LTYPE
- MLINESTYLE
- LAYER
- VIEWPORT
- LAYOUT

## **ייצוא לוח DWG ספציפי ל-PDF**

גישה זו פועלת כך:

1. טען קובץ DWG באמצעות מחלקת **Aspose.CAD.Image.load** שיטת מפעל.
1. צור מופע של מחלקת **CadRasterizationOptions** והגדר את גובה ורוחב העמוד המתקבל.
1. הגדר את מאפיין **Layouts** עבור אובייקט **CadRasterizationOptions**.
1. צור מופע של מחלקת **PdfOptions** והגדר את מאפיין **VectorRasterizationOptions** שלה.
1. ייצא את התמונה ל-PDF באמצעות שיטת **Image.save()**.

מדגם הקוד למטה מציג כיצד להמיר לוח ספציפי של DWG ל-PDF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-ExportSpecificLayoutToPDF.py" >}}

## **ייצוא DWG ל-PDF/A ו-PDF/E**

גישה זו פועלת כך:

1. טען קובץ DWG באמצעות שיטת **Image.load** שיטת מפעל.
1. צור מופע של מחלקת **CadRasterizationOptions**.
1. צור מופע של מחלקת **PdfOptions** והגדר את מאפיין **VectorRasterizationOptions** שלה.
1. הגדר את מאפיין צייתנות PDF ושמור אותו.
1. ייצא את התמונה ל-PDF באמצעות שיטת **Image.save()**.

מדגם הקוד למטה מציג כיצד להמיר קובץ DWG ל-PDF/A ו-PDF/E.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-to-Compliance-PDF.py" >}}

## **המרת שרטוטי DWG ל-DXF**

Aspose.CAD מספקת את הפונקציה לטעון קובץ DWG של AutoCAD ולהמיר אותו לפורמט DXF. גישת המרה מ-DWG ל-DXF פועלת כך:

1. טען קובץ שרטוט DWG באמצעות שיטת **Image.load**.
1. ייצא את שרטוט DWG ל-DXF באמצעות שיטת **Image.save()**.

מדגם הקוד למטה מציג כיצד להמיר קובץ DWG לפורמט DXF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-DXF.py" >}}

## **המרת שרטוטי DWG ל-SVG**

Aspose.CAD עבור API Python יכול לטעון שרטוטי AutoCAD בפורמט DWG, ולהמיר אותו ל-SVG. נושא זה מסביר את השימוש ב-API של Aspose.CAD כדי להשיג את המרה מ-DWG לפורמט SVG באמצעות צעדים פשוטים כפי שהוגדרו למעלה.

1. טען את קובץ DWG למופע של **Image**.
1. צור אובייקט של מחלקת **SvgOptions** והגדר את המאפיינים הנדרשים.
1. ייצא את שרטוט DWG ל-SVG באמצעות שיטת **Image.save()**.

מדגם הקוד למטה מציג כיצד להמיר קובץ DWG לפורמט SVG.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-SVG.py" >}}
