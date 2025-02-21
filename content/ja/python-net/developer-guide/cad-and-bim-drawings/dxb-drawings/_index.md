---
title: DXB図面
type: docs
weight: 90
url: /ja/python-net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **DXB形式をPDFにエクスポートする**

Aspose.CAD for Pythonを使用すると、開発者はDXBファイルを[PDF](https://docs.fileformat.com/pdf/)形式にエクスポートできます。DXBから[PDF](https://docs.fileformat.com/pdf/)への変換アプローチは次のように機能します:

1. **Image.load**ファクトリメソッドを使用してDXB図面ファイルをロードします。
1. **CadRasterizationOptions**クラスのオブジェクトを作成し、**page_height**および**page_width**プロパティを設定します。
1. **PdfOptions**クラスのオブジェクトを作成し、**vector_rasterization_options**プロパティを設定します。
1. **Image.save**を呼び出し、2番目のパラメータとして**PdfOptions**のオブジェクトを渡します。

## サンプルコード

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXB-to-PDF-Export.py" >}}
