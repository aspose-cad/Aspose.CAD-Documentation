---
title: Експортиране на JasperReport в SVG
type: docs
weight: 40
url: /bg/jasperreports/user-guide/export-jasperreport-to-svg/
---

{{% alert color="primary" %}}

Aspose.CAD за JasperReports предоставя клас на име ASSvgExporter за експортиране на JasperReport в SVG.

{{% /alert %}}

Следният кодов фрагмент демонстрира как да се експортира JasperReport в SVG.

**Java**

{{< highlight java >}}
// Инициализация на SVG експортер
ASSvgExporter svgExporter = new ASSvgExporter();
ASSvgExportConfigurationImpl svgExportConfiguration = new ASSvgExportConfigurationImpl();
// Включване на шрифтовете в експортирания SVG
svgExportConfiguration.setEmbedFonts(true);
// Включване на компресия
svgExportConfiguration.setCompress(true);

svgExporter.setConfiguration(svgExportConfiguration);

// Задаване на входа за експортиране
exporterInput = new ASExportInputImpl(jasperPrint);
svgExporter.setExporterInput(exporterInput);

// Задаване на изхода за експортиране
exporterOutput = new ASExporterOutputImpl("shapesExample.svg");
svgExporter.setExporterOutput(exporterOutput);

// Извършване на експорта на отчета
svgExporter.exportReport();
{{< /highlight >}}
