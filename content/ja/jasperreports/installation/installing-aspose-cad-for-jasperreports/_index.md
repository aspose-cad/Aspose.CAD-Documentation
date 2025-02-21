---
title: JasperReports用Aspose.CADのインストール
type: docs
weight: 20
url: /ja/jasperreports/installation/installing-aspose-cad-for-jasperreports/
---

アプリケーションから**Aspose.CAD for JasperReports**を使用するには、**aspose-cad-jasperreports-xx.x.jar**を**aspose-cad-jasperreports-xx.x.zip**の\libフォルダーからJasperReports\libディレクトリまたはアプリケーションのライブラリフォルダーにコピーします。それから、プログラムでエクスポーターにアクセスできます。

以下の例は、Aspose.CAD for JasperReportsを使用してレポートをTIFFファイルにエクスポートするために必要な典型的なコードを示しています。他の例は、製品アーカイブに含まれているデモレポートに見つけることができます。

**Java**

{{< highlight java >}}
    ASTiffExporter tiffExporter = new ASTiffExporter(); // TIFFエクスポーターのインスタンスを作成
    ASTiffExportConfigurationImpl tiffExportConfiguration = new ASTiffExportConfigurationImpl(TiffExpectedFormatEnum.TiffDeflateRgb); // エクスポート設定を構成
    tiffExportConfiguration.setArtist("ジョン・スミス"); // アーティスト名を設定
    tiffExportConfiguration.setDateTime("2020年8月12日"); // 日付と時刻を設定
    tiffExportConfiguration.setCompression(TiffCompressionsEnum.AdobeDeflate); // 圧縮形式を設定
    tiffExporter.setConfiguration(tiffExportConfiguration); // エクスポーターに設定を適用

    exporterInput = new ASExportInputImpl(jasperPrint); // エクスポート入力を作成
    tiffExporter.setExporterInput(exporterInput); // エクスポーター入力を設定

    exporterOutput = new ASExporterOutputImpl("shapesExample.tiff"); // エクスポート出力を指定
    tiffExporter.setExporterOutput(exporterOutput); // エクスポーター出力を設定

    tiffExporter.exportReport(); // レポートをエクスポート
{{< /highlight >}}
