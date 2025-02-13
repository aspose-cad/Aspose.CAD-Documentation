---
title: Exportation avec des options 3D
type: docs
weight: 40
url: /fr/java/developer-guide/export-with-3d-options/
---

## **Exportation avec des options 3D**

Quelques options ont été introduites pour exporter des modèles 3D vers PDF/raster à partir des formats FBX, OBJ, STL correspondants.

Voici des exemples de la scène 3D sous différents points de vue :

![Figures](/fr/_assets/guide/3d/fig1.png)

![Figures d'autres points de vue](/fr/_assets/guide/3d/fig2.png)

La propriété ObserverPoint permet de faire pivoter la scène 3D selon des angles spécifiés autour de l'axe. Cet exemple montre le code et le résultat d'exportation en utilisant quelques angles de rotation arbitraires.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "ObserverPoint-property.java">}}

![Exportation avec rotation](/fr/_assets/guide/3d/fig3.png)

Changer l'ObserverAngle en ObserverPoint = new ObserverPoint(5, 60, 0) permet de faire pivoter la scène.

![Exportation avec rotation changée](/fr/_assets/guide/3d/fig4.png)

L'autre propriété RenderMode3D permet de spécifier comment le résultat de l'exportation doit être présenté. Il existe 3 modes : Solide (par défaut), Fil de fer, et SolideAvecArêtes.

L'exemple ci-dessous permet de créer un modèle en fil de fer pour l'objet sphérique.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "RenderMode3D-property.java">}}

![Mode fil de fer](/fr/_assets/guide/3d/fig5.png)

L'exemple ci-dessous montre la différence entre les modes Solide et SolideAvecArêtes.

![Mode solide](/fr/_assets/guide/3d/fig6.png)
![Mode solide avec arête](/fr/_assets/guide/3d/fig7.png)
