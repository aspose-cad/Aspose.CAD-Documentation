---
title: בדוק אם התמונות המיועדות החיצוניות קיימות והחלף הפניות
type: docs
weight: 22
url: /he/net/developer-guide/how-to/check-whether-external-referenced-images-exist-and-replace-references/
---

## **איך לערוך היפרלינקים על אובייקטים**

**בעיה:** איך לבדוק אם התמונות המיועדות החיצוניות קיימות ולהחליף הפניות (CADNET-8088).

**טיפים:** כדי לעשות זאת, קבל ישות מסוג CadObjectTypeName.IMAGEDEF מהאנטיטיס של השרטוט והשתמש ב-CadRasterImageDef לבדוק.

**דוגמא:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "check-whether-external-referenced-images-exist-and-replace-references.cs" >}}
