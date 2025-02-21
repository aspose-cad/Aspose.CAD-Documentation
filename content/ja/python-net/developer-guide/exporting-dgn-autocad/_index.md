---
title: DGN AutoCAD のエクスポート
type: docs
weight: 50
url: /ja/python-net/developer-guide/exporting-dgn-autocad/
---

## **PDF への DGN AutoCAD 形式のエクスポート**

Aspose.CAD for Python API には、DGN AutoCAD ファイルを読み込み、PDF 形式に変換する機能が追加されました。**CadImage** クラスがその目的を果たします。

既存の DGN ファイルを **CadImage** として読み込む必要があります。**CadRasterizationOptions** クラスのインスタンスを作成し、異なるプロパティを設定します。**PdfOptions** クラスのインスタンスを作成し、**CadRasterizationOptions** インスタンスを渡します。次に、**CadImage** クラス インスタンスの **save** メソッドを呼び出します。

### サンプルコード

以下は、[DGN](https://docs.fileformat.com/cad/dgn/) を [PDF](https://docs.fileformat.com/pdf/) 形式に変換/エクスポートするためのコードのデモです。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-PDF-Export.py" >}}


## **DGN AutoCAD 形式をラスタ画像形式にエクスポート**

Aspose.CAD for Python API には、DGN AutoCAD ファイルを読み込み、ラスタ画像に変換する機能が追加されました。**CadImage** クラスがその目的を果たします。

既存の DGN ファイルを **CadImage** として読み込む必要があります。**CadRasterizationOptions** クラスのインスタンスを作成し、異なるプロパティを設定します。**JpegOptions** クラスのインスタンスを作成し、**CadRasterizationOptions** インスタンスを渡します。次に、**CadImage** クラス インスタンスの **save** メソッドを呼び出します。

### サンプルコード

以下は、[DGN](https://docs.fileformat.com/cad/dgn/) を [JPEG](https://docs.fileformat.com/image/jpeg/) 画像に変換/エクスポートするためのコードのデモです。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DNG-to-JPEG-Export.py" >}}

## **DGN v7 の 3D エンティティサポート**

Aspose.CAD for Python API には、[DGN](https://docs.fileformat.com/cad/dgn/) AutoCAD ファイルを読み込み、DGN v7 用の 3D エンティティをサポートする機能が追加されました。**CadImage** クラスがその目的を果たします。各 [DGN](https://docs.fileformat.com/cad/dgn/) 画像は 9 つの事前定義されたビューをサポートします。それは 1 から 9 に列挙されます。エクスポート時にビューが定義されていない場合、マルチページ出力形式（PDF のような）では、すべてのビューがそれぞれのページにエクスポートされます。DGN ファイル形式では 3D エンティティがサポートされ、2D もサポートされています。これには、**VectorRasterizationOptions** が使用され、DGN 形式では TypeOfEntities はもはや使用されません（2D と 3D が同時にサポートされます）。

### サンプルコード

以下は、サポートされている DGN 要素を確認するためのサンプルコードです。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DGN-Drawings-SupportOf3DForDGNV7.py" >}}
