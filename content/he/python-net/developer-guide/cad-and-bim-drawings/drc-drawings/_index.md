---
title: שרטוטי DRC
type: docs
weight: 40
url: /he/python-net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **ייצוא פורמט DRC ל-PDF**

Aspose.CAD עבור Python מאפשר למפתחים לייצא קובץ [DRC](https://docs.fileformat.com/3d/drc/) לפורמט [PDF](https://docs.fileformat.com/pdf/). גישת ההמרה מ-[DRC](https://docs.fileformat.com/3d/drc/) ל-[PDF](https://docs.fileformat.com/pdf/) פועלת כדלקמן:

1. טען את קובץ השרטוט DRC באמצעות מתודת המפעל **Image.load**.
1. צור אובייקט של המחלקה **CadRasterizationOptions** והגדר את המאפיינים **page_height** ו-**page_width**.
1. צור אובייקט של המחלקה **PdfOptions** והגדר את המאפיין **VectorRasterizationOptions**.
1. קרא ל-**Image.save** תוך העברת אובייקט של **PdfOptions** כפרמטר השני.

## דוגמת קוד


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "convert-drc-to-pdf.py" >}}
