---
title: FBX Zeichnungen
type: docs
weight: 70
url: /de/net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **Exportieren des FBX-Formats nach PDF**

Aspose.CAD für .NET ermöglicht Entwicklern, eine [FBX](https://docs.fileformat.com/3d/fbx/) Datei in das [PDF](https://docs.fileformat.com/pdf/) Format zu exportieren. Der Ansatz zur Konvertierung von [FBX](https://docs.fileformat.com/3d/fbx/) nach [PDF](https://docs.fileformat.com/pdf/) funktioniert wie folgt:

1. Laden Sie die [FBX](https://docs.fileformat.com/3d/fbx/) Zeichnungsdatei mit der [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) Fabrikmethode.
1. Erstellen Sie ein Objekt der [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) Klasse und setzen Sie die Eigenschaften [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) und [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Erstellen Sie ein Objekt der [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) Klasse und setzen Sie die Eigenschaft [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Rufen Sie [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) auf und übergeben Sie ein Objekt von [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) als zweiten Parameter.

## Beispielcode

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-FBX-to-PDF-Export.cs" >}}
