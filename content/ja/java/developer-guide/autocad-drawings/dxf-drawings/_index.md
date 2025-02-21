---
title: DXF 図面
type: docs
weight: 60
url: /ja/java/developer-guide/autocad-drawings/dxf-drawings/
---

## **DXF 図面を PDF にエクスポートする**

Aspose.CAD は、AutoCAD DXF 図面エンティティをロードし、それらを PDF 形式の全体図面としてレンダリングする機能を提供します。DXF から PDF への変換手法は次のように機能します：

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) ファクトリメソッドを使用して、DXF 図面ファイルをロードします。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) クラスのオブジェクトを作成し、[**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) および [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) プロパティを設定します。
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) クラスのオブジェクトを作成し、[**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) プロパティを設定します。
1. 2 番目のパラメーターとして [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) のオブジェクトを渡して、Image.Save を呼び出します。

以下のコードサンプルは、デフォルト設定を使用してファイルを変換する方法を示しています。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFDrawingToPDF-.java" >}}

### **サポートされているフォーマット**

現在、AutoCAD DXF 2010 ファイルフォーマットを完全にサポートしています。以前の DXF バージョンが 100% 有効であることは保証されていません。将来的な Aspose.CAD バージョンで、さらに多くのフォーマットと機能を含める計画です。

### **サポートされているエンティティ**

現在、私たちは広く使用されているすべての 2D エンティティと、その基本的なデフォルトパラメーターを次のようにサポートしています：

1. アラインディメンション
1. アンギュラーディメンション
1. アーク
1. アトリビュート
1. ブロックリファレンス
1. サークル
1. ダイアメーターディメンション
1. エリプス
1. ハッチ
1. ライン
1. マルチラインテキスト
1. オーディネートディメンション
1. ポイント
1. ポリライン
1. ラジアルディメンション
1. レイ
1. 回転ディメンション
1. テーブル
1. テキスト
1. Xライン

{{% alert color="primary" %}}

パース中にサポートしていないエンティティやプロパティに遭遇した場合、そのエンティティやプロパティは静かに無視されます。

{{% /alert %}}

### **メモリ管理**

プロパティ [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) は、メモリの再割り当てを制御するために使用できます。再割り当ては、事前に割り当てられたキャッシュに最もよく発生します。システムが、割り当てられたスペースが不十分だと判断した場合に発生する可能性があります。

- デフォルト値 **False** に設定されている場合、スペースは同じ媒体に再割り当てされます。
- **True** に設定された場合、再割り当ては指定された最大スペースを超えることはできません。この場合、既存のメモリ内で割り当てられたキャッシュ (再割り当てが必要) が解放され、拡張されたスペースがディスクに割り当てられます。

## **DXF 図面の特定のレイヤーを PDF にエクスポートする**

このアプローチは次のように機能します：

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) ファクトリメソッドを使用して、DXF 図面ファイルを開きます。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) のインスタンスを作成し、[**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) および [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) プロパティを指定します。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) のオブジェクトにレイヤーを追加します。
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) のインスタンスを作成し、その [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) プロパティを設定します。
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) メソッドを使用して、図面を PDF にエクスポートします。

以下のコードサンプルは、DXF の特定のレイヤーを PDF に変換する方法を示しています。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificLayerOfDXFDrawingToPDF-.java" >}}

## **DXF 図面の特定のレイヤーを画像にエクスポートする**

このアプローチは次のように機能します：

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) ファクトリメソッドを使用して、DXF 図面ファイルを開きます。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) のインスタンスを作成し、[**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) および [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) プロパティを指定します。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) のオブジェクトにレイヤーを追加します。
1. [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) のインスタンスを作成し、その [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) プロパティを設定します。
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) メソッドを使用して、図面を PDF にエクスポートします。

以下のコードサンプルは、DXF の特定のレイヤーを画像に変換する方法を示しています。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.java" >}}

## **DXF 図面の一部として PDF ファイルをレンダリングする**

このアプローチは次のように機能します：

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) ファクトリメソッドを使用して、DXF 図面ファイルをロードします。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) クラスのオブジェクトを作成し、PDF ファイルをロードします。
1. [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) および [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad/imageoptions/VectorRasterizationOptions#setPageWidth-float-) プロパティを設定します。
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) を呼び出して、ファイルを保存します。

以下のコードサンプルは、DXF 図面の一部として PDF ファイルをレンダリングする方法を示しています。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-RenderDXFAsPDF-RenderDXFAsPDF.java" >}}

## **DXF を WMF にエクスポートする**

このアプローチは次のように機能します：

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) ファクトリメソッドを使用して、DXF 図面ファイルをロードします。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) クラスのオブジェクトを作成し、PDF ファイルをロードします。
1. [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) および [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad/imageoptions/VectorRasterizationOptions#setPageWidth-float-) プロパティを設定します。
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) を呼び出して、ファイルを保存します。

以下のコードサンプルは、DXF を WMF にエクスポートする方法を示しています。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFToWMF-ExportDXFToWMF.java" >}}

## **DXF ファイルの保存をサポートする**

Aspose.CAD は、AutoCAD DXF ファイルをロードし、それに変更を加え再度 DXF ファイルとして保存する機能を提供します。以下のコードサンプルは、指定された要件を達成する方法を示しています。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SaveDXFFiles-SaveDXFFiles.java" >}}

## **DXF 形式の埋め込み DGN アンダーレイをエクスポートする**

Aspose.CAD は、AutoCAD DXF ファイルをロードし、DXF 形式の埋め込み DGN アンダーレイをエクスポートする機能を提供します。

以下のコードサンプルは、指定された要件を達成する方法を示しています。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportEmbeddedDGN-ExportEmbeddedDGN.java" >}}

## **特定の DXF レイアウトを PDF にエクスポートする**

このアプローチは次のように機能します：

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) ファクトリメソッドを使用して、DXF 図面ファイルを開きます。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) のインスタンスを作成し、[**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) および [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) プロパティを指定します。
1. [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) プロパティを使用して、希望するレイアウト名を指定します。
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) のインスタンスを作成し、その [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) プロパティを設定します。
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) メソッドを使用して、図面を PDF にエクスポートします。

以下のコードサンプルは、DXF の特定のレイアウトを PDF に変換する方法を示しています。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToPDF-.java" >}}

{{% alert color="primary" %}}

プロパティ [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) は文字列配列型であるため、PDF 形式への変換のために同時に複数のレイアウトを指定できます。すべてのレイアウトを指定する場合、生成される PDF には複数のページが含まれ、それぞれのページが個別の AutoCAD レイアウトを表します。

{{% /alert %}}

## **ATTRIB および MTEXT オブジェクトにアクセスする**

このアプローチは次のように機能します：

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) ファクトリメソッドを使用して、DXF 図面ファイルを開きます。
1. CAD ファイル内のエンティティにアクセスします。
1. [**CadEntityTypeName.MTEXT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#MTEXT) および [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT) エンティティをチェックします。
1. さらなる処理のために一時リストに追加します。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-AddAttribMText-AddAttribMText.java" >}}

## **CAD インサートオブジェクトを分解する**

このアプローチは次のように機能します：

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) ファクトリメソッドを使用して、DXF 図面ファイルを開きます。
1. CAD ファイル内のエンティティにアクセスします。
1. [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT) エンティティをチェックします。
1. [**CadBlockEntity**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity) タイプリストをチェックします。
1. エンティティを処理します。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-DecomposeCadInsertObject-DecomposeCadInsertObject.java" >}}

## **ブロッククリッピングのサポート**

Aspose.CAD は、ブロッククリッピング機能を提供します。ブロッククリッピングアプローチは次のように機能します：

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) ファクトリメソッドを使用して、DXF 図面ファイルをロードします。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) クラスのオブジェクトを作成し、PDF ファイルをロードします。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) の必要なプロパティを設定します。
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) のオブジェクトを第 2 パラメーターとして渡して [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) を呼び出し、ファイルを保存します。

以下のコードサンプルは、ブロッククリッピングの仕組みを示しています。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SupportOfBlockClipping-SupportOfBlockClipping.java" >}}

## **画像を DXF にエクスポートする**

Aspose.CAD を使用すると、画像を DXF 形式にエクスポートできます。このアプローチを使用すると、次のアクションを実行できます：

1. 新しいフォントを設定する
1. エンティティを非表示にする
1. テキストを更新する

以下のコードスニペットは、上記のアクションを実行する方法を示しています。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-ExportImagesToDXF.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-GetFileExtension.java" >}}
