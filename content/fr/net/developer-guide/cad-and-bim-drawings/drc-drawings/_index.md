---
title: Dessins DRC
type: docs
weight: 15
url: /fr/net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **Exportation des Dessins DRC en PDF**

Aspose.CAD fournit la fonctionnalité de charger les entités de dessin AutoCAD [DRC](https://docs.fileformat.com/3d/drc/) et de les rendre en tant que dessin entier au format [PDF](https://docs.fileformat.com/pdf/). L'approche de conversion de [DRC](https://docs.fileformat.com/3d/drc/) en [PDF](https://docs.fileformat.com/pdf/) fonctionne comme suit :

1. Charger le fichier de dessin [DRC](https://docs.fileformat.com/3d/drc/) en utilisant la méthode de fabrique [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Créer un objet de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) et définir les propriétés [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) et [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Créer un objet de la classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) et définir la propriété [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Appeler [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) tout en passant un objet de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) comme deuxième paramètre.

### Exemple de Code

L'exemple de code ci-dessous montre comment convertir un fichier en utilisant les paramètres par défaut.


{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DRC-to-PDF-Export.cs" >}}
