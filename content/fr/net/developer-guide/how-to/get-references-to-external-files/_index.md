---
title: Obtenir des références à des fichiers externes
type: docs
weight: 36
url: /fr/net/developer-guide/how-to/get-references-to-external-files/
---

## **Comment obtenir des références à des fichiers externes**

**Problème :** Comment obtenir des références à des fichiers externes (CADNET-110).

**Conseils :** Pour obtenir des références à des fichiers externes pour des dessins dans le bloc d'entité, il y a un champ XRef PathName pour les images raster. CadRasterImage Def est utilisé pour le sous-jet externe, CadDgnUnderlay est utilisé et son champ UnderlayPath.

**Exemple :**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "get-references-to-external-files.cs" >}}
