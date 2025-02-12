---
title: إضافة كائنات TEXT/MTEXT جديدة إلى يمين الكائنات الموجودة 
type: docs
weight: 17
url: /ar/net/developer-guide/how-to/add-new-text-mtext-entities-to-the-right-of-existing-ones/
---

## **كيفية إضافة كائنات TEXT/MTEXT جديدة إلى يمين الكائنات الموجودة**

**المشكلة:** كيفية إضافة كائنات TEXT/MTEXT جديدة إلى يمين الكائنات الموجودة (CADNET-8172).

**نصائح:** للقيام بذلك، أنشئ كائن CadBaseEntity، قم بإنشاء CadMText أو CadText مع النص، في الكائن الجديد، أضف cadImage.Layouts["Model"].BlockTableRecordHandle من الرسم إلى حقل SoftOwner وأضفه إلى كتلة cadImage.BlockEntities[" *MODEL_SPACE"] وأضف الكائن الجديد إلى كائنات الرسم.

**مثال:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "add-new-text-mtext-entities-to-the-right-of-existing-ones.cs" >}}
