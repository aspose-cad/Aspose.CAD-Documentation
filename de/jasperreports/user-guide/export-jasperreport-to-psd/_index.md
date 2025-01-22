---
title: JasperReport nach PSD exportieren
type: docs
weight: 90
url: /de/jasperreports/jasperreport-nach-psd-exportieren
---

{{% alert color="primary" %}}

Aspose.CAD für JasperReports stellt eine Klasse namens ASPsdExporter zum Exportieren von JasperReport nach PSD bereit.

{{% /alert %}}

Der folgende Code-Schnipsel zeigt, wie der JasperReport nach PSD exportiert wird.

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
