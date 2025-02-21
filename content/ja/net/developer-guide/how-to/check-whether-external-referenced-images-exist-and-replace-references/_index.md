---
title: 外部参照画像が存在するかどうかを確認し、参照を置き換える
type: docs
weight: 22
url: /ja/net/developer-guide/how-to/check-whether-external-referenced-images-exist-and-replace-references/
---

## **オブジェクトのハイパーリンクを編集する方法**

**課題:** 外部参照画像が存在するかどうかを確認し、参照を置き換える方法 (CADNET-8088)。

**ヒント:** これを行うには、図面エンティティから CadObjectTypeName.IMAGEDEF のエンティティを取得し、CadRasterImageDef を使用して確認します。

**例:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "check-whether-external-referenced-images-exist-and-replace-references.cs" >}}
