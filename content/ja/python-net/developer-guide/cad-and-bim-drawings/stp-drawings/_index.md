---
title: STP 図面
type: docs
weight: 160
url: /ja/python-net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **STP形式のPDFへのエクスポート**

Aspose.CAD for Pythonは、開発者が[STP](https://docs.fileformat.com/3d/stp/)ファイルを[PDF](https://docs.fileformat.com/pdf/)形式にエクスポートできるようにします。[STP](https://docs.fileformat.com/3d/stp/)から[PDF](https://docs.fileformat.com/pdf/)への変換手法は次のように機能します。

1. **Image.load**ファクトリーメソッドを使用して、[STP](https://docs.fileformat.com/3d/stp/)図面ファイルを読み込みます。
1. **CadRasterizationOptions**クラスのオブジェクトを作成し、**page_height**および**page_width**プロパティを設定します。
1. **PdfOptions**クラスのオブジェクトを作成し、**vector_rasterization_options**プロパティを設定します。
1. **Image.save**を呼び出し、**PdfOptions**のオブジェクトを第二のパラメータとして渡します。

## サンプルコード

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-STP-to-PDF-Export.py" >}}
