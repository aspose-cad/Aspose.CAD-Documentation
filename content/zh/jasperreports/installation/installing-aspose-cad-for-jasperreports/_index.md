---
title: 安装 Aspose.CAD for JasperReports
type: docs
weight: 20
url: /zh/jasperreports/installation/installing-aspose-cad-for-jasperreports/
---

要在您的应用程序中使用 **Aspose.CAD for JasperReports**，请将 **aspose-cad-jasperreports-xx.x.jar** 从 **aspose-cad-jasperreports-xx.x.zip** 的 \lib 文件夹复制到 JasperReports\lib 目录或您应用程序的库文件夹中。之后，您可以以编程方式访问导出器。

以下示例显示了使用 Aspose.CAD for JasperReports 将报告导出到 TIFF 文件所需的典型代码。更多示例可以在产品档案中包含的演示报告中找到。

**Java**

{{< highlight java >}}
    ASTiffExporter tiffExporter = new ASTiffExporter();
    ASTiffExportConfigurationImpl tiffExportConfiguration = new ASTiffExportConfigurationImpl(TiffExpectedFormatEnum.TiffDeflateRgb);
    tiffExportConfiguration.setArtist("John Smith");
    tiffExportConfiguration.setDateTime("12.08.2020");
    tiffExportConfiguration.setCompression(TiffCompressionsEnum.AdobeDeflate);
    tiffExporter.setConfiguration(tiffExportConfiguration);

    exporterInput = new ASExportInputImpl(jasperPrint);
    tiffExporter.setExporterInput(exporterInput);

    exporterOutput = new ASExporterOutputImpl("shapesExample.tiff");
    tiffExporter.setExporterOutput(exporterOutput);

    tiffExporter.exportReport();
{{< /highlight >}}
