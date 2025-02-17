---
title: שרטוטי DRC
type: docs
weight: 15
url: /he/net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **ייצוא שרטוטי DRC לפורמט PDF**

Aspose.CAD מספקת את הפיצ'ר לטעון ישויות שרטוט AutoCAD [DRC](https://docs.fileformat.com/3d/drc/) ולגרום להם להיראות כמו שרטוט שלם לפורמט [PDF](https://docs.fileformat.com/pdf/). גישת ההמרה מ-[DRC](https://docs.fileformat.com/3d/drc/) ל-[PDF](https://docs.fileformat.com/pdf/) פועלת כדלקמן:

1. טען את קובץ השירטוט [DRC](https://docs.fileformat.com/3d/drc/) באמצעות מתודת היצור [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. צור אובייקט של המחלקה [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) והגדר את המאפיינים [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) ו-[**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. צור אובייקט של המחלקה [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) והגדר את המאפיין [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. קרא ל-[**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) כשאתה מעביר אובייקט של [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) כפרמטר השני.

### דוגמת קוד

דוגמת הקוד למטה מראה כיצד להמיר קובץ תוך שימוש בהגדרות ברירת המחדל.


{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DRC-to-PDF-Export.cs" >}}
