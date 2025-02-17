---
title: רישומים DXF
type: docs
weight: 60
url: /he/java/developer-guide/autocad-drawings/dxf-drawings/
---

## **ייצוא רישומים DXF ל-PDF**

Aspose.CAD מספקת את הפונקציה לטעון ישויות רישום DXF של AutoCAD ולהמיר אותן כרישום שלם לפורמט PDF. גישת ההמרה מ-DXF ל-PDF פועלת כך:

1. טען את קובץ הרישום DXF באמצעות מתודת הייצור [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. צור אובייקט של מחלקת [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) והגדר את התכונות [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) ו-[**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. צור אובייקט של מחלקת [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) והגדר את התכונה [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. קרא ל-Image.Save כאשר אתה מעביר אובייקט של [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) כפרמטר השני.

קטע הקוד למטה מראה כיצד להמיר קובץ תוך שימוש בהגדרות ברירת מחדל.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFDrawingToPDF-.java" >}}

### **פורמטים נתמכים**

כרגע אנו תומכים לגמרי בפורמט הקובץ DXF של AutoCAD 2010. גרסאות DXF הקודמות לא מובטחות להיות תקפות ב-100%. אנו מתכננים לכלול יותר פורמטים ופונקציות בגרסאות העתידיות של Aspose.CAD.

### **יישויות נתמכות**

כרגע אנו תומכים בכל הישויות 2D הנפוצות ובפרמטרים הבסיסיים שלהם כמו הבא:

1. מידה מיושרת
1. מידה זוויתית
1. קשת
1. תכונה
1. הפניה לחסום
1. עיגול
1. מידה קוטר
1. אליפסה
1. חציצה
1. קו
1. טקסט רב-שירי
1. מידה אורדינט
1. נקודה
1. פוליליין
1. מידה רדיאלית
1. קרן
1. מידה מופנית
1. טבלה
1. טקסט
1. קו X

{{% alert color="primary" %}}

אם במהלך הניתוח נתקלנו בישות או בתכונה שאינן נתמכות, הישות או התכונה יתעלמו בשקט.

{{% /alert %}}

### **ניהול זיכרון**

המאפיין [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) יכול לשמש לשליטה על הקצאה מחדש של זיכרון. הקצאה מחדש סביר שתתרחש עבור קאש שנוקשה מראש. זה יכול לקרות כאשר המערכת מזהה שהמרחב שהוקצה לא יהיה מספיק.

- אם [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) מוגדר לערך ברירת המחדל, **שקר**, המרחב מוקצה מחדש לאותו מדיום.
- כאשר הוא מוגדר ל-**נכון**, הקצאה מחדש לא יכולה לעלות על המרחק המקסימלי שנקבע. במקרה זה, הקאש המוקצה בזיכרון (שצריך הקצאה מחדש) משתחרר ומרחב מורחב מוקצה בדיסק.

## **ייצוא שכבת DXF ספציפית ל-PDF**

גישת זו פועלת כך:

1. פתח קובץ רישום DXF באמצעות מתודת הייצור [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. צור מופע של [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) וציין את התכונות [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) ו-[**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. הוסף שכבות לאובייקט של [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. צור מופע של [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) והגדר את התכונה [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. ייצא את הרישום ל-PDF באמצעות המתודה [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

קטע הקוד למטה מראה כיצד להמיר שכבת DXF ספציפית ל-PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificLayerOfDXFDrawingToPDF-.java" >}}

## **ייצוא שכבת DXF ספציפית לתמונה**

גישת זו פועלת כך:

1. פתח את קובץ הרישום DXF באמצעות מתודת הייצור [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. צור מופע של [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) וציין את התכונות [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) ו-[**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. הוסף שכבות לאובייקט של [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. צור מופע של [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) והגדר את התכונה [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. ייצא את הרישום ל-PDF באמצעות המתודה [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

קטע הקוד למטה מראה כיצד להמיר שכבת DXF ספציפית לתמונה.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.java" >}}

## **הצגת קבצי PDF כחלק רישומי DXF**

גישה זו פועלת כך:

1. טען קובץ רישום DXF באמצעות מתודת הייצור [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. צור אובייקט של מחלקת [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) וטעון קבצי PDF.
1. הגדר את התכונות [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) ו-[**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. קרא ל-[**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) ושמור את הקובץ.

קטע הקוד למטה מראה כיצד להציג קבצי PDF כחלק מרישומי DXF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-RenderDXFAsPDF-RenderDXFAsPDF.java" >}}

## **ייצוא DXF ל-WMF**

גישה זו פועלת כך:

1. טען קובץ רישום DXF באמצעות מתודת הייצור [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. צור אובייקט של מחלקת [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) וטעון קבצי PDF.
1. הגדר את התכונות [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) ו-[**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. קרא ל-[**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) ושמור את הקובץ.

קטע הקוד למטה מראה כיצד לייצא DXF ל-WMF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFToWMF-ExportDXFToWMF.java" >}}

## **תמיכה בשמירת קבצי DXF**

Aspose.CAD מספקת את הפונקציה לטעון קבצי DXF של AutoCAD ולבצע שינויים בהם ולשמור אותם שוב כקובץ DXF. הקטע קוד למטה מראה כיצד להשיג את הדרישות המפורטות.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SaveDXFFiles-SaveDXFFiles.java" >}}

## **ייצוא DGN תחתית מוטמעת לפורמט DXF**

Aspose.CAD מספקת את הפונקציה לטעון קבצי DXF של AutoCAD ולייצא DGN תחתית מוטמעת לפורמט DXF.

קטע הקוד למטה מראה כיצד להשיג את הדרישות המפורטות.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportEmbeddedDGN-ExportEmbeddedDGN.java" >}}

## **ייצוא פריסת DXF ספציפית ל-PDF**

גישה זו פועלת כך:

1. פתח קובץ רישום DXF באמצעות מתודת הייצור [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. צור מופע של [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) וציין את התכונות [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) ו-[**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. ציין את שמות הפריסות הרצויים באמצעות התכונה [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-).
1. צור מופע של [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) והגדר את התכונה [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. ייצא את הרישום ל-PDF באמצעות המתודה [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

קטע הקוד למטה מראה כיצד להמיר פריסה ספציפית של DXF ל-PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToPDF-.java" >}}

{{% alert color="primary" %}}

המאפיין [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) הוא מסוג מערך מיתרים, כך שתוכל לציין יותר מפריסה אחת בו זמנית להמרה אפשרית לפורמט PDF. כאשר מציינים מספר פריסות עבור המאפיין [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-), ה-PDF המתקבל יכיל מספר עמודים, כאשר כל עמוד מייצג פריסה נפרדת של AutoCAD.

{{% /alert %}}

## **גישה לאובייקטים ATTRIB ו-MTEXT**

גישה זו פועלת כך:

1. פתח קובץ רישום DXF באמצעות מתודת הייצור [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. גש ליישויות בתוך קובץ CAD.
1. בדוק עבור ישויות [**CadEntityTypeName.MTEXT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#MTEXT) ו-[**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT).
1. הוסף לרשימה זמנית לעיבוד נוסף.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-AddAttribMText-AddAttribMText.java" >}}

## **פירוק אובייקטי CAD Insert**

גישה זו פועלת כך:

1. פתח קובץ רישום **DXF** באמצעות מתודת הייצור [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. גש ליישויות בתוך קובץ CAD.
1. בדוק עבור ישויות [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT).
1. בדוק עבור רשימת סוג [**CadBlockEntity**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity).
1. עבד את היישויות.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-DecomposeCadInsertObject-DecomposeCadInsertObject.java" >}}

## **תמיכה בקליפת בלוק**

Aspose.CAD מספקת את הפונקציה של קליפת בלוק. גישת קליפת הבלוק פועלת כך:

1. טען קובץ רישום DXF באמצעות מתודת הייצור [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. צור אובייקט של מחלקת [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) וטעון קבצי PDF.
1. הגדר את התכונות הרצויות של [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. קרא ל-[**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) כאשר אתה מעביר אובייקט של [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) כפרמטר השני ושמור את הקובץ.

קטע הקוד למטה מראה כיצד קליפת בלוק פועלת.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SupportOfBlockClipping-SupportOfBlockClipping.java" >}}

## **ייצוא תמונות ל-DXF**

באמצעות Aspose.CAD, אתה יכול לייצא תמונות לפורמט DXF. באמצעות גישה זו, אתה יכול לבצע את הפעולות הבאות:

1. הגדר גופן חדש
1. התנגש ביישויות
1. עדכן טקסט

קטע הקוד הבא מראה לך כיצד לבצע את הפעולות המפורטות לעיל.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-ExportImagesToDXF.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-GetFileExtension.java" >}}
