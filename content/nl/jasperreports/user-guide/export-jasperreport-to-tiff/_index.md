---
title: Exporteer JasperReport naar TIFF
type: docs
weight: 100
url: /nl/jasperreports/user-guide/export-jasperreport-to-tiff/
---

{{% alert color="primary" %}}

Aspose.CAD voor JasperReports biedt een klasse genaamd ASTiffExporter voor het exporteren van JasperReport naar TIFF.

{{% /alert %}}

De volgende codefragment demonstreert hoe u de JasperReport naar TIFF kunt exporteren.

**Java**

{{< highlight java >}}

// ASTiffExporter is de klasse die we gebruiken voor de export
ASTiffExporter tiffExporter = new ASTiffExporter();
// Configuratie voor het exporteren naar TIFF
ASTiffExportConfigurationImpl tiffExportConfiguration = new ASTiffExportConfigurationImpl(TiffExpectedFormatEnum.TiffDeflateRgb);
tiffExportConfiguration.setArtist("John Smith");
tiffExportConfiguration.setDateTime("12.08.2020");
tiffExportConfiguration.setCompression(TiffCompressionsEnum.AdobeDeflate);
tiffExporter.setConfiguration(tiffExportConfiguration);

// Hier stellen we de invoer voor de export in
exporterInput = new ASExportInputImpl(jasperPrint);
tiffExporter.setExporterInput(exporterInput);

// Hier stellen we de uitvoer voor de export in
exporterOutput = new ASExporterOutputImpl("shapesExample.tiff");
tiffExporter.setExporterOutput(exporterOutput);

// Exporteer het rapport
tiffExporter.exportReport();

{{< /highlight >}}
