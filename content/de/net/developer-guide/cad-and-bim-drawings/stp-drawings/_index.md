---
title: STP Zeichnungen
type: docs
weight: 70
url: /de/net/stp-drawings/
---

## **Exportieren des STP-Formats nach PDF**

Aspose.CAD für .NET ermöglicht es Entwicklern, eine [STP](https://docs.fileformat.com/3d/stp/) Datei in das [PDF](https://docs.fileformat.com/pdf/) Format zu exportieren. Der Ansatz zur Konvertierung von [STP](https://docs.fileformat.com/3d/stp/) nach [PDF](https://docs.fileformat.com/pdf/) funktioniert wie folgt:

1. Laden Sie die [STP](https://docs.fileformat.com/3d/stp/) Zeichnungsdatei mit der [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) Fabrikmethode.
1. Erstellen Sie ein Objekt der [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) Klasse und setzen Sie die Eigenschaften [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) und [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Erstellen Sie ein Objekt der [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) Klasse und setzen Sie die [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) Eigenschaft.
1. Rufen Sie [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) auf, während Sie ein Objekt von [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) als zweiten Parameter übergeben.

## Beispielcode

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-STP-to-PDF-Export.cs" >}}
