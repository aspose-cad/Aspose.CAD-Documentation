---
title: Travailler avec le format de fichier OBJ
type: docs
weight: 120
url: /fr/javascript-net/developer-guide/cad-and-bim-drawings/travailler-avec-le-format-de-fichier-obj/
---

{{% alert color="primary" %}}

Aspose.CAD prend désormais en charge le format de fichier OBJ. Le format de fichier OBJ est une géométrie 3D qui contient des textures, des coordonnées 3D, des faces polygonales et d'autres informations sur l'objet.

{{% /alert %}}

## **Exportation du format OBJ vers PNG**

Aspose.CAD pour Javascript dans Angular permet aux développeurs d'exporter un [OBJ](https://docs.fileformat.com/3d/obj/) vers le format [PNG](https://docs.fileformat.com/image/png/).
L'approche de conversion de [OBJ](https://docs.fileformat.com/3d/obj/) en [PNG](https://docs.fileformat.com/image/png/) fonctionne comme suit :

1. Chargez le fichier de dessin [OBJ](https://docs.fileformat.com/3d/obj/) en utilisant la méthode **Image.load**.
1. Appelez **Image.save** en passant un objet de **PngOptions** en tant que deuxième paramètre.

## Exemple de code

Le code ci-dessous montre comment atteindre le même objectif en utilisant Aspose.CAD pour JavaScript

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-OBJ-to-PNG-Export.js" >}}
