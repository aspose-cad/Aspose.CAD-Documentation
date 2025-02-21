---
title: Voorbereiden van JasperPrint voor export
type: docs
weight: 10
url: /nl/jasperreports/user-guide/prepare-jasperprint-for-export/
---

{{% alert color="primary" %}}

De JasperReports-bibliotheek biedt een klasse genaamd JasperFillManager voor het voorbereiden van JasperPrint voor export.

{{% /alert %}}

De volgende codefragment toont hoe je een JasperPrint-object kunt maken om een rapport voor verdere afbeeldingsexport voor te bereiden.

**Java**

{{< highlight java >}}

JasperReport jasperReport = JasperCompileManager.compileReport("shapesReport.jrxml");
// Compilet het rapport 
JasperPrint jasperPrint = JasperFillManager.fillReport(jasperReport, null, new JREmptyDataSource());
// Vul het rapport in met lege gegevensbron

{{< /highlight >}}
