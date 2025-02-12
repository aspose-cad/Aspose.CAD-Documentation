---
title: Exportieren von DWG/DXF-Zeichnungen und Layouts in eine bestimmte Größe
type: docs
weight: 40
url: /de/net/developer-guide/export-into-size/
---

## **Exportieren des Modells und aller Layouts in A4-PDF-Größe**

Die Aspose.CAD API ermöglicht es Ihnen, alle Blätter der DWG/DXF-Datei in eine bestimmte physische PDF-Größe zu exportieren.

Der folgende Beispielcode legt die Größe des [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) Objekts fest, um die gewünschte PDF-Größe zu erreichen. 
Die Größe des A4-Papierblatts beträgt 210x297 Millimeter oder 8,27x11,69 Zoll, und diese Werte werden im Code verwendet.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Calculate sizes for A4.cs">}}

## **Exportieren von CAD-Layouts in PDF in unterschiedlicher Größe**

Manchmal ist es erforderlich, das Layout in seiner physischen Größe zu exportieren. Im folgenden Beispiel wird der Export der Zeichnung in eine mehrseitige PDF demonstriert, bei dem jede Seite mit Layout-Inhalt ihre eigene physische PDF-Größe hat. Dieses Beispiel verwendet die [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/layoutpagesizes/) Eigenschaft.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Export to multipage with different pages sizes.cs">}}
