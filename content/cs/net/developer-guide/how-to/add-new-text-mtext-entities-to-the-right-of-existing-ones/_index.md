---
title: Přidání nových entit TEXT/MTEXT doprava od existujících
type: docs
weight: 17
url: /cs/net/developer-guide/how-to/add-new-text-mtext-entities-to-the-right-of-existing-ones/
---

## **Jak přidat nové entity TEXT/MTEXT doprava od existujících**

**Problém:** Jak přidat nové entity TEXT/MTEXT doprava od existujících (CADNET-8172).

**Tipy:** Abyste tohoto dosáhli, vytvořte objekt CadBaseEntity, vytvořte CadMText nebo CadText s textem, v novém objektu přidejte do pole SoftOwner hodnotu cadImage.Layouts["Model"].BlockTableRecordHandle z výkresu a přidejte ho do bloku cadImage.BlockEntities[" *MODEL_SPACE"] a nový objekt přidejte do entit výkresu.

**Příklad:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "pridani-novych-text-mtext-entit-doprava-od-existujicich.cs" >}}
