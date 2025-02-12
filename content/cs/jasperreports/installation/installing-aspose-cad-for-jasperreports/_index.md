---
title: Instalace Aspose.CAD pro JasperReports
type: docs
weight: 20
url: /cs/jasperreports/installing-aspose-cad-for-jasperreports/
---

Pro použití **Aspose.CAD pro JasperReports** ve vaší aplikaci zkopírujte soubor **aspose-cad-jasperreports-xx.x.jar** z adresáře \lib složky **aspose-cad-jasperreports-xx.x.zip** do adresáře JasperReports\lib nebo do knihovního adresáře vaší aplikace. Poté budete moci přistupovat k exportérům programově.

Následující příklad ukazuje typický kód potřebný k exportu zprávy do souboru TIFF pomocí Aspose.CAD pro JasperReports. Více příkladů lze nalézt v ukázkových zprávách zahrnutých v archivu produktu.

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
