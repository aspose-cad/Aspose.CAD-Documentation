---
title: Экспорт JasperReport в TIFF
type: docs
weight: 100
url: /ru/jasperreports/user-guide/export-jasperreport-to-tiff/
---

{{% alert color="primary" %}}

Aspose.CAD для JasperReports предоставляет класс под названием ASTiffExporter для экспорта JasperReport в TIFF.

{{% /alert %}}

Следующий фрагмент кода демонстрирует, как экспортировать JasperReport в TIFF.

**Java**

{{< highlight java >}}

ASTiffExporter tiffExporter = new ASTiffExporter();
ASTiffExportConfigurationImpl tiffExportConfiguration = new ASTiffExportConfigurationImpl(TiffExpectedFormatEnum.TiffDeflateRgb);
tiffExportConfiguration.setArtist("Джон Смит");
tiffExportConfiguration.setDateTime("12.08.2020");
tiffExportConfiguration.setCompression(TiffCompressionsEnum.AdobeDeflate);
tiffExporter.setConfiguration(tiffExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
tiffExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.tiff");
tiffExporter.setExporterOutput(exporterOutput);

tiffExporter.exportReport();

{{< /highlight >}}
