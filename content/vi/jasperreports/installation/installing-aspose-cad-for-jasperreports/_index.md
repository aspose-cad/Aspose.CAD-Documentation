---
title: Cài đặt Aspose.CAD cho JasperReports
type: docs
weight: 20
url: /vi/jasperreports/installation/installing-aspose-cad-for-jasperreports/
---

Để sử dụng **Aspose.CAD cho JasperReports** từ ứng dụng của bạn, hãy sao chép **aspose-cad-jasperreports-xx.x.jar** từ thư mục \lib của **aspose-cad-jasperreports-xx.x.zip** vào thư mục JasperReports\lib hoặc vào một thư mục thư viện của ứng dụng của bạn. Sau đó, bạn có thể truy cập các trình xuất theo cách lập trình.

Ví dụ sau đây cho thấy mã điển hình cần thiết để xuất một báo cáo sang tệp TIFF bằng cách sử dụng Aspose.CAD cho JasperReports. Nhiều ví dụ hơn có thể được tìm thấy trong các báo cáo demo được bao gồm trong lưu trữ sản phẩm.

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
