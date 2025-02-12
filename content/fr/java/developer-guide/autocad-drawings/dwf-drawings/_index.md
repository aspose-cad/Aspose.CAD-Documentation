---
title: Dessins DWF
type: docs
weight: 20
url: /fr/java/dwf-drawings/
---

## **Exportation des Dessins DWF en PDF**

Aspose.CAD pour l'API Java peut charger des dessins AutoCAD au format DWF et les convertir en PDF. Ce sujet explique l'utilisation de l'API Aspose.CAD pour réaliser la conversion de DWF au format PDF à travers des étapes simples comme défini ci-après.

### **Convertir les fichiers DWF en PDF**

Les étapes simples suivantes sont nécessaires pour convertir DWF en PDF.

1. Charger le fichier DWF dans une instance de [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Créer un objet de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) et définir les propriétés [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) & [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Créer un objet de la classe [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) et définir la propriété [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Appeler [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) en passant un objet de [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) comme deuxième paramètre.

L'exemple de code ci-dessous montre comment exporter des Dessins DWF en PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToPDF-ExportToPDF.java" >}}

### **Support des calques dans DWF**

Aspose.CAD fournit la fonctionnalité de charger les entités de dessin DWF AutoCAD et de les rendre en tant que dessin complet au format JPG.

1. Charger le fichier de dessin DWF en utilisant la méthode de fabrique [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Créer un objet de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Ajouter les calques souhaités.
1. Appeler [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) en passant un objet de [**JPEGOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) comme deuxième paramètre.

L'exemple de code ci-dessous montre comment convertir un fichier en utilisant les paramètres par défaut.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWFDrawings-SupportOfLayers-SupportOfLayers.java" >}}
