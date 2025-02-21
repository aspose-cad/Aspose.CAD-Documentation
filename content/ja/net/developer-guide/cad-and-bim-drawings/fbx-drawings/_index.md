---
title: FBX図面
type: docs
weight: 70
url: /ja/net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **FBX形式をPDFにエクスポートする**

Aspose.CAD for .NET は、開発者が [FBX](https://docs.fileformat.com/3d/fbx/) ファイルを [PDF](https://docs.fileformat.com/pdf/) 形式にエクスポートできるようにします。 [FBX](https://docs.fileformat.com/3d/fbx/) から [PDF](https://docs.fileformat.com/pdf/) への変換手法は次のように機能します。

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) ファクトリメソッドを使用して、[FBX](https://docs.fileformat.com/3d/fbx/) 図面ファイルを読み込みます。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) クラスのオブジェクトを作成し、[**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) と [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) プロパティを設定します。
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) クラスのオブジェクトを作成し、[**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) プロパティを設定します。
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) を呼び出し、二番目のパラメーターとして [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) のオブジェクトを渡します。

## サンプルコード

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-FBX-to-PDF-Export.cs" >}}
