---
title: Support des fichiers CTB
type: docs
weight: 40
url: /fr/java/developer-guide/support-ctb/
---

## **Support des fichiers CTB**

Parfois, la couleur, les épaisseurs de ligne et d'autres options pour les dessins peuvent être utilisées non seulement à partir des dessins eux-mêmes, mais aussi à partir des styles d'impression dans des fichiers CTB séparés. 
La façon la plus simple d'utiliser ces informations est de placer les fichiers CTB correspondants à côté du fichier avec le dessin au format DWG/DXF et les informations provenant de ceux-ci seront appliquées 
automatiquement lors de l'exportation.

Il est également possible de charger tous les fichiers CTB sous forme de flux en utilisant 
[**setCtbSources**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setCtbSources-java.util.Map-) propriété de 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) objet.

Voici un exemple de comment faire cela :

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setCtbSources-example.java">}}
