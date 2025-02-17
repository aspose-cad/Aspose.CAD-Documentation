---
title: הזזת רישום למטה כדי להוסיף כותרת
type: docs
weight: 40
url: /he/net/developer-guide/how-to/move-drawing-down-to-add-title/
---

## **איך להזיז רישום למטה כדי להוסיף כותרת**

**בעיות:** איך להזיז רישום למטה כדי להוסיף כותרת (CADNET-980).

**טיפים:** כדי לעשות זאת, צור אובייקט CadText עם פרמטרים, הוסף את הבלוק הזה לרישום, ואז עדכן את הרישום עם הממדים החדשים באמצעות UpdateSize, הוסף פוליליין שהוא מסגרת סביב הרישום, הוסף את הפוליליין ל- BlockEntities["*Model_Space"] ועדכן שוב עם UpdateSize.

**דוגמה:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "move-drawing-down-to-add-title.cs" >}}
