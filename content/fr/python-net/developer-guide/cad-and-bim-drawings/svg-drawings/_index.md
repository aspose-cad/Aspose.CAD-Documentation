---
title: Dessins SVG
type: docs
weight: 170
url: /fr/python-net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **Exportation du format SVG vers PDF**

Aspose.CAD pour Python permet aux développeurs d'exporter un fichier [SVG](https://docs.fileformat.com/page-description-language/svg/) au format [PDF](https://docs.fileformat.com/pdf/). L'approche de conversion de [SVG](https://docs.fileformat.com/page-description-language/svg/) en [PDF](https://docs.fileformat.com/pdf/) fonctionne comme suit :

1. Chargez le fichier de dessin SVG en utilisant la méthode de fabrique **Image.load**.
1. Créez un objet de la classe **CadRasterizationOptions** et définissez les propriétés **page_height** et **page_width**.
1. Créez un objet de la classe **PdfOptions** et définissez la propriété **VectorRasterizationOptions**.
1. Appelez **Image.save** en passant un objet de **PdfOptions** comme deuxième paramètre.

## Exemple de code

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-SVG-to-PDF-Export.py" >}}
