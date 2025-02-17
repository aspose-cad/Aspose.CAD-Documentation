---
title: JasperPrint को निर्यात के लिए तैयार करें
type: docs
weight: 10
url: /hi/jasperreports/user-guide/prepare-jasperprint-for-export/
---

{{% alert color="primary" %}}

JasperReports लाइब्रेरी JasperPrint को निर्यात के लिए तैयार करने के लिए JasperFillManager नामक एक क्लास प्रदान करती है।

{{% /alert %}}

निम्नलिखित कोड स्निपेट यह प्रदर्शित करता है कि रिपोर्ट को आगे की छवि निर्यात के लिए तैयार करने के लिए JasperPrint ऑब्जेक्ट कैसे बनाया जाता है।

**Java**

{{< highlight java >}}

JasperReport jasperReport = JasperCompileManager.compileReport("shapesReport.jrxml");
JasperPrint jasperPrint = JasperFillManager.fillReport(jasperReport, null, new JREmptyDataSource());

{{< /highlight >}}
