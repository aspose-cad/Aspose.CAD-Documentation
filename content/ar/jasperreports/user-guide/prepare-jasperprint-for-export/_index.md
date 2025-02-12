---
title: إعداد JasperPrint للتصدير
type: docs
weight: 10
url: /ar/jasperreports/user-guide/prepare-jasperprint-for-export/
---

{{% alert color="primary" %}}

توفر مكتبة JasperReports فئة تُدعى JasperFillManager لإعداد JasperPrint للتصدير.

{{% /alert %}}

يكشف الكود التالي عن كيفية إنشاء كائن JasperPrint لإعداد تقرير للتصدير إلى صورة لاحقاً.

**Java**

{{< highlight java >}}

JasperReport jasperReport = JasperCompileManager.compileReport("shapesReport.jrxml");
JasperPrint jasperPrint = JasperFillManager.fillReport(jasperReport, null, new JREmptyDataSource());

{{< /highlight >}}
