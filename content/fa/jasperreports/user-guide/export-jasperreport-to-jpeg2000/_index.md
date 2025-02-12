---
title: صادرات JasperReport به JPEG2000
type: docs
weight: 80
url: /fa/jasperreports/export-jasperreport-to-jpeg2000
---

{{% alert color="primary" %}}

Aspose.CAD برای JasperReports یک کلاسی به نام ASJpeg2000Exporter برای صادرات JasperReport به JPEG2000 فراهم می‌کند.

{{% /alert %}}

قطعه کد زیر نشان می‌دهد که چگونه می‌توان JasperReport را به JPEG2000 صادر کرد.

**جاوا**

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
