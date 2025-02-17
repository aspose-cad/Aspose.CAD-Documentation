---
title: איורים DXF
type: docs
weight: 60
url: /he/net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **ייצוא איורי DXF ל-PDF**

Aspose.CAD מספקת את האפשרות לטעון ישויות איור DXF של AutoCAD ולהציג את כולן בפורמט PDF. גישת המרה מ-DXF ל-PDF מתבצעת כך:

1. טען קובץ איור DXF באמצעות המתודת [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. צור אובייקט של מחלקת [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) וקבע את המאפיינים [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. צור אובייקט של מחלקת [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) וקבע את מאפיין ה-[**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. קרא ל-[**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) תוך העברת אובייקט של [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) כעוד פרמטר.

דוגמת הקוד למטה מראה כיצד להמיר קובץ באמצעות הגדרות ברירת מחדל.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFToPDF-ExportDXFToPDF.cs" >}}

### **פורמטים נתמכים**

נכון לעכשיו אנו תומכים במלואם בפורמטי קבצים DXF 2010 של AutoCAD. לא מובטחת תקValidity של גרסאות DXF הקודמות. אנו מתכננים לכלול פורמטים נוספים ופיצ'רים בגרסאות עתידיות של Aspose.CAD.

### **ישויות נתמכות**

נכון לעכשיו אנו תומכים בכל הישויות 2D הנפוצות ובפרמטרים ברירת המחדל הבסיסיים שלהם כדלקמן:

1. ממד מיושר
1. ממד זוויתי
1. קשת
1. מאפיין
1. הפניה לחסימה
1. עיגול
1. ממד קוטר
1. אליפסה
1. הדגשה
1. קו
1. טקסט מרובה שורות
1. ממד סדרתי
1. נקודה
1. פוליליין
1. ממד רדיאלי
1. קרן
1. ממד מסובב
1. טבלה
1. טקסט
1. קו X

{{% alert color="primary" %}}

אם במהלך הפרסינג ניתקל בישות או במאפיין שאנו לא תומכים בו, הישות או המאפיין יתעלמו בשקט.

{{% /alert %}}

### **ניהול זיכרון**

המאפיין [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) של מחלקת [**Cache**](https://reference.aspose.com/cad/net/aspose.cad/cache) יכול לשמש לשליטה על שידור מחדש של זיכרון. שידור מחדש הוא בגדר הסבירות שיתקיים עבור מטמונות שהוקצו מראש. זה יכול לקרות כאשר המערכת מגלה שהמרחב שהוקצה לא יהיה מספיק.

- אם [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) מוגדר לערך ברירת המחדל, **False**, המרחב יוקצה מחדש לאותו מדיה.
- כאשר זה מוגדר ל-**True**, השידור מחדש לא יכול לעלות על המרחב המקסימלי המוגדר. במקרה זה, המטמון המוקצה בזיכרון הקיים (המצריך שידור מחדש) מתפנה ומרחב נוסף מוקצה בדיסק.

## **ייצוא שכבת DXF ספציפית ל-PDF**

גישת זו מתבצעת כך:

1. פתח קובץ איור DXF באמצעות המתודת [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. צור מופע של [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) וקבע את המאפיינים [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) & [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. הוסף שכבות לאובייקט של [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. צור מופע של [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) וקבע את המאפיין [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. קרא למתודת [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) ועבר את האובייקט של [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) כעוד פרמטר.

דוגמת הקוד למטה מראה כיצד להמיר שכבת DXF ספציפית ל-PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayerToPDF-ExportDXFSpecificLayerToPDF.cs" >}}

## **Render PDF files as a part of DXF drawings**

גישת זו מתבצעת כך:

1. טען קובץ איור DXF באמצעות המתודת [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. צור אובייקט של מחלקת [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) וטען קבצי PDF.
1. קבע את המאפיינים [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. קרא [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) ושמור את הקובץ.

דוגמת הקוד למטה מראה כיצד להציג קבצי PDF כחלק מאיורי DXF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

## **Export embedded DGN underlay for DXF format**

Aspose.CAD מספקת את הפיצ'ר לטעון קובצי DXF של AutoCAD ולייצא את ה-DGN המשולב עבור פורמט DXF.

דוגמת הקוד למטה מראה כיצד להשיג דרישות ספציפיות.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **Support for Saving DXF Files**

Aspose.CAD מספקת את האפשרות לטעון קובצי DXF של AutoCAD ולבצע שינויים בהם ולשמור אותם שוב כקובץ DXF.

דוגמת הקוד למטה מראה כיצד להשיג דרישות ספציפיות.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-SaveDXFFiles-SaveDXFFiles.cs" >}}

## **Export DXF to WMF**

גישת זו מתבצעת כך:

1. טען קובץ איור DXF באמצעות המתודת [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. צור אובייקט של מחלקת [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) וטען קבצי PDF.
1. קבע את המאפיינים [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. קרא [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) ושמור את הקובץ.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportDXFToWMF-ExportDXFToWMF.cs" >}}

## **Exporting Specific DXF Layout to PDF**

גישת זו מתבצעת כך:

1. פתח קובץ איור DXF באמצעות המתודת [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. צור מופע של [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) וקבע את המאפיינים [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) & [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. ציין את השמות הרצויים של הליירים באמצעות המאפיין [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts).
1. צור מופע של [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) וקבע את המאפיין [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. ייצא את האיור ל-PDF על ידי קריאה למתודת [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) ועבר את האובייקט של [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) כעוד פרמטר.

דוגמת הקוד למטה מראה כיצד להמיר שכבה ספציפית של DXF ל-PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

{{% alert color="primary" %}}

המאפיין [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) הוא מסוג מערך מחרוזות כך שתוכל לציין יותר מלייר אחד בכל פעם להמרה אפשרית לפורמט PDF. בעודך מציין מספר ליירים עבור מאפיין [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts), ה-PDF המתקבל יהיה בעל מספר עמודים, כאשר כל עמוד מייצג לייר של AutoCAD.

{{% /alert %}}

## **Support of Block Clipping**

Aspose.CAD מספקת את האפשרות של חיתוך בלוקים. גישת חיתוך בלוקים עובדת כך:

1. טען קובץ איור DXF באמצעות המתודת [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. צור אובייקט של מחלקת [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) וטען קבצי PDF.
1. קבע את המאפיינים הרצויים של [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. קרא ל-[**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) בעת העברת אובייקט של [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) כעוד פרמטר ושמור את הקובץ.

דוגמת הקוד למטה מראה כיצד חיתוך בלוקים עובד.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DXF-Drawings-SupportOfBlockClipping-SupportOfBlockClipping.cs" >}}

## **ייצוא תמונות ל-DXF**

באמצעות Aspose.CAD, אתה יכול לייצא תמונות לפורמט DXF. באמצעות גישה זו, תוכל לבצע את הפעולות הבאות:

1. קבע גופן חדש
1. הסתר ישויות
1. עדכן טקסט

דוגמת הקוד הבאה מראה לך כיצד לבצע את הפעולות המפורטות לעיל.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportImagesToDXF-ExportImagesToDXF.cs" >}}

## **ייצוא שכבת DXF ספציפית לתמונה**

גישת זו מתבצעת כך:

1. פתח קובץ איור DXF באמצעות המתודת [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. צור מופע של [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) וקבע את המאפיינים [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) וה-[**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. הוסף שכבות לאובייקט של [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. צור מופע של [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) וקבע את המאפיין [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. ייצא את האיור ל-PDF באמצעות המתודת [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

דוגמת הקוד למטה מראה כיצד להמיר שכבה ספציפית של DXF לתמונה.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.cs" >}}
