---
title: JasperPrint für den Export vorbereiten
type: docs
weight: 10
url: /de/jasperreports/prepare-jasperprint-for-export
---

{{% alert color="primary" %}}

Die JasperReports-Bibliothek bietet eine Klasse namens JasperFillManager zur Vorbereitung von JasperPrint für den Export.

{{% /alert %}}

Der folgende Code zeigt, wie man ein JasperPrint-Objekt erstellt, um einen Bericht für den weiteren Bildexport vorzubereiten.

**Java**

{{< highlight java >}}

JasperReport jasperReport = JasperCompileManager.compileReport("shapesReport.jrxml");
JasperPrint jasperPrint = JasperFillManager.fillReport(jasperReport, null, new JREmptyDataSource());

{{< /highlight >}}
