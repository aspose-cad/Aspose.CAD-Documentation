---
title: Ajouter de nouvelles entités TEXT/MTEXT à droite des entités existantes
type: docs
weight: 17
url: /fr/net/developer-guide/how-to/add-new-text-mtext-entities-to-the-right-of-existing-ones/
---

## **Comment ajouter de nouvelles entités TEXT/MTEXT à droite des entités existantes**

**Problème :** Comment ajouter de nouvelles entités TEXT/MTEXT à droite des entités existantes (CADNET-8172).

**Astuce :** Pour ce faire, créez un objet CadBaseEntity, créez un CadMText ou CadText avec du texte, dans le nouvel objet, ajoutez cadImage.Layouts["Model"].BlockTableRecordHandle du dessin au champ SoftOwner et ajoutez-le au bloc cadImage.BlockEntities[" *MODEL_SPACE"] et ajoutez le nouvel objet aux entités du dessin.

**Exemple :**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "add-new-text-mtext-entities-to-the-right-of-existing-ones.cs" >}}
