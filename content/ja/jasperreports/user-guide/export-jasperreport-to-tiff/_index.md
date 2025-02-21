---
title: JasperReportをTIFFにエクスポート
type: docs
weight: 100
url: /ja/jasperreports/user-guide/export-jasperreport-to-tiff/
---

{{% alert color="primary" %}}

Aspose.CAD for JasperReportsは、JasperReportをTIFFにエクスポートするためのASTiffExporterというクラスを提供します。

{{% /alert %}}

次のコードスニペットは、JasperReportをTIFFにエクスポートする方法を示しています。

**Java**

{{< highlight java >}}

ASTiffExporter tiffExporter = new ASTiffExporter();
ASTiffExportConfigurationImpl tiffExportConfiguration = new ASTiffExportConfigurationImpl(TiffExpectedFormatEnum.TiffDeflateRgb);
tiffExportConfiguration.setArtist("John Smith"); // アーティスト名を設定
tiffExportConfiguration.setDateTime("12.08.2020"); // 日付を設定
tiffExportConfiguration.setCompression(TiffCompressionsEnum.AdobeDeflate);
tiffExporter.setConfiguration(tiffExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
tiffExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.tiff");
tiffExporter.setExporterOutput(exporterOutput);

tiffExporter.exportReport();

{{< /highlight >}}
