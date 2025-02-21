---
title: IGES 図面
type: docs
weight: 80
url: /ja/javascript-net/developer-guide/cad-and-bim-drawings/iges-drawings/
---

## **IGES 形式を PNG にエクスポートする**

Aspose.CAD for Javascript in Angular は、開発者が [IGES](https://docs.fileformat.com/cad/iges/) ファイルを [PNG](https://docs.fileformat.com/image/png/) 形式にエクスポートすることを可能にします。
[IGES](https://docs.fileformat.com/cad/iges/) から [PNG](https://docs.fileformat.com/image/png/) への変換アプローチは以下の通りです：

1. **Image.load** メソッドを使用して [IGES](https://docs.fileformat.com/cad/iges/) 図面ファイルをロードします。
1. **PngOptions** のオブジェクトを第二パラメータとして渡しながら **Image.save** を呼び出します。

## サンプルコード

以下のコードは、Aspose.CAD for JavaScript を使用して同じ目的を達成する方法を示しています。

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-IGES-to-PNG-Export.js" >}}
