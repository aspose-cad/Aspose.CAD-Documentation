---
title: Add new TEXT/MTEXT entities to the right of existing ones 
type: docs
weight: 10
url: /net/how-to/add-new-text-mtext-entities-to-the-right-of-existing-ones/
---

## **How to add new TEXT/MTEXT entities to the right of existing ones**

**Issue:** How to add new TEXT/MTEXT entities to the right of existing ones (CADNET-8172).

**Tips:** To do this, create a CadBaseEntity object, create a CadMText or CadText with text, in the new object to the SoftOwner field add cadImage.Layouts["Model"].BlockTableRecordHandle from the drawing and add it to the cadImage.BlockEntities[" *MODEL_SPACE"] block and add new object to drawing entities.

**Example:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "add-new-text-mtext-entities-to-the-right-of-existing-ones.cs" >}}