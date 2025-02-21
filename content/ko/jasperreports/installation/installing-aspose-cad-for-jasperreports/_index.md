---
title: JasperReports용 Aspose.CAD 설치
type: docs
weight: 20
url: /ko/jasperreports/installation/installing-aspose-cad-for-jasperreports/
---

애플리케이션에서 **Aspose.CAD for JasperReports**를 사용하려면 **aspose-cad-jasperreports-xx.x.jar** 파일을 **aspose-cad-jasperreports-xx.x.zip**의 \lib 폴더에서 JasperReports\lib 디렉토리 또는 애플리케이션의 라이브러리 폴더로 복사하십시오. 그 후, 프로그래매틱하게 내보내기를 사용할 수 있습니다.

다음 예제는 Aspose.CAD for JasperReports를 사용하여 보고서를 TIFF 파일로 내보내기 위해 필요한 일반적인 코드를 보여줍니다. 더 많은 예제는 제품 아카이브에 포함된 데모 보고서에서 찾을 수 있습니다.

**Java**

{{< highlight java >}}
    ASTiffExporter tiffExporter = new ASTiffExporter();
    ASTiffExportConfigurationImpl tiffExportConfiguration = new ASTiffExportConfigurationImpl(TiffExpectedFormatEnum.TiffDeflateRgb);
    tiffExportConfiguration.setArtist("John Smith");
    tiffExportConfiguration.setDateTime("12.08.2020");
    tiffExportConfiguration.setCompression(TiffCompressionsEnum.AdobeDeflate);
    tiffExporter.setConfiguration(tiffExportConfiguration);

    exporterInput = new ASExportInputImpl(jasperPrint);
    tiffExporter.setExporterInput(exporterInput);

    exporterOutput = new ASExporterOutputImpl("shapesExample.tiff");
    tiffExporter.setExporterOutput(exporterOutput);

    tiffExporter.exportReport();
{{< /highlight >}}
