---
title: Dossiers DRC
type: docs
weight: 40
url: /fr/python-net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **Exportation du format DRC en PDF**

Aspose.CAD pour Python permet aux développeurs d'exporter un fichier [DRC](https://docs.fileformat.com/3d/drc/) en format [PDF](https://docs.fileformat.com/pdf/). L'approche de conversion de [DRC](https://docs.fileformat.com/3d/drc/) en [PDF](https://docs.fileformat.com/pdf/) fonctionne comme suit :

1. Charger le fichier de dessin DRC en utilisant la méthode de fabrique **Image.load**.
1. Créer un objet de la classe **CadRasterizationOptions** et définir les propriétés **page_height** et **page_width**.
1. Créer un objet de la classe **PdfOptions** et définir la propriété **VectorRasterizationOptions**.
1. Appeler **Image.save** en passant un objet de **PdfOptions** comme deuxième paramètre.

## Exemple de code


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "convert-drc-to-pdf.py" >}}
