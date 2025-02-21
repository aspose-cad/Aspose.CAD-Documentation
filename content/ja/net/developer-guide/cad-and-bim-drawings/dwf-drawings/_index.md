---
title: DWF図面
type: docs
weight: 20
url: /ja/net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **DWF図面をPDFにエクスポートする**

Aspose.CADは、AutoCADの[DWF](https://docs.fileformat.com/cad/dwf/)図面エンティティを読み込み、全体の図面を[PDF](https://docs.fileformat.com/pdf/)形式としてレンダリングする機能を提供します。[DWF](https://docs.fileformat.com/cad/dwf/)から[PDF](https://docs.fileformat.com/pdf/)への変換アプローチは以下のように機能します：

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2)ファクトリメソッドを使用して[DWF](https://docs.fileformat.com/cad/dwf/)図面ファイルを読み込みます。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions)クラスのオブジェクトを作成し、[**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight)と[**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth)プロパティを設定します。
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions)クラスのオブジェクトを作成し、[**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions)プロパティを設定します。
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)を呼び出し、[**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions)のオブジェクトを第二引数として渡します。

### サンプルコード

以下のコードサンプルは、デフォルト設定を使用してファイルを変換する方法を示しています。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **DWF図面からレイヤーを抽出する**

Aspose.CADは、AutoCADの[DWF](https://docs.fileformat.com/cad/dwf/)図面エンティティを読み込み、全体の図面を[JPEG](https://docs.fileformat.com/image/jpeg/)形式としてレンダリングする機能を提供します。

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2)ファクトリメソッドを使用して[DWF](https://docs.fileformat.com/cad/dwf/)図面ファイルを読み込みます。
1. [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions)クラスのオブジェクトを作成します。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions)クラスのオブジェクトを作成します。
1. [JPEG](https://docs.fileformat.com/image/jpeg/)オブジェクトを使用してレイヤー名を抽出します。
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)を呼び出し、[**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions)のオブジェクトを第二引数として渡します。

### サンプルコード

以下のコードサンプルは、デフォルト設定を使用してファイルを変換する方法を示しています。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **DWFのレイヤーのサポート**

Aspose.CADは、AutoCADの[DWF](https://docs.fileformat.com/cad/dwf/)図面エンティティを読み込み、全体の図面を[JPEG](https://docs.fileformat.com/image/jpeg/)形式としてレンダリングする機能を提供します。

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2)ファクトリメソッドを使用して[DWF](https://docs.fileformat.com/cad/dwf/)図面ファイルを読み込みます。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions)クラスのオブジェクトを作成します。
1. 必要なレイヤーを追加します。
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)を呼び出し、[**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions)のオブジェクトを第二引数として渡します。

### サンプルコード

以下のコードサンプルは、デフォルト設定を使用してファイルを変換する方法を示しています。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWF-Drawings-SupportOfLayers-SupportOfLayers.cs" >}}

## **DWF図面をBMPにエクスポートする**

Aspose.CADは、AutoCADの[DWF](https://docs.fileformat.com/cad/dwf/)図面エンティティを読み込み、全体の図面を[BMP](https://docs.fileformat.com/image/bmp/)形式としてレンダリングする機能を提供します。[DWF](https://docs.fileformat.com/cad/dwf/)から[BMP](https://docs.fileformat.com/image/bmp/)への変換アプローチは以下のように機能します：

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2)ファクトリメソッドを使用して[DWF](https://docs.fileformat.com/cad/dwf/)図面ファイルを読み込みます。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions)クラスのオブジェクトを作成し、[**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight)と[**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth)プロパティを設定します。
1. [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions)クラスのオブジェクトを作成し、[**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions)プロパティを設定します。
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)を呼び出し、[**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions)のオブジェクトを第二引数として渡します。

### サンプルコード

以下のコードサンプルは、デフォルト設定を使用して[DWF](https://docs.fileformat.com/cad/dwf/)ファイルを[BMP](https://docs.fileformat.com/image/bmp/)に変換する方法を示しています。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}
