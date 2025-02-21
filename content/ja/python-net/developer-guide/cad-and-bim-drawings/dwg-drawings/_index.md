---
title: DWG 図面
type: docs
weight: 70
url: /ja/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **DWG 図面を PDF にエクスポートする**

Aspose.CAD for Python API は、[DWG](https://docs.fileformat.com/cad/dwg/) 形式の AutoCAD 図面を読み込み、[PDF](https://docs.fileformat.com/pdf/) に変換できます。このトピックでは、Aspose.CAD API を使用して、DWG から PDF 形式への変換を実現するための手順を説明します。

{{% alert color="primary" %}}

API は以下の AutoCAD DWG リビジョンをサポートしています：

- DWG 2004 バージョン 16.0 リリース 18
- DWG 2005 バージョン 16.1
- DWG 2010 バージョン 18.0
- DWG 2013 バージョン 19.0

{{% /alert %}}

### **DWG ファイル形式**

[DWG](https://docs.fileformat.com/cad/dwg/) は、ベクター画像データとメタデータを含むバイナリファイルです。ベクター画像データは、DWGを表示する方法についてCADアプリケーションに指示を提供します。メタデータには、ファイルに関するさまざまな情報が含まれる場合があり、特定の場所に関するデータやクライアントデータも含まれます。DWGファイル形式の仕様書は、[この PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf) で見つけることができます。

### **DWG ファイルを PDF に変換する**

[DWG](https://docs.fileformat.com/cad/dwg/) を [PDF](https://docs.fileformat.com/pdf/) に変換するために必要な簡単な手順は次のとおりです。

1. DWG ファイルを **Image** のインスタンスに読み込みます。
1. **CadRasterizationOptions** クラスのオブジェクトを作成し、**page_height** および **page_width** プロパティを設定します。
1. **PdfOptions** クラスのオブジェクトを作成し、**VectorRasterizationOptions** プロパティを設定します。
1. **Image.save** を呼び出し、**PdfOptions** のオブジェクトを 2 番目のパラメーターとして渡します。

以下のコードサンプルは、DWG 図面を PDF にエクスポートする方法を示しています。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-PDF-Export.py" >}}

### **サポートされる AutoCAD プリミティブ**

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

このアプローチは以下のように動作します：

1. **Aspose.CAD.Image.load** ファクトリメソッドを使用して DWG ファイルを読み込みます。
1. **CadRasterizationOptions** クラスのインスタンスを作成し、結果のページの高さと幅を設定します。
1. **CadRasterizationOptions** オブジェクトの **Layouts** プロパティを設定します。
1. **PdfOptions** クラスのインスタンスを作成し、その **VectorRasterizationOptions** プロパティを設定します。
1. **Image.save()** メソッドを使用して画像を PDF にエクスポートします。

以下のコードサンプルは、特定の DWG レイアウトを PDF に変換する方法を示しています。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-ExportSpecificLayoutToPDF.py" >}}

## **DWG を PDF/A および PDF/E にエクスポートする**

このアプローチは以下のように機能します：

1. **Image.load** ファクトリメソッドを使用して DWG ファイルを読み込みます。
1. **CadRasterizationOptions** クラスのインスタンスを作成します。
1. **PdfOptions** クラスのインスタンスを作成し、その **VectorRasterizationOptions** プロパティを設定します。
1. PDF 準拠プロパティを設定し、保存します。
1. **Image.save()** メソッドを使用して画像を PDF にエクスポートします。

以下のコードサンプルは、DWG ファイルを PDF/A および PDF/E に変換する方法を示しています。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-to-Compliance-PDF.py" >}}

## **DWG 図面を DXF に変換する**

Aspose.CAD は、AutoCAD DWG ファイルを読み込み、DXF 形式にエクスポートする機能を提供します。DWG から DXF への変換アプローチは以下のように機能します：

1. **Image.load** ファクトリメソッドを使用して DWG 図面ファイルを読み込みます。
1. **Image.save()** メソッドを使用して DWG 図面を DXF にエクスポートします。

以下のコードサンプルは、DWG ファイルを DXF 形式に変換する方法を示しています。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-DXF.py" >}}

## **DWG 図面を SVG に変換する**

Aspose.CAD for Python API は、DWG 形式の AutoCAD 図面を読み込み、SVG に変換できます。このトピックでは、DWG を SVG 形式に変換するための Aspose.CAD API の使用方法を以下の簡単な手順で説明します。

1. DWG ファイルを **Image** のインスタンスに読み込みます。
1. **SvgOptions** クラスのオブジェクトを作成し、必要なプロパティを設定します。
1. **Image.save()** メソッドを使用して DWG 図面を SVG にエクスポートします。

以下のコードサンプルは、DWG ファイルを SVG 形式に変換する方法を示しています。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-SVG.py" >}}
