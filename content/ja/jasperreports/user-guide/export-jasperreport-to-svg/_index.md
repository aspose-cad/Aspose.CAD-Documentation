---
title: JasperReportをSVGにエクスポート
type: docs
weight: 40
url: /ja/jasperreports/user-guide/export-jasperreport-to-svg/
---

{{% alert color="primary" %}}

Aspose.CAD for JasperReportsは、JasperReportをSVGにエクスポートするためのASSvgExporterというクラスを提供しています。

{{% /alert %}}

以下のコードスニペットは、JasperReportをSVGにエクスポートする方法を示しています。

**Java**

{{< highlight java >}}

// SVGエクスポーターを作成
ASSvgExporter svgExporter = new ASSvgExporter();
ASSvgExportConfigurationImpl svgExportConfiguration = new ASSvgExportConfigurationImpl();
svgExportConfiguration.setEmbedFonts(true);
svgExportConfiguration.setCompress(true);

svgExporter.setConfiguration(svgExportConfiguration);

// エクスポート入力を設定
exporterInput = new ASExportInputImpl(jasperPrint);
svgExporter.setExporterInput(exporterInput);

// エクスポート出力を設定
exporterOutput = new ASExporterOutputImpl("shapesExample.svg");
svgExporter.setExporterOutput(exporterOutput);

// レポートをエクスポート
svgExporter.exportReport();

{{< /highlight >}}
