---
title: Menginstal Aspose.CAD untuk JasperReports
type: docs
weight: 20
url: /id/jasperreports/installation/installing-aspose-cad-for-jasperreports/
---

Untuk menggunakan **Aspose.CAD untuk JasperReports** dari aplikasi Anda, salin **aspose-cad-jasperreports-xx.x.jar** dari folder \lib dari **aspose-cad-jasperreports-xx.x.zip** ke direktori JasperReports\lib atau ke folder pustaka aplikasi Anda. Setelah itu, Anda dapat mengakses ekspor secara pemrograman.

Contoh berikut menunjukkan kode yang biasa diperlukan untuk mengekspor laporan ke file TIFF menggunakan Aspose.CAD untuk JasperReports. Lebih banyak contoh dapat ditemukan dalam laporan demo yang disertakan dalam arsip produk.

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
