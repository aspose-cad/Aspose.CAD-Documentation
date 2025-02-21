---
title: Instalowanie Aspose.CAD dla JasperReports
type: docs
weight: 20
url: /pl/jasperreports/installation/installing-aspose-cad-for-jasperreports/
---

Aby używać **Aspose.CAD dla JasperReports** z Twojej aplikacji, skopiuj **aspose-cad-jasperreports-xx.x.jar** z folderu \lib pliku **aspose-cad-jasperreports-xx.x.zip** do katalogu JasperReports\lib lub do folderu biblioteki Twojej aplikacji. Po tym możesz uzyskać dostęp do eksporterów programowo.

Poniższy przykład pokazuje typowy kod potrzebny do eksportu raportu do pliku TIFF przy użyciu Aspose.CAD dla JasperReports. Więcej przykładów można znaleźć w raportach demo dołączonych do archiwum produktu.

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
