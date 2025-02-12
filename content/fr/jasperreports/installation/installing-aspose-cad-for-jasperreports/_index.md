---
title: Installation d'Aspose.CAD pour JasperReports
type: docs
weight: 20
url: /fr/jasperreports/installing-aspose-cad-for-jasperreports/
---

Pour utiliser **Aspose.CAD pour JasperReports** depuis votre application, copiez **aspose-cad-jasperreports-xx.x.jar** depuis le dossier \lib de **aspose-cad-jasperreports-xx.x.zip** vers le répertoire JasperReports\lib ou vers un dossier de bibliothèque de votre application. Après cela, vous pourrez accéder aux exportateurs de manière programmatique.

L'exemple suivant montre le code typique nécessaire pour exporter un rapport vers un fichier TIFF en utilisant Aspose.CAD pour JasperReports. D'autres exemples peuvent être trouvés dans les rapports de démonstration inclus dans l'archive du produit.

**Java**

{{< highlight java >}}
    ASTiffExporter tiffExporter = new ASTiffExporter(); // Créer l'exportateur TIFF
    ASTiffExportConfigurationImpl tiffExportConfiguration = new ASTiffExportConfigurationImpl(TiffExpectedFormatEnum.TiffDeflateRgb); // Configurer l'exportation TIFF
    tiffExportConfiguration.setArtist("John Smith");
    tiffExportConfiguration.setDateTime("12.08.2020");
    tiffExportConfiguration.setCompression(TiffCompressionsEnum.AdobeDeflate);
    tiffExporter.setConfiguration(tiffExportConfiguration);

    exporterInput = new ASExportInputImpl(jasperPrint); // Définir l'entrée à exporter
    tiffExporter.setExporterInput(exporterInput);

    exporterOutput = new ASExporterOutputImpl("shapesExample.tiff"); // Définir la sortie de l'exportation
    tiffExporter.setExporterOutput(exporterOutput);

    tiffExporter.exportReport(); // Exporter le rapport
{{< /highlight >}}
