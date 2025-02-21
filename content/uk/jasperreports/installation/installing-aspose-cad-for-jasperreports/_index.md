---
title: Встановлення Aspose.CAD для JasperReports
type: docs
weight: 20
url: /uk/jasperreports/installation/installing-aspose-cad-for-jasperreports/
---

Щоб використовувати **Aspose.CAD для JasperReports** у вашій програмі, скопіюйте **aspose-cad-jasperreports-xx.x.jar** з папки \lib файлу **aspose-cad-jasperreports-xx.x.zip** до каталогу JasperReports\lib або до бібліотечної папки вашої програми. Після цього ви зможете отримати доступ до експортера програмно.

Наступний приклад показує типовий код, необхідний для експорту звіту у файл TIFF, використовуючи Aspose.CAD для JasperReports. Більше прикладів можна знайти у демонстраційних звітах, що входять до архіву продукту.

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
