---
title: זיהוי דפי קוד אוטומטי
type: docs
weight: 10
url: /he/net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **זיהוי דפי קוד אוטומטי**

Aspose.CAD תומך בזיהוי דפי קוד אוטומטי עבור [DWG](https://docs.fileformat.com/cad/dwg/) ו[DWF](https://docs.fileformat.com/cad/dwf/) קבצים. אם אינכם מעוניינים להשתמש בתכונה זו, אתם יכולים לעקוף זאת על ידי הגדרת המאפיינים הבאים של מחלקת [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions).

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedencoding): מגדיר את הקידוד שמשתמשים בו לקרוא נתוני טקסט מפורמטים לא-יוניקוד DXF ו-DWG. הוא מזוהה אוטומטית לפי ברירת המחדל.
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedmifencoding): מגדיר את הקידוד שמשתמשים בו לקרוא סמלים מקודדים MIF של קידודי CJK (M+nXXXX פורמט). הוא מזוהה אוטומטית לפי ברירת המחדל.
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/recovermalformedcifmif): מגדיר אם תווים מקודדים CIF (U+XXXX) ו-MIF יתפרשו מחדש אם הם לא מכילים פורמט AutoCAD נכון (AutoCAD מקדים סמלים אלו בסימן לכותנה). לפי ברירת המחדל, הם מפורסמים מחדש.

## דוגמת קוד

דוגמת הקוד למטה מראה כיצד לעקוף את זיהוי דפי הקוד האוטומטי ב-Aspose.CAD.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-OverrideAutomaticCodepageDetectionDwg-1.cs" >}}
