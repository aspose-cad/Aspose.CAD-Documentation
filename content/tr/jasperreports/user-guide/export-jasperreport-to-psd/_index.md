---
title: JasperReport'u PSD Olarak Dışa Aktarma
type: docs
weight: 90
url: /tr/jasperreports/user-guide/export-jasperreport-to-psd/
---

{{% alert color="primary" %}}

Aspose.CAD for JasperReports, JasperReport'u PSD'ye dışa aktarmak için ASPsdExporter adında bir sınıf sağlar.

{{% /alert %}}

Aşağıdaki kod kesiti, JasperReport'u PSD'ye nasıl dışa aktaracağınızı göstermektedir.

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
