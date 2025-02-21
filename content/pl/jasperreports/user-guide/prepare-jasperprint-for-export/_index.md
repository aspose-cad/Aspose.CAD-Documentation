---
title: Przygotowanie JasperPrint do eksportu
type: docs
weight: 10
url: /pl/jasperreports/user-guide/prepare-jasperprint-for-export/
---

{{% alert color="primary" %}}

Biblioteka JasperReports provides to class named JasperFillManager do przygotowania JasperPrint do eksportu.

{{% /alert %}}

Następujący fragment kodu demonstruje, jak stworzyć obiekt JasperPrint, aby przygotować raport do dalszego eksportu obrazów.

**Java**

{{< highlight java >}}

JasperReport jasperReport = JasperCompileManager.compileReport("shapesReport.jrxml");
JasperPrint jasperPrint = JasperFillManager.fillReport(jasperReport, null, new JREmptyDataSource());

{{< /highlight >}}
