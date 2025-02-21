---
title: SVG図面
type: docs
weight: 70
url: /ja/javascript-net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **SVG形式をPNGにエクスポートする**

Aspose.CAD for Javascript in Angularは、開発者が[SVG](https://docs.fileformat.com/page-description-language/svg/)ファイルを[PNG](https://docs.fileformat.com/image/png/)形式にエクスポートすることを可能にします。
[SVG](https://docs.fileformat.com/page-description-language/svg/)から[PNG](https://docs.fileformat.com/image/png/)への変換アプローチは以下のように機能します：

1. **Image.load**メソッドを使用して[SVG](https://docs.fileformat.com/page-description-language/svg/)図面ファイルをロードします。
1. **Image.save**を呼び出し、第二引数として**PngOptions**のオブジェクトを渡します。

## サンプルコード

以下のコードは、Aspose.CAD for JavaScriptを使用して同じ目標を達成する方法を示しています。

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-SVG-to-PNG-Export.js" >}}
