---
title: Installing Aspose.CAD for JasperReports
type: docs
weight: 20
url: /jasperreports/installation/installing-aspose-cad-for-jasperreports/
---

To use **Aspose.CAD for JasperReports** from your application, copy **aspose-cad-jasperreports-xx.x.jar** from the \lib folder of **aspose-cad-jasperreports-xx.x.zip** to the JasperReports\lib directory or to a library folder of your application. After that, you can access the exporters programmatically.

The following example shows the typical code needed to export a report to an TIFF file using Aspose.CAD for JasperReports. More examples can be found in the demo reports included in the product archive.

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
