---
title: CAD図面サイズの調整
type: docs
weight: 10
url: /ja/java/developer-guide/adjusting-cad-drawing-size/
---

{{% alert color="primary" %}}

Java用Aspose.CADを使用すると、開発者はCAD形式の変換中に図面のサイズを調整できます。このトピックでは、[**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) 列挙型を使用してサイズを自動調整または調整する方法について説明します。

{{% /alert %}}

## **CAD図面サイズの調整**

Java用Aspose.CADは、CAD形式の変換中に図面のサイズを調整するために[**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) 列挙型を提供します。図面サイズを調整する方法は2つあります。

1. 自動サイズ調整
1. [**com.aspose.cad.imageoptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/package-frame) クラスの[**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) 列挙型を使用してサイズを調整

サイズを自動調整する場合、開発者は[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) クラスのWidthおよびHeightプロパティを提供する必要はありません。以下に自動サイズ調整の例を示すコードスニペットを提供します。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AutoAdjustingCADDrawingSize.java" >}}

[**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) 列挙型は、WidthおよびHeightプロパティが設定されていない場合にスケーリングを調整する機能を提供します。以下に[**UnitType**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/UnitType) の使用方法を示すコードスニペットを提供します。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-AdjustingCADDrawingSizeUsingUnitType-AdjustingCADDrawingSizeUsingUnitType.java" >}}
