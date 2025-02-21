---
title: ポリラインとして長方形を作成し、ハッチで塗りつぶす
type: docs
weight: 24
url: /ja/net/developer-guide/how-to/create-rectangle-as-polylines-and-fill-it-with-hatch/
---

## **ポリラインとして長方形を作成し、ハッチで塗りつぶす方法**

**問題:** ポリラインとして長方形を作成し、ハッチで塗りつぶす方法 (CADNET-1351)。

**ヒント:** これを行うには、CadLwPolylineを作成し、ポイント座標を追加します。色を扱うにはCadHatchを使用し、接続するにはCadEdgeBoundaryPathを使用します。角度を扱うにはCadHatchを使用し、パターンにはCadHatchPatternDataを使用します。

**例:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "create-rectangle-as-polylines-and-fill-it-with-hatch.cs" >}}
