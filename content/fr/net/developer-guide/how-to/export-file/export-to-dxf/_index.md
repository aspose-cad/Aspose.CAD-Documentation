---
title: Exporter vers DXF
type: docs
weight: 20
url: /fr/net/developer-guide/how-to/export-file/export-to-dxf/
---

## **Comment exporter vers DXF**

**Problème :** Comment exporter vers DXF.

**Conseils :** Pour ce faire, vous pouvez utiliser DxfOption, à la fois binaire et normal, dans les options d'enregistrement de fichier.

**Remarque :** L'une des fonctionnalités intéressantes est la capacité d'enregistrer n'importe quel format de fichier pris en charge en dxf.
C'est une très bonne fonctionnalité, qui présente également plusieurs nuances :
L'enregistrement à partir des formats de fichiers DXF/DWG - effectue une exportation avec des entités exactes que le format source possède.
L'exportation à partir d'autres formats - effectue une exportation en n'utilisant que des lignes et des entités de texte.
De plus, nous prenons en charge les formats de fichiers DXf ASCII et binaire.

**Exemple :**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "export-to-dxf.cs" >}}
