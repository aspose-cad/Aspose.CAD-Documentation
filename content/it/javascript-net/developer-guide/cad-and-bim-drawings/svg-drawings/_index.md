---
title: Disegni SVG
type: docs
weight: 70
url: /it/javascript-net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **Esportazione del formato SVG in PNG**

Aspose.CAD per Javascript in Angular consente agli sviluppatori di esportare un file [SVG](https://docs.fileformat.com/page-description-language/svg/) nel formato [PNG](https://docs.fileformat.com/image/png/).
L'approccio di conversione da [SVG](https://docs.fileformat.com/page-description-language/svg/) a [PNG](https://docs.fileformat.com/image/png/) funziona come segue:

1. Caricare il file di disegno [SVG](https://docs.fileformat.com/page-description-language/svg/) utilizzando il metodo **Image.load**.
1. Chiamare **Image.save** passando un oggetto di **PngOptions** come secondo parametro.

## Codice di esempio

Il codice sottostante mostra come raggiungere lo stesso obiettivo utilizzando Aspose.CAD per JavaScript

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-SVG-to-PNG-Export.js" >}}
