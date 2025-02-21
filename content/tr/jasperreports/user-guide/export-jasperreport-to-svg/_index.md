---
title: JasperReport'u SVG'ye Aktarma
type: docs
weight: 40
url: /tr/jasperreports/user-guide/export-jasperreport-to-svg/
---

{{% alert color="primary" %}}

Aspose.CAD for JasperReports, JasperReport'u SVG'ye aktarmak için ASSvgExporter adında bir sınıf sunar.

{{% /alert %}}

Aşağıdaki kod örneği, JasperReport'u SVG'ye aktarmanın nasıl yapıldığını gösterir.

**Java**

{{< highlight java >}}

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
