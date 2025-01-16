---
title: تحريك الرسم لأسفل لإضافة عنوان
type: docs
weight: 40
url: /ar/net/how-to/move-drawing-down-to-add-title/
---

## **كيفية تحريك الرسم لأسفل لإضافة عنوان**

**المشكلة:** كيفية تحريك الرسم لأسفل لإضافة عنوان (CADNET-980).

**نصائح:** للقيام بذلك، أنشئ كائن CadText مع المعلمات، أضف هذه الكتلة إلى الرسم، ثم قم بتحديث الرسم بالأبعاد الجديدة باستخدام UpdateSize، أضف خطًا متقطعًا يكون إطارًا حول الرسم، أضف خطًا متقطعًا إلى BlockEntities["*Model_Space"] وقم بالتحديث مرة أخرى باستخدام UpdateSize.

**مثال:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "move-drawing-down-to-add-title.cs" >}}
