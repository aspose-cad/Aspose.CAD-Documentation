---
title: ייצוא פורמט DGN AutoCAD
type: docs
weight: 50
url: /he/net/developer-guide/exporting-dgn-autocad/
---

## **ייצוא פורמט DGN AutoCAD לקובץ PDF**

Aspose.CAD עבור .NET API הציגה את הפונקציה לטעון קובץ DGN AutoCAD ולהמיר אותו לפורמט PDF. [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) המעמד משמש למטרה זו.

תצטרך לטעון קובץ DGN קיים כ-[**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage). צור מופע של ה-[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) והגדר מאפיינים שונים. צור מופע של ה-[**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) ו-pass את המופע של [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions). עכשיו קרא למתודה [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) של המעמד [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage).

### דוגמת קוד

הנה ההדגמה של הקוד להמיר/לייצא [DGN](https://docs.fileformat.com/cad/dgn/) לפורמט [PDF](https://docs.fileformat.com/pdf/).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **ייצוא פורמט DGN AutoCAD לפורמט תמונה רסטרית**

Aspose.CAD עבור .NET API הציגה את הפונקציה לטעון קובץ DGN AutoCAD ולהמיר אותו לתמונה רסטרית. [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) המעמד משמש למטרה זו.

תצטרך לטעון קובץ DGN קיים כ-[**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage). צור מופע של ה-[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) והגדר מאפיינים שונים. צור מופע של ה-[**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) ועבר את המופע של [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions). עכשיו קרא למתודה [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) של המעמד [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage).

### דוגמת קוד

הנה ההדגמה של הקוד להמיר/לייצא [DGN](https://docs.fileformat.com/cad/dgn/) לתמונה [JPEG](https://docs.fileformat.com/image/jpeg/).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-ExportDGNToRasterImage-ExportDGNToRasterImage.cs" >}}

## **תמיכה ישויות 3D עבור DGN v7**

Aspose.CAD עבור .NET API הציגה את הפונקציה לטעון קובץ [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD ולתמוך בישויות 3D עבור DGN v7. [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) המעמד משמש למטרה זו. כל תמונת [DGN](https://docs.fileformat.com/cad/dgn/) תומכת ב-9 תצוגות מוגדרות מראש. זה נמנה מ-1 עד 9. אם התצוגה לא מוגדרת בזמן ייצוא, עבור פורמטי פלט עם דפים מרובים (כמו PDF), כל התצוגות ייצאו, כל אחת בדף נפרד. ישויות 3D נתמכות בפורמט קובץ DGN, כמו גם 2D. לצורך זה, [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) משמש, TypeOfEntities לא בשימוש יותר עבור פורמט DGN (גם 2D וגם 3D נתמכים במקביל).

### דוגמת קוד

הנה דוגמת הקוד של רכיבי DGN הנתמכים.
  
{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-SupportOf3DForDGNV7-3DSupportForDGNV7.cs" >}}
