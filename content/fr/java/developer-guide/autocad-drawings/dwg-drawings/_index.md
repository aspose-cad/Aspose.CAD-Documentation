---
title: Dessins DWG
type: docs
weight: 40
url: /fr/java/developer-guide/autocad-drawings/dwg-drawings/
---

## **Exportation des dessins DWG vers PDF**

L'API Aspose.CAD pour Java peut charger des dessins AutoCAD au format DWG et les convertir en PDF. Ce sujet explique l'utilisation de l'API Aspose.CAD pour réaliser la conversion de DWG en format PDF à travers des étapes simples comme défini ci-après.

{{% alert color="primary" %}}

L'API prend en charge les révisions DWG AutoCAD suivantes :

- Version DWG 2004 version 16.0 publication 18
- Version DWG 2005 version 16.1
- Version DWG 2010 version 18.0
- Version DWG 2013 version 19.0

{{% /alert %}}

### **Format de fichier DWG**

Un DWG est un fichier binaire qui contient des données d'image vectorielle et des métadonnées. Les données d'image vectorielle fournissent des instructions à l'application CAD sur la façon d'afficher le DWG ; les métadonnées peuvent contenir une variété d'informations sur le fichier, y compris des données spécifiques à l'emplacement et également des données client. Les spécifications ouvertes pour le format de fichier DWG peuvent être trouvées [dans ce PDF](https://www.opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Convertir des fichiers DWG en PDF**

Les étapes simples suivantes sont nécessaires pour convertir DWG en PDF.

1. Chargez le fichier DWG dans une instance de [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Créez un objet de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) et définissez les propriétés [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Créez un objet de la classe [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) et définissez la propriété [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Appelez la méthode [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) et passez l'objet de [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) comme deuxième paramètre.

Le code ci-dessous montre comment exporter des dessins DWG vers PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ConvertDWGFileToPDF-ConvertDWGFileToPDF.java" >}}

### **Créer un PDF unique avec différentes tailles de mise en page**

Aspose.CAD pour Java vous permet de convertir le fichier DWG en un seul PDF avec différentes tailles de mise en page. Cette approche fonctionne comme suit :

1. Chargez un fichier DWG en utilisant la méthode de fabrique [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Créez une instance de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) et définissez la hauteur et la largeur de la page résultantes.
1. Ajoutez les tailles de mise en page requises [**LayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setLayoutPageSizes-com.aspose.ms.System.Collections.Generic.Dictionary-) pour l'objet [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Créez une instance de la classe [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) et définissez sa propriété [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Exportez l'image au format PDF en utilisant la méthode [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Le code ci-dessous montre comment créer un PDF unique avec différentes mises en page.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.java" >}}

### **Exportation de DWG vers PDF/A et PDF/E**

Les étapes simples suivantes sont nécessaires pour convertir DWG en PDF.

1. Chargez le fichier DWG dans une instance de [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Créez un objet de la [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) classe et définissez les propriétés [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Créez un objet de la [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) classe et définissez la propriété [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Appelez la [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) méthode et passez l'objet de [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) comme deuxième paramètre.

Le code ci-dessous montre comment exporter des dessins DWG vers PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToCompliancePDF-DWGToCompliancePDF.java" >}}

### **Primitives AutoCAD prises en charge**

Les primitives AutoCAD suivantes sont prises en charge.

- TEXTE
- MTEXTE
- ATTDEF
- ATTRIB
- ARC
- ÉLLIPSE
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
- CALQUE
- VUEPORT
- MISE EN PAGE

## **Exportation d'une mise en page DWG spécifique vers PDF**

Cette approche fonctionne comme suit :

1. Chargez un fichier DWG en utilisant la méthode de fabrique [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Créez une instance de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) et définissez la hauteur et la largeur de la page résultantes.
1. Définissez la propriété [**Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) pour l'objet [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Créez une instance de la classe [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) et définissez sa propriété [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Exportez l'image au format PDF en utilisant la méthode [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Le code ci-dessous montre comment convertir une mise en page spécifique de DWG en PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportSpecificDWGLayoutToPDF-ExportSpecificDWGLayoutToPDF.java" >}}

## **Exportation de DWG vers Raster ou PDF en utilisant une taille fixe**

L'API Aspose.CAD pour Java peut charger des dessins AutoCAD au format DWG et les convertir en PDF ou Raster en utilisant une taille fixe.

Le code ci-dessous montre comment implémenter cette fonctionnalité.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.java" >}}

## **Support des lignes cachées arrondies lors de l'exportation de DWG/DXF vers BMP et PDF**

Cette approche fonctionne comme suit :

1. Chargez un fichier DWG en utilisant la méthode [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) méthode de fabrique.
1. Créez une instance de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Créez une instance de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) et définissez la hauteur et la largeur de la page résultantes.
1. Créez une instance de la classe [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) et définissez sa propriété [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Exportez l'image au format PDF en utilisant la méthode [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Le code ci-dessous montre comment implémenter cette fonctionnalité.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportForHiddenLines-SupportForHiddenLines.java" >}}

## **Support pour définir la zone d'impression pour l'image DWG dans le PDF exporté**

L'API Aspose.CAD pour Java peut charger des dessins AutoCAD au format DWG et les convertir en PDF. Ce sujet explique l'utilisation de l'API Aspose.CAD pour obtenir le support nécessaire pour définir une zone d'impression pour l'image DWG dans le PDF exporté.

Le code ci-dessous montre comment implémenter cette fonctionnalité.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Support pour la lecture des métadonnées XREF pour le fichier DWG**

1. Chargez un fichier DWG en utilisant la méthode [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) méthode de fabrique.
1. Parcourez chaque entité image.
1. Si l'entité est [**CadUnderlay**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadUnderlay) alors entité XREF avec des métadonnées.

Le code ci-dessous montre comment réaliser cette fonctionnalité.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ReadXREEFMetaData-ReadXREEFMetaData.java" >}}

## **Document DWG en spécifiant des coordonnées**

L'API Aspose.CAD pour Java fournit maintenant une fonctionnalité pour rendre des documents DWG en fournissant les coordonnées de la largeur et de la hauteur du document.

Le code ci-dessous montre comment rendre un document DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-RenderDWGDocument-RenderDWGDocument.java" >}}

La propriété [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#getLayouts--) est de type tableau de chaînes, vous pouvez donc spécifier plus d'une mise en page à la fois pour une conversion possible au format PDF. En spécifiant plusieurs mises en page pour la propriété [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-), le PDF résultant aurait plusieurs pages, où chaque page représente une mise en page AutoCAD individuelle.

### **Lister toutes les mises en page**

Vous pouvez lister toutes les mises en page présentes dans un dessin AutoCAD en utilisant le code ci-dessous.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ListAllLayoutsInAnAutoCADDrawing-ListAllLayoutsInAnAutoCADDrawing.java" >}}

## **Obtenir la valeur d'attribut de bloc de référence externe**

L'API Aspose.CAD pour Java vous permet d'obtenir une référence externe d'un attribut de bloc. L'API Aspose.CAD expose la propriété [**getXRefPathName()**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity#getXRefPathName--) pour obtenir la référence externe d'un attribut de bloc dans une collection [**CadBlockDictionary**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadBlockDictionary).

Le code suivant démontre comment obtenir une référence externe d'un attribut de bloc.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-GetBlockAttributeValueOfExternalReference-GetBlockAttributeValueOfExternalReference.java" >}}

## **Rechercher du texte dans un fichier AutoCAD DWG**

L'API Aspose.CAD pour Java vous permet de rechercher du texte dans un fichier DWG AutoCAD. L'API Aspose.CAD expose la classe [**CadText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadText) qui représente des entités de texte dans le fichier AutoCAD DWG. La classe [**CadMText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadMText) est également incluse dans l'API Aspose.CAD car certaines autres entités peuvent également contenir du texte.

Le code ci-dessous démontre comment rechercher du texte dans le fichier AutoCAD DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchTextInDWGAutoCADFile.java" >}}

### **Rechercher du texte dans une mise en page spécifique**

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchForTextInSpecificLayout.java" >}}

### **Accéder aux indicateurs de sous-couche pour le format DWG**

Aspose.CAD pour Java a implémenté les indicateurs de sous-couche pour le format DWG et permet aux développeurs d'y accéder. Voici la simple démonstration de code.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.java" >}}

## **Support des entités DWG**

L'API Aspose.CAD pour Java peut charger des dessins AutoCAD au format DWG et prendre en charge différentes entités avec lesquelles travailler.

### **Support pour l'entité MLeader**

Un DWG est un fichier binaire qui contient des données d'image vectorielle et des métadonnées. Il existe différentes entités dans un fichier DWG. La section suivante décrit un exemple de travail avec l'entité MLeader à l'intérieur du fichier DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.java" >}}

### **Support pour l'exportation de l'entité DWG vers l'image**

Un DWG est un fichier binaire qui contient des données d'image vectorielle et des métadonnées. Il existe différentes entités dans un fichier DWG. La section suivante décrit un exemple d'exportation d'une entité DWG particulière vers l'image.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ParticularDWGToImage-ParticularDWGToImage.java" >}}

## **Support pour importer une image dans un fichier DWG**

L'API Aspose.CAD pour Java peut charger des dessins AutoCAD au format DWG et prendre en charge différentes entités avec lesquelles travailler. Un DWG est un fichier binaire qui contient des données d'image vectorielle et des métadonnées. Il existe différentes entités dans un fichier DWG. La section suivante décrit comment nous pouvons importer des images à l'intérieur du fichier DWG.

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ImportImageToDWG-ImportImageToDWG.java" >}}

## **Support pour ajouter du texte dans DWG**

L'API Aspose.CAD pour Java peut charger des dessins AutoCAD au format DWG et prendre en charge différentes entités avec lesquelles travailler. Un DWG est un fichier binaire qui contient des données d'image vectorielle et des métadonnées. Il existe différentes entités dans un fichier DWG. La section suivante décrit comment nous pouvons ajouter du texte à l'intérieur du fichier DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-AddTextInDWG-AddTextInDWG.java" >}}

## **Support pour les maillages dans DWG**

L'API Aspose.CAD pour Java peut désormais accéder aux entités prenant en charge les maillages, qui incluent les types [**CadPolyFaceMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolyFaceMesh) et [**CadPolygonMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolygonMesh). L'exemple suivant décrit comment nous pouvons accéder aux types de maillage.

## **Convertir des dessins DWG en DXF**

Aspose.CAD offre la fonctionnalité de charger un fichier DWG AutoCAD et de l'exporter au format DXF. L'approche de conversion de DWG à DXF fonctionne comme suit :

1. Chargez le fichier de dessin DWG en utilisant la méthode de fabrique [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) .
1. Exportez le dessin DWG en DXF en utilisant la méthode [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Le code ci-dessous montre comment convertir un fichier DWG en format DXF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToDXF-DWGToDXF.java" >}}

## **Convertir des dessins DWG en SVG**

L'API Aspose.CAD peut charger des dessins AutoCAD au format DWG et les convertir en SVG. Ce sujet explique l'utilisation de l'API Aspose.CAD pour réaliser la conversion de DWG en format SVG à travers des étapes simples comme défini ci-dessous.

1. Chargez le fichier DWG dans une instance de [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Créez un objet de la classe [**SvgOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/SvgOptions) et définissez les propriétés requises.
1. Exportez le dessin DWG en SVG en utilisant la méthode [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Le code ci-dessous montre comment convertir un fichier DWG en format SVG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportToSVG-ExportToSVG.java" >}}
