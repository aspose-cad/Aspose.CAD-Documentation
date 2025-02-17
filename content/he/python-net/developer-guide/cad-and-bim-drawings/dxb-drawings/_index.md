---
title: שרטוטי DXB
type: docs
weight: 90
url: /he/python-net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **ייצוא פורמט DXB ל-PDF**

Aspose.CAD עבור Python מאפשר למפתחים לייצא קובץ DXB לפורמט [PDF](https://docs.fileformat.com/pdf/). גישת ההמרה מ-DXB ל-[PDF](https://docs.fileformat.com/pdf/) פועלת כדלקמן:

1. טען את קובץ השרטוט DXB באמצעות מתודת המפעל **Image.load**.
1. צור אובייקט של מחלקת **CadRasterizationOptions** והגדר את המאפיינים **page_height** ו-**page_width**.
1. צור אובייקט של מחלקת **PdfOptions** והגדר את המאפיין **vector_rasterization_options**.
1. קרא ל-**Image.save** תוך כדי העברת אובייקט של **PdfOptions** כפרמטר השני.

## דוגמת קוד

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXB-to-PDF-Export.py" >}}
