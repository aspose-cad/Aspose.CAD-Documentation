---
title: Εξαγωγή JasperReport σε SVG
type: docs
weight: 40
url: /el/jasperreports/export-jasperreport-to-svg
---

{{% alert color="primary" %}}

Η Aspose.CAD για JasperReports παρέχει μια κλάση που ονομάζεται ASSvgExporter για την εξαγωγή του JasperReport σε SVG.

{{% /alert %}}

Το παρακάτω απόσπασμα κώδικα δείχνει πώς να εξαγάγετε το JasperReport σε SVG.

**Java**

{{< highlight java >}}

ASSvgExporter svgExporter = new ASSvgExporter();
ASSvgExportConfigurationImpl svgExportConfiguration = new ASSvgExportConfigurationImpl();
svgExportConfiguration.setEmbedFonts(true); // Ενσωματώστε γραμματοσειρές
svgExportConfiguration.setCompress(true); // Συμπίεση

svgExporter.setConfiguration(svgExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
svgExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.svg");
svgExporter.setExporterOutput(exporterOutput);

svgExporter.exportReport();

{{< /highlight >}}
