---
title: Disegni SVG
type: docs
weight: 70
url: /it/net/developer-guide/cad-and-bim-drawings/svg-drawings/
---

## **Esportazione del formato SVG in PDF**

Aspose.CAD per .NET consente agli sviluppatori di esportare un file SVG in formato [PDF](https://docs.fileformat.com/pdf/). L'approccio di conversione da SVG a [PDF](https://docs.fileformat.com/pdf/) funziona come segue:

1. Caricare il file di disegno SVG utilizzando il metodo di fabbrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Creare un oggetto della classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e impostare le proprietà [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) e [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Creare un oggetto della classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) e impostare la proprietà [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Chiamare [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) passando un oggetto di [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) come secondo parametro.

## Codice di esempio

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-SVG-to-PDF-Export.cs" >}}
