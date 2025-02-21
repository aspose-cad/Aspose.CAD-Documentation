---
title: DRC 図面
type: docs
weight: 15
url: /ja/net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **DRC 図面を PDF にエクスポートする**

Aspose.CAD は、AutoCAD [DRC](https://docs.fileformat.com/3d/drc/) 図面エンティティをロードし、全体の図面を [PDF](https://docs.fileformat.com/pdf/) 形式でレンダリングする機能を提供します。 [DRC](https://docs.fileformat.com/3d/drc/) から [PDF](https://docs.fileformat.com/pdf/) への変換アプローチは次のように機能します。

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) ファクトリメソッドを使用して [DRC](https://docs.fileformat.com/3d/drc/) 図面ファイルをロードします。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) クラスのオブジェクトを作成し、[**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) と [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) プロパティを設定します。
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) クラスのオブジェクトを作成し、[**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) プロパティを設定します。
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) を呼び出し、[**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) のオブジェクトを第二引数として渡します。

### サンプルコード

以下のコードサンプルは、デフォルト設定を使用してファイルを変換する方法を示しています。


{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DRC-to-PDF-Export.cs" >}}
