---
title: Installazione di Aspose.CAD per JasperReports
type: docs
weight: 20
url: /it/jasperreports/installation/installing-aspose-cad-for-jasperreports/
---

Per utilizzare **Aspose.CAD per JasperReports** dalla tua applicazione, copia **aspose-cad-jasperreports-xx.x.jar** dalla cartella \lib di **aspose-cad-jasperreports-xx.x.zip** nella directory JasperReports\lib o in una cartella di librerie della tua applicazione. Dopo di che, puoi accedere agli esportatori in modo programmatico.

Il seguente esempio mostra il codice tipico necessario per esportare un report in un file TIFF utilizzando Aspose.CAD per JasperReports. Ulteriori esempi possono essere trovati nei report demo inclusi nell'archivio del prodotto.

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
