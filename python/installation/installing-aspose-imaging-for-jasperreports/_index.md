---
title: Installing Aspose.CAD for Pythons
type: docs
weight: 20
url: /pythons/installing-aspose-cad-for-pythons/
---

To use **Aspose.CAD for Pythons** from your application, copy **aspose-cad-pythons-xx.x.jar** from the \lib folder of **aspose-cad-pythons-xx.x.zip** to the Pythons\lib directory or to a library folder of your application. After that, you can access the exporters programmatically.

The following example shows the typical code needed to export a report to an TIFF file using Aspose.CAD for Pythons. More examples can be found in the demo reports included in the product archive.

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
