---
title: Lägg till nya TEXT/MTEXT-enheter till höger om befintliga 
type: docs
weight: 17
url: /sv/net/developer-guide/how-to/add-new-text-mtext-entities-to-the-right-of-existing-ones/
---

## **Hur man lägger till nya TEXT/MTEXT-enheter till höger om befintliga**

**Problem:** Hur man lägger till nya TEXT/MTEXT-enheter till höger om befintliga (CADNET-8172).

**Tips:** För att göra detta, skapa ett CadBaseEntity-objekt, skapa en CadMText eller CadText med text, i det nya objektet lägg till cadImage.Layouts["Model"].BlockTableRecordHandle från ritningen till SoftOwner-fältet och lägg till det i cadImage.BlockEntities[" *MODEL_SPACE"]-blocket och lägg till det nya objektet till ritningsenheterna.

**Exempel:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "add-new-text-mtext-entities-to-the-right-of-existing-ones.cs" >}}
