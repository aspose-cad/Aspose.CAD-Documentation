---
title: Das Exportieren von DWG/DXF-Zeichnungen und Layouts in eine spezifische Größe
type: docs
weight: 40
url: /de/java/developer-guide/export-into-size/
---

## **Exportieren Sie das Modell und alle Layouts in A4 PDF-Größe**

Die Aspose.CAD-API ermöglicht es Ihnen, alle Blätter der DWG/DXF-Datei in eine spezifische physische PDF-Größe zu exportieren.
Der folgende Beispielscode legt die Größe des [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions/) Objekts fest, um die gewünschte PDF-Größe zu erreichen.
Die Größe eines A4-Papierblatts beträgt 210x297 Millimeter oder 8,27x11,69 Zoll und diese Werte werden im Code verwendet.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "set-page-size.java">}}

## **Exportieren von CAD-Layouts in PDF in unterschiedlicher Größe**

Manchmal ist es erforderlich, ein Layout in seiner physischen Größe zu exportieren. Das folgende Beispiel demonstriert den Export der Zeichnung in ein mehrseitiges PDF, wobei jede Seite mit Layoutinhalt über eine eigene physische PDF-Größe verfügt. Dieses Beispiel verwendet die Eigenschaft [**getLayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#getLayoutPageSizes--).

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "export-different-pages-sizes.java">}}
