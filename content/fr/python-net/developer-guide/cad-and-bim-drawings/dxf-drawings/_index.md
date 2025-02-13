---
title: Dessins DXF
type: docs
weight: 10
url: /fr/python-net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **Exportation des Dessins DXF en PDF**

Aspose.CAD offre la possibilité de charger des entités de dessins DXF AutoCAD et de les rendre sous forme de dessin complet au format PDF. L'approche de conversion DXF en PDF fonctionne comme suit :

1. Chargez le fichier de dessin DXF en utilisant la méthode de fabrique **Image.load**.
1. Créez un objet de la classe **CadRasterizationOptions** et définissez les propriétés **page_height** et **page_width**.
1. Créez un objet de la classe **PdfOptions** et définissez la propriété **VectorRasterizationOptions**.
1. Appelez **Image.save** en passant un objet de **PdfOptions** comme deuxième paramètre.

L'exemple de code ci-dessous montre comment convertir un fichier en utilisant les paramètres par défaut.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXF-to-PDF-Export.py" >}}

### **Formats Pris en Charge**

Pour le moment, nous prenons entièrement en charge les formats de fichiers DXF AutoCAD 2010. Les versions précédentes de DXF ne sont pas garanties d'être valides à 100 %. Nous prévoyons d'inclure davantage de formats et de fonctionnalités dans les futures versions d'Aspose.CAD.

### **Entités Pris en Charge**

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

Si pendant l'analyse nous rencontrons une entité ou une propriété que nous ne supportons pas, l'entité ou la propriété sera ignorée silencieusement.

{{% /alert %}}

## **Exporter le DGN sous-jacent intégré au format DXF**

Aspose.CAD offre la possibilité de charger des fichiers DXF AutoCAD et d'exporter le DGN sous-jacent intégré au format DXF.

L'exemple de code ci-dessous montre comment atteindre les exigences spécifiées.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ExportEmbeddedDGN.py" >}}

## **Support pour la Sauvegarde des Fichiers DXF**

Aspose.CAD offre la possibilité de charger des fichiers DXF AutoCAD, d'y apporter des modifications et de les enregistrer à nouveau sous forme de fichier DXF.

L'exemple de code ci-dessous montre comment atteindre les exigences spécifiées.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-Drawings-SaveDXFFiles.py" >}}

## **Exporter DXF en WMF**

Cette approche fonctionne comme suit :

1. Chargez le fichier de dessin DXF en utilisant la méthode de fabrique **Image.load**.
1. Créez un objet de la classe **CadRasterizationOptions** et chargez les fichiers PDF.
1. définissez les propriétés **page_height** et **page_width**.
1. Appelez **Image.save** et enregistrez le fichier.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-to-WMF-Export.py" >}}
