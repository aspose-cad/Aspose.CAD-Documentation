---
title: DXB Zeichnungen
type: docs
weight: 70
url: /de/net/dxb-drawings/
---

## **Exportieren des DXB-Formats nach PDF**

Aspose.CAD für .NET ermöglicht Entwicklern, eine DXB-Datei in das [PDF](https://docs.fileformat.com/pdf/) Format zu exportieren. Der Ansatz zur Konvertierung von DXB in [PDF](https://docs.fileformat.com/pdf/) funktioniert wie folgt:

1. Laden Sie die DXB-Zeichnungsdatei mit der [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) Fabrikmethode.
1. Erstellen Sie ein Objekt der [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) Klasse und setzen Sie die Eigenschaften [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Erstellen Sie ein Objekt der [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) Klasse und setzen Sie die [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) Eigenschaft.
1. Rufen Sie [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) auf, während Sie ein Objekt von [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) als zweiten Parameter übergeben.

## Beispielcode

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DXB-to-PDF-Export.cs" >}}
