---
title: ヒンジレイヤーと名前付きレイヤーをエクスポートしない方法
type: docs
weight: 26
url: /ja/net/developer-guide/how-to/do-not-export-hidden-layer-and-layers-by-name/
---

## **ヒンジレイヤーと名前付きレイヤーをエクスポートしない方法**

**問題:** ヒンジレイヤーと名前付きレイヤーをエクスポートしない方法。

**ヒント:** これを行うには、"LayerToHide"という名前でないレイヤーの配列を作成し、それをrasterizationOptions.Layersに追加する必要があります。

**例:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "do-not-export-hidden-layer-and-layers-by-name.cs" >}}
