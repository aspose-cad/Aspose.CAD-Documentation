---
title: Disegni SVG
type: docs
weight: 170
url: /it/python-net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **Esportazione del formato SVG in PDF**

Aspose.CAD per Python consente agli sviluppatori di esportare un file [SVG](https://docs.fileformat.com/page-description-language/svg/) in formato [PDF](https://docs.fileformat.com/pdf/). L'approccio di conversione da [SVG](https://docs.fileformat.com/page-description-language/svg/) a [PDF](https://docs.fileformat.com/pdf/) funziona come segue:

1. Caricare il file di disegno SVG utilizzando il metodo factory **Image.load**.
1. Creare un oggetto della classe **CadRasterizationOptions** e impostare le proprietà **page_height** e **page_width**.
1. Creare un oggetto della classe **PdfOptions** e impostare la proprietà **VectorRasterizationOptions**.
1. Chiamare **Image.save** passando un oggetto di **PdfOptions** come secondo parametro.

## Codice di esempio

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-SVG-to-PDF-Export.py" >}}
