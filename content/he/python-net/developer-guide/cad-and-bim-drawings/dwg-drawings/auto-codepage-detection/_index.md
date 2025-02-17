---
title: זיהוי קוד דף אוטומטי
type: docs
weight: 10
url: /he/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **זיהוי קוד דף אוטומטי**

Aspose.CAD תומך בזיהוי קוד דף אוטומטי עבור [DWG](https://docs.fileformat.com/cad/dwg/) ו [DWF](https://docs.fileformat.com/cad/dwf/) קבצים. אם אינך מעוניין להשתמש בתכונה זו, תוכל לעקוף זאת על ידי הגדרת המאפיינים הבאים של מחלקת **LoadOptions**.

- **specified_encoding**: מגדיר את הקידוד המשמש לקריאת נתוני טקסט מקובצי DXF ו-DWG שאינם Unicode. הוא מזוהה באופן אוטומטי כברירת מחדל.
- **specified_mif_encoding**: מגדיר את הקידוד המשמש לקריאת סמלים מקודדים MIF של קידודי CJK (פורמט M+nXXXX). הוא מזוהה באופן אוטומטי כברירת מחדל.
- **recover_malformed_cif_mif**: מגדיר האם תווים מקודדים CIF (U+XXXX) ו-MIF יתפרשו אם אין להם עיצוב מתאים של AutoCAD (AutoCAD מקדים סמלים אלו עם מקף הפסק). כברירת מחדל, הם מתפרשים.

## דוגמת קוד

בדוגמת הקוד למטה מוצג כיצד לעקוף את זיהוי קוד הדף האוטומטי ב-Aspose.CAD.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-OverrideAutomaticCodepageDetectionDwg.py" >}}
