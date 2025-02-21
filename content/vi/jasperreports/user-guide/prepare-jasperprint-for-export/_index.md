---
title: Chuẩn bị JasperPrint để xuất
type: docs
weight: 10
url: /vi/jasperreports/user-guide/prepare-jasperprint-for-export/
---

{{% alert color="primary" %}}

Thư viện JasperReports cung cấp một lớp tên là JasperFillManager để chuẩn bị JasperPrint cho việc xuất.

{{% /alert %}}

Đoạn mã sau đây minh họa cách tạo đối tượng JasperPrint để chuẩn bị một báo cáo cho việc xuất ảnh sau này.

**Java**

{{< highlight java >}}

JasperReport jasperReport = JasperCompileManager.compileReport("shapesReport.jrxml");
JasperPrint jasperPrint = JasperFillManager.fillReport(jasperReport, null, new JREmptyDataSource());

{{< /highlight >}}
