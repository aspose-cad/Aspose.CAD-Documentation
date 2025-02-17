---
title: ייצוא JasperReport ל-SVG
type: docs
weight: 40
url: /he/jasperreports/user-guide/export-jasperreport-to-svg/
---

{{% alert color="primary" %}}

Aspose.CAD עבור JasperReports מספקת מחלקה בשם ASSvgExporter לייצוא JasperReport ל-SVG.

{{% /alert %}}

קטע הקוד הבא מדגים כיצד לייצא את JasperReport ל-SVG.

**Java**

{{< highlight java >}}

// קוד לייצוא JasperReport ל-SVG
ASSvgExporter svgExporter = new ASSvgExporter();
ASSvgExportConfigurationImpl svgExportConfiguration = new ASSvgExportConfigurationImpl();
svgExportConfiguration.setEmbedFonts(true);
svgExportConfiguration.setCompress(true);

svgExporter.setConfiguration(svgExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
svgExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.svg");
svgExporter.setExporterOutput(exporterOutput);

svgExporter.exportReport();

{{< /highlight >}}
