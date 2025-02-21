---
title: Esportare JasperReport in PSD
type: docs
weight: 90
url: /it/jasperreports/user-guide/export-jasperreport-to-psd/
---

{{% alert color="primary" %}}

Aspose.CAD per JasperReports fornisce una classe chiamata ASPsdExporter per esportare JasperReport in PSD.

{{% /alert %}}

Il seguente frammento di codice dimostra come esportare JasperReport in PSD.

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
