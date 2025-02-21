---
title: Instalando Aspose.CAD para JasperReports
type: docs
weight: 20
url: /pt/jasperreports/installation/installing-aspose-cad-for-jasperreports/
---

Para usar **Aspose.CAD para JasperReports** em sua aplicação, copie **aspose-cad-jasperreports-xx.x.jar** da pasta \lib do **aspose-cad-jasperreports-xx.x.zip** para o diretório JasperReports\lib ou para uma pasta de bibliotecas de sua aplicação. Depois disso, você pode acessar os exportadores programaticamente.

O seguinte exemplo mostra o código típico necessário para exportar um relatório para um arquivo TIFF usando Aspose.CAD para JasperReports. Mais exemplos podem ser encontrados nos relatórios de demonstração incluídos no arquivo do produto.

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
