---
title: COLLADA-Zeichnungen
type: docs
weight: 70
url: /de/net/developer-guide/cad-and-bim-drawings/collada-drawings/
---

## **Exportieren im COLLADA-Format als PDF**

Aspose.CAD für .NET ermöglicht Entwicklern, eine Datei im [COLLADA](https://docs.fileformat.com/3d/dae/)-Format in das [PDF](https://docs.fileformat.com/pdf/)-Format zu exportieren. Der Konvertierungsansatz von [COLLADA](https://docs.fileformat.com/3d/dae/) nach [PDF](https://docs.fileformat.com/pdf/) funktioniert wie folgt:

1. Laden Sie die [COLLADA](https://docs.fileformat.com/3d/dae/)-Zeichnungsdatei mithilfe der Methode [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) der Fabrik.
1. Erstellen Sie ein Objekt der Klasse [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) und legen Sie die Eigenschaften [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) und [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) fest.
1. Erstellen Sie ein Objekt der Klasse [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) und legen Sie die Eigenschaft [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) fest.
1. Rufen Sie [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) auf und übergeben Sie als zweiten Parameter ein Objekt von [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions).

## Beispielcode

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-COLLADA-to-PDF-Export.cs" >}}
