---
title: DGN図面
type: docs
weight: 10
url: /ja/javascript-net/developer-guide/cad-and-bim-drawings/dgn-drawing/
---

## **DGNフォーマットをPNGにエクスポートする**

Aspose.CAD for Javascript in Angularは、開発者が[DGN](https://docs.fileformat.com/cad/dgn/)ファイルを[PNG](https://docs.fileformat.com/image/png/)フォーマットにエクスポートすることを可能にします。
[DGN](https://docs.fileformat.com/cad/dgn/)から[PNG](https://docs.fileformat.com/image/png/)への変換方法は次のように機能します：

1. **Image.load**メソッドを使用して[DGN](https://docs.fileformat.com/cad/dgn/)図面ファイルを読み込みます。
1. **PngOptions**のオブジェクトを第二引数として渡しながら**Image.save**を呼び出します。

## サンプルコード

以下のコードは、Aspose.CAD for JavaScriptを使用して同じ目標を達成する方法を示しています。

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-DGN-to-PNG-Export.js" >}}
