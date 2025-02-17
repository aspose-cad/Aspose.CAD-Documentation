---
title: שרטוטי FBX
type: docs
weight: 70
url: /he/net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **ייצוא פורמט FBX ל-PDF**

Aspose.CAD עבור .NET מאפשר למפתחים לייצא קובץ [FBX](https://docs.fileformat.com/3d/fbx/) לפורמט [PDF](https://docs.fileformat.com/pdf/). גישת ההמרה מ-[FBX](https://docs.fileformat.com/3d/fbx/) ל-[PDF](https://docs.fileformat.com/pdf/) פועלת כדלקמן:

1. טען את קובץ השרטוט [FBX](https://docs.fileformat.com/3d/fbx/) באמצעות המתודה מפ fábrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. צור אובייקט של מחלקת [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) והגדר את המאפיינים [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) ו-[**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. צור אובייקט של מחלקת [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) והגדר את המאפיין [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. התקשר ל-[**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) כאשר אתה מעביר אובייקט של [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) כפרמטר השני.

## דוגמת קוד

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-FBX-to-PDF-Export.cs" >}}
