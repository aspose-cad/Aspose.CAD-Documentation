---
title: Installera Aspose.CAD för JasperReports
type: docs
weight: 20
url: /sv/jasperreports/installation/installing-aspose-cad-for-jasperreports/
---

För att använda **Aspose.CAD för JasperReports** i din applikation, kopiera **aspose-cad-jasperreports-xx.x.jar** från \lib-mappen i **aspose-cad-jasperreports-xx.x.zip** till JasperReports\lib-katalogen eller till en biblioteksmapp i din applikation. Efter det kan du programmässigt få åtkomst till exportörerna.

Följande exempel visar den typiska koden som behövs för att exportera en rapport till en TIFF-fil med hjälp av Aspose.CAD för JasperReports. Fler exempel finns i demoreferenserna som ingår i produktarkivet.

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
