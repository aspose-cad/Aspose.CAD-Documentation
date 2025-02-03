---
title: Εξαγωγή JasperReport σε JPEG2000
type: docs
weight: 80
url: /el/jasperreports/export-jasperreport-to-jpeg2000
---

{{% alert color="primary" %}}

Το Aspose.CAD για JasperReports παρέχει μια κλάση ονομαζόμενη ASJpeg2000Exporter για την εξαγωγή του JasperReport σε JPEG2000.

{{% /alert %}}

Το παρακάτω απόσπασμα κώδικα δείχνει πώς να εξάγετε το JasperReport σε JPEG2000.

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
