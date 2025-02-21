---
title: 自動コードページ検出
type: docs
weight: 10
url: /ja/java/developer-guide/autocad-drawings/dwg-drawings/auto-codepage-detection/
---

## **自動コードページ検出**

Aspose.CADは、[DWG](https://docs.fileformat.com/cad/dwg/)および[DWF](https://docs.fileformat.com/cad/dwf/)ファイルの自動コードページ検出をサポートしています。この機能を使用しない場合は、[**LoadOptions**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions)クラスの次のプロパティを設定することで上書きできます。

- [**SpecifiedEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedEncoding-int-)：非Unicode DXFおよびDWG形式からテキストデータを読み取るために使用されるエンコーディングを設定します。デフォルトでは自動検出されます。
- [**SpecifiedMifEncoding**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setSpecifiedMifEncoding-int-)：CJKエンコーディングのMIFエンコードシンボルを読み取るために使用されるエンコーディングを設定します（M+nXXXX形式）。デフォルトでは自動検出されます。
- [**RecoverMalformedCifMif**](https://reference.aspose.com/cad/java/com.aspose.cad/LoadOptions#setRecoverMalformedCifMif-boolean-)：CIF（U+XXXX）およびMIFエンコードされた文字が適切なAutoCADフォーマットを持たない場合にデコードされるかどうかを定義します（AutoCADはこれらのシンボルの前にバックスラッシュを付けます）。デフォルトではデコードされます。

## サンプルコード

以下のコードサンプルは、Aspose.CADで自動コードページ検出を上書きする方法を示しています。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-OverrideAutomaticCodePageDetectionDwg-1.java" >}}
