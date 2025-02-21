---
title: Disegni STP
type: docs
weight: 70
url: /it/net/developer-guide/cad-and-bim-drawings/stp-drawings/
---

## **Esportazione del formato STP in PDF**

Aspose.CAD per .NET consente agli sviluppatori di esportare un file [STP](https://docs.fileformat.com/3d/stp/) in formato [PDF](https://docs.fileformat.com/pdf/). L'approccio di conversione da [STP](https://docs.fileformat.com/3d/stp/) a [PDF](https://docs.fileformat.com/pdf/) funziona come segue:

1. Carica il file di disegno [STP](https://docs.fileformat.com/3d/stp/) utilizzando il metodo factory [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
2. Crea un oggetto della classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e imposta le proprietà [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) e [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
3. Crea un oggetto della classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) e imposta la proprietà [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
4. Chiama [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) passando un oggetto della classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) come secondo parametro.

## Codice di esempio

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-STP-to-PDF-Export.cs" >}}
