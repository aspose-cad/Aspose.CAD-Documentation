---
title: Exportování JasperReport do formátu PSD
type: docs
weight: 90
url: /cs/jasperreports/export-jasperreport-to-psd
---

{{% alert color="primary" %}}

Aspose.CAD pro JasperReports poskytuje třídu nazvanou ASPsdExporter pro export JasperReportu do formátu PSD.

{{% /alert %}}

Následující ukázka kódu demonstruje, jak exportovat JasperReport do formátu PSD.

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
