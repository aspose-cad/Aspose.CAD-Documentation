---
title: Installation von Aspose.CAD für JasperReports
type: docs
weight: 20
url: /de/jasperreports/installation/installing-aspose-cad-for-jasperreports/
---

Um **Aspose.CAD für JasperReports** von Ihrer Anwendung aus zu verwenden, kopieren Sie **aspose-cad-jasperreports-xx.x.jar** aus dem \lib-Ordner von **aspose-cad-jasperreports-xx.x.zip** in das JasperReports\lib-Verzeichnis oder in einen Bibliotheksordner Ihrer Anwendung. Danach können Sie auf die Exporteure programmgesteuert zugreifen.

Das folgende Beispiel zeigt den typischen Code, der benötigt wird, um einen Bericht unter Verwendung von Aspose.CAD für JasperReports in eine TIFF-Datei zu exportieren. Weitere Beispiele finden Sie in den Demo-Berichten, die im Produktarchiv enthalten sind.

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
