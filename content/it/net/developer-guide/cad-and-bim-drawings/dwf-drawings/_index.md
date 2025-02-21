---
title: Disegni DWF
type: docs
weight: 20
url: /it/net/developer-guide/cad-and-bim-drawings/dwf-drawings/
---

## **Esportazione di Disegni DWF in PDF**

Aspose.CAD fornisce la funzionalità di caricare entità di disegno [DWF](https://docs.fileformat.com/cad/dwf/) di AutoCAD e renderizzarle come un intero disegno in formato [PDF](https://docs.fileformat.com/pdf/). L'approccio di conversione da [DWF](https://docs.fileformat.com/cad/dwf/) a [PDF](https://docs.fileformat.com/pdf/) funziona come segue:

1. Carica il file di disegno [DWF](https://docs.fileformat.com/cad/dwf/) utilizzando il metodo factory [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
2. Crea un oggetto della classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e imposta le proprietà [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) e [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
3. Crea un oggetto della classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) e imposta la proprietà [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
4. Chiama [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) passando un oggetto di [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) come secondo parametro.

### Esempio di Codice

Il campione di codice sottostante mostra come convertire un file utilizzando le impostazioni predefinite.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **Estrazione dei Layer dal Disegno DWF**

Aspose.CAD fornisce la funzionalità di caricare entità di disegno [DWF](https://docs.fileformat.com/cad/dwf/) di AutoCAD e renderizzarle come un intero disegno in formato [JPEG](https://docs.fileformat.com/image/jpeg/).

1. Carica il file di disegno [DWF](https://docs.fileformat.com/cad/dwf/) utilizzando il metodo factory [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
2. Crea un oggetto della classe [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions).
3. Crea un oggetto della classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
4. Estrai i nomi dei layer utilizzando l'oggetto [JPEG](https://docs.fileformat.com/image/jpeg/).
5. Chiama [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) passando un oggetto di [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) come secondo parametro.

### Esempio di Codice

Il campione di codice sottostante mostra come convertire un file utilizzando le impostazioni predefinite.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportDWFToPDF-ExportDWFToPDF.cs" >}}

## **Supporto dei Layer in DWF**

Aspose.CAD fornisce la funzionalità di caricare entità di disegno [DWF](https://docs.fileformat.com/cad/dwf/) di AutoCAD e renderizzarle come un intero disegno in formato [JPEG](https://docs.fileformat.com/image/jpeg/).

1. Carica il file di disegno [DWF](https://docs.fileformat.com/cad/dwf/) utilizzando il metodo factory [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
2. Crea un oggetto della classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
3. Aggiungi i layer desiderati.
4. Chiama [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) passando un oggetto di [**JPEGOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) come secondo parametro.

### Esempio di Codice

Il campione di codice sottostante mostra come convertire un file utilizzando le impostazioni predefinite.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWF-Drawings-SupportOfLayers-SupportOfLayers.cs" >}}

## **Esportazione di Disegni DWF in BMP**

Aspose.CAD fornisce la funzionalità di caricare entità di disegno [DWF](https://docs.fileformat.com/cad/dwf/) di AutoCAD e renderizzarle come un intero disegno in formato [BMP](https://docs.fileformat.com/image/bmp/). L'approccio di conversione da [DWF](https://docs.fileformat.com/cad/dwf/) a [BMP](https://docs.fileformat.com/image/bmp/) funziona come segue:

1. Carica il file di disegno [DWF](https://docs.fileformat.com/cad/dwf/) utilizzando il metodo factory [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
2. Crea un oggetto della classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e imposta le proprietà [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) e [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
3. Crea un oggetto della classe [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) e imposta la proprietà [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions).
4. Chiama [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) passando un oggetto di [**BmpOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/bmpoptions) come secondo parametro.

### Esempio di Codice

Il campione di codice sottostante mostra come convertire un file [DWF](https://docs.fileformat.com/cad/dwf/) in [BMP](https://docs.fileformat.com/image/bmp/) utilizzando le impostazioni predefinite.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}
