---
title: שרטוטי DWG
type: docs
weight: 40
url: /he/net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **ייצוא שרטוטי DWG ל-PDF**

Aspose.CAD עבור .NET API יכול לטעון שרטוטי AutoCAD בפורמט [DWG](https://docs.fileformat.com/cad/dwg/) ולהמיר אותו ל-[PDF](https://docs.fileformat.com/pdf/). נושא זה מסביר את השימוש ב-Aspose.CAD API כדי להשיג את ההמרה מ-DWG לפורמט PDF באמצעות צעדים פשוטים המוגדרים למעלה.

{{% alert color="primary" %}}

ה-API תומך בהתפתחויות הבאות של DWG של AutoCAD:

- גרסה 16.0 של DWG 2004 שחרור 18
- גרסה 16.1 של DWG 2005
- גרסה 18.0 של DWG 2010
- גרסה 19.0 של DWG 2013

{{% /alert %}}

### **פורמט קובץ DWG**

פורמט [DWG](https://docs.fileformat.com/cad/dwg/) הוא קובץ בינארי המכיל נתוני תמונה וקטוריים ומטא-דאטה. נתוני התמונה הווקטוריים מספקים הנחיות ליישום ה-CAD כיצד להציג את ה-DWG; המטא-דאטה יכולה להכיל מגוון של מידע על הקובץ כולל נתוני מיקום ומידע של לקוחות. מפרטים פתוחים עבור פורמט הקובץ DWG יכולים להתמצא [ב-PDF הזה](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **להמיר קובצי DWG ל-PDF**

הצעדים הפשוטים הבאים נדרשים כדי להמיר [DWG](https://docs.fileformat.com/cad/dwg/) ל-[PDF](https://docs.fileformat.com/pdf/).

1. טען את קובץ ה-DWG לדוגמת של [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. צור אובייקט של הקלאס [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) ובצע הגדרות עבור תכונות [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) ו-[**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. צור אובייקט של הקלאס [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) והגדר את תכונת [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. קרא ל-[**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) כאשר אתה מעביר אובייקט של [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) כפרמטר השני.

דוגמת הקוד למטה מציגה כיצד לייצא שרטוטי DWG ל-PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToPDF-ExportToPDF.cs" >}}

### **יצירת PDF אחד עם גדלים שונים של פריסות**

Aspose.CAD עבור .NET מאפשר לך להמיר קובץ DWG ל-PDF אחד עם גדלים שונים של פריסות. גישה זו פועלת כך:

1. טען קובץ DWG באמצעות השיטה הפקטוריאלית [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. צור דוגמת של הקלאס [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) והגדר את גובה ועובי הדף התוצאיים.
1. הוסף את [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/layoutpagesizes) הנדרשות עבור האובייקט [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. צור דוגמת של הקלאס [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) והגדר את תכונת [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. ייצא את התמונה ל-PDF באמצעות השיטה [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

דוגמת הקוד למטה מציגה כיצד ליצור PDF אחד עם פריסות שונות.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.cs" >}}

### **פרימיטיבים נתמכים של AutoCAD**

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

גישה זו פועלת כך:

1. טען קובץ DWG באמצעות השיטה הפקטוריאלית [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. צור דוגמת של הקלאס [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) והגדר את גובה ועובי הדף התוצאיים.
1. הגדר את תכונת [**Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) עבור האובייקט [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. צור דוגמת של הקלאס [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) והגדר את תכונת [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. ייצא את התמונה ל-PDF באמצעות השיטה [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

דוגמת הקוד למטה מציגה כיצד להמיר פריסה ספציפית של DWG ל-PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **להציג מסמך DWG על ידי ציון קואורדינטות**

Aspose.CAD עבור .NET API עכשיו מספקת תכונה להציג מסמכי DWG על ידי ספק קואורדינטות של רוחב וגובה המסמך.

דוגמת הקוד למטה מציגה כיצד להציג מסמך DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-RenderDWGDocument-RenderDWGDocument.cs" >}}

## **ייצוא DWG לרסטר או PDF בגודל קבוע**

Aspose.CAD עבור .NET API יכול לטעון שרטוטי AutoCAD בפורמט DWG, ולהמיר אותו ל-PDF או לרסטר בגודל קבוע.

דוגמת הקוד למטה מציגה כיצד ליישם תכונה זו.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.cs" >}}

## **ייצוא DWG ל-PDF/A ו-PDF/E**

גישה זו פועלת כך:

1. טען קובץ DWG באמצעות השיטה הפקטוריאלית [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. צור דוגמת של הקלאס [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. צור דוגמת של הקלאס [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) והגדר את תכונת [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. הגדר את תכונת התאמה של PDF ושמור אותו.
1. ייצא את התמונה ל-PDF באמצעות השיטה [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

דוגמת הקוד למטה מציגה כיצד להמיר קובץ DWG ל-PDF/A ו-PDF/E.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-DWGToCompliancePDF-DWGToCompliancePDF.cs" >}}

## **תמיכה בקווים מוסתרים מעוגלים בעת ייצוא DWG/DXF ל-BMP ו-PDF**

גישה זו פועלת כך:

1. טען קובץ DWG באמצעות השיטה הפקטוריאלית [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. צור דוגמת של הקלאס [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) והגדר את גובה ועובי הדף התוצאיים.
1. צור דוגמת של הקלאס [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) והגדר את תכונת [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. ייצא את התמונה ל-PDF באמצעות השיטה [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

דוגמת הקוד למטה מציגה כיצד ליישם תכונה זו.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-SupportForHiddenLines-SupportForHiddenLines.cs" >}}

## **תמיכה בהגדרת אזור הדפסה עבור תמונת DWG ב-PDF המיוצא**

Aspose.CAD עבור .NET API יכול לטעון שרטוטי AutoCAD בפורמט DWG ולהמיר אותם ל-PDF. נושא זה מסביר את השימוש ב-Aspose.CAD API כדי להשיג את התמיכה בהגדרת אזור הדפסה עבור תמונת DWG ב-PDF המיוצא.

דוגמת הקוד למטה מציגה כיצד ליישם תכונה זו.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **תמיכה בקריאת מטא-דאטה XREF עבור קובץ DWG**

1. טען קובץ DWG באמצעות השיטה הפקטוריאלית [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. עבור דרך כל ישות תמונה.
1. אם ישות היא CadUnderlay אז ישות XREF עם מטא-דאטה.

דוגמת הקוד למטה מציגה כיצד להשיג תכונה זו.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ReadXREEFMetaData-ReadXREEFMetaData.cs" >}}

התכונה [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) היא מסוג מערך מחרוזות כך שתוכל לציין יותר מפריסה אחת בו זמנית להמרה אפשרית לפורמט PDF. בזמן שאתה מציין מספר פריסות עבור תכונת [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts), ה-PDF התוצאתי יכיל מספר עמודים, כאשר כל עמוד מייצג פריסת AutoCAD בודדת.

### **רשימת כל הפריסות**

תוכל לרשום את כל הפריסות הקיימות בשרטוט AutoCAD באמצעות הקוד הבא.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-ListLayouts-ListLayouts.cs" >}}

### **גישה לדגלי ה-underlay עבור פורמט DWG**

Aspose.CAD עבור .NET הטמיעה את הדגלים וה-underlay של פורמט DWG ומאפשרת למפתחים לגשת אליהם. להלן הדגמה פשוטה של הקוד.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.cs" >}}

## **תמיכה בישויות DWG**

Aspose.CAD עבור .NET API יכול לטעון שרטוטי AutoCAD בפורמט DWG ותומך בישויות שונות לעבודה עם.

### **תמיכה בישות MLeader**

DWG הוא קובץ בינארי המכיל נתוני תמונה וקטוריים ומטא-דאטה. ישנן ישויות שונות בקובץ DWG. הסעיף הבא מתאר דוגמה לעבודה עם ישות MLeader בתוך קובץ ה-DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.cs" >}}

### **תמיכה בייצוא ישות DWG לתמונה**

DWG הוא קובץ בינארי המכיל נתוני תמונה וקטוריים ומטא-דאטה. ישנן ישויות שונות בקובץ DWG. הסעיף הבא מתאר דוגמה לייצוא ישות DWG מסוימת לתמונה.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ParticularDWGToImage-ParticularDWGToImage.cs" >}}

## **תמיכה בהוספת טקסט ב-DWG**

Aspose.CAD עבור .NET API יכול לטעון שרטוטי AutoCAD בפורמט DWG ותומך בישויות שונות לעבודה עם. DWG הוא קובץ בינארי המכיל נתוני תמונה וקטוריים ומטא-דאטה. ישנן ישויות שונות בקובץ DWG. הסעיף הבא מתאר כיצד ניתן להוסיף טקסט בתוך קובץ ה-DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-AddTextInDWG-AddTextInDWG.cs" >}}

## **תמיכה בייבוא תמונה לקובץ DWG**

Aspose.CAD עבור .NET API יכול לטעון שרטוטי AutoCAD בפורמט DWG ותומך בישויות שונות לעבודה עם. DWG הוא קובץ בינארי המכיל נתוני תמונה וקטוריים ומטא-דאטה. ישנן ישויות שונות בקובץ DWG. הסעיף הבא מתאר כיצד ניתן לייבא תמונות בתוך קובץ ה-DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DWG-Drawings-ImportImageToDWG-ImportImageToDWG.cs" >}}

## **תמיכה ברשת ב-DWG**

Aspose.CAD עבור .NET API יכולה עכשיו לגשת לישויות השייכות לרשת אשר כוללות את סוגי [**CadPolyFaceMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolyfacemesh) ו-[**CadPolygonMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolygonmesh). הדוגמה הבאה מתארת איך ניתן לגשת לסוגי הרשת.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-MeshSupportForDWG-MeshSupportForDWG.cs" >}}

## **להמיר שרטוטי DWG ל-DXF**

Aspose.CAD מספקת את הפיצ'ר לטעון קובץ DWG של AutoCAD ולייצא אותו לפורמט DXF. גישת ההמרה מ-DWG ל-DXF פועלת כך:

1. טען את קובץ שרטוט DWG באמצעות השיטה הפקטוריאלית [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. ייצא את שרטוט ה-DWG ל-DXF באמצעות השיטה [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

דוגמת הקוד למטה מציגה כיצד להמיר קובץ DWG לפורמט DXF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-DWGToDXF-DWGToDXF.cs" >}}

## **להמיר שרטוטי DWG ל-SVG**

Aspose.CAD עבור .NET API יכולה לטעון שרטוטי AutoCAD בפורמט DWG, ולהמיר אותו ל-SVG. נושא זה מסביר את השימוש ב-Aspose.CAD API כדי להשיג את ההמרה מ-DWG לפורמט SVG באמצעות צעדים פשוטים המוגדרים למטה.

1. טען את קובץ ה-DWG לדוגמת של [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. צור אובייקט של הקלאס [**SvgOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/svgoptions) והגדר את התכונות הנדרשות.
1. ייצא את שרטוט ה-DWG ל-SVG באמצעות השיטה [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

דוגמת הקוד למטה מציגה כיצד להמיר קובץ DWG לפורמט SVG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToSVG-ExportToSVG.cs" >}}

## **לטעון קובץ DWG גדול**

Aspose.CAD עבור .NET מספקת את האפשרות לפתוח קובצי DWG מאוד גדולים בעזרת הקלאס [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image). עכשיו אתה יכול לפתוח קבצים גדולים בקלות עם העזרה של קוד דוגמה המוצג למטה.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-LargeDWGToPDF-LargeDWGToPDF.cs" >}}
