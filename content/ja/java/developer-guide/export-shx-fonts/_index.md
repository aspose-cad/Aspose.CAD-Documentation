---
title: SHXフォントのエクスポート
type: docs
weight: 40
url: /ja/java/developer-guide/export-shx-fonts/
---

## **DXF/DWG図面のSHXフォントをエクスポートする**

一部の図面には、フォントのシンボルを形状の形で保存する特殊なSHXフォーマットのフォントが含まれている場合があります。
このフォーマットでは、図面で使用される各フォントに対して追加の読み込み手続きが必要です。
Apose.CADは、SHXで書かれたテキストを含む図面をエクスポートでき、これを行うためのさまざまなオプションがあります。
最も簡単な方法は、[**setShxFonts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setShxFonts-java.lang.String:A-)プロパティを使用することです。これは[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions)オブジェクトのものです。 

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxFonts-example.java">}}

各SHXフォントには、それに関連付けられた適切なコードページが付属しています。これらの関連付けは既知のSHXフォント用に知られており、一部はAspose.CADに埋め込まれています。
カスタムSHXフォントが使用される場合には、**setShxCodePages**プロパティを適用し、SHXファイルへのパスおよび対応するコードページを設定することが可能です。

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxCodePages-example.java">}}
