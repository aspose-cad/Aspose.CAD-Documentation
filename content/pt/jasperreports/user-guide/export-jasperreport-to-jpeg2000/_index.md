---
title: Exportar JasperReport para JPEG2000
type: docs
weight: 80
url: /pt/jasperreports/user-guide/export-jasperreport-to-jpeg2000/
---

{{% alert color="primary" %}}

Aspose.CAD para JasperReports fornece uma classe chamada ASJpeg2000Exporter para exportar JasperReport para JPEG2000.

{{% /alert %}}

O seguinte trecho de código demonstra como exportar o JasperReport para JPEG2000.

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
