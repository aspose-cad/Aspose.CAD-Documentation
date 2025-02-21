---
title: DXB 図面
type: docs
weight: 70
url: /ja/net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **DXB 形式を PDF にエクスポートする**

Aspose.CAD for .NET を使用すると、開発者は DXB ファイルを [PDF](https://docs.fileformat.com/pdf/) 形式にエクスポートできます。DXB から [PDF](https://docs.fileformat.com/pdf/) への変換手順は以下の通りです。

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) ファクトリメソッドを使用して DXB 図面ファイルを読み込みます。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) クラスのオブジェクトを作成し、[**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) および [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) プロパティを設定します。
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) クラスのオブジェクトを作成し、[**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) プロパティを設定します。
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) を呼び出し、2番目のパラメータとして [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) のオブジェクトを渡します。

## サンプルコード

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DXB-to-PDF-Export.cs" >}}
