---
title: DWG図面
type: docs
weight: 40
url: /ja/java/developer-guide/autocad-drawings/dwg-drawings/
---

## **DWG図面をPDFにエクスポートする**

Aspose.CAD for Java APIはDWG形式のAutoCAD図面をロードし、PDFに変換することができます。このトピックでは、Aspose.CAD APIを使用してDWGをPDF形式に変換するための簡単な手順を説明します。

{{% alert color="primary" %}}

APIは以下のAutoCAD DWGのリビジョンをサポートしています：

- DWG 2004 バージョン16.0リリース18
- DWG 2005 バージョン16.1
- DWG 2010 バージョン18.0
- DWG 2013 バージョン19.0

{{% /alert %}}

### **DWGファイルフォーマット**

DWGはベクター画像データとメタデータを含むバイナリファイルです。ベクター画像データはCADアプリケーションにDWGを表示する方法について指示を提供します; メタデータにはファイルに関するさまざまな情報が含まれる場合があります。DWGファイルフォーマットのオープンスペックは[このPDF](https://www.opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)で見つけることができます。

### **DWGファイルをPDFに変換する**

DWGをPDFに変換するには、以下の簡単なステップが必要です。

1. DWGファイルをインスタンスの[**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image)にロードします。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions)クラスのオブジェクトを作成し、[**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-)と[**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-)プロパティを設定します。
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions)クラスのオブジェクトを作成し、[**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions)プロパティを設定します。
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--)メソッドを呼び出し、[**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions)のオブジェクトを第二パラメータとして渡します。

以下のコードサンプルは、DWG図面をPDFにエクスポートする方法を示しています。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ConvertDWGFileToPDF-ConvertDWGFileToPDF.java" >}}

### **異なるレイアウトサイズの単一PDFを作成する**

Aspose.CAD for Javaを使用すると、DWGファイルを異なるレイアウトサイズの単一PDFに変換することができます。このアプローチは以下のように機能します。

1. [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-)ファクトリメソッドを使用してDWGファイルをロードします。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions)クラスのインスタンスを作成し、生成されたページの高さと幅を設定します。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions)オブジェクトのために必要な[**LayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setLayoutPageSizes-com.aspose.ms.System.Collections.Generic.Dictionary-)を追加します。
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions)クラスのインスタンスを作成し、その[**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions)プロパティを設定します。
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--)メソッドを使用して画像をPDFにエクスポートします。

以下のコードサンプルは、異なるレイアウトを持つ単一PDFを作成する方法を示しています。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.java" >}}

### **DWGをPDF/AおよびPDF/Eにエクスポートする**

DWGをPDFに変換するには、以下の簡単なステップが必要です。

1. DWGファイルをインスタンスの[**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image)にロードします。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions)クラスのオブジェクトを作成し、[**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-)と[**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-)プロパティを設定します。
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions)クラスのオブジェクトを作成し、[**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions)プロパティを設定します。
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--)メソッドを呼び出し、[**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions)のオブジェクトを第二パラメータとして渡します。

以下のコードサンプルは、DWG図面をPDFにエクスポートする方法を示しています。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToCompliancePDF-DWGToCompliancePDF.java" >}}

### **サポートされているAutoCADプリミティブ**

以下のAutoCADプリミティブがサポートされています。

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

## **特定のDWGレイアウトをPDFにエクスポートする**

このアプローチは以下のように機能します。

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-)ファクトリメソッドを使用してDWGファイルをロードします。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions)クラスのインスタンスを作成し、生成されたページの高さと幅を設定します。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions)オブジェクトの[**Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-)プロパティを設定します。
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions)クラスのインスタンスを作成し、その[**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions)プロパティを設定します。
1. [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--)メソッドを使用して画像をPDFにエクスポートします。

以下のコードサンプルは、DWGの特定のレイアウトをPDFに変換する方法を示しています。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportSpecificDWGLayoutToPDF-ExportSpecificDWGLayoutToPDF.java" >}}

## **固定サイズを使用してDWGをラスタまたはPDFにエクスポートする**

Aspose.CAD for Java APIはDWG形式のAutoCAD図面をロードし、固定サイズを使用してPDFまたはラスタに変換することができます。

以下のコードサンプルは、この機能を実装する方法を示しています。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.java" >}}

## **DWG/DXFをBMPおよびPDFにエクスポートする際のラウンド隠し線のサポート**

このアプローチは以下のように機能します。

1. [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-)ファクトリメソッドを使用してDWGファイルをロードします。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions)クラスのインスタンスを作成します。
1. 生成されたページの高さと幅を設定するために[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions)クラスのインスタンスを作成します。
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions)クラスのインスタンスを作成し、その[**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions)プロパティを設定します。
1. [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--)メソッドを使用して画像をPDFにエクスポートします。

以下のコードサンプルは、この機能を実装する方法を示します。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportForHiddenLines-SupportForHiddenLines.java" >}}

## **エクスポートされたPDF内のDWG画像の印刷エリアを設定するサポート**

Aspose.CAD for Java APIはDWG形式のAutoCAD図面をロードし、それをPDFに変換することができます。このトピックでは、エクスポートされたPDF内のDWG画像の印刷エリアを設定するサポートを得るためのAspose.CAD APIの使用法を説明します。

以下のコードサンプルは、この機能を実装する方法を示しています。

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **DWGファイルのXREFメタデータを読み取るサポート**

1. [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-)ファクトリメソッドを使用してDWGファイルをロードします。
1. 各画像エンティティをトラバースします。
1. エンティティが[**CadUnderlay**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadUnderlay)の場合は、メタデータとともにXREFエンティティを処理します。

以下のコードサンプルは、この機能を達成する方法を示しています。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ReadXREEFMetaData-ReadXREEFMetaData.java" >}}

## **座標を指定してDWG文書をレンダリングする**

Aspose.CAD for Java APIは、文書の幅と高さの座標を指定することによってDWG文書をレンダリングする機能を提供しています。

以下のコードサンプルは、DWG文書をレンダリングする方法を示しています。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-RenderDWGDocument-RenderDWGDocument.java" >}}

プロパティ[**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#getLayouts--)は文字列配列の型であるため、PDF形式への変換のために複数のレイアウトを同時に指定することができます。 [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-)プロパティに複数のレイアウトを指定すると、生成されるPDFには複数のページが含まれ、それぞれのページは個々のAutoCADレイアウトを表します。

### **すべてのレイアウトをリストする**

次のコードスニペットを使用して、AutoCAD図面に存在するすべてのレイアウトをリストすることができます。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ListAllLayoutsInAnAutoCADDrawing-ListAllLayoutsInAnAutoCADDrawing.java" >}}

## **外部参照のブロック属性値を取得する**

Aspose.CAD for Java APIは、ブロック属性の外部参照を取得することを許可します。Aspose.CAD APIは、[**getXRefPathName()**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity#getXRefPathName--)プロパティを公開して、[**CadBlockDictionary**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadBlockDictionary)コレクション内のブロック属性の外部参照を取得します。

以下のコードは、ブロック属性の外部参照を取得する方法を示しています。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-GetBlockAttributeValueOfExternalReference-GetBlockAttributeValueOfExternalReference.java" >}}

## **DWG AutoCADファイル内のテキストを検索する**

Aspose.CAD for Java APIは、DWG AutoCADファイル内のテキストを検索することを許可します。Aspose.CAD APIは、DWG AutoCADファイル内のテキストエンティティを表す[**CadText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadText)クラスを公開しています。また、他のエンティティにもテキストが含まれている可能性があるため、[**CadMText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadMText)クラスもAspose.CAD APIに含まれています。

以下のコードは、DWG AutoCADファイル内のテキストを検索する方法を示しています。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchTextInDWGAutoCADFile.java" >}}

### **特定のレイアウト内でテキストを検索する**

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchForTextInSpecificLayout.java" >}}

### **DWGフォーマットの下書きフラグにアクセスする**

Aspose.CAD for JavaはDWGフォーマットの下書きフラグを実装しており、開発者がそれらにアクセスできるようにしています。以下は、簡単なコードのデモです。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.java" >}}

## **DWGエンティティのサポート**

Aspose.CAD for Java APIは、DWG形式のAutoCAD図面をロードし、さまざまなエンティティをサポートして操作することができます。

### **MLeaderエンティティのサポート**

DWGはベクター画像データとメタデータを含むバイナリファイルです。DWGファイルにはさまざまなエンティティが含まれています。以下のセクションでは、DWGファイル内でMLeaderエンティティを操作する例を説明します。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.java" >}}

### **DWGエンティティを画像にエクスポートするサポート**

DWGはベクター画像データとメタデータを含むバイナリファイルです。DWGファイルにはさまざまなエンティティが含まれています。以下のセクションでは、特定のDWGエンティティを画像にエクスポートする例を説明します。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ParticularDWGToImage-ParticularDWGToImage.java" >}}

## **DWGファイルに画像をインポートするサポート**

Aspose.CAD for Java APIはDWG形式のAutoCAD図面をロードし、さまざまなエンティティをサポートして操作することができます。DWGはベクター画像データとメタデータを含むバイナリファイルです。DWGファイルにはさまざまなエンティティが含まれています。以下のセクションでは、DWGファイル内に画像をインポートする方法を説明します。

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ImportImageToDWG-ImportImageToDWG.java" >}}

## **DWGにテキストを追加するサポート**

Aspose.CAD for Java APIはDWG形式のAutoCAD図面をロードし、さまざまなエンティティをサポートして操作することができます。DWGはベクター画像データとメタデータを含むバイナリファイルです。DWGファイルにはさまざまなエンティティが含まれています。以下のセクションでは、DWGファイル内にテキストを追加する方法を説明します。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-AddTextInDWG-AddTextInDWG.java" >}}

## **DWG内のメッシュのサポート**

Aspose.CAD for Java APIは、[**CadPolyFaceMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolyFaceMesh)および[**CadPolygonMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolygonMesh)タイプのメッシュをサポートするエンティティにアクセスすることができます。以下の例では、メッシュタイプにアクセスする方法を説明します。

## **DWG図面をDXFに変換する**

Aspose.CADはAutoCAD DWGファイルをロードし、それをDXF形式にエクスポートする機能を提供します。DWGからDXFへの変換アプローチは以下のように機能します。

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-)ファクトリメソッドを使ってDWG図面ファイルをロードします。
1. [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--)メソッドを使用してDWG図面をDXFにエクスポートします。

以下のコードサンプルは、DWGファイルをDXF形式に変換する方法を示しています。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToDXF-DWGToDXF.java" >}}

## **DWG図面をSVGに変換する**

Aspose.CAD APIはDWG形式のAutoCAD図面をロードし、それをSVGに変換することができます。このトピックでは、DWGをSVG形式に変換するためのAspose.CAD APIの使用法を以下の簡単な手順で説明します。

1. DWGファイルをインスタンスの[**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image)にロードします。
1. [**SvgOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/SvgOptions)クラスのオブジェクトを作成し、必要なプロパティを設定します。
1. [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--)メソッドを使用してDWG図面をSVGにエクスポートします。

以下のコードサンプルは、DWGファイルをSVG形式に変換する方法を示しています。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportToSVG-ExportToSVG.java" >}}
