---
title: Disegni DXF
type: docs
weight: 60
url: /it/java/developer-guide/autocad-drawings/dxf-drawings/
---

## **Esportazione di Disegni DXF in PDF**

Aspose.CAD fornisce la funzionalità di caricare le entità di disegno DXF di AutoCAD e renderle come un intero disegno in formato PDF. L'approccio di conversione da DXF a PDF funziona come segue:

1. Carica il file di disegno DXF utilizzando il metodo fabbrica [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Crea un oggetto della classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) e imposta le proprietà [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) e [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Crea un oggetto della classe [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) e imposta la proprietà [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Chiama Image.Save passando un oggetto di [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) come secondo parametro.

Il campione di codice qui sotto mostra come convertire un file utilizzando le impostazioni predefinite.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFDrawingToPDF-.java" >}}

### **Formati supportati**

Al momento supportiamo completamente i formati di file AutoCAD DXF 2010. Le versioni DXF precedenti non sono garantite al 100% valide. Abbiamo in programma di includere più formati e funzionalità nelle future versioni di Aspose.CAD.

### **Entità Supportate**

Al momento supportiamo tutte le entità 2D diffuse e i loro parametri predefiniti di base come segue:

1. Dimensione allineata
1. Dimensione angolare
1. Arco
1. Attributo
1. Riferimento al blocco
1. Cerchio
1. Dimensione del diametro
1. Ellisse
1. Hachure
1. Linea
1. Testo multiriga
1. Dimensione ordinata
1. Punto
1. Polilinea
1. Dimensione radiale
1. Raggio
1. Dimensione ruotata
1. Tabella
1. Testo
1. Xline

{{% alert color="primary" %}}

Se durante il parsing incontriamo un'entità o proprietà che non supportiamo, l'entità o la proprietà verrà ignorata silenziosamente.

{{% /alert %}}

### **Gestione della memoria**

La proprietà [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) può essere usata per controllare la riallocazione della memoria. La riallocazione è più probabile che si verifichi per le cache pre-allocate. Può avvenire quando il sistema si rende conto che lo spazio allocato non sarà sufficiente.

- Se [**ExactReallocateOnly**](https://reference.aspose.com/cad/java/com.aspose.cad/Cache#getExactReallocateOnly--) è impostato sul valore predefinito, **False**, lo spazio viene riallocato nello stesso medium.
- Quando impostato su **True**, la riallocazione non può superare lo spazio massimo specificato. In questo caso, la cache in memoria esistente (che richiede la riallocazione) viene liberata e viene allocato spazio esteso su disco.

## **Esportazione di uno strato specifico di Disegni DXF in PDF**

Questo approccio funziona come segue:

1. Apri un file di disegno DXF usando il metodo fabbrica [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Crea un'istanza di [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) e specifica le proprietà [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) e [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Aggiungi strati all'oggetto di [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Crea un'istanza di [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) e imposta la sua proprietà [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Esporta il disegno in PDF usando il metodo [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Il campione di codice qui sotto mostra come convertire uno strato specifico di DXF in PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificLayerOfDXFDrawingToPDF-.java" >}}

## **Esportazione di uno strato specifico di Disegni DXF in Immagine**

Questo approccio funziona come segue:

1. Apri un file di disegno DXF usando il metodo fabbrica [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Crea un'istanza di [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) e specifica le proprietà [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) e [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Aggiungi strati all'oggetto di [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Crea un'istanza di [**JpegOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) e imposta la sua proprietà [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Esporta il disegno in PDF usando il metodo [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Il campione di codice qui sotto mostra come convertire uno strato specifico di DXF in Immagine.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToImage-ExportSpecificDXFLayoutToImage.java" >}}

## **Renderizza file PDF come parte dei Disegni DXF**

Questo approccio funziona come segue:

1. Carica il file di disegno DXF utilizzando il metodo fabbrica [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Crea un oggetto della classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) e carica i file PDF.
1. Imposta le proprietà [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) e [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad/imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Chiama [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) e salva il file.

Il campione di codice qui sotto mostra come renderizzare file PDF come parte dei Disegni DXF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-RenderDXFAsPDF-RenderDXFAsPDF.java" >}}

## **Esporta DXF in WMF**

Questo approccio funziona come segue:

1. Carica il file di disegno DXF utilizzando il metodo fabbrica [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Crea un oggetto della classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) e carica i file PDF.
1. Imposta le proprietà [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) e [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad/imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Chiama [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) e salva il file.

Il campione di codice qui sotto mostra come esportare DXF in WMF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportDXFToWMF-ExportDXFToWMF.java" >}}

## **Supporto per il salvataggio di file DXF**

Aspose.CAD fornisce la funzionalità di caricare file DXF di AutoCAD e apportare modifiche e salvarlo di nuovo come file DXF. Il campione di codice qui sotto mostra come soddisfare i requisiti specificati.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SaveDXFFiles-SaveDXFFiles.java" >}}

## **Esportazione di sottofondo DGN incorporato per il formato DXF**

Aspose.CAD fornisce la funzionalità di caricare file DXF di AutoCAD ed esportare il sottofondo DGN incorporato per il formato DXF.

Il campione di codice qui sotto mostra come soddisfare i requisiti specificati.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportEmbeddedDGN-ExportEmbeddedDGN.java" >}}

## **Esportazione di Layout DXF Specifico in PDF**

Questo approccio funziona come segue:

1. Apri un file di disegno DXF usando il metodo fabbrica [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Crea un'istanza di [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) e specifica le proprietà [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) e [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Specifica il/i nome/i del layout desiderato usando la proprietà [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-).
1. Crea un'istanza di [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) e imposta la sua proprietà [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Esporta il disegno in PDF usando il metodo [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--).

Il campione di codice qui sotto mostra come convertire un layout specifico di DXF in PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportSpecificDXFLayoutToPDF-.java" >}}

{{% alert color="primary" %}}

La proprietà [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) è di tipo array di stringhe, quindi puoi specificare più layout contemporaneamente per la possibile conversione in formato PDF. Specificando più layout per la proprietà [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-), il PDF risultante avrà più pagine, dove ogni pagina rappresenta un singolo layout di AutoCAD.

{{% /alert %}}

## **Accesso agli oggetti ATTRIB e MTEXT**

Questo approccio funziona come segue:

1. Apri un file di disegno DXF usando il metodo fabbrica [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Accedi alle entità all'interno del file CAD.
1. Controlla le entità [**CadEntityTypeName.MTEXT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#MTEXT) e [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT).
1. Aggiungi a una lista temporanea per ulteriori elaborazioni.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-AddAttribMText-AddAttribMText.java" >}}

## **Decomponi oggetti di inserimento CAD**

Questo approccio funziona come segue:

1. Apri un file di disegno **DXF** utilizzando il metodo fabbrica [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Accedi alle entità all'interno del file CAD.
1. Controlla le entità [**CadEntityTypeName.INSERT**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadconsts/CadEntityTypeName#INSERT).
1. Controlla la lista di tipi [**CadBlockEntity**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity).
1. Elabora le entità.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-DecomposeCadInsertObject-DecomposeCadInsertObject.java" >}}

## **Supporto del ritaglio dei blocchi**

Aspose.CAD fornisce la funzionalità di Ritaglio dei Blocchi. L'approccio di Ritaglio dei Blocchi funziona come segue:

1. Carica il file di disegno DXF utilizzando il metodo fabbrica [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Crea un oggetto della classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) e carica i file PDF.
1. Imposta le proprietà desiderate di [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Chiama [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) passando un oggetto di [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) come secondo parametro e salva il file.

Il campione di codice qui sotto mostra come funziona il Ritaglio dei Blocchi.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-SupportOfBlockClipping-SupportOfBlockClipping.java" >}}

## **Esporta Immagini in DXF**

Utilizzando Aspose.CAD, puoi esportare immagini in formato DXF. Utilizzando questo approccio, puoi eseguire le seguenti azioni:

1. Imposta un nuovo font.
1. Nascondi le entità.
1. Aggiorna il testo.

Il seguente frammento di codice ti mostra come eseguire le azioni sopra elencate.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-ExportImagesToDXF.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-ExportImagesToDXF-GetFileExtension.java" >}}
