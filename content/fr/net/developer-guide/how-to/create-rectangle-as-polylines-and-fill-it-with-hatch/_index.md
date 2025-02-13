---
title: Créer un rectangle sous forme de polylignes et le remplir avec un hachage
type: docs
weight: 24
url: /fr/net/developer-guide/how-to/create-rectangle-as-polylines-and-fill-it-with-hatch/
---

## **Comment créer un rectangle sous forme de polylignes et le remplir avec un hachage**

**Problème :** Comment créer un rectangle sous forme de polylignes et le remplir avec un hachage (CADNET-1351).

**Conseils :** Pour ce faire, créez un CadLwPolyline et ajoutez-lui des coordonnées de points, utilisez CadHatch pour travailler avec la couleur et utilisez CadEdgeBoundaryPath pour connectez, utilisez CadHatch pour travailler avec les angles et CadHatchPatternData pour le motif.

**Exemple :**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "create-rectangle-as-polylines-and-fill-it-with-hatch.cs" >}}
