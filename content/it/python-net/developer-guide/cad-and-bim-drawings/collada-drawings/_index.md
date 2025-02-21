---
title: Disegni COLLADA
type: docs
weight: 20
url: /it/python-net/developer-guide/cad-and-bim-drawings/collada-drawings/
---

## **Esportazione del formato COLLADA in PDF**

Aspose.CAD per Python consente agli sviluppatori di esportare un file [COLLADA](https://docs.fileformat.com/3d/dae/) in formato [PDF](https://docs.fileformat.com/pdf/). L'approccio di conversione da [COLLADA](https://docs.fileformat.com/3d/dae/) a [PDF](https://docs.fileformat.com/pdf/) funziona come segue:

1. Carica il file di disegno [COLLADA](https://docs.fileformat.com/3d/dae/) utilizzando il metodo di fabbrica **Image.load**.
1. Crea un oggetto della classe **CadRasterizationOptions** e imposta le proprietà **page_height** e **page_width**.
1. Crea un oggetto della classe **PdfOptions** e imposta la proprietà **vector_rasterization_options**.
1. Chiama **Image.save** passando un oggetto di **PdfOptions** come secondo parametro.

## Codice di esempio

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-COLLADA-to-PDF-Export.py" >}}
