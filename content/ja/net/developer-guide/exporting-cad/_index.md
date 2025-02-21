---
title: CADのエクスポート
type: docs
weight: 40
url: /ja/net/developer-guide/exporting-cad/
---

## **3D AutoCAD画像をPDFにエクスポートする**

Aspose.CADを使用すると、3D AutoCAD画像をPDFにエクスポートできます。3Dエンティティをエクスポートしたいことを指定するために、[**Aspose.CAD.ImageOptions.CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions)を使用してください。

以下のサンプルコードは、AutoCADの3Dファイルを読み込み、それを[PDF](https://docs.fileformat.com/pdf/)にエクスポートします。ファイルがPDFに変換されると、好きなPDFビューワーを使って開くことができます。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-Export3DImagestoPDF-Export3DImagestoPDF.cs" >}}

## **CADレイアウトをPDFにエクスポートする**

Aspose.CAD for .NETを使用すると、CADレイアウトをPDFにエクスポートできます。[**CadImage**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad/cadimage)クラスの[**Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index)メソッドを使用して、レイアウトを[PDF](https://docs.fileformat.com/pdf/)フォーマットにエクスポートできます。

以下のサンプルコードは、CADファイルを読み込み、その「モデル」レイアウトをPDFにエクスポートします。ファイルがPDFに変換されると、好きなPDFビューワーを使って開くことができます。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-CADLayoutsToPDF-CADLayoutsToPDF.cs" >}}

## **エクスポートでのペン設定のサポート**

Aspose.CAD for .NETを使用すると、CADのエクスポートプロパティにペンオプションを追加できます。[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions)を使用して、ペンプロパティオプションを設定できます。

以下は、指定された要件を達成するためのサンプルコードです。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-PenSupportInExport-PenSupportInExport.cs" >}}

## **CAD挿入オブジェクトの分解**

Aspose.CAD for .NETを使用すると、CADオブジェクトを分解し、挿入内部の個別エンティティを処理できます。以下は、指定された要件を達成するためのサンプルコードです。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-DecomposeCADInsertObject-DecomposeCADInsertObject.cs" >}}

## **ACADプロキシエンティティのサポート**

Aspose.CAD for .NETを使用すると、ACAD_PROXY_ENTITYエンティティを読み取り、エクスポートできます。以下は、指定された要件を達成するためのサンプルコードです。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ACADProxyEntities-ACADProxyEntities.cs" >}}

## **IGESフォーマットの統合**

Aspose.CAD for .NETを使用すると、IGESフォーマットを読み取り、エクスポートできます。以下は、指定された要件を達成するためのサンプルコードです。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-IntegrateIGESFormat-IntegrateIGESFormat.cs" >}}

## **メッシュモデルのサポート**

Aspose.CAD for .NETを使用すると、エッジ、頂点、および顔を含むメッシュモデルを実装およびカウントできます。以下は、指定された要件を達成するためのサンプルコードです。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-MeshSupport-MeshSupport.cs" >}}

## **カスタム視点の設定**

Aspose.CAD for .NETを使用すると、モデルレイアウトのカスタム視点を設定できます。[**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions)を使用して、カスタム視点を設定できます。以下のコードサンプルは、カスタム視点を設定する方法を示しています。

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-FreePointOfView-FreePointOfView.cs" >}}
