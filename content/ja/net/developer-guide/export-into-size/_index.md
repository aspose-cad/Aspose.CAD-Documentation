---
title: 指定サイズへのDWG/DXF図面とレイアウトのエクスポート
type: docs
weight: 40
url: /ja/net/developer-guide/export-into-size/
---

## **A4 PDFサイズへのモデルとすべてのレイアウトのエクスポート**

Aspose.CAD APIを使用すると、DWG/DXFファイルのすべてのシートを指定された物理PDFサイズにエクスポートできます。

次のサンプルコードは、希望するPDFサイズを達成するために[**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/)オブジェクトのサイズを設定します。
A4用紙のサイズは210x297ミリメートルまたは8.27x11.69インチであり、これらの値がコードに使用されています。

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Calculate sizes for A4.cs">}}

## **異なるサイズのPDFへのCADレイアウトのエクスポート**

レイアウトをその物理サイズにエクスポートする必要がある場合があります。以下の例は、各ページのレイアウトコンテンツが自身の物理PDFサイズを持つマルチページPDFへの図面のエクスポートを示しています。この例では、[**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/layoutpagesizes/)プロパティが使用されています。

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Export to multipage with different pages sizes.cs">}}
