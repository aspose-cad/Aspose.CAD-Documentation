---
title: DWF図面
type: docs
weight: 50
url: /ja/python-net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **DWF図面をPDFにエクスポートする**

Aspose.CADは、AutoCADの[DWF](https://docs.fileformat.com/cad/dwf/)図面エンティティをロードし、全体の図面を[PDF](https://docs.fileformat.com/pdf/)形式にレンダリングする機能を提供します。[DWF](https://docs.fileformat.com/cad/dwf/)から[PDF](https://docs.fileformat.com/pdf/)への変換アプローチは次のように機能します：

1. **Image.load**ファクトリメソッドを使用して[DWF](https://docs.fileformat.com/cad/dwf/)図面ファイルをロードします。
1. **CadRasterizationOptions**クラスのオブジェクトを作成し、**page_height**および**page_width**プロパティを設定します。
1. **PdfOptions**クラスのオブジェクトを作成し、**vector_rasterization_options**プロパティを設定します。
1. **Image.save**を呼び出し、**PdfOptions**のオブジェクトを2番目のパラメーターとして渡します。

### サンプルコード

以下のコードサンプルでは、デフォルト設定を使用してファイルを変換する方法を示しています。


{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-PDF-Export.py" >}}

## **DWF図面をBMPにエクスポートする**

Aspose.CADは、AutoCADの[DWF](https://docs.fileformat.com/cad/dwf/)図面エンティティをロードし、全体の図面を[BMP](https://docs.fileformat.com/image/bmp/)形式にレンダリングする機能を提供します。[DWF](https://docs.fileformat.com/cad/dwf/)から[BMP](https://docs.fileformat.com/image/bmp/)への変換アプローチは次のように機能します：

1. **Image.load**ファクトリメソッドを使用して[DWF](https://docs.fileformat.com/cad/dwf/)図面ファイルをロードします。
1. **CadRasterizationOptions**クラスのオブジェクトを作成し、**page_height**および**page_width**プロパティを設定します。
1. **BmpOptions**クラスのオブジェクトを作成し、**vector_rasterization_options**プロパティを設定します。
1. **Image.save**を呼び出し、**BmpOptions**のオブジェクトを2番目のパラメーターとして渡します。

### サンプルコード

以下のコードサンプルでは、デフォルト設定を使用して[DWF](https://docs.fileformat.com/cad/dwf/)ファイルを[BMP](https://docs.fileformat.com/image/bmp/)に変換する方法を示しています。

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-BMP-Export.py" >}}
