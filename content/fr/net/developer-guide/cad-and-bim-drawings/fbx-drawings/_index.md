---
title: Dessins FBX
type: docs
weight: 70
url: /fr/net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **Exporter le format FBX vers PDF**

Aspose.CAD pour .NET permet aux développeurs d'exporter un fichier [FBX](https://docs.fileformat.com/3d/fbx/) au format [PDF](https://docs.fileformat.com/pdf/). L'approche de conversion [FBX](https://docs.fileformat.com/3d/fbx/) vers [PDF](https://docs.fileformat.com/pdf/) fonctionne comme suit :

1. Chargez le fichier de dessin [FBX](https://docs.fileformat.com/3d/fbx/) en utilisant la méthode de fabrique [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Créez un objet de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) et définissez les propriétés [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) et [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Créez un objet de la classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) et définissez la propriété [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Appelez [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) en passant un objet de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) comme deuxième paramètre.

## Exemple de code

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-FBX-to-PDF-Export.cs" >}}
