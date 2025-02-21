---
title: 将新的 TEXT/MTEXT 实体添加到现有实体的右侧
type: docs
weight: 17
url: /zh/net/developer-guide/how-to/add-new-text-mtext-entities-to-the-right-of-existing-ones/
---

## **如何将新的 TEXT/MTEXT 实体添加到现有实体的右侧**

**问题：** 如何将新的 TEXT/MTEXT 实体添加到现有实体的右侧 (CADNET-8172)。

**提示：** 要做到这一点，创建一个 CadBaseEntity 对象，使用文本创建一个 CadMText 或 CadText，在新对象的 SoftOwner 字段中添加 cadImage.Layouts["Model"].BlockTableRecordHandle 来自图纸，并将其添加到 cadImage.BlockEntities[" *MODEL_SPACE"] 块中，并将新对象添加到图纸实体中。

**示例：**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "add-new-text-mtext-entities-to-the-right-of-existing-ones.cs" >}}
