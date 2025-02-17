---
title: זיהוי קוד-דף אוטומטי
type: docs
weight: 10
url: /he/java/developer-guide/autocad-drawings/dwg-drawings/auto-codepage-detection/
---

## **זיהוי קוד-דף אוטומטי**

Aspose.CAD תומכת בזיהוי קוד-דף אוטומטי עבור [DWG](https://docs.fileformat.com/cad/dwg/) ו [DWF](https://docs.fileformat.com/cad/dwf/) קבצים. אם אינכם מעוניינים להשתמש בתכונה זו, תוכלו לבטל זאת על ידי הגדרת המאפיינים הבאים של מחלקת [**LoadOptions**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions).

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedEncoding-int-): מגדיר את הקידוד המשמש לקרוא נתוני טקסט מקבצים ב DXF וב DWG שאינם Unicode. הוא מזוהה אוטומטית כברירת מחדל.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedMifEncoding-int-): מגדיר את הקידוד המשמש לקרוא סמלים מקודדים במערכת MIF של קידודים CJK (פורמט M+nXXXX). הוא מזוהה אוטומטית כברירת מחדל.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setRecoverMalformedCifMif-boolean-): מגדיר האם תווים מקודדים CIF (U+XXXX) ו-MIF יפורקו אם אין להם פורמט AutoCAD מתאים (AutoCAD מקדים סמלים אלה עם קו נטוי אחורה). כברירת מחדל, הם מפורקים.

## דוגמת קוד

בדוגמת הקוד למטה מוצגת כיצד לבטל את זיהוי קוד-דף האוטומטי ב-Aspose.CAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-OverrideAutomaticCodePageDetectionDwg-1.java" >}}
