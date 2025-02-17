---
title: 3DS Drawings
type: docs
weight: 70
url: /he/net/developer-guide/cad-and-bim-drawings/3ds-drawings/
---

## **ייצוא פורמט 3DS ל-PDF**

Aspose.CAD עבור .NET מאפשר למפתחים לייצא קובץ [3DS](https://docs.fileformat.com/3d/3ds/) לפורמט [PDF](https://docs.fileformat.com/pdf/). גישת ההמרה מ-[3DS](https://docs.fileformat.com/3d/3ds/) ל-[PDF](https://docs.fileformat.com/pdf/) פועלת כפי שמפורט להלן:

1. טען קובץ רישום [3DS](https://docs.fileformat.com/3d/3ds/) באמצעות השיטה המ фабрика [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. צור אובייקט של מחלקת [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) וקבע את מאפייני [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) ו-[**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. צור אובייקט של מחלקת [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) וקבע את מאפיין [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. קרא ל-[**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) תוך כדי העברת אובייקט של [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) כפרמטר השני.

## דוגמת קוד

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-3DS-to-PDF-Export.cs" >}}
