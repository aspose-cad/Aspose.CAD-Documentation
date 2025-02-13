---
title: Dessins DXB
type: docs
weight: 70
url: /fr/net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **Exportation du format DXB vers PDF**

Aspose.CAD pour .NET permet aux développeurs d'exporter un fichier DXB au format [PDF](https://docs.fileformat.com/pdf/). L'approche de conversion de DXB en [PDF](https://docs.fileformat.com/pdf/) fonctionne comme suit :

1. Chargez le fichier de dessin DXB en utilisant la méthode d'usine [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Créez un objet de la classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) et définissez les propriétés [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) et [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Créez un objet de la classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) et définissez la propriété [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Appelez [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) en passant un objet de [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) comme deuxième paramètre.

## Exemple de Code

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DXB-to-PDF-Export.cs" >}}
