---
title: Preparar JasperPrint para exportación
type: docs
weight: 10
url: /es/jasperreports/prepare-jasperprint-for-export
---

{{% alert color="primary" %}}

La biblioteca JasperReports proporciona una clase llamada JasperFillManager para preparar JasperPrint para exportación.

{{% /alert %}}

El siguiente fragmento de código demuestra cómo crear un objeto JasperPrint para preparar un informe para una futura exportación de imagen.

**Java**

{{< highlight java >}}

JasperReport jasperReport = JasperCompileManager.compileReport("shapesReport.jrxml");
JasperPrint jasperPrint = JasperFillManager.fillReport(jasperReport, null, new JREmptyDataSource());

{{< /highlight >}}
