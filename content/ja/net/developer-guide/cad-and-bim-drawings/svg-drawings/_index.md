---
title: SVG 図形
type: docs
weight: 70
url: /ja/net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **SVG形式をPDFにエクスポートする**

Aspose.CAD for .NETは、開発者がSVGファイルを[PDF](https://docs.fileformat.com/pdf/)形式にエクスポートすることを可能にします。SVGから[PDF](https://docs.fileformat.com/pdf/)への変換アプローチは以下のように動作します：

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2)ファクトリメソッドを使用してSVG図面ファイルを読み込みます。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions)クラスのオブジェクトを作成し、[**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight)および[**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth)プロパティを設定します。
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions)クラスのオブジェクトを作成し、[**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions)プロパティを設定します。
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)を呼び出し、[**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions)のオブジェクトを第二引数として渡します。

## サンプルコード

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-SVG-to-PDF-Export.cs" >}}
