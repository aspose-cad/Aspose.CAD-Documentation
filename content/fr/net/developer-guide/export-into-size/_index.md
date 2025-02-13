---
title: Exportation des dessins et mises en page DWG/DXF dans une taille spécifiée
type: docs
weight: 40
url: /fr/net/developer-guide/export-into-size/
---

## **Exporter le modèle et toutes les mises en page au format PDF A4**

L'API Aspose.CAD vous permet d'exporter toutes les feuilles du fichier DWG/DXF dans une taille PDF physique spécifiée.

Le code d'exemple suivant configure la taille de l'objet [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) pour obtenir la taille PDF souhaitée. La taille de la feuille de papier A4 est de 210x297 millimètres ou 8,27x11,69 pouces et ces valeurs sont utilisées dans le code.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Calculate sizes for A4.cs">}}

## **Exporter les mises en page CAD en PDF dans une taille différente**

Parfois, il est nécessaire d'exporter une mise en page dans sa taille physique. L'exemple ci-dessous démontre l'exportation du dessin dans un PDF multipage où chaque page avec le contenu de la mise en page a sa propre taille PDF physique. Cet exemple utilise la propriété [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/layoutpagesizes/).

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Export to multipage with different pages sizes.cs">}}
