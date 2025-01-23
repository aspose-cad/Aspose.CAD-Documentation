---
title: Подготовка на JasperPrint за експортиране
type: docs
weight: 10
url: /bg/jasperreports/prepare-jasperprint-for-export
---

{{% alert color="primary" %}}

Библиотеката JasperReports предоставя клас, наречен JasperFillManager, за подготовка на JasperPrint за експортиране.

{{% /alert %}}

Следният кодов фрагмент демонстрира как да се създаде обект JasperPrint, за да се подготви отчет за по-нататъшен експортиране на изображение.

**Java**

{{< highlight java >}}

JasperReport jasperReport = JasperCompileManager.compileReport("shapesReport.jrxml");
JasperPrint jasperPrint = JasperFillManager.fillReport(jasperReport, null, new JREmptyDataSource());

{{< /highlight >}}
