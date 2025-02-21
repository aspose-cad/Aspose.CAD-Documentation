---
title: DGN AutoCADのエクスポート
type: docs
weight: 50
url: /ja/net/developer-guide/exporting-dgn-autocad/
---

## **PDFへのDGN AutoCADフォーマットのエクスポート**

Aspose.CAD for .NET APIは、DGN AutoCADファイルを読み込み、PDFフォーマットに変換する機能を提供しました。[**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage)クラスがその目的を果たします。

既存のDGNファイルを[**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage)として読み込む必要があります。[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions)クラスのインスタンスを作成し、さまざまなプロパティを設定します。[**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions)クラスのインスタンスを作成し、[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions)インスタンスを渡します。次に、[**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage)クラスのインスタンスの[**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)メソッドを呼び出します。

### サンプルコード

以下は、[DGN](https://docs.fileformat.com/cad/dgn/)を[PDF](https://docs.fileformat.com/pdf/)フォーマットに変換/エクスポートするコードのデモンストレーションです。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **DGN AutoCADフォーマットのラスタ画像フォーマットへのエクスポート**

Aspose.CAD for .NET APIは、DGN AutoCADファイルを読み込み、ラスタ画像に変換する機能を提供しました。[**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage)クラスがその目的を果たします。

既存のDGNファイルを[**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage)として読み込む必要があります。[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions)クラスのインスタンスを作成し、さまざまなプロパティを設定します。[**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions)クラスのインスタンスを作成し、[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions)インスタンスを渡します。次に、[**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage)クラスのインスタンスの[**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)メソッドを呼び出します。

### サンプルコード

以下は、[DGN](https://docs.fileformat.com/cad/dgn/)を[JPEG](https://docs.fileformat.com/image/jpeg/)画像に変換/エクスポートするコードのデモンストレーションです。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-ExportDGNToRasterImage-ExportDGNToRasterImage.cs" >}}

## **DGN v7の3Dエンティティサポート**

Aspose.CAD for .NET APIは、[DGN](https://docs.fileformat.com/cad/dgn/) AutoCADファイルを読み込み、DGN v7の3Dエンティティをサポートする機能を提供しました。[**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage)クラスがその目的を果たします。各[DGN](https://docs.fileformat.com/cad/dgn/)画像は9つの事前定義されたビューをサポートしています。これは1から9までの範囲で列挙されます。エクスポート時にビューが定義されていない場合は、マルチページ出力フォーマット（PDFなど）では、すべてのビューがエクスポートされ、それぞれが別のページに配置されます。DGNファイルフォーマットでは3Dエンティティがサポートされており、2Dもサポートされています。これには、[**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions)が使用され、TypeOfEntitiesはDGNフォーマットではもはや使用されていません（2Dと3Dは同時にサポートされています）。

### サンプルコード

以下は、サポートされているDGN要素を確認するためのサンプルコードです。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DGN-Drawings-SupportOf3DForDGNV7-3DSupportForDGNV7.cs" >}}
