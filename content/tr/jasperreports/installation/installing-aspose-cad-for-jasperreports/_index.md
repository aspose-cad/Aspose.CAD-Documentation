---
title: Aspose.CAD'in JasperReports için Kurulumu
type: docs
weight: 20
url: /tr/jasperreports/installation/installing-aspose-cad-for-jasperreports/
---

Uygulamanızdan **Aspose.CAD for JasperReports**'i kullanmak için, **aspose-cad-jasperreports-xx.x.jar** dosyasını **aspose-cad-jasperreports-xx.x.zip**'in \lib klasöründen JasperReports\lib dizinine veya uygulamanızın bir kütüphane klasörüne kopyalayın. Bunun ardından, ihracatçılara programatik olarak erişebilirsiniz.

Aşağıdaki örnek, Aspose.CAD for JasperReports kullanarak bir raporu TIFF dosyasına ihraç etmek için gereken tipik kodu göstermektedir. Daha fazla örnek, ürün arşivine dahil edilen demo raporlarda bulunabilir.

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
