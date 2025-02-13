---
title: Dessins DXF
type: docs
weight: 60
url: /fr/net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **Exportation des Dessins DXF vers PDF**

Aspose.CAD offre la fonctionnalité de charger des entités de dessin DXF d'AutoCAD et de les rendre en tant qu'ensemble de dessin au format PDF. L'approche de conversion DXF en PDF fonctionne comme suit :

1. Chargez le fichier de dessin DXF en utilisant la méthode de fabrique [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Créez un objet de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) et définissez les propriétés [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) et [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Créez un objet de la classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) et définissez la propriété [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Appelez [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) en passant un objet de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) en tant que deuxième paramètre.

L'exemple de code ci-dessous montre comment convertir un fichier en utilisant les paramètres par défaut.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFToPDF-ExportDXFToPDF.cs" >}}

### **Formats Supportés**

Pour le moment, nous supportons entièrement les formats de fichiers AutoCAD DXF 2010. Les versions antérieures de DXF ne garantissent pas d'être 100% valides. Nous prévoyons d'inclure plus de formats et de fonctionnalités dans les futures versions d'Aspose.CAD.

### **Entités Supportées**

Pour le moment, nous prenons en charge toutes les entités 2D répandues et leurs paramètres par défaut de base comme suit :

1. Dimension Alignée
1. Dimension Angulaire
1. Arc
1. Attribut
1. Référence de Bloc
1. Cercle
1. Dimension de Diamètre
1. Ellipse
1. Hachure
1. Ligne
1. Texte Multiligne
1. Dimension Ordonnée
1. Point
1. Polyligne
1. Dimension Radiale
1. Rayon
1. Dimension Rotatée
1. Table
1. Texte
1. Xline

{{% alert color="primary" %}}

Si pendant l'analyse nous rencontrons une entité ou une propriété que nous ne supportons pas, l'entité ou la propriété sera silencieusement ignorée.

{{% /alert %}}

### **Gestion de Mémoire**

La propriété [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) de la classe [**Cache**](https://reference.aspose.com/cad/net/aspose.cad/cache) peut être utilisée pour contrôler la réallocation de la mémoire. La réallocation est plus susceptible de se produire pour les caches pré-alloués. Cela peut se produire lorsque le système détermine que l'espace alloué ne sera pas suffisant.

- Si [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) est défini à la valeur par défaut, **False**, l'espace est réalloué au même support.
- Lorsqu'il est défini à **True**, la réallocation ne peut pas dépasser l'espace maximum spécifié. Dans ce cas, le cache en mémoire existant (qui nécessite une réallocation) est libéré et un espace étendu est alloué sur le disque.

## **Exportation d'une Couche Spécifique des Dessins DXF vers PDF**

Cette approche fonctionne comme suit :

1. Ouvrez un fichier de dessin DXF en utilisant la méthode de fabrique [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Créez une instance de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) et spécifiez les propriétés [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) et [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Ajoutez des couches à l'objet de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Créez une instance de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) et définissez sa propriété [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Appelez la méthode [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) et passez l'objet de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) comme deuxième paramètre.

L'exemple de code ci-dessous montre comment convertir une couche spécifique de DXF en PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayerToPDF-ExportDXFSpecificLayerToPDF.cs" >}}

## **Rendre des fichiers PDF comme partie des dessins DXF**

Cette approche fonctionne comme suit :

1. Chargez le fichier de dessin DXF en utilisant la méthode de fabrique [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Créez un objet de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) et chargez des fichiers PDF.
1. Définissez les propriétés [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) et [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Appelez [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) et sauvegardez le fichier.

L'exemple de code ci-dessous montre comment rendre des fichiers PDF comme partie des dessins DXF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

## **Exporter la sous-couche DGN intégrée pour le format DXF**

Aspose.CAD offre la fonctionnalité de charger des fichiers DXF d'AutoCAD et d'exporter la sous-couche DGN intégrée pour le format DXF.

L'exemple de code ci-dessous montre comment atteindre les exigences spécifiées.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **Support pour la Sauvegarde des Fichiers DXF**

Aspose.CAD offre la fonctionnalité de charger des fichiers DXF d'AutoCAD, d'apporter des modifications et de les sauvegarder à nouveau sous forme de fichier DXF.

L'exemple de code ci-dessous montre comment atteindre les exigences spécifiées.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-SaveDXFFiles-SaveDXFFiles.cs" >}}

## **Exportation DXF vers WMF**

Cette approche fonctionne comme suit :

1. Chargez le fichier de dessin DXF en utilisant la méthode de fabrique [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Créez un objet de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) et chargez des fichiers PDF.
1. Définissez les propriétés [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) et [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Appelez [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) et sauvegardez le fichier.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportDXFToWMF-ExportDXFToWMF.cs" >}}

## **Exportation d'une Mise en Page DXF Spécifique vers PDF**

Cette approche fonctionne comme suit :

1. Ouvrez un fichier de dessin DXF en utilisant la méthode de fabrique [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Créez une instance de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) et spécifiez les propriétés [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) et [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Spécifiez le(s) nom(s) de mise en page souhaité(s) en utilisant la propriété [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts).
1. Créez une instance de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) et définissez sa propriété [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Exportez le dessin en PDF en appelant la méthode [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) et en passant l'objet de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) comme deuxième paramètre.

L'exemple de code ci-dessous montre comment convertir une mise en page spécifique de DXF en PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

{{% alert color="primary" %}}

La propriété [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) est de type tableau de chaînes, vous pouvez donc spécifier plus d'une mise en page à la fois pour une conversion possible en format PDF. Lors de la spécification de plusieurs mises en page pour la propriété [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts), le PDF résultant aura plusieurs pages, où chaque page représente une mise en page AutoCAD individuelle.

{{% /alert %}}

## **Support du Clipping de Bloc**

Aspose.CAD offre la fonctionnalité de Clipping de Bloc. L'approche de Clipping de Bloc fonctionne comme suit :

1. Chargez le fichier de dessin DXF en utilisant la méthode de fabrique [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Créez un objet de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) et chargez des fichiers PDF.
1. Définissez les propriétés souhaitées de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Appelez [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) en passant un objet de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) comme deuxième paramètre et sauvegardez le fichier.

L'exemple de code ci-dessous montre comment fonctionne le Clipping de Bloc.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DXF-Drawings-SupportOfBlockClipping-SupportOfBlockClipping.cs" >}}

## **Exporter des Images vers DXF**

Avec Aspose.CAD, vous pouvez exporter des images au format DXF. Grâce à cette approche, vous pouvez effectuer les actions suivantes :

1. Définir une nouvelle police
1. Cacher des entités
1. Mettre à jour le texte

L'exemple de code ci-dessous vous montre comment effectuer les actions listées ci-dessus.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportImagesToDXF-ExportImagesToDXF.cs" >}}

## **Exportation d'une Couche Spécifique des Dessins DXF vers une Image**

Cette approche fonctionne comme suit :

1. Ouvrez un fichier de dessin DXF en utilisant la méthode de fabrique [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Créez une instance de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) et spécifiez les propriétés [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) et [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Ajoutez des couches à l'objet de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Créez une instance de [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) et définissez sa propriété [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Exportez le dessin en PDF en utilisant la méthode [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

L'exemple de code ci-dessous montre comment convertir une couche spécifique de DXF en Image.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.cs" >}}
