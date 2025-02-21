---
title: Exportera JasperReport till PSD
type: docs
weight: 90
url: /sv/jasperreports/user-guide/export-jasperreport-to-psd/
---

{{% alert color="primary" %}}

Aspose.CAD för JasperReports tillhandahåller en klass som heter ASPsdExporter för att exportera JasperReport till PSD.

{{% /alert %}}

Följande koden-snutt visar hur du exporterar JasperReport till PSD.

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
