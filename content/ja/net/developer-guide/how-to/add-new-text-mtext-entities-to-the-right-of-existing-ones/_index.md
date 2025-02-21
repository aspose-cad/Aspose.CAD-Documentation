---
title: 既存のテキスト/MTEXTエンティティの右に新しいテキスト/MTEXTエンティティを追加する
type: docs
weight: 17
url: /ja/net/developer-guide/how-to/add-new-text-mtext-entities-to-the-right-of-existing-ones/
---

## **既存のテキスト/MTEXTエンティティの右に新しいテキスト/MTEXTエンティティを追加する方法**

**問題:** 既存のテキスト/MTEXTエンティティの右に新しいテキスト/MTEXTエンティティを追加する方法 (CADNET-8172)。

**ヒント:** これを行うには、CadBaseEntityオブジェクトを作成し、テキストを持つCadMTextまたはCadTextを作成し、新しいオブジェクトのSoftOwnerフィールドに図面からcadImage.Layouts["Model"].BlockTableRecordHandleを追加し、cadImage.BlockEntities[" *MODEL_SPACE"]ブロックに追加し、新しいオブジェクトを図面エンティティに追加します。

**例:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "add-new-text-mtext-entities-to-the-right-of-existing-ones.cs" >}}
