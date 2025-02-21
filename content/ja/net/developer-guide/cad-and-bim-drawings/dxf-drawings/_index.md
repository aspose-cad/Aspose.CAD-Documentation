---
title: DXF図面
type: docs
weight: 60
url: /ja/net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **PDFへのDXF図面のエクスポート**

Aspose.CADは、AutoCAD DXF図面エンティティをロードし、それらをPDF形式で全体の図面としてレンダリングする機能を提供します。DXFからPDFへの変換手法は次のように機能します。

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) ファクトリーメソッドを使用してDXF図面ファイルをロードします。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) クラスのオブジェクトを作成し、[**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) と [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) プロパティを設定します。
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) クラスのオブジェクトを作成し、[**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) プロパティを設定します。
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) を呼び出し、[**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) のオブジェクトを2番目のパラメーターとして渡します。

以下のコードサンプルは、デフォルト設定を使用してファイルを変換する方法を示しています。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFToPDF-ExportDXFToPDF.cs" >}}

### **対応フォーマット**

現在、私たちはAutoCAD DXF 2010ファイルフォーマットを完全にサポートしています。以前のDXFバージョンは100%有効であることは保証されません。将来的なAspose.CADバージョンにおいて、さらに多くのフォーマットと機能を含める予定です。

### **サポートされているエンティティ**

現在、私たちはすべての一般的な2Dエンティティとその基本的なデフォルトパラメーターをサポートしています：

1. アライン寸法
1. 角度寸法
1. アーク
1. 属性
1. ブロック参照
1. 円
1. 直径寸法
1. 楕円
1. ハッチ
1. 線
1. マルチラインテキスト
1. 座標寸法
1. 点
1. ポリライン
1. 放射寸法
1. 光線
1. 回転寸法
1. テーブル
1. テキスト
1. X線

{{% alert color="primary" %}}

パース中にサポートしていないエンティティまたはプロパティに遭遇した場合、そのエンティティまたはプロパティは静かに無視されます。

{{% /alert %}}

### **メモリ管理**

[**Cache**](https://reference.aspose.com/cad/net/aspose.cad/cache) クラスのプロパティ [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) は、メモリの再割り当てを制御するために使用できます。再割り当ては、事前に割り当てられたキャッシュに対して最も頻繁に発生します。システムが割り当てられたスペースが不十分であることを確認すると発生する可能性があります。

- [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) がデフォルト値である **False** に設定されている場合、スペースは同じ媒体に再割り当てされます。
- **True** に設定されている場合、再割り当ては指定された最大スペースを超えることができません。この場合、既存のメモリ内キャッシュは解放され、拡張されたスペースがディスクに割り当てられます。 

## **特定のDXF図面のレイヤーをPDFにエクスポート**

この手法は次のように機能します：

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) ファクトリーメソッドを使用してDXF図面ファイルを開きます。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) のインスタンスを作成し、[**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) と [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) プロパティを指定します。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) のオブジェクトにレイヤーを追加します。
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) のインスタンスを作成し、その [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) プロパティを設定します。
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) メソッドを呼び出し、[**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) のオブジェクトを2番目のパラメーターとして渡します。

以下のコードサンプルは、DXFの特定のレイヤーをPDFに変換する方法を示しています。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayerToPDF-ExportDXFSpecificLayerToPDF.cs" >}}

## **DXF図面の一部としてPDFファイルをレンダリング**

この手法は次のように機能します：

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) ファクトリーメソッドを使用してDXF図面ファイルをロードします。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) クラスのオブジェクトを作成し、PDFファイルをロードします。
1. [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) と [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) プロパティを設定します。
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) を呼び出してファイルを保存します。

以下のコードサンプルは、DXF図面の一部としてPDFファイルをレンダリングする方法を示しています。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

## **DXF形式の埋め込みDGNアンダーレイをエクスポート**

Aspose.CADは、AutoCAD DXFファイルをロードし、DXF形式の埋め込みDGNアンダーレイをエクスポートする機能を提供します。

以下のコードサンプルは、指定された要件を達成する方法を示しています。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **DXFファイルの保存サポート**

Aspose.CADは、AutoCAD DXFファイルをロードし、変更を加えて再度DXFファイルとして保存する機能を提供します。

以下のコードサンプルは、指定された要件を達成する方法を示しています。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-SaveDXFFiles-SaveDXFFiles.cs" >}}

## **DXFからWMFへのエクスポート**

この手法は次のように機能します：

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) ファクトリーメソッドを使用してDXF図面ファイルをロードします。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) クラスのオブジェクトを作成し、PDFファイルをロードします。
1. [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) と [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) プロパティを設定します。
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) を呼び出してファイルを保存します。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportDXFToWMF-ExportDXFToWMF.cs" >}}

## **特定のDXFレイアウトをPDFにエクスポート**

この手法は次のように機能します：

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) ファクトリーメソッドを使用してDXF図面ファイルを開きます。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) のインスタンスを作成し、[**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) と [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) プロパティを指定します。
1. [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) プロパティを使用して、希望するレイアウト名を指定します。
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) のインスタンスを作成し、その [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) プロパティを設定します。
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) メソッドを呼び出して描画をPDFにエクスポートし、[**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) のオブジェクトを2番目のパラメーターとして渡します。

以下のコードサンプルは、DXFの特定のレイアウトをPDFに変換する方法を示しています。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

{{% alert color="primary" %}}

プロパティ [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) は文字列配列のため、一度に複数のレイアウトを指定してPDFフォーマットへの変換を行うことができます。 [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) プロパティに複数のレイアウトを指定する場合、生成されるPDFは複数ページとなり、各ページは個々のAutoCADレイアウトを表します。

{{% /alert %}}

## **ブロッククリッピングのサポート**

Aspose.CADは、ブロッククリッピング機能を提供します。ブロッククリッピング手法は次のように機能します：

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) ファクトリーメソッドを使用してDXF図面ファイルをロードします。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) クラスのオブジェクトを作成し、PDFファイルをロードします。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) の希望するプロパティを設定します。
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) を呼び出し、[**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions)のオブジェクトを第二引数として渡し、ファイルを保存します。

以下のコードサンプルは、ブロッククリッピングがどのように機能するかを示しています。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DXF-Drawings-SupportOfBlockClipping-SupportOfBlockClipping.cs" >}}

## **DXFに画像をエクスポート**

Aspose.CADを使用すると、画像をDXF形式にエクスポートできます。この手法を使用して、次のアクションを実行できます：

1. 新しいフォントを設定
1. エンティティを非表示にする
1. テキストを更新

以下のコードスニペットは、上記のアクションを実行する方法を示しています。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportImagesToDXF-ExportImagesToDXF.cs" >}}

## **DXF図面の特定のレイヤーを画像にエクスポート**

この手法は次のように機能します：

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) ファクトリーメソッドを使用してDXF図面ファイルを開きます。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) のインスタンスを作成し、[**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) および [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) プロパティを指定します。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) のオブジェクトにレイヤーを追加します。
1. [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) のインスタンスを作成し、その [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) プロパティを設定します。
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) メソッドを使用して描画をPDFにエクスポートします。

以下のコードサンプルは、DXFの特定のレイヤーを画像に変換する方法を示しています。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.cs" >}}
