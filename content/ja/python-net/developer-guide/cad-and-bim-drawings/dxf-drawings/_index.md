---
title: DXF 図面
type: docs
weight: 10
url: /ja/python-net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **DXF 図面を PDF にエクスポート**

Aspose.CAD は、AutoCAD DXF 図面エンティティをロードし、それらを全体の図面として PDF 形式にレンダリングする機能を提供します。DXF から PDF への変換アプローチは以下のように機能します：

1. **Image.load** ファクトリメソッドを使用して DXF 図面ファイルをロードします。
1. **CadRasterizationOptions** クラスのオブジェクトを作成し、**page_height** および **page_width** プロパティを設定します。
1. **PdfOptions** クラスのオブジェクトを作成し、**VectorRasterizationOptions** プロパティを設定します。
1. **Image.save** を呼び出し、**PdfOptions** のオブジェクトを第二引数として渡します。

以下のコードサンプルは、デフォルト設定を使用してファイルを変換する方法を示しています。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXF-to-PDF-Export.py" >}}

### **サポートされているフォーマット**

現時点では、AutoCAD DXF 2010 ファイル形式を完全にサポートしています。以前の DXF バージョンは 100% 有効であることが保証されていません。今後の Aspose.CAD バージョンでは、さらに多くのフォーマットと機能を含める予定です。

### **サポートされているエンティティ**

現時点では、以下の一般的な 2D エンティティとその基本的なデフォルトパラメータをサポートしています：

1. アライン寸法
1. 角度寸法
1. アーク
1. 属性
1. ブロック参照
1. サークル
1. 直径寸法
1. 楕円
1. ハッチ
1. 線
1. マルチラインテキスト
1. 縦標寸法
1. ポイント
1. ポリライン
1. 半径寸法
1. レイ
1. 回転寸法
1. テーブル
1. テキスト
1. X 線

{{% alert color="primary" %}}

パース中にサポートしていないエンティティまたはプロパティが見つかった場合、そのエンティティまたはプロパティは静かに無視されます。

{{% /alert %}}

## **DXF 形式用の埋め込み DGN アンダーレイをエクスポート**

Aspose.CAD は、AutoCAD DXF ファイルをロードし、DXF 形式用の埋め込み DGN アンダーレイをエクスポートする機能を提供します。

以下のコードサンプルは、指定された要件を達成する方法を示しています。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ExportEmbeddedDGN.py" >}}

## **DXF ファイルの保存サポート**

Aspose.CAD は、AutoCAD DXF ファイルをロードし、それを変更して再度 DXF ファイルとして保存する機能を提供します。

以下のコードサンプルは、指定された要件を達成する方法を示しています。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-Drawings-SaveDXFFiles.py" >}}

## **DXF を WMF にエクスポート**

このアプローチは次のように機能します：

1. **Image.load** ファクトリメソッドを使用して DXF 図面ファイルをロードします。
1. **CadRasterizationOptions** クラスのオブジェクトを作成し、PDF ファイルをロードします。
1. **page_height** および **page_width** プロパティを設定します。
1. **Image.save** を呼び出し、ファイルを保存します。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-to-WMF-Export.py" >}}
