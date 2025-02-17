---
title: שרטוטי COLLADA
type: docs
weight: 70
url: /he/net/developer-guide/cad-and-bim-drawings/collada-drawings/
---

## **ייצוא פורמט COLLADA ל-PDF**

Aspose.CAD עבור .NET מאפשר למפתחים לייצא קובץ [COLLADA](https://docs.fileformat.com/3d/dae/) לפורמט [PDF](https://docs.fileformat.com/pdf/). גישת המרה מ[COLLADA](https://docs.fileformat.com/3d/dae/) ל[PDF](https://docs.fileformat.com/pdf/) פועלת כך:

1. טען קובץ שרטוט [COLLADA](https://docs.fileformat.com/3d/dae/) באמצעות שיטת המפעל [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. צור אובייקט של מחלקת [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) ו-set את המאפיינים [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) ו-[**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. צור אובייקט של מחלקת [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) והגדר את המאפיין [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. קרא ל[**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) כאשר אתה מעביר אובייקט של [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) כפרמטר השני.

## דוגמת קוד

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-COLLADA-to-PDF-Export.cs" >}}
