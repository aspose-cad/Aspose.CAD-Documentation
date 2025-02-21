---
title: Preparar JasperPrint para exportação
type: docs
weight: 10
url: /pt/jasperreports/user-guide/prepare-jasperprint-for-export/
---

{{% alert color="primary" %}}

A biblioteca JasperReports fornece uma classe chamada JasperFillManager para preparar JasperPrint para exportação.

{{% /alert %}}

O seguinte trecho de código demonstra como criar um objeto JasperPrint para preparar um relatório para exportação de imagem posterior.

**Java**

{{< highlight java >}}

JasperReport jasperReport = JasperCompileManager.compileReport("shapesReport.jrxml");
JasperPrint jasperPrint = JasperFillManager.fillReport(jasperReport, null, new JREmptyDataSource());

{{< /highlight >}}
