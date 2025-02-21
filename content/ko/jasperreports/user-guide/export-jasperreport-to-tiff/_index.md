---
title: JasperReport를 TIFF로 내보내기
type: docs
weight: 100
url: /ko/jasperreports/user-guide/export-jasperreport-to-tiff/
---

{{% alert color="primary" %}}

Aspose.CAD for JasperReports는 JasperReport를 TIFF로 내보내기 위해 ASTiffExporter라는 클래스를 제공합니다.

{{% /alert %}}

다음 코드 스 니펫은 JasperReport를 TIFF로 내보내는 방법을 보여줍니다.

**Java**

{{< highlight java >}}

ASTiffExporter tiffExporter = new ASTiffExporter();
ASTiffExportConfigurationImpl tiffExportConfiguration = new ASTiffExportConfigurationImpl(TiffExpectedFormatEnum.TiffDeflateRgb);
tiffExportConfiguration.setArtist("존 스미스"); // 아티스트 이름 설정
tiffExportConfiguration.setDateTime("2020.08.12"); // 날짜 및 시간 설정
tiffExportConfiguration.setCompression(TiffCompressionsEnum.AdobeDeflate);
tiffExporter.setConfiguration(tiffExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
tiffExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.tiff");
tiffExporter.setExporterOutput(exporterOutput);

tiffExporter.exportReport();

{{< /highlight >}}
