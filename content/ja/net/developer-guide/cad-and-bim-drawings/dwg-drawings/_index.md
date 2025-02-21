---
title: DWG 図面
type: docs
weight: 40
url: /ja/net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **DWG 図面を PDF にエクスポートする**

Aspose.CAD for .NET API は、AutoCAD 図面の [DWG](https://docs.fileformat.com/cad/dwg/) 形式を読み込んで [PDF](https://docs.fileformat.com/pdf/) に変換できます。このトピックでは、DWG を PDF 形式に変換するための Aspose.CAD API の使い方を、以下に定義された簡単なステップを通じて説明します。

{{% alert color="primary" %}}

API は以下の AutoCAD DWG リビジョンをサポートしています：

- DWG 2004 バージョン 16.0 リリース 18
- DWG 2005 バージョン 16.1
- DWG 2010 バージョン 18.0
- DWG 2013 バージョン 19.0

{{% /alert %}}

### **DWG ファイル形式**

[DWG](https://docs.fileformat.com/cad/dwg/) は、ベクター画像データとメタデータを含むバイナリファイルです。ベクター画像データは、DWG を表示するための指示を CAD アプリケーションに提供し、メタデータはファイルに関するさまざまな情報（位置に特有のデータやクライアントデータを含む）を含む場合があります。DWG ファイル形式のオープンスペックは、[この PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf) で見つけることができます。

### **DWG ファイルを PDF に変換する**

[DWG](https://docs.fileformat.com/cad/dwg/) を [PDF](https://docs.fileformat.com/pdf/) に変換するには、以下の簡単なステップが必要です。

1. [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image) のインスタンスに DWG ファイルを読み込みます。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) クラスのオブジェクトを作成し、[**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) と [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) プロパティを設定します。
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) クラスのオブジェクトを作成し、[**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) プロパティを設定します。
1. [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) を呼び出し、第二引数に [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) のオブジェクトを渡します。

以下のコードサンプルは、DWG 図面を PDF にエクスポートする方法を示しています。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToPDF-ExportToPDF.cs" >}}

### **異なるレイアウトサイズでの単一 PDF の作成**

Aspose.CAD for .NET を使用すると、DWG ファイルを異なるレイアウトサイズを持つ単一の PDF に変換できます。このアプローチは次のように機能します：

1. [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) ファクトリーメソッドを使用して DWG ファイルを読み込みます。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) クラスのインスタンスを作成し、結果ページの高さと幅を設定します。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) オブジェクトに必要な [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/layoutpagesizes) を追加します。
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) クラスのインスタンスを作成し、その [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) プロパティを設定します。
1. [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) メソッドを使用して画像を PDF にエクスポートします。

以下のコードサンプルは、異なるレイアウトの単一 [PDF](https://docs.fileformat.com/pdf/) を作成する方法を示しています。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.cs" >}}

### **サポートされている AutoCAD プリミティブ**

以下の AutoCAD プリミティブがサポートされています。

- TEXT
- MTEXT
- ATTDEF
- ATTRIB
- ARC
- ELLIPSE
- HATCH
- LEADER
- POINT
- VERTEX 2D
- VERTEX 3D
- POLYLINE 2D
- LWPOLYLINE
- RAY
- CIRCLE
- DIMENSION ORDINATE
- DIMENSION LINEAR
- DIMENSION ALIGNED
- DIMENSION ANG 3Pt
- DIMENSION ANG 2Ln
- DIMENSION RADIUS
- DIMENSION DIAMETER
- SHAPE
- SOLID
- SPLINE
- MLINE
- LINE
- XLINE
- STYLE
- DIMSTYLE
- LTYPE
- MLINESTYLE
- LAYER
- VIEWPORT
- LAYOUT

## **特定の DWG レイアウトを PDF にエクスポートする**

このアプローチは次のように機能します：

1. [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) ファクトリーメソッドを使用して DWG ファイルを読み込みます。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) クラスのインスタンスを作成し、結果ページの高さと幅を設定します。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) オブジェクトの [**Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) プロパティを設定します。
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) クラスのインスタンスを作成し、その [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) プロパティを設定します。
1. [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) メソッドを使用して画像を PDF にエクスポートします。

以下のコードサンプルは、特定のレイアウトの DWG を PDF に変換する方法を示しています。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **座標を指定して DWG ドキュメントをレンダリングする**

Aspose.CAD for .NET API は、ドキュメントの幅と高さの座標を指定することによって DWG ドキュメントをレンダリングする機能を現在提供しています。

以下のコードサンプルは、DWG ドキュメントをレンダリングする方法を示しています。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-RenderDWGDocument-RenderDWGDocument.cs" >}}

## **固定サイズを使用して DWG をラスタまたは PDF にエクスポートする**

Aspose.CAD for .NET API は DWG 形式の AutoCAD 図面を読み込み、固定サイズを使用して PDF またはラスタに変換できます。

以下のコードサンプルは、この機能を実装する方法を示しています。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.cs" >}}

## **DWG を PDF/A および PDF/E にエクスポートする**

このアプローチは次のように機能します：

1. [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) ファクトリーメソッドを使用して DWG ファイルを読み込みます。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) クラスのインスタンスを作成します。
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) クラスのインスタンスを作成し、その [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) プロパティを設定します。
1. PDF 準拠プロパティを設定し、保存します。
1. [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) メソッドを使用して画像を PDF にエクスポートします。

以下のコードサンプルは、DWG ファイルを PDF/A および PDF/E に変換する方法を示しています。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-DWGToCompliancePDF-DWGToCompliancePDF.cs" >}}

## **DWG/DXF を BMP および PDF にエクスポートする際の隠れた線のラウンド処理のサポート**

このアプローチは次のように機能します：

1. [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) ファクトリーメソッドを使用して DWG ファイルを読み込みます。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) クラスのインスタンスを作成し、結果ページの高さと幅を設定します。
1. [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) クラスのインスタンスを作成し、その [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index) プロパティを設定します。
1. [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) メソッドを使用して画像を PDF にエクスポートします。

以下のコードサンプルは、この機能を実装する方法を示しています。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-SupportForHiddenLines-SupportForHiddenLines.cs" >}}

## **エクスポートされた PDF に DWG 画像の印刷領域を設定するサポート**

Aspose.CAD for .NET API は DWG 形式の AutoCAD 図面を読み込み、PDF に変換できます。このトピックでは、エクスポートされた PDF の DWG 画像に印刷領域を設定するサポートのための Aspose.CAD API の使い方を説明します。

以下のコードサンプルは、この機能を実装する方法を示しています。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **DWG ファイルの XREF メタデータを読み取るサポート**

1. [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) ファクトリーメソッドを使用して DWG ファイルを読み込みます。
1. すべての画像エンティティを巡回します。
1. エンティティが CadUnderlay の場合、XREF エンティティとメタデータを取得します。

以下のコードサンプルは、この機能を実現する方法を示しています。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ReadXREEFMetaData-ReadXREEFMetaData.cs" >}}

プロパティ [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) は文字列配列の型であるため、PDF 形式への変換のために複数のレイアウトを一度に指定できます。[**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) プロパティに複数のレイアウトを指定すると、生成された PDF には複数のページが含まれ、それぞれのページが個別の AutoCAD レイアウトを表します。

### **すべてのレイアウトをリスト表示する**

以下のコードスニペットを使用して、AutoCAD 図面に存在するすべてのレイアウトをリスト表示できます。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-ListLayouts-ListLayouts.cs" >}}

### **DWG 形式の下地フラグにアクセスする**

Aspose.CAD for .NET は DWG 形式の下地フラグを実装しており、開発者がアクセスできるようにしています。以下は、簡単なコードのデモです。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.cs" >}}

## **DWG エンティティのサポート**

Aspose.CAD for .NET API は DWG 形式の AutoCAD 図面を読み込み、さまざまなエンティティをサポートして作業できます。

### **MLeader エンティティのサポート**

DWG はベクター画像データとメタデータを含むバイナリファイルです。DWG ファイル内にはさまざまなエンティティがあります。以下のセクションでは、DWG ファイル内の MLeader エンティティで作業する例を説明します。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.cs" >}}

### **DWG エンティティを画像にエクスポートするサポート**

DWG はベクター画像データとメタデータを含むバイナリファイルです。DWG ファイル内にはさまざまなエンティティがあります。以下のセクションでは、特定の DWG エンティティを画像にエクスポートする例を説明します。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ParticularDWGToImage-ParticularDWGToImage.cs" >}}

## **DWG にテキストを追加するサポート**

Aspose.CAD for .NET API は DWG 形式の AutoCAD 図面を読み込み、さまざまなエンティティをサポートして作業できます。DWG はベクター画像データとメタデータを含むバイナリファイルです。DWG ファイル内にはさまざまなエンティティがあります。以下のセクションでは、DWG ファイル内にテキストを追加する方法を説明します。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-AddTextInDWG-AddTextInDWG.cs" >}}

## **DWG ファイルに画像をインポートするサポート**

Aspose.CAD for .NET API は DWG 形式の AutoCAD 図面を読み込み、さまざまなエンティティをサポートして作業できます。DWG はベクター画像データとメタデータを含むバイナリファイルです。DWG ファイル内にはさまざまなエンティティがあります。以下のセクションでは、DWG ファイル内に画像をインポートする方法を説明します。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DWG-Drawings-ImportImageToDWG-ImportImageToDWG.cs" >}}

## **DWG のメッシュのサポート**

Aspose.CAD for .NET API は、[**CadPolyFaceMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolyfacemesh) および [**CadPolygonMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolygonmesh) タイプを含むメッシュをサポートするエンティティにアクセスできるようになりました。以下の例では、メッシュタイプにアクセスする方法を説明します。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-MeshSupportForDWG-MeshSupportForDWG.cs" >}}

## **DWG 図面を DXF に変換する**

Aspose.CAD は、AutoCAD DWG ファイルを読み込み、DXF 形式にエクスポートする機能を提供します。DWG から DXF への変換アプローチは次のように機能します：

1. [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index) ファクトリーメソッドを使用して DWG 図面ファイルを読み込みます。
1. [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) メソッドを使用して DWG 図面を DXF にエクスポートします。

以下のコードサンプルは、DWG ファイルを DXF 形式に変換する方法を示しています。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-DWGToDXF-DWGToDXF.cs" >}}

## **DWG 図面を SVG に変換する**

Aspose.CAD for .NET API は、DWG 形式の AutoCAD 図面を読み込み、SVG に変換できます。このトピックでは、DWG を SVG 形式に変換するための Aspose.CAD API の使い方を、以下に定義された簡単なステップを通じて説明します。

1. [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image) のインスタンスに DWG ファイルを読み込みます。
1. [**SvgOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/svgoptions) クラスのオブジェクトを作成し、必要なプロパティを設定します。
1. [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) メソッドを使用して DWG 図面を SVG にエクスポートします。

以下のコードサンプルは、DWG ファイルを SVG 形式に変換する方法を示しています。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToSVG-ExportToSVG.cs" >}}

## **大きな DWG ファイルを読み込む**

Aspose.CAD for .NET は [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image) クラスを使用して非常に大きな DWG ファイルを開く機能を提供します。以下のサンプルコードを使用して、大きなファイルを簡単に開くことができます。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-LargeDWGToPDF-LargeDWGToPDF.cs" >}}
