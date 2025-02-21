---
title: 外部ファイルへの参照を取得する方法
type: docs
weight: 36
url: /ja/net/developer-guide/how-to/get-references-to-external-files/
---

## **外部ファイルへの参照を取得する方法**

**問題:** 外部ファイルへの参照を取得する方法 (CADNET-110)。

**ヒント:** エンティティブロック内の図面の外部ファイルへの参照を取得するには、ラスタ画像用に XRef PathName フィールドがあります。外部下書きには CadRasterImage Def が使用され、CadDgnUnderlay が使用され、その UnderlayPath フィールドがあります。

**例:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "get-references-to-external-files.cs" >}}
