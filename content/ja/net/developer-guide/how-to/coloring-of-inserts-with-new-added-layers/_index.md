---
title: 新しく追加されたレイヤーを使用した挿入のカラリング
type: docs
weight: 23
url: /ja/net/developer-guide/how-to/coloring-of-inserts-with-new-added-layers/
---

## **新しく追加されたレイヤーを使用した挿入のカラリング方法 (CADNET-1146)**

**問題:** 新しく追加されたレイヤーを使用した挿入のカラリング方法 (CADNET-1146)。

**ヒント:** これを行うには、CadLayerTableクラスを使用して新しいレイヤーを描画に追加できるレイヤーを作成し、CadLayersListを使用して複数のレイヤーを追加することもできます。

**例:**

{{% alert color="primary" %}}

初期ファイルには名前が「1」、「2」、「3」、「4」、「5」の5つの挿入が含まれており、すべてがデフォルトの0レイヤーにあります。

{{% /alert %}}

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "coloring-of-inserts-with-new-added-layers.cs" >}}
