---
title: STL図面
type: docs
weight: 100
url: /ja/javascript-net/developer-guide/cad-and-bim-drawings/stl-drawings/
---

## **STL形式をPNGにエクスポートする**

Aspose.CAD for Javascript in Angularは、開発者が[STL](https://docs.fileformat.com/cad/stl/)ファイルを[PNG](https://docs.fileformat.com/image/png/)形式にエクスポートすることを可能にします。
[STL](https://docs.fileformat.com/cad/stl/)から[PNG](https://docs.fileformat.com/image/png/)への変換アプローチは以下のように機能します：

1. **Image.load**メソッドを使用して[STL](https://docs.fileformat.com/cad/stl/)図面ファイルをロードします。
2. **PngOptions**のオブジェクトを2番目のパラメータとして渡して**Image.save**を呼び出します。

## サンプルコード

以下のコードは、Aspose.CAD for JavaScriptを使用して同じ目標を達成する方法を示しています。

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-STL-to-PNG-Export.js" >}}
