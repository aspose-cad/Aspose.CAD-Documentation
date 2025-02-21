---
title: Lavorare con il formato di file OBJ
type: docs
weight: 120
url: /it/javascript-net/developer-guide/cad-and-bim-drawings/working-with-obj-file-format/
---

{{% alert color="primary" %}}

Aspose.CAD ora supporta il formato di file OBJ. Il formato di file OBJ è una geometria 3D che contiene mappe di texture, coordinate 3D, facce poligonali e altre informazioni sugli oggetti.

{{% /alert %}}

## **Esportazione del formato OBJ in PNG**

Aspose.CAD per Javascript in Angular consente agli sviluppatori di esportare un file [OBJ](https://docs.fileformat.com/3d/obj/) in formato [PNG](https://docs.fileformat.com/image/png/).
L'approccio di conversione da [OBJ](https://docs.fileformat.com/3d/obj/) a [PNG](https://docs.fileformat.com/image/png/) funziona come segue:

1. Carica il file di disegno [OBJ](https://docs.fileformat.com/3d/obj/) utilizzando il metodo **Image.load**.
1. Chiama **Image.save** passando un oggetto di **PngOptions** come secondo parametro.

## Esempio di codice

Il codice sottostante mostra come raggiungere lo stesso obiettivo utilizzando Aspose.CAD per JavaScript

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-OBJ-to-PNG-Export.js" >}}
