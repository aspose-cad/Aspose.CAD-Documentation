---
title: 指定サイズへのDWG/DXF図面とレイアウトのエクスポート
type: docs
weight: 40
url: /ja/java/developer-guide/export-into-size/
---

## **A4 PDFサイズへのモデルとすべてのレイアウトのエクスポート**

Aspose.CAD APIは、DWG/DXFファイルのすべてのシートを指定された物理PDFサイズにエクスポートすることを可能にします。
以下のサンプルコードは、所望のPDFサイズを達成するために[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions/)オブジェクトのサイズを設定します。
A4用紙のサイズは210x297ミリメートル（8.27x11.69インチ）であり、これらの値がコードに使用されています。

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "set-page-size.java">}}

## **異なるサイズのPDFへのCADレイアウトのエクスポート**

時には、レイアウトをその物理サイズでエクスポートする必要があります。以下の例は、各ページにレイアウトコンテンツを持つマルチページPDFへの図面のエクスポートを示しています。
この例では、[**getLayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#getLayoutPageSizes--)プロパティを使用しています。

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "export-different-pages-sizes.java">}}
