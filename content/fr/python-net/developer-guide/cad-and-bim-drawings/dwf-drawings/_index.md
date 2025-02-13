---
title: Dessins DWF
type: docs
weight: 50
url: /fr/python-net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **Exportation des dessins DWF en PDF**

Aspose.CAD fournit la fonctionnalité de charger des entités de dessin AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) et de les rendre en tant que dessin entier au format [PDF](https://docs.fileformat.com/pdf/). L'approche de conversion de [DWF](https://docs.fileformat.com/cad/dwf/) à [PDF](https://docs.fileformat.com/pdf/) fonctionne comme suit :

1. Chargez le fichier de dessin [DWF](https://docs.fileformat.com/cad/dwf/) en utilisant la méthode de fabrique **Image.load**.
1. Créez un objet de la classe **CadRasterizationOptions** et définissez les propriétés **page_height** et **page_width**.
1. Créez un objet de la classe **PdfOptions** et définissez la propriété **vector_rasterization_options**.
1. Appelez **Image.save** en passant un objet de **PdfOptions** comme deuxième paramètre.

### Exemple de Code

L'exemple de code ci-dessous montre comment convertir un fichier en utilisant les paramètres par défaut.


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-PDF-Export.py" >}}

## **Exportation des dessins DWF en BMP**

Aspose.CAD fournit la fonctionnalité de charger des entités de dessin AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) et de les rendre en tant que dessin entier au format [BMP](https://docs.fileformat.com/image/bmp/). L'approche de conversion de [DWF](https://docs.fileformat.com/cad/dwf/) à [BMP](https://docs.fileformat.com/image/bmp/) fonctionne comme suit :

1. Chargez le fichier de dessin [DWF](https://docs.fileformat.com/cad/dwf/) en utilisant la méthode de fabrique **Image.load**.
1. Créez un objet de la classe **CadRasterizationOptions** et définissez les propriétés **page_height** et **page_width**.
1. Créez un objet de la classe **BmpOptions** et définissez la propriété **vector_rasterization_options**.
1. Appelez **Image.save** en passant un objet de **BmpOptions** comme deuxième paramètre.

### Exemple de Code

L'exemple de code ci-dessous montre comment convertir un fichier [DWF](https://docs.fileformat.com/cad/dwf/) en [BMP](https://docs.fileformat.com/image/bmp/) en utilisant des paramètres par défaut.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-BMP-Export.py" >}}
