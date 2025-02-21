---
title: DWGファイルの読み取り、更新、書き込み
type: docs
weight: 11
url: /ja/net/developer-guide/how-to/work-with-file/read-update-and-write-dwg-file/
---

## **DWGファイルの読み取り、更新、書き込み方法**

**問題:** DWGファイルをどのように読み取り、更新し、書き込むか。

**ヒント:** これを行うには、loadメソッドを使用してファイルを取得し、必要なエンティティを取得して、それらに変更を加えます。例えば、開始点と終了点の変更や線の太さの変更などです。

**注意:** このコードスニペットは、dwgファイルの読み取り、オブジェクトの変更（線、円、テキスト値の位置：読み取り/書き込みがサポートされる他のオブジェクトとその値にも変更を加えることができます）を示し、新しいファイルに保存する例を示しています。これにより、新しいファイルをAutoCADで開き、変更された値を持つオブジェクトを見ることができます。

**例:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-cadline-cadcircle-cadtext.cs" >}}
