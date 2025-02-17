---
title: שרטוטי DXB
type: docs
weight: 70
url: /he/net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **ייצוא בפורמט DXB ל-PDF**

Aspose.CAD עבור .NET מאפשר למפתחים לייצא קובץ DXB לפורמט [PDF](https://docs.fileformat.com/pdf/). גישת המרה מ-DXB ל-[PDF](https://docs.fileformat.com/pdf/) פועלת כפי שמפורט להלן:

1. טען את קובץ השרטוט DXB באמצעות שיטת המפעל [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
2. צור אובייקט של מחלקת [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) והגדר את המאפיינים [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) ו-[**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
3. צור אובייקט של מחלקת [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) והגדר את מאפיין [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
4. קרא ל-[**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) תוך כדי העברת אובייקט של [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) כפרמטר השני.

## קוד לדוגמה

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DXB-to-PDF-Export.cs" >}}
