---
title: ציורים ב-SVG
type: docs
weight: 70
url: /he/net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **ייצוא פורמט SVG ל-PDF**

Aspose.CAD עבור .NET מאפשר ל developers לייצא קובץ SVG לפורמט [PDF](https://docs.fileformat.com/pdf/). גישת ההמרה מ-SVG ל-[PDF](https://docs.fileformat.com/pdf/) פועלת כך:

1. טען את קובץ הציור SVG באמצעות שיטת ה-factory [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. צור אובייקט של המחלקה [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) והגדר את המאפיינים [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) ו-[**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. צור אובייקט של המחלקה [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) והגדר את המאפיין [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. קרא ל-[**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) תוך כדי העברת אובייקט של [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) כפרמטר השני.

## קוד לדוגמה

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-SVG-to-PDF-Export.cs" >}}
