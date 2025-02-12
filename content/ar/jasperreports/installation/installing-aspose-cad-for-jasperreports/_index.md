---
title: تثبيت Aspose.CAD لـ JasperReports
type: docs
weight: 20
url: /ar/jasperreports/installation/installing-aspose-cad-for-jasperreports/
---

لاستخدام **Aspose.CAD لـ JasperReports** من تطبيقك، انسخ **aspose-cad-jasperreports-xx.x.jar** من مجلد \lib الخاص بـ **aspose-cad-jasperreports-xx.x.zip** إلى دليل JasperReports\lib أو إلى مجلد مكتبة تطبيقك. بعد ذلك، يمكنك الوصول إلى المصدرين برمجياً.

يوضح المثال التالي الكود النموذجي المطلوب لتصدير تقرير إلى ملف TIFF باستخدام Aspose.CAD لـ JasperReports. يمكن العثور على المزيد من الأمثلة في التقارير التجريبية المضمنة في أرشيف المنتج.

**Java**

{{< highlight java >}}
    ASTiffExporter tiffExporter = new ASTiffExporter();
    ASTiffExportConfigurationImpl tiffExportConfiguration = new ASTiffExportConfigurationImpl(TiffExpectedFormatEnum.TiffDeflateRgb);
    tiffExportConfiguration.setArtist("جون سميث");
    tiffExportConfiguration.setDateTime("12.08.2020");
    tiffExportConfiguration.setCompression(TiffCompressionsEnum.AdobeDeflate);
    tiffExporter.setConfiguration(tiffExportConfiguration);

    exporterInput = new ASExportInputImpl(jasperPrint);
    tiffExporter.setExporterInput(exporterInput);

    exporterOutput = new ASExporterOutputImpl("shapesExample.tiff");
    tiffExporter.setExporterOutput(exporterOutput);

    tiffExporter.exportReport();
{{< /highlight >}}
