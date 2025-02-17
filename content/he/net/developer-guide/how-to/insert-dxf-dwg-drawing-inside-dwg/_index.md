---
title: הכנס שרטוט DXF/DWG בתוך DWG
type: docs
weight: 38
url: /he/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dwg/
---

## **איך להכניס שרטוט DXF/DWG בתוך DWG**

**בעיה:** איך להכניס שרטוט DXF/DWG בתוך DWG.

**טיפים:** כדי לעשות זאת, קודם כל צור CadInsertObject עם הערכים הנדרשים, לאחר מכן קבל את כל הבלוקים ב-CadBlockDictionary, צור בלוק חדש CadBlockEntity והוסף אותו ל-CadBlockDictionary, הוסף CadBlockDictionary ל-BlockEntities של השרטוט, הוסף CadInsertObject לישות השרטוט עבור המערך, צור CadBlockTableObject על פי ייחוס, ולאחר מכן הוסף בלוק לשרטוט.

**דוגמה:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dwg.cs" >}}
