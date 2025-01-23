---
title: 3DS-Zeichnungen
type: docs
weight: 70
url: /de/net/3ds-zeichnungen/
---

## **Exportieren des 3DS-Formats als PDF**

Aspose.CAD für .NET ermöglicht es Entwicklern, eine [3DS](https://docs.fileformat.com/3d/3ds/)-Datei in das [PDF](https://docs.fileformat.com/pdf/)-Format zu exportieren. Der Ansatz zur Konvertierung von [3DS](https://docs.fileformat.com/3d/3ds/) in [PDF](https://docs.fileformat.com/pdf/) funktioniert wie folgt:

1. Laden Sie die [3DS](https://docs.fileformat.com/3d/3ds/)-Zeichnungsdatei mithilfe der Factory-Methode [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Erstellen Sie ein Objekt der Klasse [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) und legen Sie die Eigenschaften [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) und [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) fest.
1. Erstellen Sie ein Objekt der Klasse [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) und legen Sie die Eigenschaft [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) fest.
1. Rufen Sie [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) auf und übergeben Sie als zweiten Parameter ein Objekt von [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions).

## Beispielcode

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-3DS-to-PDF-Export.cs" >}}
