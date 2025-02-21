---
title: ポリラインの幅を変更する 
type: docs
weight: 20
url: /ja/net/developer-guide/how-to/change-width-of-the-polyline/
---

## **ポリラインの幅の変更方法**

**問題:** ポリラインの幅を変更する方法 (CADNET-459-460)。

**ヒント:** CadBaseEntityの幅を変更するには（タイプがCadEntityTypeName.LWPOLYLINEの場合）、(entity as CadLwPolyline).ConstantWidth = 2 または通常のエンティティの場合はLineWeightを使用します。

**例:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-width-of-the-polyline.cs" >}}
