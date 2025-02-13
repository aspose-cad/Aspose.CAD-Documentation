---
title: Dessins STP
type: docs
weight: 70
url: /fr/net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **Exportation du format STP en PDF**

Aspose.CAD pour .NET permet aux développeurs d'exporter un fichier [STP](https://docs.fileformat.com/3d/stp/) au format [PDF](https://docs.fileformat.com/pdf/). L'approche de conversion de [STP](https://docs.fileformat.com/3d/stp/) en [PDF](https://docs.fileformat.com/pdf/) fonctionne comme suit :

1. Charger le fichier de dessin [STP](https://docs.fileformat.com/3d/stp/) en utilisant la méthode de fabrique [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Créer un objet de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) et définir les propriétés [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) et [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Créer un objet de la classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) et définir la propriété [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Appeler [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) en passant un objet de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) comme deuxième paramètre.

## Exemple de Code

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-STP-to-PDF-Export.cs" >}}
