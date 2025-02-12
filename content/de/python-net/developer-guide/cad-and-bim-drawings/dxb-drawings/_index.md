---
title: DXB Zeichnungen
type: docs
weight: 90
url: /de/python-net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **DXB-Format nach PDF exportieren**

Aspose.CAD für Python ermöglicht Entwicklern den Export einer DXB-Datei in das [PDF](https://docs.fileformat.com/pdf/) Format. Der Ansatz zur Konvertierung von DXB in [PDF](https://docs.fileformat.com/pdf/) funktioniert wie folgt:

1. Laden Sie die DXB-Zeichnungsdatei mit der **Image.load** Fabrikmethode.
1. Erstellen Sie ein Objekt der Klasse **CadRasterizationOptions** und setzen Sie die Eigenschaften **page_height** und **page_width**.
1. Erstellen Sie ein Objekt der Klasse **PdfOptions** und setzen Sie die Eigenschaft **vector_rasterization_options**.
1. Rufen Sie **Image.save** auf, während Sie ein Objekt von **PdfOptions** als zweiten Parameter übergeben.

## Beispielcode

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXB-to-PDF-Export.py" >}}
