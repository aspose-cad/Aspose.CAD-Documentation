---
title: Changer la largeur de la polyligne 
type: docs
weight: 20
url: /fr/net/developer-guide/how-to/change-width-of-the-polyline/
---

## **Comment changer la largeur de la polyligne**

**Problème :** Comment changer la largeur de la polyligne (CADNET-459-460).

**Conseils :** Pour changer la largeur dans CadBaseEntity (si le type est CadEntityTypeName.LWPOLYLINE) utilisez (entity as CadLwPolyline).ConstantWidth = 2 ou pour les entités régulières LineWeight.

**Exemple :**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-width-of-the-polyline.cs" >}}
