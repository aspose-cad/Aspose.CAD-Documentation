---
title: DWF 図面
type: docs
weight: 20
url: /ja/java/developer-guide/autocad-drawings/dwf-drawings/
---

## **DWF 図面を PDF にエクスポートする**

Aspose.CAD for Java API は DWF 形式の AutoCAD 図面を読み込み、PDF に変換できます。このトピックでは、DWF から PDF 形式への変換を実現するための Aspose.CAD API の使用方法について説明します。

### **DWF ファイルを PDF に変換する**

DWF を PDF に変換するために必要な簡単な手順は以下の通りです。

1. [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image) のインスタンスに DWF ファイルを読み込みます。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) クラスのオブジェクトを作成し、[**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) と [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) プロパティを設定します。
1. [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) クラスのオブジェクトを作成し、[**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) プロパティを設定します。
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) を呼び出し、[**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) のオブジェクトを第二引数として渡します。

以下のコードサンプルは、DWF 図面を PDF にエクスポートする方法を示しています。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToPDF-ExportToPDF.java" >}}

### **DWF におけるレイヤーのサポート**

Aspose.CAD は、AutoCAD DWF 図面エンティティを読み込み、JPG 形式の全体図面としてレンダリングする機能を提供しています。

1. [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) ファクトリーメソッドを使用して DWF 図面ファイルを読み込みます。
1. [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) クラスのオブジェクトを作成します。
1. 必要なレイヤーを追加します。
1. [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) を呼び出し、[**JPEGOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) のオブジェクトを第二引数として渡します。

以下のコードサンプルは、デフォルト設定を使用してファイルを変換する方法を示しています。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWFDrawings-SupportOfLayers-SupportOfLayers.java" >}}
