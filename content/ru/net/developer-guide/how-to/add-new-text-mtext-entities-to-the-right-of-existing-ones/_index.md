---
title: Добавить новые сущности TEXT/MTEXT справа от существующих 
type: docs
weight: 17
url: /ru/net/developer-guide/how-to/add-new-text-mtext-entities-to-the-right-of-existing-ones/
---

## **Как добавить новые сущности TEXT/MTEXT справа от существующих**

**Проблема:** Как добавить новые сущности TEXT/MTEXT справа от существующих (CADNET-8172).

**Советы:** Для этого создайте объект CadBaseEntity, создайте CadMText или CadText с текстом, в новом объекте в поле SoftOwner добавьте cadImage.Layouts["Model"].BlockTableRecordHandle из чертежа и добавьте его в блок cadImage.BlockEntities[" *MODEL_SPACE"] и добавьте новый объект в сущности чертежа.

**Пример:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "add-new-text-mtext-entities-to-the-right-of-existing-ones.cs" >}}
