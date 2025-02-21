---
title: CTBファイルのサポート
type: docs
weight: 40
url: /ja/net/developer-guide/support-ctb/
---

## **CTBファイルのサポート**

時々、色、線の太さ、その他のオプションは、図面そのもののほかに、別のCTBファイルのプロットスタイルからも使用されることがあります。
この情報を使用する最も簡単な方法は、該当するCTBファイルをDWG/DXF形式の図面ファイルの近くに置くことで、これらの情報が自動的にエクスポート中に適用されます。

すべてのCTBファイルをStreamの形式で読み込むことも可能です。これは 
[**CtbSources**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/ctbsources/) プロパティを使用して 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) オブジェクトから行えます。

これを行う方法の例は次のとおりです:
 
{{< gist aspose-com-gists d497c535082c162a22c937aeb71e55c9 "Ctb-from-stream.cs">}}
