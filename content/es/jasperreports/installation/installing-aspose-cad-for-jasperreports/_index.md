---
title: Instalación de Aspose.CAD para JasperReports
type: docs
weight: 20
url: /es/jasperreports/installing-aspose-cad-for-jasperreports/
---

Para usar **Aspose.CAD para JasperReports** desde su aplicación, copie **aspose-cad-jasperreports-xx.x.jar** de la carpeta \lib de **aspose-cad-jasperreports-xx.x.zip** al directorio JasperReports\lib o a una carpeta de bibliotecas de su aplicación. Después de eso, puede acceder a los exportadores programáticamente.

El siguiente ejemplo muestra el código típico necesario para exportar un informe a un archivo TIFF utilizando Aspose.CAD para JasperReports. Más ejemplos se pueden encontrar en los informes de demostración incluidos en el archivo del producto.

**Java**

{{< highlight java >}}
    // Inicializa el exportador TIFF
    ASTiffExporter tiffExporter = new ASTiffExporter();
    ASTiffExportConfigurationImpl tiffExportConfiguration = new ASTiffExportConfigurationImpl(TiffExpectedFormatEnum.TiffDeflateRgb);
    tiffExportConfiguration.setArtist("John Smith");
    tiffExportConfiguration.setDateTime("12.08.2020");
    tiffExportConfiguration.setCompression(TiffCompressionsEnum.AdobeDeflate);
    tiffExporter.setConfiguration(tiffExportConfiguration);

    // Configura la entrada del exportador
    exporterInput = new ASExportInputImpl(jasperPrint);
    tiffExporter.setExporterInput(exporterInput);

    // Configura la salida del exportador
    exporterOutput = new ASExporterOutputImpl("shapesExample.tiff");
    tiffExporter.setExporterOutput(exporterOutput);

    // Exporta el informe
    tiffExporter.exportReport();
{{< /highlight >}}
