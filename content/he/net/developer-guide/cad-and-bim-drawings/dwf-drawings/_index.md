---
title: שרטוטי DWF
type: docs
weight: 20
url: /he/net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **ייצוא שרטוטי DWF לפורמט PDF**

Aspose.CAD מספקת את האפשרות לטעון ישויות שרטוט של AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) ולהציג אותם כשרטוט שלם בפורמט [PDF](https://docs.fileformat.com/pdf/). גישת ההמרה מ-[DWF](https://docs.fileformat.com/cad/dwf/) ל-[PDF](https://docs.fileformat.com/pdf/) פועלת כדלקמן:

1. טען קובץ שרטוט [DWF](https://docs.fileformat.com/cad/dwf/) בעזרת שיטת המפעל [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. צור אובייקט של מחלקת [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) והגדר את המאפיינים [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. צור אובייקט של מחלקת [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) והגדר את המאפיין [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. התקשר ל[**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) תוך כדי העברת אובייקט של [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) כפרמטר השני.

### דוגמת קוד

דוגמת הקוד למטה מראה כיצד להמיר קובץ בעזרת ההגדרות המחדליות.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **חילוץ שכבות משרטוט DWF**

Aspose.CAD מספקת את האפשרות לטעון ישויות שרטוט של AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) ולהציג אותם כשרטוט שלם בפורמט [JPEG](https://docs.fileformat.com/image/jpeg/).

1. טען קובץ שרטוט [DWF](https://docs.fileformat.com/cad/dwf/) בעזרת שיטת המפעל [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. צור אובייקט של מחלקת [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions).
1. צור אובייקט של מחלקת [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. חתוך את שמות השכבות באמצעות האובייקט [JPEG](https://docs.fileformat.com/image/jpeg/).
1. התקשר ל[**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) תוך כדי העברת אובייקט של [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) כפרמטר השני.

### דוגמת קוד

דוגמת הקוד למטה מראה כיצד להמיר קובץ בעזרת ההגדרות המחדליות.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **תמיכה בשכבות ב-DWF**

Aspose.CAD מספקת את האפשרות לטעון ישויות שרטוט של AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) ולהציג אותם כשרטוט שלם בפורמט [JPEG](https://docs.fileformat.com/image/jpeg/).

1. טען קובץ שרטוט [DWF](https://docs.fileformat.com/cad/dwf/) בעזרת שיטת המפעל [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. צור אובייקט של מחלקת [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. הוסף שכבות רצויות.
1. התקשר ל[**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) תוך כדי העברת אובייקט של [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) כפרמטר השני.

### דוגמת קוד

דוגמת הקוד למטה מראה כיצד להמיר קובץ בעזרת ההגדרות המחדליות.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWF-Drawings-SupportOfLayers-SupportOfLayers.cs" >}}

## **ייצוא שרטוטי DWF לפורמט BMP**

Aspose.CAD מספקת את האפשרות לטעון ישויות שרטוט של AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) ולהציג אותם כשרטוט שלם בפורמט [BMP](https://docs.fileformat.com/image/bmp/). גישת ההמרה מ-[DWF](https://docs.fileformat.com/cad/dwf/) ל-[BMP](https://docs.fileformat.com/image/bmp/) פועלת כדלקמן:

1. טען קובץ שרטוט [DWF](https://docs.fileformat.com/cad/dwf/) בעזרת שיטת המפעל [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. צור אובייקט של מחלקת [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) והגדר את המאפיינים [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. צור אובייקט של מחלקת [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) והגדר את המאפיין [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. התקשר ל[**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) תוך כדי העברת אובייקט של [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) כפרמטר השני.

### דוגמת קוד

דוגמת הקוד למטה מראה כיצד להמיר קובץ [DWF](https://docs.fileformat.com/cad/dwf/) לפורמט [BMP](https://docs.fileformat.com/image/bmp/) בעזרת ההגדרות המחדליות.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}
