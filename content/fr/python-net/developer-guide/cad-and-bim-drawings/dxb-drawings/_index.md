---
title: Dessins DXB
type: docs
weight: 90
url: /fr/python-net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **Exportation du format DXB en PDF**

Aspose.CAD pour Python permet aux développeurs d'exporter un fichier DXB au format [PDF](https://docs.fileformat.com/pdf/). L'approche de conversion DXB en [PDF](https://docs.fileformat.com/pdf/) fonctionne comme suit :

1. Chargez le fichier de dessin DXB en utilisant la méthode de fabrique **Image.load**.
1. Créez un objet de la classe **CadRasterizationOptions** et définissez les propriétés **page_height** et **page_width**.
1. Créez un objet de la classe **PdfOptions** et définissez la propriété **vector_rasterization_options**.
1. Appelez **Image.save** en passant un objet de **PdfOptions** comme deuxième paramètre.

## Exemple de code

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXB-to-PDF-Export.py" >}}
