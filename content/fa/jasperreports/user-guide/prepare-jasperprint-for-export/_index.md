---
title: آماده‌سازی JasperPrint برای صادرات
type: docs
weight: 10
url: /fa/jasperreports/user-guide/prepare-jasperprint-for-export/
---

{{% alert color="primary" %}}

کتابخانه JasperReports کلاسی به نام JasperFillManager برای آماده‌سازی JasperPrint برای صادرات فراهم می‌کند.

{{% /alert %}}

کد زیر نحوه ایجاد شیء JasperPrint را برای آماده‌سازی یک گزارش برای صادرات تصویر بعدی نشان می‌دهد.

**Java**

{{< highlight java >}}

JasperReport jasperReport = JasperCompileManager.compileReport("shapesReport.jrxml");
// آماده‌سازی گزارش
JasperPrint jasperPrint = JasperFillManager.fillReport(jasperReport, null, new JREmptyDataSource());

{{< /highlight >}}
