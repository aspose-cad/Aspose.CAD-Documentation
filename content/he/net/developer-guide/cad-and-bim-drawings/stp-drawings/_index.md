---
title: שרטוטי STP
type: docs
weight: 70
url: /he/net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **ייצוא פורמט STP ל-PDF**

Aspose.CAD עבור .NET מאפשר למפתחים לייצא קובץ [STP](https://docs.fileformat.com/3d/stp/) לפורמט [PDF](https://docs.fileformat.com/pdf/). גישת ההמרה מ-[STP](https://docs.fileformat.com/3d/stp/) ל-[PDF](https://docs.fileformat.com/pdf/) פועלת כדלקמן:

1. טען קובץ שרטוט [STP](https://docs.fileformat.com/3d/stp/) באמצעות שיטת המפעל [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. צור אובייקט של מחלקת [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) והגדר את התכונות [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) ו-[**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. צור אובייקט של מחלקת [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) והגדר את התכונה [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. קרא ל-[**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) בעודך מעביר אובייקט של [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) כפרמטר השני.

## דוגמת קוד

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-STP-to-PDF-Export.cs" >}}
