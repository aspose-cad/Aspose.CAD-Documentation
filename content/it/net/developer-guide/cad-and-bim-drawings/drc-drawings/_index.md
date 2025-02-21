---
title: Disegni DRC
type: docs
weight: 15
url: /it/net/developer-guide/cad-and-bim-drawings/drc-drawings/
---

## **Esportazione dei Disegni DRC in PDF**

Aspose.CAD offre la funzionalità di caricare entità di disegno AutoCAD [DRC](https://docs.fileformat.com/3d/drc/) e renderizzarle come un intero disegno in formato [PDF](https://docs.fileformat.com/pdf/). L'approccio alla conversione da [DRC](https://docs.fileformat.com/3d/drc/) a [PDF](https://docs.fileformat.com/pdf/) funziona come segue:

1. Carica il file di disegno [DRC](https://docs.fileformat.com/3d/drc/) utilizzando il metodo factory [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Crea un oggetto della classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e imposta le proprietà [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) e [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Crea un oggetto della classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) e imposta la proprietà [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Chiama [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) passando un oggetto di [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) come secondo parametro.

### Codice di Esempio

Il campione di codice sottostante mostra come convertire un file utilizzando le impostazioni predefinite.


{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-DRC-to-PDF-Export.cs" >}}
