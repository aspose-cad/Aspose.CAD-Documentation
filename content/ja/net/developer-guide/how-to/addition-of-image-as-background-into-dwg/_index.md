---
title: DWGに画像を背景として追加する方法
type: docs
weight: 15
url: /ja/net/developer-guide/how-to/addition-of-image-as-background-into-dwg/
---

## **DWGに画像を背景として追加する方法**

**問題:** DWGに画像を背景として追加する方法。

**ヒント:** これを行うには、背景画像のためにCadRasterImageDefオブジェクトを作成し、描画用に背景を挿入するためにCadRasterImageオブジェクトを作成し、描画オブジェクトにCadRasterImageオブジェクトを追加し、CadBaseObject CadBaseObjectを作成してcadImage.Objectsに追加し、すべてをCadBlockTableObjectを介して処理します。

**例:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "addition-of-image-as-background-into-dwg.cs" >}}
