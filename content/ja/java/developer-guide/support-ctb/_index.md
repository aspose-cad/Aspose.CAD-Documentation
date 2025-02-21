---
title: CTBファイルのサポート
type: docs
weight: 40
url: /ja/java/developer-guide/support-ctb/
---

## **CTBファイルのサポート**

時には、図面の色、線の太さ、その他のオプションは、図面自体からだけでなく、別のCTBファイルのプロットスタイルからも使用されることがあります。
この情報を使用する最も簡単な方法は、該当するCTBファイルをDWG/DXF形式の図面ファイルの近くに置くことで、そこからの情報が
エクスポート中に自動的に適用されることです。

すべてのCTBファイルをストリームの形で読み込むことも可能で、これは
[**setCtbSources**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setCtbSources-java.util.Map-) プロパティを使用して
[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) オブジェクトの 

こちらがその実例です：
 
{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setCtbSources-example.java">}}
