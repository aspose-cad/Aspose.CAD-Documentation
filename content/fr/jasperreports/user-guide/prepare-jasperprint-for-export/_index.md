---
title: Préparer JasperPrint pour l'exportation
type: docs
weight: 10
url: /fr/jasperreports/prepare-jasperprint-for-export
---

{{% alert color="primary" %}}

La bibliothèque JasperReports fournit une classe nommée JasperFillManager pour préparer JasperPrint pour l'exportation.

{{% /alert %}}

Le code suivant montre comment créer un objet JasperPrint pour préparer un rapport pour une exportation d'image ultérieure.

**Java**

{{< highlight java >}}

// Compiler le rapport
JasperReport jasperReport = JasperCompileManager.compileReport("shapesReport.jrxml");
// Remplir le rapport avec des données vides
JasperPrint jasperPrint = JasperFillManager.fillReport(jasperReport, null, new JREmptyDataSource());

{{< /highlight >}}
