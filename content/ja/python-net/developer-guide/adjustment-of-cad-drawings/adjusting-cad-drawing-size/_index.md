---
title: CAD図面サイズの調整
type: docs
weight: 10
url: /ja/python-net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Aspose.CAD for Pythonライブラリを使用することで、開発者はサポートされているフォーマットへの変換中にCAD図面のサイズを調整できます。このトピックでは、**ImageOptions**クラスの**UnitType**列挙型を使用して、自動的または手動でサイズを調整する方法について説明します。

{{% /alert %}}

## **CAD図面サイズの調整**

Aspose.CAD for Pythonは、CADフォーマットの変換中に図面のサイズを調整するための**UnitType**列挙型を提供します。図面サイズを調整する方法は2つあります。

1. 自動サイズ調整。
1. **ImageOptions**クラスの**UnitType**列挙型を使用してサイズを調整。

サイズを自動的に調整する場合、開発者は**CadRasterizationOptions**クラスのWidthおよびHeightプロパティを指定する必要はありません。以下に示すコードスニペットは、自動サイズ調整の例です。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AutoAdjustingCADDrawingSize.py" >}}

**UnitType**列挙型は、WidthおよびHeightプロパティが設定されていない場合にスケーリングを調整する能力を提供します。以下に示すコードスニペットは、**UnitType**の使用方法を示しています。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "AdjustingCADDrawingSizeUsingUnitType.py" >}}
