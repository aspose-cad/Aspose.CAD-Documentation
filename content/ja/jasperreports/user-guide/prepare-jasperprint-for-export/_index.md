---
title: JasperPrintをエクスポートのために準備する
type: docs
weight: 10
url: /ja/jasperreports/user-guide/prepare-jasperprint-for-export/
---

{{% alert color="primary" %}}

JasperReportsライブラリは、JasperPrintをエクスポートのために準備するためのJasperFillManagerというクラスを提供しています。

{{% /alert %}}

以下のコードスニペットは、画像のエクスポートのためにレポートを準備するJasperPrintオブジェクトを作成する方法を示しています。

**Java**

{{< highlight java >}}

JasperReport jasperReport = JasperCompileManager.compileReport("shapesReport.jrxml");
JasperPrint jasperPrint = JasperFillManager.fillReport(jasperReport, null, new JREmptyDataSource());

{{< /highlight >}}
