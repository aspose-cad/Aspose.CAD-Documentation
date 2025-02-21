---
title: タイトルを追加するために図面を下に移動する
type: docs
weight: 40
url: /ja/net/developer-guide/how-to/move-drawing-down-to-add-title/
---

## **タイトルを追加するために図面を下に移動する方法**

**問題:** タイトルを追加するために図面を下に移動する方法 (CADNET-980)。

**ヒント:** これを行うには、パラメータを持つ CadText オブジェクトを作成し、このブロックを図面に追加します。その後、UpdateSize で新しい寸法を使用して図面を更新し、図面の周りにフレームとなるポリラインを追加し、BlockEntities["*Model_Space"] にポリラインを追加して再度 UpdateSize で更新します。

**例:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "move-drawing-down-to-add-title.cs" >}}
