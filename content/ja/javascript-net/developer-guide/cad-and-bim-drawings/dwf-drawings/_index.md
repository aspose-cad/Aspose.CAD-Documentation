---
title: DWF 図面
type: docs
weight: 20
url: /ja/javascript-net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **DWF形式をPNGにエクスポートする**

Aspose.CAD for Javascript in Angularは、開発者が[DWF](https://docs.fileformat.com/cad/dwf/)ファイルを[PNG](https://docs.fileformat.com/image/png/)形式にエクスポートできるようにします。
[DWF](https://docs.fileformat.com/cad/dwf/)から[PNG](https://docs.fileformat.com/image/png/)への変換アプローチは次のように機能します：

1. **Image.load**メソッドを使用して[DWF](https://docs.fileformat.com/cad/dwf/)図面ファイルをロードします。
1. 2番目のパラメーターとして**PngOptions**のオブジェクトを渡しながら**Image.save**を呼び出します。

## サンプルコード

以下のコードは、Aspose.CAD for JavaScriptを使用して同じ目的を達成する方法を示しています。

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-DWF-to-PNG-Export.js" >}}
