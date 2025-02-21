---
title: Preparare JasperPrint per l'esportazione
type: docs
weight: 10
url: /it/jasperreports/user-guide/prepare-jasperprint-for-export/
---

{{% alert color="primary" %}}

La libreria JasperReports fornisce una classe chiamata JasperFillManager per preparare JasperPrint per l'esportazione.

{{% /alert %}}

Il seguente frammento di codice dimostra come creare un oggetto JasperPrint per preparare un rapporto per una successiva esportazione in immagine.

**Java**

{{< highlight java >}}

JasperReport jasperReport = JasperCompileManager.compileReport("shapesReport.jrxml");
JasperPrint jasperPrint = JasperFillManager.fillReport(jasperReport, null, new JREmptyDataSource());

{{< /highlight >}}
