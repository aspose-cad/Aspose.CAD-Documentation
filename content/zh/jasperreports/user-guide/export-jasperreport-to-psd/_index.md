---
title: 导出 JasperReport 到 PSD
type: docs
weight: 90
url: /zh/jasperreports/user-guide/export-jasperreport-to-psd/
---

{{% alert color="primary" %}}

Aspose.CAD for JasperReports 提供了一个名为 ASPsdExporter 的类，用于将 JasperReport 导出为 PSD。

{{% /alert %}}

以下代码片段演示了如何将 JasperReport 导出为 PSD。

**Java**

{{< highlight java >}}

ASPsdExporter psdExporter = new ASPsdExporter();
ASPsdExportConfigurationImpl psdExportConfiguration = new ASPsdExportConfigurationImpl();
psdExportConfiguration.setColorMode(ColorModesEnum.Rgb);
psdExportConfiguration.setPsdVersion(PsdVersionEnum.Psd);
psdExportConfiguration.setCompressionMethod(CompressionMethodEnum.Raw);
psdExporter.setConfiguration(psdExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
psdExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.psd");
psdExporter.setExporterOutput(exporterOutput);

psdExporter.exportReport();

{{< /highlight >}}
