---
title: Dessins COLLADA
type: docs
weight: 20
url: /fr/python-net/developer-guide/cad-and-bim-drawings/collada-drawings/
---

## **Exportation du format COLLADA en PDF**

Aspose.CAD pour Python permet aux développeurs d'exporter un fichier [COLLADA](https://docs.fileformat.com/3d/dae/) au format [PDF](https://docs.fileformat.com/pdf/). L'approche de conversion de [COLLADA](https://docs.fileformat.com/3d/dae/) en [PDF](https://docs.fileformat.com/pdf/) fonctionne comme suit :

1. Chargez le fichier de dessin [COLLADA](https://docs.fileformat.com/3d/dae/) en utilisant la méthode de fabrique **Image.load**.
1. Créez un objet de la classe **CadRasterizationOptions** et définissez les propriétés **page_height** et **page_width**.
1. Créez un objet de la classe **PdfOptions** et définissez la propriété **vector_rasterization_options**.
1. Appelez **Image.save** en passant un objet de **PdfOptions** comme deuxième paramètre.

## Code d'exemple

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-COLLADA-to-PDF-Export.py" >}}
