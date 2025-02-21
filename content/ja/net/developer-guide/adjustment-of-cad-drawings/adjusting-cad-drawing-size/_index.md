---
title: CAD図面サイズの調整
type: docs
weight: 10
url: /ja/net/developer-guide/adjustment-of-cad-drawings/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Aspose.CAD for .NETライブラリを使用することで、開発者はサポートされている形式への変換中にCAD図面のサイズを調整できます。このトピックでは、[**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype)列挙型を使用して、サイズを自動的または手動で調整する方法について説明します。[**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions)クラスの。

{{% /alert %}}

## **CAD図面サイズの調整**

Aspose.CAD for .NETは、CAD形式の変換中に図面のサイズを調整するための[**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype)列挙型を提供します。図面サイズを調整する方法は2つあります。

1. 自動サイズ調整
1. [**Aspose.CAD.ImageOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions)クラスの[**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype)列挙型を使用してサイズを調整する

サイズを自動的に調整する場合、開発者は[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/index)クラスのWidthおよびHeightプロパティを提供する必要はありません。以下に示すコードスニペットは、自動サイズ調整の例です。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AutoAdjustingCADDrawingSize-AutoAdjustingCADDrawingSize.cs" >}}

[**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype)列挙型は、WidthおよびHeightプロパティが設定されていない場合にスケーリングを調整する機能を提供します。以下に示すコードスニペットは、[**UnitType**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/unittype)の使用方法を示しています。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.cs" >}}
