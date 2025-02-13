---
title: Support des fichiers CTB
type: docs
weight: 40
url: /fr/net/developer-guide/support-ctb/
---

## **Support des fichiers CTB**

Parfois, les couleurs, poids de ligne et certaines autres options pour les dessins peuvent être utilisées non seulement à partir des dessins eux-mêmes, mais aussi à partir des styles d'impression dans des fichiers CTB séparés. 
Le moyen le plus simple d'utiliser ces informations est de placer les fichiers CTB correspondants à côté du fichier avec le dessin au format DWG/DXF, et les informations provenant de ceux-ci seront appliquées 
automatiquement lors de l'exportation.

Il est également possible de charger tous les fichiers CTB sous forme de flux en utilisant 
[**CtbSources**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/ctbsources/) propriété de 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) objet.

Voici un exemple de comment faire cela :
 
{{< gist aspose-com-gists d497c535082c162a22c937aeb71e55c9 "Ctb-from-stream.cs">}}
