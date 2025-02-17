---
title: הכנס ציור DXF/DWG בתוך DXF
type: docs
weight: 39
url: /he/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dxf/
---

## **איך להכניס ציור DXF/DWG בתוך DXF**

**בעיה:** איך להכניס ציור DXF/DWG בתוך DXF.

**טיפים:** כדי לעשות זאת, עליך קודם כל ליצור CadInsertObject עם הערכים הנדרשים, ואז לקבל את כל הבלוקים ב-CadBlockDictionary, ליצור בלוק CadBlockEntity חדש ולהוסיף אותו ל-CadBlockDictionary, להוסיף את CadBlockDictionary ל-BlockEntities של הציור, להוסיף CadInsertObject ליישויות של הציור עבור המערך.

**דוגמה:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dxf.cs" >}}
