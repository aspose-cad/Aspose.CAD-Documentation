---
title: Neue TEXT/MTEXT-Entitäten rechts von bestehenden hinzufügen
type: docs
weight: 17
url: /de/net/developer-guide/how-to/add-new-text-mtext-entities-to-the-right-of-existing-ones/
---

## **Wie man neue TEXT/MTEXT-Entitäten rechts von bestehenden hinzufügt**

**Problem:** Wie man neue TEXT/MTEXT-Entitäten rechts von bestehenden hinzufügt (CADNET-8172).

**Tipps:** Um dies zu tun, erstellen Sie ein CadBaseEntity-Objekt, erstellen Sie ein CadMText oder CadText mit Text, fügen Sie im neuen Objekt dem SoftOwner-Feld cadImage.Layouts["Model"].BlockTableRecordHandle aus der Zeichnung hinzu und fügen Sie es zum cadImage.BlockEntities[" *MODEL_SPACE"] Block hinzu und fügen Sie das neue Objekt zu den Zeichnungsentitäten hinzu.

**Beispiel:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "add-new-text-mtext-entities-to-the-right-of-existing-ones.cs" >}}
