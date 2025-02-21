---
title: Подготовка JasperPrint для экспорта
type: docs
weight: 10
url: /ru/jasperreports/user-guide/prepare-jasperprint-for-export/
---

{{% alert color="primary" %}}

Библиотека JasperReports предоставляет класс под названием JasperFillManager для подготовки JasperPrint к экспорту.

{{% /alert %}}

Следующий фрагмент кода демонстрирует, как создать объект JasperPrint для подготовки отчета к дальнейшему экспорту изображения.

**Java**

{{< highlight java >}}

JasperReport jasperReport = JasperCompileManager.compileReport("shapesReport.jrxml");
JasperPrint jasperPrint = JasperFillManager.fillReport(jasperReport, null, new JREmptyDataSource());

{{< /highlight >}}
