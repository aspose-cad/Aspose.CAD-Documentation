---
title: Экспорт JasperReport в PSD
type: docs
weight: 90
url: /ru/jasperreports/user-guide/export-jasperreport-to-psd/
---

{{% alert color="primary" %}}

Aspose.CAD для JasperReports предоставляет класс под названием ASPsdExporter для экспорта JasperReport в PSD.

{{% /alert %}}

Следующий фрагмент кода демонстрирует, как экспортировать JasperReport в PSD.

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
