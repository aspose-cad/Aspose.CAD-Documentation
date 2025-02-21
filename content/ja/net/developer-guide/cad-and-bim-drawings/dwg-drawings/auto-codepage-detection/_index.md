---
title: 自動コードページ検出
type: docs
weight: 10
url: /ja/net/developer-guide/cad-and-bim-drawings/dwg-drawings/auto-codepage-detection/
---

## **自動コードページ検出**

Aspose.CADは、[DWG](https://docs.fileformat.com/cad/dwg/)および[DWF](https://docs.fileformat.com/cad/dwf/)ファイルの自動コードページ検出をサポートしています。この機能を使用したくない場合は、[**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions)クラスの以下のプロパティを設定することで上書きできます。

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedencoding): 非Unicode DXFおよびDWGフォーマットからテキストデータを読み取るために使用されるエンコーディングを設定します。デフォルトでは自動検出されます。
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/specifiedmifencoding): CJKエンコーディングのMIFエンコードされたシンボルを読み取るために使用されるエンコーディングを設定します（M+nXXXXフォーマット）。デフォルトでは自動検出されます。
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/properties/recovermalformedcifmif): CIF（U+XXXX）およびMIFエンコードされた文字が正しいAutoCADフォーマットを持たない場合、それらがデコードされるかどうかを定義します（AutoCADはこれらのシンボルの前にバックスラッシュを付けます）。デフォルトでは、これらはデコードされます。

## サンプルコード

以下のコードサンプルは、Aspose.CADで自動コードページ検出を上書きする方法を示しています。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-OverrideAutomaticCodepageDetectionDwg-1.cs" >}}
