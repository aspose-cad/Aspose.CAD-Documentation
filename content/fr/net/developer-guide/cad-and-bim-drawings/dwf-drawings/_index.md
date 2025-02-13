---
title: Dessins DWF
type: docs
weight: 20
url: /fr/net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **Exportation de dessins DWF vers PDF**

Aspose.CAD fournit la fonctionnalité de charger des entités de dessin AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) et de les rendre comme un dessin entier au format [PDF](https://docs.fileformat.com/pdf/). L'approche de conversion [DWF](https://docs.fileformat.com/cad/dwf/) vers [PDF](https://docs.fileformat.com/pdf/) fonctionne comme suit :

1. Charger le fichier de dessin [DWF](https://docs.fileformat.com/cad/dwf/) en utilisant la méthode de fabrique [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Créer un objet de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) et définir les propriétés [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) et [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Créer un objet de la classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) et définir la propriété [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Appeler [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) tout en passant un objet de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) comme deuxième paramètre.

### Exemple de code

L'exemple de code ci-dessous montre comment convertir un fichier en utilisant les paramètres par défaut.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **Extraire des calques à partir d'un dessin DWF**

Aspose.CAD fournit la fonctionnalité de charger des entités de dessin AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) et de les rendre comme un dessin entier au format [JPEG](https://docs.fileformat.com/image/jpeg/).

1. Charger le fichier de dessin [DWF](https://docs.fileformat.com/cad/dwf/) en utilisant la méthode de fabrique [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Créer un objet de la classe [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions).
1. Créer un objet de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Extraire le nom des calques à l'aide de l'objet [JPEG](https://docs.fileformat.com/image/jpeg/).
1. Appeler [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) tout en passant un objet de [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) comme deuxième paramètre.

### Exemple de code

L'exemple de code ci-dessous montre comment convertir un fichier en utilisant les paramètres par défaut.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **Support des calques dans DWF**

Aspose.CAD fournit la fonctionnalité de charger des entités de dessin AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) et de les rendre comme un dessin entier au format [JPEG](https://docs.fileformat.com/image/jpeg/).

1. Charger le fichier de dessin [DWF](https://docs.fileformat.com/cad/dwf/) en utilisant la méthode de fabrique [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Créer un objet de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Ajouter les calques souhaités.
1. Appeler [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) tout en passant un objet de [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) comme deuxième paramètre.

### Exemple de code

L'exemple de code ci-dessous montre comment convertir un fichier en utilisant les paramètres par défaut.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWF-Drawings-SupportOfLayers-SupportOfLayers.cs" >}}

## **Exportation de dessins DWF vers BMP**

Aspose.CAD fournit la fonctionnalité de charger des entités de dessin AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) et de les rendre comme un dessin entier au format [BMP](https://docs.fileformat.com/image/bmp/). L'approche de conversion [DWF](https://docs.fileformat.com/cad/dwf/) vers [BMP](https://docs.fileformat.com/image/bmp/) fonctionne comme suit :

1. Charger le fichier de dessin [DWF](https://docs.fileformat.com/cad/dwf/) en utilisant la méthode de fabrique [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Créer un objet de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) et définir les propriétés [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) et [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Créer un objet de la classe [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) et définir la propriété [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Appeler [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) tout en passant un objet de [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) comme deuxième paramètre.

### Exemple de code

L'exemple de code ci-dessous montre comment convertir un fichier [DWF](https://docs.fileformat.com/cad/dwf/) au format [BMP](https://docs.fileformat.com/image/bmp/) en utilisant les paramètres par défaut.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}
