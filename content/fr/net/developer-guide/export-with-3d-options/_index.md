---
title: Exportation avec des options 3D
type: docs
weight: 40
url: /fr/net/developer-guide/export-with-3d-options/
---

## **Exportation avec des options 3D**

Quelques options ont été introduites pour exporter des modèles 3D vers PDF/raster à partir de formats FBX, OBJ, STL correspondants.

Voici des exemples de la scène 3D depuis différents points de vue :

![Figures](/cad/_assets/guide/3d/fig1.png)

![Figures d'autres points de vue](/cad/_assets/guide/3d/fig2.png)

La propriété ObserverPoint permet de faire pivoter la scène 3D selon des angles spécifiés autour de l'axe. Cet exemple montre le code et le résultat de l'exportation en utilisant des angles de rotation arbitraires.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "ObserverPoint-property.cs">}}


![Exportation avec rotation](/cad/_assets/guide/3d/fig3.png)

Changer l'ObserverAngle à ObserverPoint = new ObserverPoint(5, 60, 0) permet de faire pivoter la scène.

![Exportation avec rotation changée](/cad/_assets/guide/3d/fig4.png)

L'autre propriété RenderMode3D permet de spécifier comment le résultat de l'exportation doit être présenté. Il existe 3 modes : Solide (le mode par défaut), Fil de fer et SolideAvecBords.

L'exemple ci-dessous permet de créer un modèle fil de fer pour l'objet sphérique.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "RenderMode3D-property.cs">}}

![Mode fil de fer](/cad/_assets/guide/3d/fig5.png)

L'exemple ci-dessous montre la différence entre les modes Solide et SolideAvecBords.

![Mode solide](/cad/_assets/guide/3d/fig6.png)
![Mode solide avec bord](/cad/_assets/guide/3d/fig7.png)
