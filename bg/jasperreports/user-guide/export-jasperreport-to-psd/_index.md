---
title: Експорт на JasperReport в PSD
type: docs
weight: 90
url: /bg/jasperreports/export-jasperreport-to-psd
---

{{% alert color="primary" %}}

Aspose.CAD за JasperReports предоставя клас, наречен ASPsdExporter, за експортиране на JasperReport в PSD.

{{% /alert %}}

Следващият кодов фрагмент демонстрира как да се експортира JasperReport в PSD.

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
