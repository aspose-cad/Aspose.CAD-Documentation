---
title: Insérer un dessin DXF/DWG à l'intérieur d'un DXF
type: docs
weight: 39
url: /fr/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dxf/
---

## **Comment insérer un dessin DXF/DWG à l'intérieur d'un DXF**

**Problème :** Comment insérer un dessin DXF/DWG à l'intérieur d'un DXF.

**Conseils :** Pour ce faire, vous devez d'abord créer un CadInsertObject avec les valeurs nécessaires, puis obtenir tous les blocs dans le CadBlockDictionary, créer un nouveau bloc CadBlockEntity et l'ajouter au CadBlockDictionary, ajouter le CadBlockDictionary aux BlockEntities du dessin, ajouter un CadInsertObject aux entités du dessin pour le tableau.

**Exemple :**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dxf.cs" >}}
