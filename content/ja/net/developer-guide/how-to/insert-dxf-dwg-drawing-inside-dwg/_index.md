---
title: DWG内にDXF/DWG図面を挿入する
type: docs
weight: 38
url: /ja/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dwg/
---

## **DWG内にDXF/DWG図面を挿入する方法**

**問題:** DWG内にDXF/DWG図面を挿入する方法。

**ヒント:** これを行うには、最初に必要な値を持つCadInsertObjectを作成し、次にCadBlockDictionary内のすべてのブロックを取得し、新しいCadBlockEntityブロックを作成してCadBlockDictionaryに追加し、図面のBlockEntitiesにCadBlockDictionaryを追加し、配列のために図面エンティティにCadInsertObjectを追加し、参照によってCadBlockTableObjectを作成し、その後図面にブロックを追加します。

**例:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dwg.cs" >}}
