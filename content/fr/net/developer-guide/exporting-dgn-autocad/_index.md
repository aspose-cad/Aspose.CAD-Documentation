---
title: Exportation du format DGN AutoCAD
type: docs
weight: 50
url: /fr/net/developer-guide/exporting-dgn-autocad/
---

## **Exportation du format DGN AutoCAD vers PDF**

Aspose.CAD pour l'API .NET a introduit la fonctionnalité de charger un fichier DGN AutoCAD et de le convertir en format PDF. La classe [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) sert cet objectif.

Vous devez charger un fichier DGN existant en tant que [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage). Créez une instance de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) et définissez différentes propriétés. Créez une instance de la classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) et passez l'instance de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions). Maintenant, appelez la méthode [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) de l'instance de la classe [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage).

### Extrait de Code

Voici la démonstration de code pour convertir/exporter [DGN](https://docs.fileformat.com/cad/dgn/) en format [PDF](https://docs.fileformat.com/pdf/).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **Exportation du format DGN AutoCAD vers format image raster**

Aspose.CAD pour l'API .NET a introduit la fonctionnalité de charger un fichier DGN AutoCAD et de le convertir en une image raster. La classe [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) sert cet objectif.

Vous devez charger un fichier DGN existant en tant que [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage). Créez une instance de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) et définissez différentes propriétés. Créez une instance de la classe [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) et passez l'instance de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions). Maintenant, appelez la méthode [**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) de l'instance de la classe [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage).

### Extrait de Code

Voici la démonstration de code pour convertir/exporter [DGN](https://docs.fileformat.com/cad/dgn/) en image [JPEG](https://docs.fileformat.com/image/jpeg/).

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-ExportDGNToRasterImage-ExportDGNToRasterImage.cs" >}}

## **Support d'entités 3D pour DGN v7**

Aspose.CAD pour l'API .NET a introduit la fonctionnalité de charger un fichier [DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD et de prendre en charge les entités 3D pour DGN v7. La classe [**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage) sert cet objectif. Chaque image [DGN](https://docs.fileformat.com/cad/dgn/) prend en charge 9 vues prédéfinies. Celles-ci sont numérotées de 1 à 9. Si aucune vue n'est définie à l'exportation, pour les formats de sortie à plusieurs pages (comme le PDF), toutes les vues seront exportées, chacune sur une page séparée. Les entités 3D sont prises en charge au format de fichier DGN, ainsi que les 2D. Pour cela, [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) est utilisé, TypeOfEntities n'est plus utilisé pour le format DGN (les 2D et 3D sont pris en charge simultanément).

### Extrait de Code

Voici l'extrait de code sur les éléments DGN pris en charge.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-SupportOf3DForDGNV7-3DSupportForDGNV7.cs" >}}
