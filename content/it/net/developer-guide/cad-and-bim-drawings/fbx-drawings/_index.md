---
title: Disegni FBX
type: docs
weight: 70
url: /it/net/developer-guide/cad-and-bim-drawings/fbx-drawings/
---

## **Esportazione del formato FBX in PDF**

Aspose.CAD per .NET consente agli sviluppatori di esportare un file [FBX](https://docs.fileformat.com/3d/fbx/) nel formato [PDF](https://docs.fileformat.com/pdf/). L'approccio di conversione da [FBX](https://docs.fileformat.com/3d/fbx/) a [PDF](https://docs.fileformat.com/pdf/) funziona come segue:

1. Carica il file di disegno [FBX](https://docs.fileformat.com/3d/fbx/) utilizzando il metodo fabbrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Crea un oggetto della classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e imposta le proprietà [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) e [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Crea un oggetto della classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) e imposta la proprietà [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
1. Chiama [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) passando un oggetto di [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) come secondo parametro.

## Codice di esempio

{{< gist "aspose-com-gists" "16de0fa2ea006758f25d1ad32bc75fd2" "Convert-FBX-to-PDF-Export.cs" >}}
