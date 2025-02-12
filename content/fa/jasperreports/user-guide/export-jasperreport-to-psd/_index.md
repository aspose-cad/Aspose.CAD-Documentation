---
title: صادرات JasperReport به PSD
type: docs
weight: 90
url: /fa/jasperreports/export-jasperreport-to-psd
---

{{% alert color="primary" %}}

Aspose.CAD برای JasperReports کلاسی به نام ASPsdExporter را برای صادرات JasperReport به PSD فراهم می‌کند.

{{% /alert %}}

کد نمونه زیر نشان می‌دهد که چگونه می‌توان JasperReport را به PSD صادر کرد.

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
