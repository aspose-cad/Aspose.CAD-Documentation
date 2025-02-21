---
title: 自動コードページ検出
type: docs
weight: 10
url: /ja/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **自動コードページ検出**

Aspose.CADは [DWG](https://docs.fileformat.com/cad/dwg/) および [DWF](https://docs.fileformat.com/cad/dwf/) ファイルの自動コードページ検出をサポートしています。この機能を使用したくない場合は、**LoadOptions**クラスの次のプロパティを設定することで上書きできます。

- **specified_encoding**: 非UnicodeのDXFおよびDWG形式からテキストデータを読み取るために使用されるエンコーディングを設定します。デフォルトでは自動検出です。
- **specified_mif_encoding**: CJKエンコーディングのMIFエンコードされたシンボル（M+nXXXX形式）を読み取るために使用されるエンコーディングを設定します。デフォルトでは自動検出です。
- **recover_malformed_cif_mif**: CIF (U+XXXX)およびMIFエンコードされた文字が適切なAutoCADフォーマットを持たない場合にデコードされるかどうかを定義します（AutoCADはこれらのシンボルの前にバックスラッシュを付けます）。デフォルトでは、デコードされます。

## サンプルコード

以下のコードサンプルは、Aspose.CADにおける自動コードページ検出の上書き方法を示しています。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-OverrideAutomaticCodepageDetectionDwg.py" >}}
