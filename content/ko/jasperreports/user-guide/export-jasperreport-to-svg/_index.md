---
title: JasperReport를 SVG로 내보내기
type: docs
weight: 40
url: /ko/jasperreports/user-guide/export-jasperreport-to-svg/
---

{{% alert color="primary" %}}

Aspose.CAD for JasperReports는 JasperReport를 SVG로 내보내기 위한 ASSvgExporter라는 클래스를 제공합니다.

{{% /alert %}}

다음 코드 스니펫은 JasperReport를 SVG로 내보내는 방법을 보여줍니다.

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
