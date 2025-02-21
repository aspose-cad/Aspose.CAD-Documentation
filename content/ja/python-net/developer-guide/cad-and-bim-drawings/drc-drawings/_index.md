---
title: DRC の図面
type: docs
weight: 40
url: /ja/python-net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **DRC 形式を PDF にエクスポートする**

Aspose.CAD for Python は、開発者が [DRC](https://docs.fileformat.com/3d/drc/) ファイルを [PDF](https://docs.fileformat.com/pdf/) 形式にエクスポートすることを可能にします。 [DRC](https://docs.fileformat.com/3d/drc/) から [PDF](https://docs.fileformat.com/pdf/) への変換アプローチは次のように機能します：

1. **Image.load** ファクトリメソッドを使用して DRC 図面ファイルを読み込みます。
1. **CadRasterizationOptions** クラスのオブジェクトを作成し、**page_height** と **page_width** プロパティを設定します。
1. **PdfOptions** クラスのオブジェクトを作成し、**VectorRasterizationOptions** プロパティを設定します。
1. **Image.save** を呼び出し、二番目のパラメータとして **PdfOptions** のオブジェクトを渡します。

## サンプルコード


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "convert-drc-to-pdf.py" >}}
