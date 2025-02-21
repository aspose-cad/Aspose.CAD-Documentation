---
title: Exporteer JasperReport naar PSD
type: docs
weight: 90
url: /nl/jasperreports/user-guide/export-jasperreport-to-psd/
---

{{% alert color="primary" %}}

Aspose.CAD voor JasperReports biedt een klasse genaamd ASPsdExporter voor het exporteren van JasperReport naar PSD.

{{% /alert %}}

De volgende codefragment laat zien hoe je de JasperReport naar PSD exporteert.

**Java**

{{< highlight java >}}

// Maak een nieuwe ASPsdExporter aan
ASPsdExporter psdExporter = new ASPsdExporter();
// Configuratie voor PSD export
ASPsdExportConfigurationImpl psdExportConfiguration = new ASPsdExportConfigurationImpl();
psdExportConfiguration.setColorMode(ColorModesEnum.Rgb);
psdExportConfiguration.setPsdVersion(PsdVersionEnum.Psd);
psdExportConfiguration.setCompressionMethod(CompressionMethodEnum.Raw);
psdExporter.setConfiguration(psdExportConfiguration);

// Stel de invoer voor de export in
exporterInput = new ASExportInputImpl(jasperPrint);
psdExporter.setExporterInput(exporterInput);

// Stel de uitvoer voor de export in
exporterOutput = new ASExporterOutputImpl("shapesExample.psd");
psdExporter.setExporterOutput(exporterOutput);

// Exporteer het rapport
psdExporter.exportReport();

{{< /highlight >}}
