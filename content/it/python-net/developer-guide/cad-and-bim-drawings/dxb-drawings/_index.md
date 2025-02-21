---
title: Disegni DXB
type: docs
weight: 90
url: /it/python-net/developer-guide/cad-and-bim-drawings/dxb-drawings/
---

## **Esportazione del formato DXB in PDF**

Aspose.CAD per Python consente agli sviluppatori di esportare un file DXB in formato [PDF](https://docs.fileformat.com/pdf/). L'approccio di conversione da DXB a [PDF](https://docs.fileformat.com/pdf/) funziona come segue:

1. Carica il file di disegno DXB utilizzando il metodo factory **Image.load**.
1. Crea un oggetto della classe **CadRasterizationOptions** e imposta le proprietà **page_height** e **page_width**.
1. Crea un oggetto della classe **PdfOptions** e imposta la proprietà **vector_rasterization_options**.
1. Chiama **Image.save** passando un oggetto di **PdfOptions** come secondo parametro.

## Esempio di codice

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXB-to-PDF-Export.py" >}}
