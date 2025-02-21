---
title: Disegni FBX
type: docs
weight: 110
url: /it/python-net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **Esportazione del formato FBX in PDF**

Aspose.CAD per Python consente agli sviluppatori di esportare un file [FBX](https://docs.fileformat.com/3d/fbx/) in formato [PDF](https://docs.fileformat.com/pdf/). L'approccio di conversione da [FBX](https://docs.fileformat.com/3d/fbx/) a [PDF](https://docs.fileformat.com/pdf/) funziona come segue:

1. Carica il file di disegno [FBX](https://docs.fileformat.com/3d/fbx/) utilizzando il metodo di fabbrica **Image.load**.
1. Crea un oggetto della classe **CadRasterizationOptions** e imposta le proprietà **PageHeight** e **PageWidth**.
1. Crea un oggetto della classe **PdfOptions** e imposta la proprietà **vector_rasterization_options**.
1. Chiama **Image.save** passando un oggetto di **PdfOptions** come secondo parametro.

## Codice di esempio

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-FBX-to-PDF-Export.py" >}}
