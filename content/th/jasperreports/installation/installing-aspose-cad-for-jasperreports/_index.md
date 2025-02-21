---
title: การติดตั้ง Aspose.CAD สำหรับ JasperReports
type: docs
weight: 20
url: /th/jasperreports/installation/installing-aspose-cad-for-jasperreports/
---

ในการใช้ **Aspose.CAD สำหรับ JasperReports** จากแอปพลิเคชันของคุณ ให้คัดลอก **aspose-cad-jasperreports-xx.x.jar** จากโฟลเดอร์ \lib ของ **aspose-cad-jasperreports-xx.x.zip** ไปยังไดเรกทอรี JasperReports\lib หรือไปยังโฟลเดอร์ไลบรารีของแอปพลิเคชันของคุณ หลังจากนั้นคุณสามารถเข้าถึง exporters ได้อย่างมีโปรแกรม

ตัวอย่างต่อไปนี้แสดงถึงโค้ดที่จำเป็นในการส่งออกเอกสารไปยังไฟล์ TIFF โดยใช้ Aspose.CAD สำหรับ JasperReports คุณสามารถดูตัวอย่างเพิ่มเติมได้ในรายงานสาธิตที่รวมอยู่ในผลิตภัณฑ์

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
