---
title: ציורי FBX
type: docs
weight: 110
url: /he/python-net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **ייצוא פורמט FBX ל-PDF**

Aspose.CAD for Python מאפשר למפתחים לייצא קובץ [FBX](https://docs.fileformat.com/3d/fbx/) לפורמט [PDF](https://docs.fileformat.com/pdf/). גישת ההמרה מ-[FBX](https://docs.fileformat.com/3d/fbx/) ל-[PDF](https://docs.fileformat.com/pdf/) פועלת כך:

1. טען קובץ ציור [FBX](https://docs.fileformat.com/3d/fbx/) באמצעות שיטת מפעל **Image.load**.
1. צור אובייקט של מחלקת **CadRasterizationOptions** והגדר את המאפיינים **PageHeight** ו-**PageWidth**.
1. צור אובייקט של מחלקת **PdfOptions** והגדר את המאפיין **vector_rasterization_options**.
1. קרא ל-**Image.save** בעודך מעביר אובייקט של **PdfOptions** כפרמטר השני.

## דוגמת קוד

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-FBX-to-PDF-Export.py" >}}
