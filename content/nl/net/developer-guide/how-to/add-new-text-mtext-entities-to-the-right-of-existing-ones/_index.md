---
title: Voeg nieuwe TEXT/MTEXT-entiteiten toe aan de rechterkant van bestaande entiteiten 
type: docs
weight: 17
url: /nl/net/developer-guide/how-to/add-new-text-mtext-entities-to-the-right-of-existing-ones/
---

## **Hoe nieuwe TEXT/MTEXT-entiteiten toe te voegen aan de rechterkant van bestaande entiteiten**

**Probleem:** Hoe nieuwe TEXT/MTEXT-entiteiten toe te voegen aan de rechterkant van bestaande entiteiten (CADNET-8172).

**Tips:** Om dit te doen, maak een CadBaseEntity-object, maak een CadMText of CadText met tekst, voeg in het nieuwe object aan het SoftOwner-veld cadImage.Layouts["Model"].BlockTableRecordHandle van de tekening toe en voeg het toe aan het cadImage.BlockEntities[" *MODEL_SPACE"]-blok en voeg het nieuwe object toe aan tekenentiteiten.

**Voorbeeld:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "add-new-text-mtext-entities-to-the-right-of-existing-ones.cs" >}}
