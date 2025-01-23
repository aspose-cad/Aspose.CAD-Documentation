---
title: JasperReport nach JPEG2000 exportieren
type: docs
weight: 80
url: /de/jasperreports/export-jasperreport-to-jpeg2000
---

{{% alert color="primary" %}}

Aspose.CAD für JasperReports stellt eine Klasse mit dem Namen ASJpeg2000Exporter bereit, um einen JasperReport nach JPEG2000 zu exportieren.

{{% /alert %}}

Der folgende Code-Ausschnitt zeigt, wie man den JasperReport nach JPEG2000 exportiert.

**Java**

{{< highlight java >}}

ASJpeg2000Exporter jpeg2000Exporter = new ASJpeg2000Exporter();
ASJpeg2000ExportConfigurationImpl jpeg2000ExportConfiguration = new ASJpeg2000ExportConfigurationImpl();
jpeg2000ExportConfiguration.setIrreversible(true);
jpeg2000ExportConfiguration.setCodec(Jpeg2000CodecEnum.J2K);
jpeg2000Exporter.setConfiguration(jpeg2000ExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
jpeg2000Exporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.jp2");
jpeg2000Exporter.setExporterOutput(exporterOutput);

jpeg2000Exporter.exportReport();

{{< /highlight >}}
