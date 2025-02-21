---
title: Disegni DXF
type: docs
weight: 60
url: /it/net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **Esportazione di Disegni DXF in PDF**

Aspose.CAD fornisce la funzionalità per caricare entità di disegno DXF di AutoCAD e renderizzarle come disegno completo in formato PDF. L'approccio di conversione da DXF a PDF funziona come segue:

1. Carica il file di disegno DXF utilizzando il metodo di fabbrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Crea un oggetto della classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e imposta le proprietà [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) e [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Crea un oggetto della classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) e imposta la proprietà [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Chiama [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) passando un oggetto di [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) come secondo parametro.

Il campione di codice sottostante mostra come convertire un file utilizzando le impostazioni predefinite.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFToPDF-ExportDXFToPDF.cs" >}}

### **Formati Supportati**

Al momento supportiamo completamente i formati di file DXF 2010 di AutoCAD. Le versioni DXF precedenti non sono garantite per essere valide al 100%. Abbiamo in programma di includere più formati e funzionalità nelle future versioni di Aspose.CAD.

### **Entità Supportate**

Al momento supportiamo tutte le entità 2D diffuse e i loro parametri predefiniti di base come segue:

1. Dimensione allineata
1. Dimensione angolare
1. Arco
1. Attributo
1. Riferimento blocco
1. Cerchio
1. Dimensione diametro
1. Ellisse
1. Riempimento
1. Linea
1. Testo multilinea
1. Dimensione ordinata
1. Punto
1. Polilinea
1. Dimensione radiale
1. Raggio
1. Dimensione ruotata
1. Tavola
1. Testo
1. Xline

{{% alert color="primary" %}}

Se durante l'analisi incontriamo un'entità o una proprietà che non supportiamo, l'entità o la proprietà saranno silenziosamente ignorate.

{{% /alert %}}

### **Gestione della Memoria**

La proprietà [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) della classe [**Cache**](https://reference.aspose.com/cad/net/aspose.cad/cache) può essere utilizzata per controllare la riallocazione della memoria. La riallocazione è più probabile che si verifichi per le cache pre-allocate. Può avvenire quando il sistema scopre che lo spazio allocato non sarà sufficiente.

- Se [**ExactReallocateOnly**](https://reference.aspose.com/cad/net/aspose.cad/cache/properties/exactreallocateonly) è impostato sul valore predefinito, **False**, lo spazio viene riallocato allo stesso supporto.
- Quando impostato su **True**, la riallocazione non può superare lo spazio massimo specificato. In questo caso, la cache in memoria già allocata (che richiede riallocazione) viene liberata e viene allocato uno spazio esteso su disco.

## **Esportazione di un Livello Specifico dei Disegni DXF in PDF**

Questo approccio funziona come segue:

1. Apri un file di disegno DXF utilizzando il metodo di fabbrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Crea un'istanza di [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e specifica le proprietà [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) e [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Aggiungi livelli all'oggetto di [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Crea un'istanza di [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) e imposta la sua proprietà [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Chiama il metodo [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) e passa l'oggetto di [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) come secondo parametro.

Il campione di codice sottostante mostra come convertire un livello specifico di DXF in PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayerToPDF-ExportDXFSpecificLayerToPDF.cs" >}}

## **Renderizza i file PDF come parte dei Disegni DXF**

Questo approccio funziona come segue:

1. Carica il file di disegno DXF utilizzando il metodo [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Crea un oggetto della classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e carica i file PDF.
1. Imposta le proprietà [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) e [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Chiama [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) e salva il file.

Il campione di codice sottostante mostra come renderizzare file PDF come parte dei disegni DXF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

## **Esportazione del sottofondo DGN incorporato per il formato DXF**

Aspose.CAD fornisce la funzionalità di caricare file DXF di AutoCAD ed esportare il sottofondo DGN incorporato per il formato DXF.

Il campione di codice sottostante mostra come raggiungere i requisiti specificati.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportEmbeddedDGN-ExportEmbeddedDGN.cs" >}}

## **Supporto per il Salvataggio dei File DXF**

Aspose.CAD fornisce la funzionalità di caricare file DXF di AutoCAD, apportare modifiche e salvarli nuovamente come file DXF.

Il campione di codice sottostante mostra come raggiungere i requisiti specificati.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-SaveDXFFiles-SaveDXFFiles.cs" >}}

## **Esportazione di DXF in WMF**

Questo approccio funziona come segue:

1. Carica il file di disegno DXF utilizzando il metodo [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Crea un oggetto della classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e carica i file PDF.
1. Imposta le proprietà [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) e [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Chiama [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) e salva il file.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportDXFToWMF-ExportDXFToWMF.cs" >}}

## **Esportazione di un Layout Specifico DXF in PDF**

Questo approccio funziona come segue:

1. Apri un file di disegno DXF utilizzando il metodo di fabbrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Crea un'istanza di [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e specifica le proprietà [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) e [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Specifica il nome del layout desiderato utilizzando la proprietà [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts).
1. Crea un'istanza di [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) e imposta la sua proprietà [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Esporta il disegno in PDF chiamando il metodo [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) e passando l'oggetto di [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) come secondo parametro.

Il campione di codice sottostante mostra come convertire un layout specifico di DXF in PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportDXFSpecificLayoutToPDF-ExportDXFSpecificLayoutToPDF.cs" >}}

{{% alert color="primary" %}}

La proprietà [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) è di tipo array di stringhe, quindi puoi specificare più layout contemporaneamente per la possibile conversione in formato PDF. Quando specifichi più layout per la proprietà [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts), il PDF risultante avrà più pagine, dove ogni pagina rappresenta un layout AutoCAD individuale.

{{% /alert %}}

## **Supporto per il Ritaglio dei Blocchi**

Aspose.CAD fornisce la funzionalità di Ritaglio dei Blocchi. L'approccio di Ritaglio dei Blocchi funziona come segue:

1. Carica il file di disegno DXF utilizzando il metodo di fabbrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Crea un oggetto della classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e carica i file PDF.
1. Imposta le proprietà desiderate di [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Chiama [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index) passando un oggetto di [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) come secondo parametro e salva il file.

Il campione di codice sottostante mostra come funziona il Ritaglio dei Blocchi.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DXF-Drawings-SupportOfBlockClipping-SupportOfBlockClipping.cs" >}}

## **Esportazione di Immagini in DXF**

Utilizzando Aspose.CAD, puoi esportare immagini in formato DXF. Utilizzando questo approccio, puoi eseguire le seguenti azioni:

1. Imposta un nuovo carattere
1. Nascondi le entità
1. Aggiorna il testo

Il seguente frammento di codice ti mostra come eseguire le azioni elencate sopra.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DXF-Drawings-ExportImagesToDXF-ExportImagesToDXF.cs" >}}

## **Esportazione di un Livello Specifico dei Disegni DXF in Immagine**

Questo approccio funziona come segue:

1. Apri un file di disegno DXF utilizzando il metodo di fabbrica [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Crea un'istanza di [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e specifica le proprietà [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) e [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Aggiungi livelli all'oggetto di [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Crea un'istanza di [**JpegOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/jpegoptions) e imposta la sua proprietà [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Esporta il disegno in PDF utilizzando il metodo [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Il campione di codice sottostante mostra come convertire un livello specifico di DXF in Immagine.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DXF-Drawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.cs" >}}
