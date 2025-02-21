---
title: FBX 図面
type: docs
weight: 110
url: /ja/python-net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **FBX フォーマットを PDF にエクスポートする**

Aspose.CAD for Python を使用すると、開発者は [FBX](https://docs.fileformat.com/3d/fbx/) ファイルを [PDF](https://docs.fileformat.com/pdf/) フォーマットにエクスポートできます。[FBX](https://docs.fileformat.com/3d/fbx/) から [PDF](https://docs.fileformat.com/pdf/) への変換アプローチは次のように機能します：

1. **Image.load** ファクトリメソッドを使用して [FBX](https://docs.fileformat.com/3d/fbx/) 図面ファイルを読み込みます。
1. **CadRasterizationOptions** クラスのオブジェクトを作成し、**PageHeight** および **PageWidth** プロパティを設定します。
1. **PdfOptions** クラスのオブジェクトを作成し、**vector_rasterization_options** プロパティを設定します。
1. **Image.save** を呼び出し、第二パラメータとして **PdfOptions** のオブジェクトを渡します。

## サンプルコード

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-FBX-to-PDF-Export.py" >}}
