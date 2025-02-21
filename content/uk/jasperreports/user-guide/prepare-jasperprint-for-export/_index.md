---
title: Підготовка JasperPrint для експорту
type: docs
weight: 10
url: /uk/jasperreports/user-guide/prepare-jasperprint-for-export/
---

{{% alert color="primary" %}}

Бібліотека JasperReports надає клас з назвою JasperFillManager для підготовки JasperPrint для експорту.

{{% /alert %}}

Наступний фрагмент коду демонструє, як створити об'єкт JasperPrint для підготовки звіту для подальшого експорту зображень.

**Java**

{{< highlight java >}}

JasperReport jasperReport = JasperCompileManager.compileReport("shapesReport.jrxml");
JasperPrint jasperPrint = JasperFillManager.fillReport(jasperReport, null, new JREmptyDataSource());

{{< /highlight >}}
