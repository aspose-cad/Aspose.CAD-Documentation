---
title: DRC-Zeichnungen
type: docs
weight: 15
url: /de/net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **Exportieren von DRC-Zeichnungen in PDF**

Aspose.CAD bietet die Funktion, AutoCAD [DRC](https://docs.fileformat.com/3d/drc/)-Zeichenentitäten zu laden und sie als gesamte Zeichnung im [PDF](https://docs.fileformat.com/pdf/)-Format zu rendern. Der Ansatz zur Konvertierung von DRC in PDF funktioniert wie folgt:

1. Laden Sie die DRC-Zeichnungsdatei mithilfe der Werkzeugmethode [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Erstellen Sie ein Objekt der Klasse [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) und setzen Sie die Eigenschaften [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) & [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Erstellen Sie ein Objekt der Klasse [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) und setzen Sie die Eigenschaft [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Rufen Sie [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) auf, indem Sie als zweiten Parameter ein Objekt von [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) übergeben.

### Beispielcode

Der folgende Code zeigt, wie eine Datei mithilfe der Standardeinstellungen konvertiert wird.


{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DRC-to-PDF-Export.cs" >}}
