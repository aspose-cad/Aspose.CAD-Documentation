---
title: Dessin DGN
type: docs
weight: 10
url: /fr/java/developer-guide/autocad-drawings/dgn-drawing/
---

## **Dessin du format DGN dans le cadre de DWG**

Aspose.CAD pour Java permet aux développeurs d'exporter un fichier DWG avec un sous-dossier DGN intégré. Voici le code démontrant comment accéder au sous-dossier DGN à l'intérieur d'un fichier DWG lors de l'exportation du fichier DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportDGNAsPartofDWG-ExportDGNAsPartofDWG.java" >}}

## **Support des entités 3D pour DGN v7**

L'API Aspose.CAD pour Java a introduit la fonctionnalité de charger un fichier AutoCAD DGN et de prendre en charge les entités 3D pour DGN v7. La classe [**CadImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadImage) sert cet objectif. Chaque image DGN prend en charge 9 vues prédéfinies. Elles sont énumérées de 1 à 9. Si aucune vue n'est définie lors de l'exportation, pour les formats de sortie multi-pages (comme PDF), toutes les vues seront exportées, chacune sur une page séparée. Les entités 3D sont prises en charge dans le format de fichier DGN, ainsi que les entités 2D. 
VectorRasterizationOptions.TypeOfEntities n'est plus utilisé pour le format DGN (les 2D et 3D sont pris en charge simultanément).

Code exemple pour voir les éléments DGN pris en charge.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportForDGNV7-SupportForDGNV7.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportedDGNElements-SupportedDGNElements.java" >}}
