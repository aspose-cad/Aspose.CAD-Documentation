---
title: DWFx 図面
type: docs
weight: 30
url: /ja/javascript-net/developer-guide/cad-and-bim-drawings/dwfx-drawing/
---

## **DWFX 形式を PNG にエクスポートする**

Aspose.CAD for Javascript in Angular は、開発者が [DWFX](https://docs.fileformat.com/cad/dwfx/) ファイルを [PNG](https://docs.fileformat.com/image/png/) 形式にエクスポートできるようにします。
[DWFX](https://docs.fileformat.com/cad/dwfx/) から [PNG](https://docs.fileformat.com/image/png/) への変換アプローチは以下のように機能します：

1. **Image.load** メソッドを使用して [DWFX](https://docs.fileformat.com/cad/dwfx/) 図面ファイルを読み込みます。
1. **PngOptions** のオブジェクトを第2パラメータとして渡しながら、**Image.save** を呼び出します。

## サンプルコード

以下のコードは、Aspose.CAD for JavaScript を使用して同じ目標を達成する方法を示しています。

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-DWFX-to-PNG-Export.js" >}}
