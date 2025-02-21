---
title: STP図面
type: docs
weight: 70
url: /ja/net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **STP形式をPDFにエクスポートする**

Aspose.CAD for .NETは、開発者が[STP](https://docs.fileformat.com/3d/stp/)ファイルを[PDF](https://docs.fileformat.com/pdf/)形式にエクスポートすることを可能にします。[STP](https://docs.fileformat.com/3d/stp/)から[PDF](https://docs.fileformat.com/pdf/)への変換アプローチは次のように機能します：

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2)ファクトリーメソッドを使用して[STP](https://docs.fileformat.com/3d/stp/)図面ファイルをロードします。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions)クラスのオブジェクトを作成し、[**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight)および[**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth)プロパティを設定します。
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions)クラスのオブジェクトを作成し、[**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions)プロパティを設定します。
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)を呼び出し、第二パラメータとして[**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions)のオブジェクトを渡します。

## サンプルコード

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-STP-to-PDF-Export.cs" >}}
