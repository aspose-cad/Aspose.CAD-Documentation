---
title: COLLADA 図面
type: docs
weight: 20
url: /ja/python-net/developer-guide/cad-and-bim-drawings/collada-drawings/
---

## **COLLADA形式をPDFにエクスポートする**

Aspose.CAD for Pythonは、開発者が[COLLADA](https://docs.fileformat.com/3d/dae/)ファイルを[PDF](https://docs.fileformat.com/pdf/)形式にエクスポートできるようにします。[COLLADA](https://docs.fileformat.com/3d/dae/)から[PDF](https://docs.fileformat.com/pdf/)への変換アプローチは以下のように機能します。

1. **Image.load**ファクトリメソッドを使用して[COLLADA](https://docs.fileformat.com/3d/dae/)図面ファイルを読み込みます。
1. **CadRasterizationOptions**クラスのオブジェクトを作成し、**page_height**と**page_width**プロパティを設定します。
1. **PdfOptions**クラスのオブジェクトを作成し、**vector_rasterization_options**プロパティを設定します。
1. **Image.save**を呼び出し、**PdfOptions**のオブジェクトを第二パラメータとして渡します。

## サンプルコード

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-COLLADA-to-PDF-Export.py" >}}
