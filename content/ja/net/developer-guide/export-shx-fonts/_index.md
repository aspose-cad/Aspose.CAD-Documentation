---
title: SHXフォントのエクスポート
type: docs
weight: 40
url: /ja/net/developer-guide/export-shx-fonts/
---

## **DXF/DWG図面用のSHXフォントのエクスポート**

一部の図面には、フォントのシンボルを形状の形式で保存する特殊なSHX形式のフォントが含まれています。この形式は、図面で使用される各フォントに対して追加の読み込み手順が必要です。Apose.CADは、SHXで書かれたテキストを含む図面をエクスポートでき、これを行うためのさまざまなオプションがあります。最も簡単な方法は、 
[**ShxFonts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/shxfonts/)プロパティを 
[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/)オブジェクトで使用することです。

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts example.cs">}}

複数のSHXフォントへのすべてのパスを設定しなくても、次の例で回避できます：

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxFonts with folder example.cs">}}

各SHXフォントには、それに関連付けられた適切なコードページが付属しています。これらの関連付けは既知のSHXフォントに対して知られており、部分的にAspose.CADに組み込まれています。
カスタムSHXフォントが使用される場合は、ShxCodePagesプロパティを適用し、SHXファイルへのパスと対応するコードページを設定できます。

{{< gist aspose-com-gists 75cbae64b15374bfb0abc00279942af8 "ShxCodePages example.cs">}}
