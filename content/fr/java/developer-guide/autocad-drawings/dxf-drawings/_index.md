---
title: Dessins DXF
type: docs
weight: 60
url: /fr/java/developer-guide/autocad-drawings/dxf-drawings/
---

## **Exportation de dessins DXF au format PDF**

Aspose.CAD offre la possibilité de charger des entités de dessin DXF d'AutoCAD et de les rendre en tant que dessin complet au format PDF. L'approche de conversion DXF en PDF fonctionne comme suit :

1. Chargez le fichier de dessin DXF à l'aide de la méthode d'usine [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Créez un objet de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) et définissez les propriétés [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) et [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Créez un objet de la classe [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) et définissez la propriété [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Appelez Image.Save en passant un objet de [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) comme deuxième paramètre.

L'exemple de code ci-dessous montre comment convertir un fichier en utilisant les paramètres par défaut.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFDrawingToPDF-.java" >}}

### **Formats pris en charge**

Pour le moment, nous supportons entièrement les formats de fichiers DXF 2010 d'AutoCAD. Les versions DXF précédentes ne sont pas garanties être 100% valides. Nous prévoyons d'inclure davantage de formats et de fonctionnalités dans les futures versions d'Aspose.CAD.

### **Entités prises en charge**

Pour le moment, nous supportons toutes les entités 2D largement répandues et leurs paramètres par défaut de base comme suit :

1. Dimension alignée
1. Dimension angulaire
1. Arc
1. Attribut
1. Référence de bloc
1. Cercle
1. Dimension de diamètre
1. Ellipse
1. Hachure
1. Ligne
1. Texte multiligne
1. Dimension ordonnée
1. Point
1. Polyligne
1. Dimension radiale
1. Rayon
1. Dimension tournante
1. Table
1. Texte
1. Xline

{{% alert color="primary" %}}

Si lors de l'analyse, nous rencontrons une entité ou une propriété que nous ne supportons pas, l'entité ou la propriété sera silencieusement ignorée.

{{% /alert %}}

### **Gestion de la mémoire**

La propriété [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) peut être utilisée pour contrôler la réallocation de mémoire. La réallocation se produit le plus souvent pour les caches préalloués. Cela peut se produire lorsque le système réalise que l'espace alloué ne sera pas suffisant.

- Si [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) est défini à la valeur par défaut, **False**, l'espace est réalloué au même support.
- Lorsqu'il est défini sur **True**, la réallocation ne peut pas dépasser l'espace maximum spécifié. Dans ce cas, le cache en mémoire déjà alloué (qui nécessite une réallocation) est libéré et un espace étendu est alloué sur le disque.

## **Exportation d'une couche spécifique de dessins DXF au format PDF**

Cette approche fonctionne comme suit :

1. Ouvrez un fichier de dessin DXF à l'aide de la méthode d'usine [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Créez une instance de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) et spécifiez les propriétés [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) et [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Ajoutez des couches à l'objet de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Créez une instance de [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) et définissez sa propriété [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Exportez le dessin au format PDF à l'aide de la méthode [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

L'exemple de code ci-dessous montre comment convertir une couche spécifique de DXF en PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificLayerOfDXFDrawingToPDF-.java" >}}

## **Exportation d'une couche spécifique de dessins DXF au format image**

Cette approche fonctionne comme suit :

1. Ouvrez un fichier de dessin DXF à l'aide de la méthode d'usine [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Créez une instance de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) et spécifiez les propriétés [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) et [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Ajoutez des couches à l'objet de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Créez une instance de [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) et définissez sa propriété [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Exportez le dessin au format image à l'aide de la méthode [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

L'exemple de code ci-dessous montre comment convertir une couche spécifique de DXF en image.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.java" >}}

## **Rendre des fichiers PDF comme partie des dessins DXF**

Cette approche fonctionne comme suit :

1. Chargez le fichier de dessin DXF à l'aide de la méthode d'usine [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Créez un objet de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) et chargez des fichiers PDF.
1. définissez les propriétés [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) et [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad/imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Appelez [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) et enregistrez le fichier.

L'exemple de code ci-dessous montre comment rendre des fichiers PDF comme partie des dessins DXF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-RenderDXFAsPDF-RenderDXFAsPDF.java" >}}

## **Export DXF vers WMF**

Cette approche fonctionne comme suit :

1. Chargez le fichier de dessin DXF à l'aide de la méthode d'usine [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Créez un objet de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) et chargez des fichiers PDF.
1. définissez les propriétés [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) et [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Appelez [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) et enregistrez le fichier.

L'exemple de code ci-dessous montre comment exporter DXF au format WMF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFToWMF-ExportDXFToWMF.java" >}}

## **Support pour l'enregistrement de fichiers DXF**

Aspose.CAD offre la possibilité de charger des fichiers DXF d'AutoCAD, d'apporter des modifications et de les enregistrer à nouveau sous forme de fichier DXF. L'exemple de code ci-dessous montre comment répondre aux exigences spécifiées.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SaveDXFFiles-SaveDXFFiles.java" >}}

## **Exportation de l'underlay DGN intégré au format DXF**

Aspose.CAD propose la possibilité de charger des fichiers DXF d'AutoCAD et d'exporter l'underlay DGN intégré pour le format DXF.

L'exemple de code ci-dessous montre comment réaliser les exigences spécifiées.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportEmbeddedDGN-ExportEmbeddedDGN.java" >}}

## **Exportation d'une disposition DXF spécifique au format PDF**

Cette approche fonctionne comme suit :

1. Ouvrez un fichier de dessin DXF à l'aide de la méthode d'usine [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Créez une instance de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) et spécifiez les propriétés [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) et [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Spécifiez le(s) nom(s) de disposition souhaité(s) à l'aide de la propriété [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-).
1. Créez une instance de [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) et définissez sa propriété [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Exportez le dessin au format PDF à l'aide de la méthode [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

L'exemple de code ci-dessous montre comment convertir une disposition spécifique de DXF en PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToPDF-.java" >}}

{{% alert color="primary" %}}

La propriété [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) est de type tableau de chaînes, vous pouvez donc spécifier plusieurs dispositions à la fois pour une conversion possible au format PDF. En spécifiant plusieurs dispositions pour la propriété [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-), le PDF résultant aurait plusieurs pages, où chaque page représente une disposition AutoCAD individuelle.

{{% /alert %}}

## **Accéder aux objets ATTRIB et MTEXT**

Cette approche fonctionne comme suit :

1. Ouvrez un fichier de dessin DXF à l'aide de la méthode d'usine [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Accédez aux entités à l'intérieur du fichier CAD.
1. Vérifiez les entités [**CadEntityTypeName.MTEXT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#MTEXT) et [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT).
1. Ajoutez à la liste temporaire pour un traitement ultérieur.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-AddAttribMText-AddAttribMText.java" >}}

## **Décomposer les objets d'insertion CAD**

Cette approche fonctionne comme suit :

1. Ouvrez un fichier de dessin **DXF** à l'aide de la méthode d'usine [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Accédez aux entités à l'intérieur du fichier CAD.
1. Vérifiez les entités [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT).
1. vérifiez la liste des types [**CadBlockEntity**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity).
1. Traitez les entités.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-DecomposeCadInsertObject-DecomposeCadInsertObject.java" >}}

## **Support du découpage de bloc**

Aspose.CAD offre la fonctionnalité de découpage de bloc. L'approche de découpage de bloc fonctionne comme suit :

1. Chargez le fichier de dessin DXF à l'aide de la méthode d'usine [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Créez un objet de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) et chargez des fichiers PDF.
1. Définissez les propriétés souhaitées de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Appelez [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) en passant un objet de [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) comme deuxième paramètre et enregistrez le fichier.

L'exemple de code ci-dessous montre comment fonctionne le découpage de bloc.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SupportOfBlockClipping-SupportOfBlockClipping.java" >}}

## **Exporter des images vers DXF**

Avec Aspose.CAD, vous pouvez exporter des images au format DXF. En utilisant cette approche, vous pouvez effectuer les actions suivantes :

1. Définir une nouvelle police
1. Cacher les entités
1. Mettre à jour le texte

Le snippet de code suivant montre comment effectuer les actions énumérées ci-dessus.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-ExportImagesToDXF.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-GetFileExtension.java" >}}
