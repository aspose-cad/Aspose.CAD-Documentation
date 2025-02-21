---
title: Siapkan JasperPrint untuk diekspor
type: docs
weight: 10
url: /id/jasperreports/user-guide/prepare-jasperprint-for-export/
---

{{% alert color="primary" %}}

Perpustakaan JasperReports menyediakan kelas bernama JasperFillManager untuk menyiapkan JasperPrint untuk diekspor.

{{% /alert %}}

Potongan kode berikut menunjukkan cara membuat objek JasperPrint untuk menyiapkan laporan untuk diekspor menjadi gambar lebih lanjut.

**Java**

{{< highlight java >}}

JasperReport jasperReport = JasperCompileManager.compileReport("shapesReport.jrxml");
JasperPrint jasperPrint = JasperFillManager.fillReport(jasperReport, null, new JREmptyDataSource());

{{< /highlight >}}
