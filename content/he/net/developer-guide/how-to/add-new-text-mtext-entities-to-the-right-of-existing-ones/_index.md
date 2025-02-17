---
title: הוספת ישויות TEXT/MTEXT חדשות מימין לישויות קיימות
type: docs
weight: 17
url: /he/net/developer-guide/how-to/add-new-text-mtext-entities-to-the-right-of-existing-ones/
---

## **איך להוסיף ישויות TEXT/MTEXT חדשות מימין לישויות קיימות**

**בעיה:** איך להוסיף ישויות TEXT/MTEXT חדשות מימין לישויות קיימות (CADNET-8172).

**טיפים:** כדי לעשות זאת, צור אובייקט CadBaseEntity, צור CadMText או CadText עם טקסט, בשדה SoftOwner של האובייקט החדש הוסף את cadImage.Layouts["Model"].BlockTableRecordHandle מהשרטוט והוסף אותו לבלוק cadImage.BlockEntities[" *MODEL_SPACE"] והוסף אובייקט חדש ליישויות השרטוט.

**דוגמה:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "add-new-text-mtext-entities-to-the-right-of-existing-ones.cs" >}}
