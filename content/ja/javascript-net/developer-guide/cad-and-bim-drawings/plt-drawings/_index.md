---
title: PLT 図面
type: docs
weight: 90
url: /ja/javascript-net/developer-guide/cad-and-bim-drawings/plt-drawings/
---

## **PLT フォーマットを PNG にエクスポートする**

Aspose.CAD for Javascript in Angular は、開発者が [PLT](https://docs.fileformat.com/cad/plt/) ファイルを [PNG](https://docs.fileformat.com/image/png/) フォーマットにエクスポートできるようにします。
[PLT](https://docs.fileformat.com/cad/plt/) から [PNG](https://docs.fileformat.com/image/png/) への変換アプローチは次のように機能します：

1. **Image.load** メソッドを使用して [PLT](https://docs.fileformat.com/cad/plt/) 図面ファイルを読み込みます。
1. **PngOptions** のオブジェクトを 2 番目のパラメーターとして渡しながら **Image.save** を呼び出します。

## サンプルコード

以下のコードは、Aspose.CAD for JavaScript を使用して同じ目的を達成する方法を示しています。

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-PLT-to-PNG-Export.js" >}}
