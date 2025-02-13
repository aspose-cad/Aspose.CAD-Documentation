---
title: Vérifiez si les images référencées externes existent et remplacez les références
type: docs
weight: 22
url: /fr/net/developer-guide/how-to/check-whether-external-referenced-images-exist-and-replace-references/
---

## **Comment modifier des hyperliens sur des objets**

**Problème :** Comment vérifier si les images référencées externes existent et remplacer les références (CADNET-8088).

**Conseils :** Pour cela, obtenez une entité de type CadObjectTypeName.IMAGEDEF à partir des entités de dessin et utilisez CadRasterImageDef pour vérifier.

**Exemple :**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "check-whether-external-referenced-images-exist-and-replace-references.cs" >}}
