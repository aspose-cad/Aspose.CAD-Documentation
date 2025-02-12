---
title: نصب Aspose.CAD برای JasperReports
type: docs
weight: 20
url: /fa/jasperreports/installation/installing-aspose-cad-for-jasperreports/
---

برای استفاده از **Aspose.CAD برای JasperReports** در برنامه خود، **aspose-cad-jasperreports-xx.x.jar** را از پوشه \lib پرونده **aspose-cad-jasperreports-xx.x.zip** به دایرکتوری JasperReports\lib یا به یک پوشه کتابخانه از برنامه خود کپی کنید. پس از آن، می‌توانید به صورت برنامه‌نویسی به صادرکنندگان دسترسی پیدا کنید.

مثال زیر کد معمولی مورد نیاز برای صادر کردن یک گزارش به یک فایل TIFF با استفاده از Aspose.CAD برای JasperReports را نشان می‌دهد. مثال‌های بیشتری را می‌توان در گزارش‌های نمایشی گنجانده شده در بایگانی محصول یافت.

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
