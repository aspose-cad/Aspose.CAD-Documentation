---
title: Eksportuj JasperReport do SVG
type: docs
weight: 40
url: /pl/jasperreports/user-guide/export-jasperreport-to-svg/
---

{{% alert color="primary" %}}

Aspose.CAD dla JasperReports udostępnia klasę o nazwie ASSvgExporter do eksportowania JasperReport do SVG.

{{% /alert %}}

Poniższy fragment kodu demonstruje, jak eksportować JasperReport do SVG.

**Java**

{{< highlight java >}}

/// Komentarz: Inicjalizacja eksportera SVG
ASSvgExporter svgExporter = new ASSvgExporter();
ASSvgExportConfigurationImpl svgExportConfiguration = new ASSvgExportConfigurationImpl();
svgExportConfiguration.setEmbedFonts(true); // Komentarz: Osadź czcionki
svgExportConfiguration.setCompress(true); // Komentarz: Kompresuj eksport

svgExporter.setConfiguration(svgExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
svgExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.svg");
svgExporter.setExporterOutput(exporterOutput);

svgExporter.exportReport(); // Komentarz: Eksportuj raport

{{< /highlight >}}
