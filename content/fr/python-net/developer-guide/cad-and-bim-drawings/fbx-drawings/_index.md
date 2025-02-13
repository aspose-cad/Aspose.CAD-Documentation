---
title: Dessins FBX
type: docs
weight: 110
url: /fr/python-net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **Exportation du format FBX vers PDF**

Aspose.CAD pour Python permet aux développeurs d'exporter un fichier [FBX](https://docs.fileformat.com/3d/fbx/) au format [PDF](https://docs.fileformat.com/pdf/). L'approche de conversion de [FBX](https://docs.fileformat.com/3d/fbx/) à [PDF](https://docs.fileformat.com/pdf/) fonctionne comme suit :

1. Charger le fichier de dessin [FBX](https://docs.fileformat.com/3d/fbx/) en utilisant la méthode de fabrique **Image.load**.
1. Créer un objet de la classe **CadRasterizationOptions** et définir les propriétés **PageHeight** et **PageWidth**.
1. Créer un objet de la classe **PdfOptions** et définir la propriété **vector_rasterization_options**.
1. Appeler **Image.save** en passant un objet de **PdfOptions** comme deuxième paramètre.

## Code d'exemple

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-FBX-to-PDF-Export.py" >}}
