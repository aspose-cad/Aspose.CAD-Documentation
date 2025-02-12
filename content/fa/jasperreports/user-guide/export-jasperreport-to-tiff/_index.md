---
title: صادر کردن JasperReport به TIFF
type: docs
weight: 100
url: /fa/jasperreports/export-jasperreport-to-tiff
---

{{% alert color="primary" %}}

Aspose.CAD برای JasperReports یک کلاس به نام ASTiffExporter برای صادر کردن JasperReport به TIFF ارائه می‌دهد.

{{% /alert %}}

قطعه کد زیر نشان می‌دهد که چگونه می‌توان JasperReport را به TIFF صادر کرد.

**Java**

{{< highlight java >}}

ASTiffExporter tiffExporter = new ASTiffExporter();
ASTiffExportConfigurationImpl tiffExportConfiguration = new ASTiffExportConfigurationImpl(TiffExpectedFormatEnum.TiffDeflateRgb);
tiffExportConfiguration.setArtist("جان اسمیت");
tiffExportConfiguration.setDateTime("12.08.2020");
tiffExportConfiguration.setCompression(TiffCompressionsEnum.AdobeDeflate);
tiffExporter.setConfiguration(tiffExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
tiffExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.tiff");
tiffExporter.setExporterOutput(exporterOutput);

tiffExporter.exportReport();

{{< /highlight >}}
