---
title: JasperReport를 WMF로 내보내기
type: docs
weight: 30
url: /ko/jasperreports/user-guide/export-jasperreport-to-wmf/
---

{{% alert color="primary" %}}

Aspose.CAD for JasperReports는 JasperReport를 WMF로 내보내기 위한 ASWmfExporter라는 클래스를 제공합니다.

{{% /alert %}}

다음 코드 조각은 JasperReport를 WMF로 내보내는 방법을 설명합니다.

**Java**

{{< highlight java >}}

// 예제 1

ASWmfExporter wmfExporter = new ASWmfExporter();
ASWmfExportConfigurationImpl wmfExportConfiguration = new ASWmfExportConfigurationImpl();
wmfExporter.setConfiguration(wmfExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
wmfExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.wmf");
wmfExporter.setExporterOutput(exporterOutput);

wmfExporter.exportReport();

{{< /highlight >}}
