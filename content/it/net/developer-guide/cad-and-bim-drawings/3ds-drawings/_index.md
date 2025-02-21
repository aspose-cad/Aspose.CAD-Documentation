---
title: Disegni 3DS
type: docs
weight: 70
url: /it/net/developer-guide/cad-and-bim-drawings/3ds-drawings/
---

## **Esportazione del formato 3DS in PDF**

Aspose.CAD per .NET consente agli sviluppatori di esportare un file [3DS](https://docs.fileformat.com/3d/3ds/) in formato [PDF](https://docs.fileformat.com/pdf/). L'approccio di conversione da [3DS](https://docs.fileformat.com/3d/3ds/) a [PDF](https://docs.fileformat.com/pdf/) funziona come segue:

1. Carica il file di disegno [3DS](https://docs.fileformat.com/3d/3ds/) utilizzando il metodo di fabbrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Crea un oggetto della classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e imposta le proprietà [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) e [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Crea un oggetto della classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) e imposta la proprietà [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Chiama [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) passando un oggetto di [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) come secondo parametro.

## Codice di esempio

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-3DS-to-PDF-Export.cs" >}}
