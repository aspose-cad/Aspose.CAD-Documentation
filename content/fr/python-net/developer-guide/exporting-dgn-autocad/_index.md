---
title: Exportation du format DGN AutoCAD
type: docs
weight: 50
url: /fr/python-net/developer-guide/exporting-dgn-autocad/
---

## **Exportation du format DGN AutoCAD vers PDF**

L'API Aspose.CAD pour Python a introduit la fonctionnalité de charger un fichier DGN AutoCAD et de le convertir en format PDF. La classe **CadImage** sert cet objectif.

Vous devez charger un fichier DGN existant en tant que **CadImage**. Créez une instance de la classe **CadRasterizationOptions** et définissez différentes propriétés. Créez une instance de la classe **PdfOptions** et transmettez l'instance **CadRasterizationOptions**. Appelez maintenant la méthode **save** de l'instance de la classe **CadImage**.

### Exemple de code

Voici la démonstration de code pour convertir/exporter le [DGN](https://docs.fileformat.com/cad/dgn/) vers le [PDF](https://docs.fileformat.com/pdf/) format.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-PDF-Export.py" >}}


## **Exportation du format DGN AutoCAD vers un format d'image raster**

L'API Aspose.CAD pour Python a introduit la fonctionnalité de charger un fichier DGN AutoCAD et de le convertir en une image raster. La classe **CadImage** sert cet objectif.

Vous devez charger un fichier DGN existant en tant que **CadImage**. Créez une instance de la classe **CadRasterizationOptions** et définissez différentes propriétés. Créez une instance de la classe **JpegOptions** et transmettez l'instance **CadRasterizationOptions**. Appelez maintenant la méthode **save** de l'instance de la classe **CadImage**.

### Exemple de code

Voici la démonstration de code pour convertir/exporter le [DGN](https://docs.fileformat.com/cad/dgn/) vers une image [JPEG](https://docs.fileformat.com/image/jpeg/).

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-JPEG-Export.py" >}}

## **Support des entités 3D pour DGN v7**

L'API Aspose.CAD pour Python a introduit la fonctionnalité de charger un fichier [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD et de supporter les entités 3D pour DGN v7. La classe **CadImage** sert cet objectif. Chaque image [DGN](https://docs.fileformat.com/cad/dgn/) prend en charge 9 vues prédéfinies. Elles sont numérotées de 1 à 9. Si la vue n'est pas définie lors de l'exportation, pour les formats de sortie multi-pages (comme PDF), toutes les vues seront exportées, chacune sur une page séparée. Les entités 3D sont supportées dans le format de fichier DGN, ainsi que les 2D. Pour cela, **VectorRasterizationOptions** est utilisé, TypeOfEntities n'est plus utilisé pour le format DGN (les deux 2D et 3D sont pris en charge simultanément).

### Exemple de code

Voici le code exemple pour voir les éléments DGN pris en charge.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DGN-Drawings-SupportOf3DForDGNV7.py" >}}
