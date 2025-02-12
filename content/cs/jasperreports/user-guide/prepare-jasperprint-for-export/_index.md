---
title: Příprava JasperPrint pro export
type: docs
weight: 10
url: /cs/jasperreports/user-guide/prepare-jasperprint-for-export/
---

{{% alert color="primary" %}}

Knihovna JasperReports poskytuje třídu JasperFillManager pro přípravu JasperPrint pro export.

{{% /alert %}}

Následující ukázka kódu demonstruje, jak vytvořit objekt JasperPrint pro přípravu zprávy pro další export obrázků.

**Java**

{{< highlight java >}}

JasperReport jasperReport = JasperCompileManager.compileReport("shapesReport.jrxml");
JasperPrint jasperPrint = JasperFillManager.fillReport(jasperReport, null, new JREmptyDataSource());

{{< /highlight >}}
