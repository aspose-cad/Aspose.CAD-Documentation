---
title: Додати нові TEXT/MTEXT сутності праворуч від існуючих 
type: docs
weight: 17
url: /uk/net/developer-guide/how-to/add-new-text-mtext-entities-to-the-right-of-existing-ones/
---

## **Як додати нові TEXT/MTEXT сутності праворуч від існуючих**

**Проблема:** Як додати нові TEXT/MTEXT сутності праворуч від існуючих (CADNET-8172).

**Поради:** Для цього створіть об'єкт CadBaseEntity, створіть CadMText або CadText з текстом, в новому об'єкті в поле SoftOwner додайте cadImage.Layouts["Model"].BlockTableRecordHandle з креслення і додайте його до блоку cadImage.BlockEntities[" *MODEL_SPACE"] та додайте новий об'єкт до сутностей креслення.

**Приклад:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "add-new-text-mtext-entities-to-the-right-of-existing-ones.cs" >}}
