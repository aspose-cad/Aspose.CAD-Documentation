---
title: JasperPrint 내보내기 준비
type: docs
weight: 10
url: /ko/jasperreports/user-guide/prepare-jasperprint-for-export/
---

{{% alert color="primary" %}}

JasperReports 라이브러리는 JasperPrint를 내보내기 위해 준비하는 JasperFillManager라는 클래스를 제공합니다.

{{% /alert %}}

다음 코드 스니펫은 JasperPrint 객체를 생성하여 보고서를 이미지로 내보내기 위해 준비하는 방법을 보여줍니다.

**Java**

{{< highlight java >}}

JasperReport jasperReport = JasperCompileManager.compileReport("shapesReport.jrxml");
JasperPrint jasperPrint = JasperFillManager.fillReport(jasperReport, null, new JREmptyDataSource());

{{< /highlight >}}
