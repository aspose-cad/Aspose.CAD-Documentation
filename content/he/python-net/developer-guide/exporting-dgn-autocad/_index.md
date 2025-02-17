---
title: ייצוא פורמט DGN AutoCAD
type: docs
weight: 50
url: /he/python-net/developer-guide/exporting-dgn-autocad/
---

## **ייצוא פורמט DGN AutoCAD ל-PDF**

Aspose.CAD עבור Python API הציגה את הפונקציונליות לטעון קובץ DGN AutoCAD ולהמיר אותו לפורמט PDF. **באמצעות מחלקת CadImage** מרגע זה ניתן.

עליך לטעון קובץ DGN קיים כביכול **CadImage**. צור מופע של מחלקת **CadRasterizationOptions** והגדר מאפיינים שונים. צור מופע של מחלקת **PdfOptions** ומסר את מופע **CadRasterizationOptions**. עכשיו התקשר למתודה **save** של מופע מחלקת **CadImage**.

### דוגמת קוד

בעקבות כך ישנה הדגמה קוד לממיר/ייצוא [DGN](https://docs.fileformat.com/cad/dgn/) לפורמט [PDF](https://docs.fileformat.com/pdf/).


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-PDF-Export.py" >}}


## **ייצוא פורמט DGN AutoCAD לפורמט תמונת רסטר**

Aspose.CAD עבור Python API הציגה את הפונקציונליות לטעון קובץ DGN AutoCAD ולהמיר אותו לתמונה רסטר. **באמצעות מחלקת CadImage** מרגע זה ניתן.

עליך לטעון קובץ DGN קיים כביכול **CadImage**. צור מופע של מחלקת **CadRasterizationOptions** והגדר מאפיינים שונים. צור מופע של מחלקת **JpegOptions** ומסר את מופע **CadRasterizationOptions**. עכשיו התקשר למתודה **save** של מופע מחלקת **CadImage**.

### דוגמת קוד

בעקבות כך ישנה הדגמה קוד לממיר/ייצוא [DGN](https://docs.fileformat.com/cad/dgn/) לתמונה [JPEG](https://docs.fileformat.com/image/jpeg/) .

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-JPEG-Export.py" >}}

## **תמיכת ישויות תלת-ממדיות עבור DGN v7**

Aspose.CAD עבור Python API הציגה את הפונקציונליות לטעון קובץ [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD ולתמוך בישויות תלת-ממדיות עבור DGN v7. **באמצעות מחלקת CadImage** מרגע זה ניתן. כל תמונת [DGN](https://docs.fileformat.com/cad/dgn/) תומכת ב-9 תצוגות מוגדרות מראש. זה ממוין מ-1 עד 9. אם לא הוגדרה תצוגה בייצוא, בפורמטים בפלט מרובה דפים (כמו PDF) כל התצוגות ייוצאו, כל אחת בדף נפרד. ישויות תלת-ממדיות נתמכות על פורמט קובץ DGN, כמו גם 2D. בשביל זה, **VectorRasterizationOptions** משמש, TypeOfEntities איננו בשימוש יותר עבור פורמט DGN (גם 2D וגם 3D נתמכים בו זמנית).

### דוגמת קוד

הקוד הבא הוא דוגמת קוד לראות אילו אלמנטים של DGN נתמכים.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DGN-Drawings-SupportOf3DForDGNV7.py" >}}
