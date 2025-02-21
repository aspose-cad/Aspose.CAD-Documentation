---
title: 円の面積と周囲の計算
type: docs
weight: 18
url: /ja/net/developer-guide/how-to/calculation-of-area-and-circumference-of-the-circles/
---

## **円の面積と周囲の計算方法**

**問題:** 円の面積と周囲の計算方法 (CADNET-1153)。

**ヒント:** これを行うには、エンティティから CadEntityTypeName.CIRCLE から半径を取得し、式 **"2 * Math.PI * radius"** を使用します。

**例:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "calculation-of-area-and-circumference-of-the-circles.cs" >}}
