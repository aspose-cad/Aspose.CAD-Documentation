---
title: Esporta JasperReport in JPEG2000
type: docs
weight: 80
url: /it/jasperreports/user-guide/export-jasperreport-to-jpeg2000/
---

{{% alert color="primary" %}}

Aspose.CAD per JasperReports fornisce una classe chiamata ASJpeg2000Exporter per esportare JasperReport in JPEG2000.

{{% /alert %}}

Il seguente frammento di codice dimostra come esportare il JasperReport in JPEG2000.

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
