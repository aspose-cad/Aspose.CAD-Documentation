---
title: DXF へのエクスポート
type: docs
weight: 20
url: /ja/net/developer-guide/how-to/export-file/export-to-dxf/
---

## **DXF へのエクスポート方法**

**問題:** DXF へのエクスポート方法。

**ヒント:** このために、ファイル保存オプションで DxfOption（二進数および通常の両方）を使用できます。

**注意:** 興味深い特徴の1つは、サポートされている任意のファイル形式を dxf に保存できる能力です。
これは実際に良い機能であり、いくつかのニュアンスもあります：
DXF/DWG ファイル形式からの保存 - ソース形式が持つ正確なエンティティでエクスポートを実行します
他の形式からのエクスポート - 線とテキストエンティティのみを使用してエクスポートを実行します。
また、ASCII およびバイナリ DXF ファイル形式をサポートしています。

**例:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "export-to-dxf.cs" >}}
