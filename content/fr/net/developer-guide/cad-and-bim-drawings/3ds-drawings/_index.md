---
title: Dessins 3DS
type: docs
weight: 70
url: /fr/net/developer-guide/cad-and-bim-drawings/3ds-drawings/
---

## **Exportation du format 3DS en PDF**

Aspose.CAD pour .NET permet aux développeurs d'exporter un fichier [3DS](https://docs.fileformat.com/3d/3ds/) au format [PDF](https://docs.fileformat.com/pdf/). L'approche de conversion de [3DS](https://docs.fileformat.com/3d/3ds/) en [PDF](https://docs.fileformat.com/pdf/) fonctionne comme suit :

1. Chargez le fichier de dessin [3DS](https://docs.fileformat.com/3d/3ds/) en utilisant la méthode de fabrique [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
2. Créez un objet de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) et définissez les propriétés [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) et [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
3. Créez un objet de la classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) et définissez la propriété [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
4. Appelez [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) en passant un objet de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) comme deuxième paramètre.

## Exemple de Code

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-3DS-to-PDF-Export.cs" >}}
