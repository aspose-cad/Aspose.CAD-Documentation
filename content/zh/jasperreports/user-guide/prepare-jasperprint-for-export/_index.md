---
title: 准备 JasperPrint 以便导出
type: docs
weight: 10
url: /zh/jasperreports/user-guide/prepare-jasperprint-for-export/
---

{{% alert color="primary" %}}

JasperReports 库提供了一个名为 JasperFillManager 的类，用于准备 JasperPrint 以便导出。

{{% /alert %}}

以下代码片段演示了如何创建 JasperPrint 对象以准备报告以便进一步的图像导出。

**Java**

{{< highlight java >}}

JasperReport jasperReport = JasperCompileManager.compileReport("shapesReport.jrxml");
JasperPrint jasperPrint = JasperFillManager.fillReport(jasperReport, null, new JREmptyDataSource());

{{< /highlight >}}
