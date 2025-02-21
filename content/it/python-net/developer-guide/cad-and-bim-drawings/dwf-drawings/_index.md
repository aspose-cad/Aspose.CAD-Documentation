---
title: Disegni DWF
type: docs
weight: 50
url: /it/python-net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **Esportazione di Disegni DWF in PDF**

Aspose.CAD offre la funzionalità di caricare entità di disegno AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) e renderizzarle come un intero disegno in formato [PDF](https://docs.fileformat.com/pdf/). L'approccio per la conversione da [DWF](https://docs.fileformat.com/cad/dwf/) a [PDF](https://docs.fileformat.com/pdf/) funziona come segue:

1. Carica il file di disegno [DWF](https://docs.fileformat.com/cad/dwf/) utilizzando il metodo factory **Image.load**.
1. Crea un oggetto della classe **CadRasterizationOptions** e imposta le proprietà **page_height** e **page_width**.
1. Crea un oggetto della classe **PdfOptions** e imposta la proprietà **vector_rasterization_options**.
1. Chiama **Image.save** passando un oggetto di **PdfOptions** come secondo parametro.

### Codice di Esempio

Il campione di codice qui sotto mostra come convertire un file utilizzando le impostazioni predefinite.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-PDF-Export.py" >}}

## **Esportazione di Disegni DWF in BMP**

Aspose.CAD offre la funzionalità di caricare entità di disegno AutoCAD [DWF](https://docs.fileformat.com/cad/dwf/) e renderizzarle come un intero disegno in formato [BMP](https://docs.fileformat.com/image/bmp/). L'approccio per la conversione da [DWF](https://docs.fileformat.com/cad/dwf/) a [BMP](https://docs.fileformat.com/image/bmp/) funziona come segue:

1. Carica il file di disegno [DWF](https://docs.fileformat.com/cad/dwf/) utilizzando il metodo factory **Image.load**.
1. Crea un oggetto della classe **CadRasterizationOptions** e imposta le proprietà **page_height** e **page_width**.
1. Crea un oggetto della classe **BmpOptions** e imposta la proprietà **vector_rasterization_options**.
1. Chiama **Image.save** passando un oggetto di **BmpOptions** come secondo parametro.

### Codice di Esempio

Il campione di codice qui sotto mostra come convertire un file [DWF](https://docs.fileformat.com/cad/dwf/) in [BMP](https://docs.fileformat.com/image/bmp/) utilizzando le impostazioni predefinite.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWF-to-BMP-Export.py" >}}
