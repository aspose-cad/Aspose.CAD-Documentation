---
title: Déplacement du point d'origine de hachures plus près de la limite de hachure pour améliorer les performances
type: docs
weight: 41
url: /fr/net/developer-guide/how-to/moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance/
---

## **Comment déplacer le point d'origine de hachure plus près de la limite de hachure pour améliorer les performances**

**Problème :** Comment déplacer le point d'origine de hachure plus près de la limite de hachure pour améliorer les performances (CADNET-1340).

**Astuces :** Pour ce faire, obtenez les entités CadHatch du dessin, définissez les points requis avec Point2D, calculez la distance et dans CadHatchPatternData définissez LineBasePoint pour X et Y.

**Exemple :**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance.cs" >}}
