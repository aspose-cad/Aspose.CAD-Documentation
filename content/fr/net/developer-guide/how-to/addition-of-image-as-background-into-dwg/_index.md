---
title: Ajout d'image en tant qu'arrière-plan dans DWG
type: docs
weight: 15
url: /fr/net/developer-guide/how-to/addition-of-image-as-background-into-dwg/
---

## **Comment ajouter une image comme arrière-plan dans DWG**

**Problème :** Comment ajouter une image comme arrière-plan dans DWG.

**Conseils :** Pour ce faire, créez un objet CadRasterImageDef pour l'image d'arrière-plan, créez un objet CadRasterImage pour insérer l'arrière-plan dans le dessin, ajoutez un objet CadRasterImage aux objets de dessin, créez un objet CadBaseObject et ajoutez-le à cadImage.Objects, traitez le tout via CadBlockTableObject.

**Exemple :**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "addition-of-image-as-background-into-dwg.cs" >}}
