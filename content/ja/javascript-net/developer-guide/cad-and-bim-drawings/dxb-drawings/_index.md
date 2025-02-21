---
title: DXB 図面
type: docs
weight: 70
url: /ja/javascript-net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **DXB 形式を PNG にエクスポートする**

Aspose.CAD for Javascript in Angular は、開発者が DXB ファイルを [PNG](https://docs.fileformat.com/image/png/) 形式にエクスポートできるようにします。
DXB から [PNG](https://docs.fileformat.com/image/png/) への変換アプローチは以下のように機能します：

1. **Image.load** メソッドを使用して DXB 図面ファイルをロードします。
1. **PngOptions** のオブジェクトを第二パラメータとして渡しながら **Image.save** を呼び出します。

## サンプルコード

以下のコードは、Aspose.CAD for JavaScript を使用して同じ目標を達成する方法を示しています。

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-DXB-to-PNG-Export.js" >}}
