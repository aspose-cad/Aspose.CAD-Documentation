---
title: הכנת JasperPrint לייצוא
type: docs
weight: 10
url: /he/jasperreports/user-guide/prepare-jasperprint-for-export/
---

{{% alert color="primary" %}}

ספריית JasperReports מספקת מחלקה בשם JasperFillManager להכנת JasperPrint לייצוא.

{{% /alert %}}

קטע הקוד הבא מדגים כיצד ליצור אובייקט JasperPrint כדי להכין דיווח לייצוא תמונה נוסף.

**Java**

{{< highlight java >}}

JasperReport jasperReport = JasperCompileManager.compileReport("shapesReport.jrxml");
JasperPrint jasperPrint = JasperFillManager.fillReport(jasperReport, null, new JREmptyDataSource());

{{< /highlight >}}
