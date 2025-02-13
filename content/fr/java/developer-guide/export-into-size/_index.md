---
title: Exportation de dessin DWG/DXF et mises en page dans une taille spécifiée
type: docs
weight: 40
url: /fr/java/developer-guide/export-into-size/
---

## **Exporter le modèle et toutes les mises en page au format PDF A4**

L'API Aspose.CAD permet d'exporter toutes les feuilles du fichier DWG/DXF dans une taille PDF physique spécifiée.
Le code d'exemple suivant configure la taille de l'objet [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions/) pour obtenir la taille PDF souhaitée.
La taille d'une feuille de papier A4 est de 210x297 millimètres ou 8,27x11,69 pouces, et ces valeurs sont utilisées dans le code.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "set-page-size.java">}}

## **Exporter les mises en page CAD en PDF dans différentes tailles**

Parfois, il est nécessaire d'exporter la mise en page dans sa taille physique. L'exemple ci-dessous montre l'exportation du dessin dans un PDF multipages où chaque page avec le contenu de la mise en page a sa propre taille PDF physique. Cet exemple utilise la propriété [**getLayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#getLayoutPageSizes--) .

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "export-different-pages-sizes.java">}}
