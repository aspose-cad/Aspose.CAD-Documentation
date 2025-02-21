---
title: Förbered JasperPrint för export
type: docs
weight: 10
url: /sv/jasperreports/user-guide/prepare-jasperprint-for-export/
---

{{% alert color="primary" %}}

JasperReports-biblioteket tillhandahåller en klass som heter JasperFillManager för att förbereda JasperPrint för export.

{{% /alert %}}

Följande kodsnutt visar hur man skapar ett JasperPrint-objekt för att förbereda en rapport för vidare bildexport.

**Java**

{{< highlight java >}}

JasperReport jasperReport = JasperCompileManager.compileReport("shapesReport.jrxml");
JasperPrint jasperPrint = JasperFillManager.fillReport(jasperReport, null, new JREmptyDataSource());

{{< /highlight >}}
