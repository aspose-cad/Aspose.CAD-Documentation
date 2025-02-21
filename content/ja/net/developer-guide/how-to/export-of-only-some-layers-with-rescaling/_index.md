---
title: 一部のレイヤーのみのエクスポートとリスケーリング
type: docs
weight: 31
url: /ja/net/developer-guide/how-to/export-of-only-some-layers-with-rescaling/
---

## **一部のレイヤーのみのエクスポートとリスケーリング (CADNET-559)**

**問題:** 一部のレイヤーのみのエクスポートとリスケーリングの方法 (CADNET-559)。

**ヒント:** これを行うには、必要なレイヤーを選択し、それらを CadBaseEntity 配列に追加し、次に描画エンティティに割り当てて UpdateSize を実行します。

**例:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "export-of-only-some-layers-with-rescaling.cs" >}}
