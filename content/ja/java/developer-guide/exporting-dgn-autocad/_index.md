---
title: DGN AutoCADのエクスポート
type: docs
weight: 50
url: /ja/java/developer-guide/exporting-dgn-autocad/
---

## **DGN AutoCADフォーマットをPDFにエクスポートする**

Aspose.CAD for Java APIは、[DGN](https://docs.fileformat.com/cad/dgn/) AutoCADファイルをロードし、それを[PDF](https://docs.fileformat.com/pdf/)フォーマットに変換する機能を導入しました。[**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage)クラスがその目的を果たします。

既存のDGNファイルを[**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage)としてロードする必要があります。[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions)クラスのインスタンスを作成し、さまざまなプロパティを設定します。[**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/pdfoptions)クラスのインスタンスを作成し、[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions)インスタンスを渡します。次に、[**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage)クラスインスタンスの[**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--)メソッドを呼び出します。

### サンプルコード

以下は、DGNをPDFフォーマットに変換/エクスポートするコードのデモです。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToPDF-ExportingDGNAutoCADFormatToPDF.java" >}}

## **DGN AutoCADフォーマットをラスター画像フォーマットにエクスポートする**

Aspose.CAD for Java APIは、[DGN](https://docs.fileformat.com/cad/dgn/) AutoCADファイルをロードし、それをラスター画像に変換する機能を導入しました。[**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage)クラスがその目的を果たします。

既存のDGNファイルを[**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage)としてロードする必要があります。[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions)クラスのインスタンスを作成し、さまざまなプロパティを設定します。[**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions)クラスのインスタンスを作成し、[**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions)インスタンスを渡します。次に、[**DgnImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.dgn/DgnImage)クラスインスタンスの[**save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--)メソッドを呼び出します。

### サンプルコード

以下は、[DGN](https://docs.fileformat.com/cad/dgn/)を[JPEG](https://docs.fileformat.com/image/jpeg/)画像に変換/エクスポートするコードのデモです。

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportingDGNAutoCADFormatToRasterImageFormat-ExportingDGNAutoCADFormatToRasterImageFormat.java" >}}
