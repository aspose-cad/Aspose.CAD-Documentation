---
title: דפי DWF
type: docs
weight: 50
url: /he/python-net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **ייצוא דפי DWF ל-PDF**

Aspose.CAD מספקת את הפיצ'ר לטעון ישויות ציור AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) ולבצע רינדור שלהן כציור שלם בפורמט [PDF](https://docs.fileformat.com/pdf/). גישת ההמרה מ-[DWF](https://docs.fileformat.com/cad/dwf/) ל-[PDF](https://docs.fileformat.com/pdf/) פועלת כדלקמן:

1. טען קובץ ציור [DWF](https://docs.fileformat.com/cad/dwf/) באמצעות מתודולוגיית **Image.load**.
1. צור אובייקט של מחלקת **CadRasterizationOptions** והגדר את המאפיינים **page_height** ו- **page_width**.
1. צור אובייקט של מחלקת **PdfOptions** והגדר את מאפיין **vector_rasterization_options**.
1. קרא ל-**Image.save** תוך כדי העברת אובייקט של **PdfOptions** כמפרמטר השני.

### דוגמת קוד

דוגמת הקוד למטה מראה כיצד להמיר קובץ תוך שימוש בהגדרות ברירת מחדל.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-PDF-Export.py" >}}

## **ייצוא דפי DWF ל-BMP**

Aspose.CAD מספקת את הפיצ'ר לטעון ישויות ציור AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) ולבצע רינדור שלהן כציור שלם בפורמט [BMP](https://docs.fileformat.com/image/bmp/). גישת ההמרה מ-[DWF](https://docs.fileformat.com/cad/dwf/) ל-[BMP](https://docs.fileformat.com/image/bmp/) פועלת כדלקמן:

1. טען קובץ ציור [DWF](https://docs.fileformat.com/cad/dwf/) באמצעות מתודולוגיית **Image.load**.
1. צור אובייקט של מחלקת **CadRasterizationOptions** והגדר את המאפיינים **page_height** ו- **page_width**.
1. צור אובייקט של מחלקת **BmpOptions** והגדר את מאפיין **vector_rasterization_options**.
1. קרא ל-**Image.save** תוך כדי העברת אובייקט של **BmpOptions** כמפרמטר השני.

### דוגמת קוד

דוגמת הקוד למטה מראה כיצד להמיר קובץ [DWF](https://docs.fileformat.com/cad/dwf/) ל-[BMP](https://docs.fileformat.com/image/bmp/) תוך שימוש בהגדרות ברירת מחדל.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-BMP-Export.py" >}}
