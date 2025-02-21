---
title: เตรียม JasperPrint สำหรับการส่งออก
type: docs
weight: 10
url: /th/jasperreports/user-guide/prepare-jasperprint-for-export/
---

{{% alert color="primary" %}}

ไลบรารี JasperReports มีคลาสชื่อ JasperFillManager สำหรับเตรียม JasperPrint สำหรับการส่งออก

{{% /alert %}}

รหัสส่วนนี้แสดงให้เห็นถึงวิธีการสร้างวัตถุ JasperPrint เพื่อเตรียมรายงานสำหรับการส่งออกภาพต่อไป

**Java**

{{< highlight java >}}

JasperReport jasperReport = JasperCompileManager.compileReport("shapesReport.jrxml");
JasperPrint jasperPrint = JasperFillManager.fillReport(jasperReport, null, new JREmptyDataSource());

{{< /highlight >}}
