---
title: Aspose.CAD voor JasperReports installeren
type: docs
weight: 20
url: /nl/jasperreports/installation/installing-aspose-cad-for-jasperreports/
---

Om **Aspose.CAD voor JasperReports** vanuit uw applicatie te gebruiken, kopieer **aspose-cad-jasperreports-xx.x.jar** vanuit de \lib map van **aspose-cad-jasperreports-xx.x.zip** naar de JasperReports\lib directory of naar een bibliotheekmap van uw applicatie. Daarna kunt u de exporteurs programmatisch benaderen.

Het volgende voorbeeld toont de typische code die nodig is om een rapport naar een TIFF-bestand te exporteren met behulp van Aspose.CAD voor JasperReports. Meer voorbeelden zijn te vinden in de demo-rapporten die zijn opgenomen in het productarchief.

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
