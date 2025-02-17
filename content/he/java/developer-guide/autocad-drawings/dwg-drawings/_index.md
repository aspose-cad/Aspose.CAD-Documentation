---
title: שרטוטי DWG
type: docs
weight: 40
url: /he/java/developer-guide/autocad-drawings/dwg-drawings/
---

## **ייצוא שרטוטי DWG ל-PDF**

Aspose.CAD עבור Java API יכול לטעון שרטוטי AutoCAD בפורמט DWG, ולהמיר אותו ל-PDF. נושא זה מסביר את השימוש ב-Aspose.CAD API כדי להשיג את המרת DWG לפורמט PDF באמצעות צעדים פשוטים כפי שהוגדרו להלן.

{{% alert color="primary" %}}

ה-API תומך בגרסאות DWG הבאות של AutoCAD:

- גרסה 16.0 שחרור 18 DWG 2004
- גרסה 16.1 DWG 2005
- גרסה 18.0 DWG 2010
- גרסה 19.0 DWG 2013

{{% /alert %}}

### **פורמט קובץ DWG**

DWG הוא קובץ בינארי המכיל נתוני תמונה וקטוריים ומטא-מידע. נתוני התמונה הווקטוריים מספקים הנחיות ליישום ה-CAD לגבי איך להציג את ה-DWG; המטא-מידע עשוי להכיל מגוון של מידע על הקובץ כולל נתוני מיקום וגם נתוני לקוח. מפרט פתוח לפורמט קובץ DWG ניתן למצוא [ב-PDF הזה](https://www.opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **המרת קבצי DWG ל-PDF**

הצעדים הפשוטים הבאים נדרשים כדי להמיר DWG ל-PDF.

1. טען את קובץ ה-DWG לתוך אינסטנציה של [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. צור אובייקט של הכיתה [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) והגדר את המאפיינים [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. צור אובייקט של הכיתה [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) והגדר את מאפיין [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. קרא לנכס [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) ומסר את אובייקט ה-[**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) כפרמטר שני.

דוגמת הקוד למטה מראה כיצד לייצא שרטוטי DWG ל-PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ConvertDWGFileToPDF-ConvertDWGFileToPDF.java" >}}

### **יצירת PDF בודד עם גדלים שונים**

Aspose.CAD עבור Java מאפשרת לך להמיר את קובץ ה-DWG ל-PDF בודד עם גדלים שונים. הגישה הזו פועלת כך:

1. טען קובץ DWG באמצעות שיטת המפעל [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. צור אינסטנציה של הכיתה [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) והגדר את גובה ורוחב הדף התוצאה.
1. הוסף את [**LayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setLayoutPageSizes-com.aspose.ms.System.Collections.Generic.Dictionary-) הנדרשות לאובייקט ה-[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. צור אינסטנציה של הכיתה [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) והגדר את מאפיין ה-[**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. ייצא את התמונה ל-PDF באמצעות שיטת [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

דוגמת הקוד למטה מראה כיצד ליצור PDF בודד עם פריסות שונות.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.java" >}}

### **ייצוא DWG ל-PDF/A ו-PDF/E**

הצעדים הפשוטים הבאים נדרשים כדי להמיר DWG ל-PDF.

1. טען את קובץ ה-DWG לתוך אינסטנציה של [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. צור אובייקט של הכיתה [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) והגדר את [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) מאפיינים.
1. צור אובייקט של הכיתה [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) והגדר את [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) מאפיין.
1. קרא לנכס [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) ומסר את אובייקט [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) כפרמטר שני.

דוגמת הקוד למטה מראה כיצד לייצא שרטוטי DWG ל-PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToCompliancePDF-DWGToCompliancePDF.java" >}}

### **פרימיטיבים נתמכים ב-AutoCAD**

הפרימיטיבים הבאים של AutoCAD נתמכים.

- TEXT
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

## **ייצוא פריסת DWG ספציפית ל-PDF**

הגישה הזו פועלת כך:

1. טען קובץ DWG באמצעות שיטת המפעל [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) .
1. צור אינסטנציה של הכיתה [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) והגדר את גובה ורוחב הדף התוצאה.
1. הגדר את מאפיין [**Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) עבור האובייקט [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) .
1. צור אינסטנציה של [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) והגדר את מאפיין ה-[**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) .
1. ייצא את התמונה ל-PDF באמצעות שיטת [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

דוגמת הקוד למטה מראה כיצד להמיר פריסה ספציפית של DWG ל-PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportSpecificDWGLayoutToPDF-ExportSpecificDWGLayoutToPDF.java" >}}

## **ייצוא DWG ל-Raster או PDF באמצעות גודל קבוע**

Aspose.CAD עבור Java API יכול לטעון שרטוטי AutoCAD בפורמט DWG, ולהמיר אותו ל-PDF או Raster באמצעות גודל קבוע.

דוגמת הקוד למטה מראה כיצד ליישם תכונה זו.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.java" >}}

## **תמיכה בקווים מוסתרים מעוגלים בעת ייצוא DWG/DXF ל-BMP ו-PDF**

הגישה הזו פועלת כך:

1. טען קובץ DWG באמצעות שיטת המפעל  [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) .
1. צור אינסטנציה של הכיתה [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) .
1. צור אינסטנציה של הכיתה [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) והגדר את גובה ורוחב הדף התוצאה.
1. צור אינסטנציה של [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) והגדר את מאפיין [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. ייצא את התמונה ל-PDF באמצעות השיטה [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

דוגמת הקוד למטה מראה כיצד ליישם תכונה זו.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportForHiddenLines-SupportForHiddenLines.java" >}}

## **תמיכה בהגדרת אזור הדפסה עבור תמונת DWG ב-PDF המיוצא**

Aspose.CAD עבור Java API יכול לטעון שרטוטי AutoCAD בפורמט DWG, ולהמיר אותו ל-PDF. נושא זה מסביר את השימוש ב-Aspose.CAD API כדי להשיג את התמיכה בהגדרת אזור הדפסה עבור תמונת DWG ב-PDF המיוצא.

דוגמת הקוד למטה מראה כיצד ליישם תכונה זו.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **תמיכה בקריאה של מטא-דאטה XREF עבור קובץ DWG**

1. טען קובץ DWG באמצעות שיטת המפעל [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) .
1. גש לכל ישות תמונה.
1. אם הישות היא [**CadUnderlay**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadUnderlay) אז ישות XREF עם מטא-דאטה.

דוגמת הקוד למטה מראה כיצד להשיג תכונה זו.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ReadXREEFMetaData-ReadXREEFMetaData.java" >}}

## **מסמך DWG על ידי ציון קואורדינטות**

Aspose.CAD עבור Java API עכשיו מספק תכונה לרנדר מסמכי DWG על ידי מתן קואורדינטות של רוחב וגובה הקובץ.

דוגמת הקוד למטה מראה כיצד לרנדר מסמך DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-RenderDWGDocument-RenderDWGDocument.java" >}}

מאפיין [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#getLayouts--) הוא מסוג מערך מיתרים כך שתוכל לציין יותר מפריסה אחת בו זמנית עבור המרה אפשרית לפורמט PDF. כאשר אתה מציין מספר פריסות עבור מאפיין [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) , ה-PDF התוצאה יכיל מספר עמודים, כאשר כל עמוד מייצג פריסת AutoCAD בודדת.

### **רשימת כל הפריסות**

תוכל לרשום את כל הפריסות הנמצאות בשרטוט AutoCAD באמצעות דוגמת הקוד הבאה.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ListAllLayoutsInAnAutoCADDrawing-ListAllLayoutsInAnAutoCADDrawing.java" >}}

## **קבלת ערך מאפיין בלוק של הפניה חיצונית**

Aspose.CAD עבור Java API מאפשרת לך לקבל הפניה חיצונית של מאפיין בלוק. Aspose.CAD API חושף את המאפיין [**getXRefPathName()**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity#getXRefPathName--) כדי לקבל את ההפניה החיצונית של מאפיין בלוק באוסף [**CadBlockDictionary**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadBlockDictionary).

הדוגמה הבאה ממחישה כיצד לקבל הפניה חיצונית של מאפיין בלוק.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-GetBlockAttributeValueOfExternalReference-GetBlockAttributeValueOfExternalReference.java" >}}

## **חיפוש טקסט בקובץ DWG של AutoCAD**

Aspose.CAD עבור Java API מאפשרת לך לחפש טקסט בקובץ DWG של AutoCAD. Aspose.CAD API חושף את הכיתה [**CadText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadText) המייצגת ישויות טקסט בקובץ DWG של AutoCAD. כיתה [**CadMText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadMText) גם כלולה ב-Aspose.CAD API מכיוון שישויות אחרות עשויות לכלול גם טקסט.

הדוגמה הבאה ממחישה כיצד לחפש טקסט בקובץ DWG של AutoCAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchTextInDWGAutoCADFile.java" >}}

### **חפש טקסט בפריסה ספציפית**

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchForTextInSpecificLayout.java" >}}

### **גישה לדגלי ההתקנה עבור פורמט DWG**

Aspose.CAD עבור Java הטמיעה את דגלי ההתקנה לפורמט DWG ומאפשרת למפתחים לגשת אליהם. הנה הדגמת קוד פשוטה.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.java" >}}

## **תמיכה ב-DWG Entities**

Aspose.CAD עבור Java API יכול לטעון שרטוטי AutoCAD בפורמט DWG ותומך בישויות שונות לעבוד איתן.

### **תמיכה ב-DWG Entity של MLeader**

DWG הוא קובץ בינארי המכיל נתוני תמונה וקטוריים ומטא-מידע. ישנם ישויות שונות בקובץ DWG. הסעיף הבא מתאר דוגמה לעבודה עם ישות MLeader בתוך קובץ DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.java" >}}

### **תמיכה בייצוא DWG Entity לתמונה**

DWG הוא קובץ בינארי המכיל נתוני תמונה וקטוריים ומטא-מידע. ישנם ישויות שונות בקובץ DWG. הסעיף הבא מתאר דוגמה לייצוא ישות DWG מסוימת לתמונה.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ParticularDWGToImage-ParticularDWGToImage.java" >}}

## **תמיכה בייבוא תמונה לקובץ DWG**

Aspose.CAD עבור Java API יכול לטעון שרטוטי AutoCAD בפורמט DWG ולתמוך בישות שונות לעבוד איתן.  DWG הוא קובץ בינארי המכיל נתוני תמונה וקטוריים ומטא-מידע. ישנם ישויות שונות בקובץ DWG. הסעיף הבא מתאר כיצד ניתן לייבא תמונות לתוך קובץ ה-DWG.

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ImportImageToDWG-ImportImageToDWG.java" >}}

## **תמיכה בהוספת טקסט ב-DWG**

Aspose.CAD עבור Java API יכול לטעון שרטוטי AutoCAD בפורמט DWG ולתמוך בישות שונות לעבוד איתן.  DWG הוא קובץ בינארי המכיל נתוני תמונה וקטוריים ומטא-מידע. ישנם ישויות שונות בקובץ DWG. הסעיף הבא מתאר כיצד ניתן להוסיף טקסט בתוך קובץ ה-DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-AddTextInDWG-AddTextInDWG.java" >}}

## **תמיכה ברשת ב-DWG**

Aspose.CAD עבור Java API יכולה עכשיו לגשת לישויות התומכות ברשת כולל סוגי [**CadPolyFaceMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolyFaceMesh) ו-[**CadPolygonMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolygonMesh). הדוגמה הבאה מתארת כיצד ניתן לגשת לסוגי רשת.

## **המרת שרטוטי DWG ל-DXF**

Aspose.CAD מספקת תכונה לטעון קובץ DWG של AutoCAD ולהמיר אותו לפורמט DXF. גישת ההמרה מ-DWG ל-DXF פועלת כך:

1. טען את קובץ שרטוט DWG באמצעות השיטה [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) .
1. ייצא את שרטוט ה-DWG ל-DXF באמצעות השיטה [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

דוגמת הקוד למטה מראה כיצד להמיר קובץ DWG לפורמט DXF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToDXF-DWGToDXF.java" >}}

## **המרת שרטוטי DWG ל-SVG**

Aspose.CAD API יכולה לטעון שרטוטי AutoCAD בפורמט DWG, ולהמיר אותו ל-SVG. נושא זה מסביר את השימוש ב-Aspose.CAD API כדי להשיג את ההמרה של DWG לפורמט SVG דרך צעדים פשוטים כפי שהוגדרו להלן.

1. טען את קובץ ה-DWG לתוך אינסטנציה של [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. צור אובייקט של הכיתה [**SvgOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/SvgOptions) והגדר את המאפיינים הדרושים.
1. ייצא את שרטוט ה-DWG לסוג SVG באמצעות השיטה [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

דוגמת הקוד למטה מראה כיצד להמיר קובץ DWG לפורמט SVG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportToSVG-ExportToSVG.java" >}}
