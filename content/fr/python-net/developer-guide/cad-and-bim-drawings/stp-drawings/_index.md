---
title: Dessins STP
type: docs
weight: 160
url: /fr/python-net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **Exportation du format STP vers PDF**

Aspose.CAD pour Python permet aux développeurs d'exporter un fichier [STP](https://docs.fileformat.com/3d/stp/) vers le format [PDF](https://docs.fileformat.com/pdf/). L'approche de conversion de [STP](https://docs.fileformat.com/3d/stp/) à [PDF](https://docs.fileformat.com/pdf/) fonctionne comme suit :

1. Charger le fichier de dessin [STP](https://docs.fileformat.com/3d/stp/) en utilisant la méthode de fabrique **Image.load**.
1. Créer un objet de la classe **CadRasterizationOptions** et définir les propriétés **page_height** et **page_width**.
1. Créer un objet de la classe **PdfOptions** et définir la propriété **vector_rasterization_options**.
1. Appeler **Image.save** en passant un objet de **PdfOptions** comme deuxième paramètre.

## Exemple de code

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-STP-to-PDF-Export.py" >}}
