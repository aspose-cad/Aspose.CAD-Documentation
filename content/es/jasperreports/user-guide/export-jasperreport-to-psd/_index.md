---
title: Exportar JasperReport a PSD
type: docs
weight: 90
url: /es/jasperreports/user-guide/export-jasperreport-to-psd/
---

{{% alert color="primary" %}}

Aspose.CAD para JasperReports proporciona una clase llamada ASPsdExporter para exportar JasperReport a PSD.

{{% /alert %}}

El siguiente fragmento de código demuestra cómo exportar el JasperReport a PSD.

**Java**

{{< highlight java >}}

// Esta línea crea una nueva instancia del exportador PSd
ASPsdExporter psdExporter = new ASPsdExporter();
// Esta línea crea una nueva configuración de exportación para PSD
ASPsdExportConfigurationImpl psdExportConfiguration = new ASPsdExportConfigurationImpl();
psdExportConfiguration.setColorMode(ColorModesEnum.Rgb);
psdExportConfiguration.setPsdVersion(PsdVersionEnum.Psd);
psdExportConfiguration.setCompressionMethod(CompressionMethodEnum.Raw);
psdExporter.setConfiguration(psdExportConfiguration);

// Esta línea crea una nueva entrada de exportación usando jasperPrint
exporterInput = new ASExportInputImpl(jasperPrint);
psdExporter.setExporterInput(exporterInput);

// Esta línea crea una nueva salida de exportación con el nombre "shapesExample.psd"
exporterOutput = new ASExporterOutputImpl("shapesExample.psd");
psdExporter.setExporterOutput(exporterOutput);

// Esta línea exporta el informe
psdExporter.exportReport();

{{< /highlight >}}
