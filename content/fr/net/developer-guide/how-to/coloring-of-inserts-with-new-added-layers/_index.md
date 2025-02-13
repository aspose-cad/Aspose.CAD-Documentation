---
title: Coloration des inserts avec de nouvelles couches ajoutées
type: docs
weight: 23
url: /fr/net/developer-guide/how-to/coloration-des-inserts-avec-de-nouvelles-couches-ajoutees/
---

## **Comment colorer les inserts avec de nouvelles couches ajoutées (CADNET-1146)**

**Problème :** Comment colorer les inserts avec de nouvelles couches ajoutées (CADNET-1146).

**Conseils :** Pour ce faire, utilisez la classe CadLayerTable pour créer une couche afin de pouvoir ajouter une nouvelle couche au dessin, vous pouvez également utiliser CadLayersList pour ajouter plusieurs couches.

**Exemple :**

{{% alert color="primary" %}}

Le fichier initial contient 5 inserts avec les noms "1", "2", "3", "4" et "5" et tous sont dans la couche par défaut 0.

{{% /alert %}}

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "coloration-des-inserts-avec-de-nouvelles-couches-ajoutees.cs" >}}
