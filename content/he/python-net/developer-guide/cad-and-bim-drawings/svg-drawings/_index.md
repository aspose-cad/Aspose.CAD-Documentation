---
title: ציורים של SVG
type: docs
weight: 170
url: /he/python-net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **ייצוא פורמט SVG ל-PDF**

Aspose.CAD עבור Python מאפשר למפתחים לייצא קובץ [SVG](https://docs.fileformat.com/page-description-language/svg/) לפורמט [PDF](https://docs.fileformat.com/pdf/). גישת המרה מ-[SVG](https://docs.fileformat.com/page-description-language/svg/) ל-[PDF](https://docs.fileformat.com/pdf/) פועלת כך:

1. טען את קובץ ציור ה-SVG באמצעות שיטת המפעל **Image.load**.
1. צור אובייקט של מחלקת **CadRasterizationOptions** והגדר את המאפיינים **page_height** ו-**page_width**.
1. צור אובייקט של מחלקת **PdfOptions** והגדר את מאפיין **VectorRasterizationOptions**.
1. הזמן את **Image.save** תוך כדי העברת אובייקט של **PdfOptions** כפרמטר השני.

## דוגמת קוד

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-SVG-to-PDF-Export.py" >}}
