---
title: Установка Aspose.CAD для JasperReports
type: docs
weight: 20
url: /ru/jasperreports/installation/installing-aspose-cad-for-jasperreports/
---

Чтобы использовать **Aspose.CAD для JasperReports** в вашем приложении, скопируйте **aspose-cad-jasperreports-xx.x.jar** из папки \lib **aspose-cad-jasperreports-xx.x.zip** в директорию JasperReports\lib или в папку библиотек вашего приложения. После этого вы сможете получить доступ к экспортерам программно.

Следующий пример показывает типичный код, необходимый для экспорта отчета в файл TIFF с использованием Aspose.CAD для JasperReports. Больше примеров можно найти в демонстрационных отчетах, включенных в архив продукта.

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
