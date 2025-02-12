---
title: SVG-Zeichnungen
type: docs
weight: 70
url: /de/net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **Exportieren von SVG-Format nach PDF**

Aspose.CAD für .NET ermöglicht Entwicklern, eine SVG-Datei in das [PDF](https://docs.fileformat.com/pdf/) -Format zu exportieren. Der Ansatz zur Konvertierung von SVG in [PDF](https://docs.fileformat.com/pdf/) funktioniert wie folgt:

1. Laden Sie die SVG-Zeichnungsdatei mit der [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2) -Fabrikmethode.
1. Erstellen Sie ein Objekt der Klasse [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) und setzen Sie die Eigenschaften [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) und [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Erstellen Sie ein Objekt der Klasse [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) und setzen Sie die Eigenschaft [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Rufen Sie [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) auf und übergeben Sie ein Objekt der [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) -Klasse als zweiten Parameter.

## Beispielcode

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-SVG-to-PDF-Export.cs" >}}
