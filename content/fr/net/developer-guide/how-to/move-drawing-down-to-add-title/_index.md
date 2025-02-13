---
title: Déplacer le dessin vers le bas pour ajouter un titre
type: docs
weight: 40
url: /fr/net/developer-guide/how-to/move-drawing-down-to-add-title/
---

## **Comment déplacer le dessin vers le bas pour ajouter un titre**

**Problème :** Comment déplacer le dessin vers le bas pour ajouter un titre (CADNET-980).

**Conseils :** Pour ce faire, créez un objet CadText avec des paramètres, ajoutez ce bloc au dessin, puis mettez à jour le dessin avec les nouvelles dimensions en utilisant UpdateSize, ajoutez une polyligne qui forme un cadre autour du dessin, ajoutez la polyligne à BlockEntities["*Model_Space"] et mettez à jour à nouveau avec UpdateSize.

**Exemple :**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "move-drawing-down-to-add-title.cs" >}}
