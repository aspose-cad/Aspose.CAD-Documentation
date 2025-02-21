---
title: OBJファイル形式の操作
type: docs
weight: 120
url: /ja/javascript-net/developer-guide/cad-and-bim-drawings/working-with-obj-file-format/
---

{{% alert color="primary" %}}

Aspose.CADは現在、OBJファイル形式をサポートしています。OBJファイル形式は、テクスチャマップ、3D座標、ポリゴン面、その他のオブジェクト情報を含む3Dジオメトリです。

{{% /alert %}}

## **OBJ形式をPNGにエクスポートする**

Aspose.CAD for Javascript in Angularでは、開発者が[OBJ](https://docs.fileformat.com/3d/obj/)ファイルを[PNG](https://docs.fileformat.com/image/png/)形式にエクスポートできます。
[OBJ](https://docs.fileformat.com/3d/obj/)から[PNG](https://docs.fileformat.com/image/png/)への変換アプローチは、以下のように機能します：

1. **Image.load**メソッドを使用して[OBJ](https://docs.fileformat.com/3d/obj/)描画ファイルをロードします。
2. **PngOptions**のオブジェクトを第二引数として渡し、**Image.save**を呼び出します。

## サンプルコード

以下のコードは、Aspose.CAD for JavaScriptを使用して同じ目標を達成する方法を示しています。

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-OBJ-to-PNG-Export.js" >}}
