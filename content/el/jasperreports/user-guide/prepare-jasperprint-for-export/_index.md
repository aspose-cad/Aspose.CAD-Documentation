---
title: Προετοιμασία JasperPrint για εξαγωγή
type: docs
weight: 10
url: /el/jasperreports/user-guide/prepare-jasperprint-for-export/
---

{{% alert color="primary" %}}

Η βιβλιοθήκη JasperReports παρέχει μια κλάση που ονομάζεται JasperFillManager για την προετοιμασία του JasperPrint για εξαγωγή.

{{% /alert %}}

Το παρακάτω τμήμα κώδικα απεικονίζει πώς να δημιουργήσετε ένα αντικείμενο JasperPrint για να προετοιμάσετε μια αναφορά για μελλοντική εξαγωγή εικόνας.

**Java**

{{< highlight java >}}

JasperReport jasperReport = JasperCompileManager.compileReport("shapesReport.jrxml");
JasperPrint jasperPrint = JasperFillManager.fillReport(jasperReport, null, new JREmptyDataSource());

{{< /highlight >}}
