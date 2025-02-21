---
title: DXF の中に DXF/DWG 図面を挿入する
type: docs
weight: 39
url: /ja/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dxf/
---

## **DXF/DWG 図面を DXF の中に挿入する方法**

**問題:** DXF の中に DXF/DWG 図面を挿入する方法。

**ヒント:** これを行うには、まず必要な値を持つ CadInsertObject を作成し、次に CadBlockDictionary 内のすべてのブロックを取得し、新しい CadBlockEntity ブロックを作成して CadBlockDictionary に追加し、CadBlockDictionary を図面の BlockEntities に追加し、配列用に図面のエンティティに CadInsertObject を追加します。

**例:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dxf.cs" >}}
