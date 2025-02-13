---
title: Insérer un dessin DXF/DWG à l'intérieur d'un DWG
type: docs
weight: 38
url: /fr/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dwg/
---

## **Comment insérer un dessin DXF/DWG à l'intérieur d'un DWG**

**Problème :** Comment insérer un dessin DXF/DWG à l'intérieur d'un DWG.

**Astuces :** Pour ce faire, créez d'abord un CadInsertObject avec les valeurs requises, puis récupérez tous les blocs dans un CadBlockDictionary, créez un nouveau bloc CadBlockEntity et ajoutez-le au CadBlockDictionary, ajoutez un CadBlockDictionary aux BlockEntities du dessin, ajoutez un CadInsertObject à l'entité de dessin pour le tableau, créez un CadBlockTableObject par référence, puis ajoutez un bloc au dessin.

**Exemple :**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dwg.cs" >}}
