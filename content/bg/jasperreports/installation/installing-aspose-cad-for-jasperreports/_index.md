---
title: Инсталиране на Aspose.CAD за JasperReports
type: docs
weight: 20
url: /bg/jasperreports/installation/installing-aspose-cad-for-jasperreports/
---

За да използвате **Aspose.CAD за JasperReports** от вашето приложение, копирайте **aspose-cad-jasperreports-xx.x.jar** от папката \lib на **aspose-cad-jasperreports-xx.x.zip** в директорията JasperReports\lib или в библиотечната папка на вашето приложение. След това можете да получите достъп до експортерите програмно.

Следният пример показва типичния код, необходим за експортиране на доклад в TIFF файл, използвайки Aspose.CAD за JasperReports. Повече примери могат да бъдат намерени в демонстрационните отчети, включени в продуктовия архив.

**Java**

{{< highlight java >}}
    ASTiffExporter tiffExporter = new ASTiffExporter();
    ASTiffExportConfigurationImpl tiffExportConfiguration = new ASTiffExportConfigurationImpl(TiffExpectedFormatEnum.TiffDeflateRgb);
    tiffExportConfiguration.setArtist("Джон Смит"); // Примерен художник
    tiffExportConfiguration.setDateTime("12.08.2020"); // Дата и час
    tiffExportConfiguration.setCompression(TiffCompressionsEnum.AdobeDeflate);
    tiffExporter.setConfiguration(tiffExportConfiguration);

    exporterInput = new ASExportInputImpl(jasperPrint);
    tiffExporter.setExporterInput(exporterInput);

    exporterOutput = new ASExporterOutputImpl("shapesExample.tiff");
    tiffExporter.setExporterOutput(exporterOutput);

    tiffExporter.exportReport();
{{< /highlight >}}
