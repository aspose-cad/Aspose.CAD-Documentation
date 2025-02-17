---
title: Aspose.CAD telepítése JasperReportshoz
type: docs
weight: 20
url: /hu/jasperreports/installation/installing-aspose-cad-for-jasperreports/
---

Az **Aspose.CAD for JasperReports** használatához az alkalmazásodból másold az **aspose-cad-jasperreports-xx.x.jar** fájlt az **aspose-cad-jasperreports-xx.x.zip** \lib mappájából a JasperReports\lib könyvtárba vagy az alkalmazásod könyvtárába. Ezt követően programozottan hozzáférhetsz az exportálóhoz.

Az alábbi példa a szükséges kódot mutatja, amely egy jelentés exportálásához szükséges TIFF fájlba az Aspose.CAD for JasperReports használatával. További példák találhatók a termékarchívumban található bemutató jelentésekben.

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
