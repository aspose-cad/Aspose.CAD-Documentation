---
title: שרטוטי STP
type: docs
weight: 160
url: /he/python-net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **ייצוא פורמט STP ל-PDF**

Aspose.CAD עבור Python מאפשר למפתחים לייצא קובץ [STP](https://docs.fileformat.com/3d/stp/) לפורמט [PDF](https://docs.fileformat.com/pdf/). גישת ההמרה מ-[STP](https://docs.fileformat.com/3d/stp/) ל-[PDF](https://docs.fileformat.com/pdf/) פועלת כדלקמן:

1. טען קובץ שרטוט [STP](https://docs.fileformat.com/3d/stp/) באמצעות מתודת המפעל **Image.load**.
1. צור אובייקט של מחלקת **CadRasterizationOptions** והגדר את המאפיינים **page_height** ו-**page_width**.
1. צור אובייקט של מחלקת **PdfOptions** והגדר את המאפיין **vector_rasterization_options**.
1. התקשר ל-**Image.save** תוך כדי העברת אובייקט של **PdfOptions** כפרמטר השני.

## דוגמת קוד

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-STP-to-PDF-Export.py" >}}
