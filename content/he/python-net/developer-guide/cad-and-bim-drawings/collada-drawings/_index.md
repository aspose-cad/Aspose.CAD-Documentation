---
title: שרטוטי COLLADA
type: docs
weight: 20
url: /he/python-net/developer-guide/cad-and-bim-drawings/collada-drawings/
---

## **ייצוא בפורמט COLLADA ל-PDF**

Aspose.CAD עבור Python מאפשר למפתחים לייצא קובץ [COLLADA](https://docs.fileformat.com/3d/dae/) לפורמט [PDF](https://docs.fileformat.com/pdf/). גישת ההמרה מ-[COLLADA](https://docs.fileformat.com/3d/dae/) ל-[PDF](https://docs.fileformat.com/pdf/) פועלת כדלקמן:

1. טען קובץ שרטוט [COLLADA](https://docs.fileformat.com/3d/dae/) באמצעות שיטת המפעל **Image.load**.
1. צור אובייקט של מחלקת **CadRasterizationOptions** והגדר את מאפייני **page_height** ו-**page_width**.
1. צור אובייקט של מחלקת **PdfOptions** והגדר את מאפיין **vector_rasterization_options**.
1. קרא ל-**Image.save** תוך כדי העברת אובייקט של **PdfOptions** כפרמטר השני.

## קוד לדוגמה

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-COLLADA-to-PDF-Export.py" >}}
