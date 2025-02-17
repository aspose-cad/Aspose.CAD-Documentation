---
title: JasperPrint előkészítése exportáláshoz
type: docs
weight: 10
url: /hu/jasperreports/user-guide/prepare-jasperprint-for-export/
---

{{% alert color="primary" %}}

A JasperReports könyvtár egy JasperFillManager nevű osztályt biztosít a JasperPrint exportálásra való előkészítéséhez.

{{% /alert %}}

Az alábbi kódrészlet bemutatja, hogyan lehet létrehozni egy JasperPrint objektumot, hogy egy jelentést előkészítsünk további kép exportálásra.

**Java**

{{< highlight java >}}

JasperReport jasperReport = JasperCompileManager.compileReport("shapesReport.jrxml");
JasperPrint jasperPrint = JasperFillManager.fillReport(jasperReport, null, new JREmptyDataSource());

{{< /highlight >}}
