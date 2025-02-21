---
title: Disegni DWG
type: docs
weight: 40
url: /it/java/developer-guide/autocad-drawings/dwg-drawings/
---

## **Esportazione di Disegni DWG in PDF**

Aspose.CAD per Java API può caricare disegni AutoCAD in formato DWG e convertirli in PDF. Questo argomento spiega l'uso dell'API Aspose.CAD per ottenere la conversione da DWG a formato PDF attraverso semplici passaggi come definiti di seguito.

{{% alert color="primary" %}}

L'API supporta le seguenti revisioni AutoCAD DWG:

- DWG 2004 versione 16.0 rilascio 18
- DWG 2005 versione 16.1
- DWG 2010 versione 18.0
- DWG 2013 versione 19.0

{{% /alert %}}

### **Formato File DWG**

Un DWG è un file binario che contiene dati di immagine vettoriale e metadati. I dati di immagine vettoriale forniscono istruzioni all'applicazione CAD su come visualizzare il DWG; i metadati possono contenere una varietà di informazioni sul file, comprese informazioni specifiche sulla posizione e anche dati del cliente. Le specifiche aperte per il formato file DWG possono essere trovate [in questo PDF](https://www.opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Convertire File DWG in PDF**

I seguenti semplici passaggi sono necessari per convertire DWG in PDF.

1. Caricare il file DWG in un'istanza di [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Creare un oggetto della classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) e impostare le proprietà [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) e [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Creare un oggetto della classe [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) e impostare la proprietà [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Chiamare il metodo [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) e passare l'oggetto di [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) come secondo parametro.

Il campione di codice seguente mostra come esportare i Disegni DWG in PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ConvertDWGFileToPDF-ConvertDWGFileToPDF.java" >}}

### **Creare un PDF Singolo con Diverse Dimensioni di Layout**

Aspose.CAD per Java consente di convertire il file DWG in un singolo PDF con diverse dimensioni di layout. Questo approccio funziona come segue:

1. Caricare un file DWG utilizzando il metodo factory [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Creare un'istanza della classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) e impostare l'altezza e la larghezza della pagina risultante.
1. Aggiungere le [**LayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setLayoutPageSizes-com.aspose.ms.System.Collections.Generic.Dictionary-) richieste per l'oggetto [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Creare un'istanza della classe [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) e impostare la sua proprietà [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Esportare l'immagine in PDF utilizzando il metodo [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Il campione di codice seguente mostra come creare un singolo PDF con diversi layout.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.java" >}}

### **Esportazione di DWG in PDF/A e PDF/E**

I seguenti semplici passaggi sono necessari per convertire DWG in PDF.

1. Caricare il file DWG in un'istanza di [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Creare un oggetto della [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) e impostare le proprietà [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) e [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Creare un oggetto della classe [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) e impostare la proprietà [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Chiamare il [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metodo e passare l'oggetto di [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) come secondo parametro.

Il campione di codice seguente mostra come esportare Disegni DWG in PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToCompliancePDF-DWGToCompliancePDF.java" >}}

### **Primitivi AutoCAD Supportati**

I seguenti primitivi AutoCAD sono supportati.

- TESTO
- MTEXT
- ATTDEF
- ATTRIB
- ARC
- ELLISSE
- RIFORO
- LEADER
- PUNTO
- VERTICE 2D
- VERTICE 3D
- POLILINEA 2D
- LWPOLYLINE
- RAGGIO
- CERCHIO
- DIMENSIONE ORDINATA
- DIMENSIONE LINEARE
- DIMENSIONE ALLINEATA
- DIMENSIONE ANG 3Pt
- DIMENSIONE ANG 2Ln
- DIMENSIONE RAGGIO
- DIMENSIONE DIAMETRO
- FORMA
- SOLIDO
- SPLINE
- MLINE
- LINEA
- XLINE
- STILE
- DIMSTYLE
- LTYPE
- MLINESTYLE
- LAYER
- VIEWPORT
- LAYOUT

## **Esportazione di un Layout DWG Specifico in PDF**

Questo approccio funziona come segue:

1. Caricare un file DWG utilizzando il metodo factory [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Creare un'istanza della classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) e impostare l'altezza e la larghezza della pagina risultante.
1. Impostare la proprietà [**Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-) per l'oggetto [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Creare un'istanza della classe [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) e impostare la sua proprietà [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Esportare l'immagine in PDF utilizzando il [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metodo.

Il campione di codice seguente mostra come convertire un layout specifico di DWG in PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportSpecificDWGLayoutToPDF-ExportSpecificDWGLayoutToPDF.java" >}}

## **Esportazione di DWG in Raster o PDF utilizzando Dimensione Fissa**

Aspose.CAD per Java API può caricare disegni AutoCAD in formato DWG e convertirli in PDF o Raster utilizzando dimensione fissa.

Il campione di codice seguente mostra come implementare questa funzionalità.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.java" >}}

## **Supporto per linee nascoste arrotondate durante l'esportazione di DWG/DXF in BMP e PDF**

Questo approccio funziona come segue:

1. Caricare un file DWG utilizzando il [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) metodo factory.
1. Creare un'istanza della [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) classe.
1. Creare un'istanza della [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) classe e impostare l'altezza e la larghezza della pagina risultante.
1. Creare un'istanza della [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) classe e impostare la sua [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) proprietà.
1. Esportare l'immagine in PDF utilizzando il [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metodo.

Il campione di codice seguente mostra come implementare questa funzionalità.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportForHiddenLines-SupportForHiddenLines.java" >}}

## **Supporto per la definizione dell'area di stampa per l'immagine DWG nel PDF esportato**

Aspose.CAD per Java API può caricare disegni AutoCAD in formato DWG e convertirli in PDF. Questo argomento spiega l'uso dell'API Aspose.CAD per ottenere il supporto per la definizione di un'area di stampa per l'immagine DWG nel PDF esportato.

Il campione di codice seguente mostra come implementare questa funzionalità.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Supporto per la lettura dei metadati XREF per il file DWG**

1. Caricare un file DWG utilizzando il [**Aspose.CAD.Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) metodo factory.
1. Percorrere ogni entità immagine.
1. Se l'entità è [**CadUnderlay**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadUnderlay), allora entità XREF con metadati.

Il campione di codice seguente mostra come ottenere questa funzionalità.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ReadXREEFMetaData-ReadXREEFMetaData.java" >}}

## **Documento DWG specificando le coordinate**

Aspose.CAD per Java API ora fornisce una funzionalità per rendere i documenti DWG fornendo le coordinate della larghezza e dell'altezza del documento.

Il campione di codice seguente mostra come rendere un documento DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-RenderDWGDocument-RenderDWGDocument.java" >}}

La proprietà [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#getLayouts--) è di tipo array di stringhe, quindi puoi specificare più layout contemporaneamente per una possibile conversione in formato PDF. Quando si specificano più layout per la proprietà [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setLayouts-java.lang.String:A-), il PDF risultante avrà più pagine, dove ogni pagina rappresenta un layout AutoCAD individuale.

### **Elenca Tutti i Layout**

Puoi elencare tutti i layout presenti in un disegno AutoCAD utilizzando il seguente frammento di codice.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ListAllLayoutsInAnAutoCADDrawing-ListAllLayoutsInAnAutoCADDrawing.java" >}}

## **Ottenere il Valore Attributo di Blocco di Riferimento Esterno**

Aspose.CAD per Java API consente di ottenere un riferimento esterno di un attributo di blocco. Aspose.CAD API espone la [**getXRefPathName()**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadBlockEntity#getXRefPathName--) proprietà per ottenere il riferimento esterno di un attributo di blocco in una collezione [**CadBlockDictionary**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadBlockDictionary).

Il seguente codice dimostra come ottenere un riferimento esterno di un attributo di blocco.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-GetBlockAttributeValueOfExternalReference-GetBlockAttributeValueOfExternalReference.java" >}}

## **Cerca Testo nel File DWG AutoCAD**

Aspose.CAD per Java API consente di cercare testo in un file DWG AutoCAD. Aspose.CAD API espone la classe [**CadText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadText) che rappresenta le entità di testo nel file DWG AutoCAD. La classe [**CadMText**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects/CadMText) è anche inclusa nell'API Aspose.CAD perché alcune altre entità possono contenere testo.

Il seguente codice dimostra come cercare testo nel file DWG AutoCAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchTextInDWGAutoCADFile.java" >}}

### **Cerca Testo in un Layout Specifico**

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SearchTextInDWGAutoCADFile-SearchForTextInSpecificLayout.java" >}}

### **Accesso ai Flag di sottofondo per il formato DWG**

Aspose.CAD per Java ha implementato i flag di sottofondo per il formato DWG e consente agli sviluppatori di accedervi. Seguendo vi è una semplice dimostrazione del codice.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.java" >}}

## **Supporto per Entità DWG**

Aspose.CAD per Java API può caricare disegni AutoCAD in formato DWG e supportare diverse entità su cui lavorare.

### **Supporto per l'Entità MLeader**

Un DWG è un file binario che contiene dati di immagine vettoriale e metadati. Ci sono diverse entità in un file DWG. La seguente sezione descrive un esempio di lavoro con l'entità MLeader all'interno del file DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.java" >}}

### **Supporto per l'Esportazione di Entità DWG in Immagine**

Un DWG è un file binario che contiene dati di immagine vettoriale e metadati. Ci sono diverse entità in un file DWG. La seguente sezione descrive un esempio di esportazione di una particolare entità DWG nell'immagine.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ParticularDWGToImage-ParticularDWGToImage.java" >}}

## **Supporto per Importare Immagine in File DWG**

Aspose.CAD per Java API può caricare disegni AutoCAD in formato DWG e supportare diverse entità con cui lavorare. Un DWG è un file binario che contiene dati di immagine vettoriale e metadati. Ci sono diverse entità in un file DWG. La seguente sezione descrive come possiamo importare immagini all'interno del file DWG.

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ImportImageToDWG-ImportImageToDWG.java" >}}

## **Supporto per Aggiungere testo in DWG**

Aspose.CAD per Java API può caricare disegni AutoCAD in formato DWG e supportare diverse entità con cui lavorare. Un DWG è un file binario che contiene dati di immagine vettoriale e metadati. Ci sono diverse entità in un file DWG. La seguente sezione descrive come possiamo aggiungere testo all'interno del file DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-AddTextInDWG-AddTextInDWG.java" >}}

## **Supporto per Mesh in DWG**

Aspose.CAD per Java API può ora accedere alle entità che supportano mesh, che includono i tipi [**CadPolyFaceMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolyFaceMesh) e [**CadPolygonMesh**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad.cadobjects.polylines/CadPolygonMesh). Il seguente esempio descrive come possiamo accedere ai tipi di mesh.

## **Convertire Disegni DWG in DXF**

Aspose.CAD fornisce la funzionalità di caricare file DWG di AutoCAD ed esportarli in formato DXF. L'approccio di conversione da DWG a DXF funziona come segue:

1. Caricare il file di disegno DWG utilizzando il metodo factory [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-) .
1. Esportare il disegno DWG in DXF utilizzando il metodo [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) .

Il campione di codice seguente mostra come convertire un file DWG in formato DXF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-DWGToDXF-DWGToDXF.java" >}}

## **Convertire Disegni DWG in SVG**

Aspose.CAD API può caricare disegni AutoCAD in formato DWG e convertirli in SVG. Questo argomento spiega l'uso dell'API Aspose.CAD per ottenere la conversione da DWG a formato SVG attraverso semplici passaggi come definiti di seguito.

1. Caricare il file DWG in un'istanza di [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Creare un oggetto della classe [**SvgOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/SvgOptions) e impostare le proprietà richieste.
1. Esportare il disegno DWG in SVG utilizzando il [**Image.save()**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) metodo.

Il campione di codice seguente mostra come convertire un file DWG in formato SVG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWGDrawings-ExportToSVG-ExportToSVG.java" >}}
