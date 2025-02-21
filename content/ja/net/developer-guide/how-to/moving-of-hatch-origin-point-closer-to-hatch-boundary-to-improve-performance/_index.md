---
title: ハッチの原点をハッチ境界に近づけてパフォーマンスを向上させる方法
type: docs
weight: 41
url: /ja/net/developer-guide/how-to/moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance/
---

## **ハッチの原点をハッチ境界に近づけてパフォーマンスを向上させる方法**

**問題:** ハッチの原点をハッチ境界に近づけてパフォーマンスを向上させる方法 (CADNET-1340)。

**ヒント:** これを行うには、図面からCadHatchエンティティを取得し、Point2Dで必要なポイントを設定し、距離を計算し、CadHatchPatternDataのXおよびYにLineBasePointを設定します。

**例:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "moving-of-hatch-origin-point-closer-to-hatch-boundary-to-improve-performance.cs" >}}
