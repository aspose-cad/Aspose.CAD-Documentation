---
title: Dessins DWG
type: docs
weight: 40
url: /fr/net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **Exportation de dessins DWG vers PDF**

Aspose.CAD pour l'API .NET peut charger des dessins AutoCAD au format [DWG](https://docs.fileformat.com/cad/dwg/) et les convertir en [PDF](https://docs.fileformat.com/pdf/). Ce sujet explique l’utilisation de l’API Aspose.CAD pour réaliser la conversion de DWG en format PDF à travers des étapes simples comme défini ci-après.

{{% alert color="primary" %}}

L'API prend en charge les révisions DWG AutoCAD suivantes :

- Version 16.0 de DWG 2004, version 18
- Version 16.1 de DWG 2005
- Version 18.0 de DWG 2010
- Version 19.0 de DWG 2013

{{% /alert %}}

### **Format de fichier DWG**

Un [DWG](https://docs.fileformat.com/cad/dwg/) est un fichier binaire qui contient des données d'image vectorielle et des métadonnées. Les données d'image vectorielle fournissent des instructions à l'application CAD sur la façon d'afficher le DWG ; les métadonnées peuvent contenir une variété d'informations sur le fichier, y compris des données spécifiques à un emplacement et également des données clients. Les spécifications ouvertes pour le format de fichier DWG peuvent être trouvées [dans ce PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Convertir des fichiers DWG en PDF**

Les étapes simples suivantes sont nécessaires pour convertir [DWG](https://docs.fileformat.com/cad/dwg/) en [PDF](https://docs.fileformat.com/pdf/).

1. Charger le fichier DWG dans une instance de [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Créer un objet de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) et définir les propriétés [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) et [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Créer un objet de la classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) et définir la propriété [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Appeler [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) tout en passant un objet de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) comme deuxième paramètre.

L'exemple de code ci-dessous montre comment exporter des dessins DWG vers PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToPDF-ExportToPDF.cs" >}}

### **Créer un PDF unique avec différentes tailles de mise en page**

Aspose.CAD pour .NET vous permet de convertir un fichier DWG en un seul PDF avec différentes tailles de mise en page. Cette approche fonctionne comme suit :

1. Charger un fichier DWG en utilisant la méthode de fabrication [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Créer une instance de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) et définir la hauteur et la largeur de la page résultante.
1. Ajouter les [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/layoutpagesizes) requises pour l'objet [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Créer une instance de la classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) et définir sa propriété [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Exporter l'image vers PDF en utilisant la méthode [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

L'exemple de code ci-dessous montre comment créer un seul [PDF](https://docs.fileformat.com/pdf/) avec différentes mises en page.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.cs" >}}

### **Primitives AutoCAD prises en charge**

Les primitives AutoCAD suivantes sont prises en charge.

- TEXTE
- MTEXTE
- ATTDEF
- ATTRIB
- ARC
- ELLIPSE
- HACHURE
- LEADER
- POINT
- VERTEX 2D
- VERTEX 3D
- POLYLINE 2D
- LWPOLYLINE
- RAY
- CERCLE
- DIMENSION ORDONNÉE
- DIMENSION LINÉAIRE
- DIMENSION ALIGNÉE
- DIMENSION ANG 3Pt
- DIMENSION ANG 2Ln
- DIMENSION RAYON
- DIMENSION DIAMÈTRE
- FORME
- SOLIDE
- SPLINE
- MLINE
- LIGNE
- XLINE
- STYLE
- DIMSTYLE
- LTYPE
- MLINESTYLE
- COUCHE
- VUEPORT
- MISE EN PAGE

## **Exportation d'une mise en page DWG spécifique vers PDF**

Cette approche fonctionne comme suit :

1. Charger un fichier DWG en utilisant la méthode de fabrication [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Créer une instance de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) et définir la hauteur et la largeur de la page résultante.
1. Définir la propriété [**Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) pour l'objet [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Créer une instance de la classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) et définir sa propriété [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Exporter l'image vers PDF en utilisant la méthode [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

L'exemple de code ci-dessous montre comment convertir une mise en page spécifique de DWG en PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Rendre un document DWG en spécifiant les coordonnées**

L'API Aspose.CAD pour .NET fournit maintenant une fonctionnalité pour rendre des documents DWG en fournissant les coordonnées de la largeur et de la hauteur du document.

L'exemple de code ci-dessous montre comment rendre un document DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-RenderDWGDocument-RenderDWGDocument.cs" >}}

## **Exportation de DWG vers Raster ou PDF en utilisant une taille fixe**

L'API Aspose.CAD pour .NET peut charger des dessins AutoCAD au format DWG et les convertir en PDF ou Raster en utilisant une taille fixe.

L'exemple de code ci-dessous montre comment implémenter cette fonctionnalité.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.cs" >}}

## **Exportation de DWG vers PDF/A et PDF/E**

Cette approche fonctionne comme suit :

1. Charger un fichier DWG en utilisant la méthode de fabrication [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Créer une instance de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Créer une instance de la classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) et définir sa propriété [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Définir la propriété de conformité PDF et l’enregistrer.
1. Exporter l'image vers PDF en utilisant la méthode [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

L'exemple de code ci-dessous montre comment convertir un fichier DWG en PDF/A et PDF/E.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-DWGToCompliancePDF-DWGToCompliancePDF.cs" >}}

## **Support pour les lignes cachées arrondies lors de l’exportation de DWG/DXF vers BMP et PDF**

Cette approche fonctionne comme suit :

1. Charger un fichier DWG en utilisant la méthode de fabrication [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Créer une instance de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) et définir la hauteur et la largeur de la page résultante.
1. Créer une instance de la classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) et définir sa propriété [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Exporter l'image vers PDF en utilisant la méthode [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

L'exemple de code ci-dessous montre comment implémenter cette fonctionnalité.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-SupportForHiddenLines-SupportForHiddenLines.cs" >}}

## **Support pour définir la zone d'impression pour l'image DWG dans le PDF exporté**

L'API Aspose.CAD pour .NET peut charger des dessins AutoCAD au format DWG et les convertir en PDF. Ce sujet explique l'utilisation de l'API Aspose.CAD pour réaliser le support de la définition d'une zone d'impression pour l'image DWG dans le PDF exporté.

L'exemple de code ci-dessous montre comment implémenter cette fonctionnalité.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Support pour la lecture des métadonnées XREF pour le fichier DWG**

1. Charger un fichier DWG en utilisant la méthode de fabrication [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Parcourir chaque entité d'image.
1. Si une entité est CadUnderlay alors entité XREF avec métadonnées.

L'exemple de code ci-dessous montre comment réaliser cette fonctionnalité.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ReadXREEFMetaData-ReadXREEFMetaData.cs" >}}

La propriété [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) est de type tableau de chaînes, vous pouvez donc spécifier plusieurs mises en page à la fois pour une conversion possible au format PDF. Lors de la spécification de plusieurs mises en page pour la propriété [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts), le PDF résultant aurait plusieurs pages, où chaque page représente une mise en page AutoCAD individuelle.

### **Lister toutes les mises en page**

Vous pouvez lister toutes les mises en page présentes dans un dessin AutoCAD en utilisant l’extrait de code suivant.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-ListLayouts-ListLayouts.cs" >}}

### **Accéder aux indicateurs de sous-couche pour le format DWG**

Aspose.CAD pour .NET a mis en œuvre les indicateurs de sous-couche pour le format DWG et permet aux développeurs d’y accéder. Voici une simple démonstration de code.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.cs" >}}

## **Support pour les entités DWG**

L'API Aspose.CAD pour .NET peut charger des dessins AutoCAD au format DWG et prendre en charge différentes entités à travailler avec.

### **Support pour l'entité MLeader**

Un DWG est un fichier binaire qui contient des données d'image vectorielle et des métadonnées. Il existe différentes entités dans un fichier DWG. La section suivante décrit un exemple de travail avec l'entité MLeader à l'intérieur du fichier DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.cs" >}}

### **Support pour l'exportation d'une entité DWG vers une image**

Un DWG est un fichier binaire qui contient des données d'image vectorielle et des métadonnées. Il existe différentes entités dans un fichier DWG. La section suivante décrit un exemple d'exportation d'une entité DWG particulière vers l'image.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ParticularDWGToImage-ParticularDWGToImage.cs" >}}

## **Support pour ajouter du texte dans DWG**

L'API Aspose.CAD pour .NET peut charger des dessins AutoCAD au format DWG et prendre en charge différentes entités à travailler avec. Un DWG est un fichier binaire qui contient des données d'image vectorielle et des métadonnées. Il existe différentes entités dans un fichier DWG. La section suivante décrit comment nous pouvons ajouter du texte à l'intérieur du fichier DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-AddTextInDWG-AddTextInDWG.cs" >}}

## **Support pour l'importation d'images dans un fichier DWG**

L'API Aspose.CAD pour .NET peut charger des dessins AutoCAD au format DWG et prendre en charge différentes entités à travailler avec. Un DWG est un fichier binaire qui contient des données d'image vectorielle et des métadonnées. Il existe différentes entités dans un fichier DWG. La section suivante décrit comment nous pouvons importer des images à l'intérieur du fichier DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DWG-Drawings-ImportImageToDWG-ImportImageToDWG.cs" >}}

## **Support pour les maillages dans DWG**

L'API Aspose.CAD pour .NET peut maintenant accéder aux entités prenant en charge les maillages, qui incluent les types [**CadPolyFaceMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolyfacemesh) et [**CadPolygonMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolygonmesh). L'exemple suivant décrit comment nous pouvons accéder aux types de maillage.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-MeshSupportForDWG-MeshSupportForDWG.cs" >}}

## **Convertir des dessins DWG en DXF**

Aspose.CAD fournit la fonctionnalité de charger un fichier DWG AutoCAD et de l'exporter au format DXF. L'approche de conversion de DWG en DXF fonctionne comme suit :

1. Charger le fichier dessin DWG en utilisant la méthode de fabrication [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Exporter le dessin DWG au DXF en utilisant la méthode [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

L'exemple de code ci-dessous montre comment convertir un fichier DWG en format DXF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-DWGToDXF-DWGToDXF.cs" >}}

## **Convertir des dessins DWG en SVG**

L'API Aspose.CAD pour .NET peut charger des dessins AutoCAD au format DWG, et les convertir en SVG. Ce sujet explique l'utilisation de l'API Aspose.CAD pour réaliser la conversion de DWG en format SVG à travers des étapes simples comme défini ci-dessous.

1. Charger le fichier DWG dans une instance de [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Créer un objet de la classe [**SvgOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/svgoptions) et définir les propriétés requises.
1. Exporter le dessin DWG en SVG en utilisant la méthode [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

L'exemple de code ci-dessous montre comment convertir un fichier DWG en format SVG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToSVG-ExportToSVG.cs" >}}

## **Charger un grand fichier DWG**

Aspose.CAD pour .NET fournit la possibilité d'ouvrir de très grands fichiers DWG en utilisant la classe [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image). Vous pouvez désormais ouvrir facilement de grands fichiers avec l'aide de l'extrait de code ci-dessous.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-LargeDWGToPDF-LargeDWGToPDF.cs" >}}
