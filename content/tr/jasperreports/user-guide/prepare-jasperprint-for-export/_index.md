---
title: JasperPrint'i dışa aktarmaya hazırlama
type: docs
weight: 10
url: /tr/jasperreports/user-guide/prepare-jasperprint-for-export/
---

{{% alert color="primary" %}}

JasperReports kütüphanesi, JasperPrint'i dışa aktarmaya hazırlamak için JasperFillManager adında bir sınıf sağlar.

{{% /alert %}}

Aşağıdaki kod örneği, bir raporu daha fazla görüntü dışa aktarmak için hazırlamak üzere JasperPrint nesnesi oluşturmanın nasıl yapılacağını göstermektedir.

**Java**

{{< highlight java >}}

JasperReport jasperReport = JasperCompileManager.compileReport("shapesReport.jrxml");
JasperPrint jasperPrint = JasperFillManager.fillReport(jasperReport, null, new JREmptyDataSource());

{{< /highlight >}}
