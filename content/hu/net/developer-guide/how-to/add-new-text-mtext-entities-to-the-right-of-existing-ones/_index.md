---
title: Új TEXT/MTEXT entitások hozzáadása a meglévők jobb oldalán
type: docs
weight: 17
url: /hu/net/developer-guide/how-to/add-new-text-mtext-entities-to-the-right-of-existing-ones/
---

## **Hogyan adhatunk hozzá új TEXT/MTEXT entitásokat a meglévők jobb oldalán**

**Probléma:** Hogyan adhatunk hozzá új TEXT/MTEXT entitásokat a meglévők jobb oldalán (CADNET-8172).

**Tippek:** Ehhez hozzon létre egy CadBaseEntity objektumot, hozzon létre egy CadMText vagy CadText objektumot szöveggel, az új objektumban a SoftOwner mezőhöz adja hozzá a cadImage.Layouts["Model"].BlockTableRecordHandle értéket a rajzból, és adja hozzá a cadImage.BlockEntities[" *MODEL_SPACE"] blokkhoz, majd adja hozzá az új objektumot a rajzi entitásokhoz.

**Példa:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "add-new-text-mtext-entities-to-the-right-of-existing-ones.cs" >}}
