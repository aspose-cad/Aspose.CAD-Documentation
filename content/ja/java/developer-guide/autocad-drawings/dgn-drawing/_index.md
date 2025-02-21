---
title: DGN 図面
type: docs
weight: 10
url: /ja/java/developer-guide/autocad-drawings/dgn-drawing/
---

## **DWG の一部としての DGN 形式の描画**

Aspose.CAD for Java を使用すると、開発者は埋め込まれた DGN アンダーレイを持つ DWG ファイルをエクスポートできます。以下は、DWG ファイルをエクスポートする際に DGN アンダーレイにアクセスする方法を示すコードです。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportDGNAsPartofDWG-ExportDGNAsPartofDWG.java" >}}

## **DGN v7 用の 3D エンティティのサポート**

Aspose.CAD for Java API では、DGN AutoCAD ファイルを読み込む機能が追加され、DGN v7 用の 3D エンティティがサポートされました。[**CadImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadImage) クラスがこの目的を果たします。各 DGN 画像は、9 つの事前定義されたビューをサポートしています。このビューは 1 から 9 まで列挙されています。エクスポート時にビューが定義されていない場合、マルチページ出力形式（PDF など）では、すべてのビューが別々のページにエクスポートされます。DGN ファイル形式には 2D と同様に 3D エンティティがサポートされています。  
VectorRasterizationOptions.TypeOfEntities は DGN 形式ではもはや使用されていません（2D と 3D の両方が同時にサポートされています）。

サポートされている DGN 要素を見るためのサンプルコードです。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportForDGNV7-SupportForDGNV7.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportedDGNElements-SupportedDGNElements.java" >}}
