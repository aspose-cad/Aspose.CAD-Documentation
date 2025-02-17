---
title: JasperReport exportálása PSD-be
type: docs
weight: 90
url: /hu/jasperreports/user-guide/export-jasperreport-to-psd/
---

{{% alert color="primary" %}}

Az Aspose.CAD for JasperReports egy ASPsdExporter nevű osztályt biztosít a JasperReport PSD-be való exportálásához.

{{% /alert %}}

Az alábbi kódrészlet bemutatja, hogyan exportálhatjuk a JasperReport-ot PSD-be.

**Java**

{{< highlight java >}}

ASPsdExporter psdExporter = new ASPsdExporter();
ASPsdExportConfigurationImpl psdExportConfiguration = new ASPsdExportConfigurationImpl();
psdExportConfiguration.setColorMode(ColorModesEnum.Rgb);
psdExportConfiguration.setPsdVersion(PsdVersionEnum.Psd);
psdExportConfiguration.setCompressionMethod(CompressionMethodEnum.Raw);
psdExporter.setConfiguration(psdExportConfiguration);

exporterInput = new ASExportInputImpl(jasperPrint);
psdExporter.setExporterInput(exporterInput);

exporterOutput = new ASExporterOutputImpl("shapesExample.psd");
psdExporter.setExporterOutput(exporterOutput);

psdExporter.exportReport();

{{< /highlight >}}
