---
title: Disegni DWG
type: docs
weight: 40
url: /it/net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **Esportazione di Disegni DWG in PDF**

Aspose.CAD per .NET API può caricare disegni AutoCAD in formato [DWG](https://docs.fileformat.com/cad/dwg/) e convertirli in [PDF](https://docs.fileformat.com/pdf/). Questo argomento spiega l'uso dell'API Aspose.CAD per ottenere la conversione da DWG a PDF attraverso semplici passaggi definiti di seguito.

{{% alert color="primary" %}}

L'API supporta le seguenti revisioni DWG di AutoCAD:

- Versione 16.0 rilascio 18 DWG 2004
- Versione 16.1 DWG 2005
- Versione 18.0 DWG 2010
- Versione 19.0 DWG 2013

{{% /alert %}}

### **Formato File DWG**

Un [DWG](https://docs.fileformat.com/cad/dwg/) è un file binario che contiene dati di immagine vettoriale e metadati. I dati dell'immagine vettoriale forniscono istruzioni all'applicazione CAD su come visualizzare il DWG; i metadati possono contenere una varietà di informazioni sul file, inclusi dati specifici della posizione e anche dati dei clienti. Le specifiche aperte per il formato file DWG possono essere trovate [in questo PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Convertire File DWG in PDF**

I seguenti semplici passaggi sono necessari per convertire [DWG](https://docs.fileformat.com/cad/dwg/) in [PDF](https://docs.fileformat.com/pdf/).

1. Carica il file DWG in un'istanza di [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Crea un oggetto della classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e imposta le proprietà [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight) e [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth).
1. Crea un oggetto della classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) e imposta la proprietà [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Chiama [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) passando un oggetto di [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) come secondo parametro.

Il campione di codice qui sotto mostra come esportare Disegni DWG in PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToPDF-ExportToPDF.cs" >}}

### **Crea un PDF Unico con Dimensioni di Layout Diverse**

Aspose.CAD per .NET consente di convertire un file DWG in un singolo PDF con dimensioni di layout diverse. Questo approccio funziona come segue:

1. Carica un file DWG utilizzando il metodo factory [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Crea un'istanza della classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e imposta l'altezza e la larghezza della pagina risultante.
1. Aggiungi le [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/layoutpagesizes) richieste per l'oggetto [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Crea un'istanza della classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) e imposta la sua proprietà [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Esporta l'immagine in PDF utilizzando il metodo [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Il campione di codice qui sotto mostra come creare un unico [PDF](https://docs.fileformat.com/pdf/) con layout diversi.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Features-SinglePDFWithDifferentLayouts-SinglePDFWithDifferentLayouts.cs" >}}

### **Primitive AutoCAD Supportate**

Le seguenti primitive AutoCAD sono supportate.

- TESTO
- MTEXT
- ATTDEF
- ATTRIB
- ARC
- ELLISSE
- RIFORO
- GUIDA
- PUNTO
- VERTICE 2D
- VERTICE 3D
- POLILINEA 2D
- LWPOLYLINE
- RAY
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

## **Esportazione di un Layout Specifico DWG in PDF**

Questo approccio funziona come segue:

1. Carica un file DWG utilizzando il metodo factory [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Crea un'istanza della classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e imposta l'altezza e la larghezza della pagina risultante.
1. Imposta la proprietà [**Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) per l'oggetto [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Crea un'istanza della classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) e imposta la sua proprietà [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Esporta l'immagine in PDF utilizzando il metodo [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Il campione di codice qui sotto mostra come convertire un layout specifico di DWG in PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Renderizza il documento DWG specificando le coordinate**

Aspose.CAD per .NET API ora fornisce una funzionalità per rendere i documenti DWG fornendo le coordinate della larghezza e dell'altezza del documento.

Il campione di codice qui sotto mostra come rendere un documento DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-RenderDWGDocument-RenderDWGDocument.cs" >}}

## **Esportazione di DWG in Raster o PDF utilizzando Dimensione Fissa**

Aspose.CAD per .NET API può caricare disegni AutoCAD in formato DWG e convertirli in PDF o Raster utilizzando dimensioni fisse.

Il campione di codice qui sotto mostra come implementare questa funzionalità.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ExportDWGToPDFOrRaster-ExportDWGToPDFOrRaster.cs" >}}

## **Esportazione di DWG in PDF/A e PDF/E**

Questo approccio funziona come segue:

1. Carica un file DWG utilizzando il metodo factory [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Crea un'istanza della classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Crea un'istanza della classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) e imposta la sua proprietà [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Imposta la proprietà di conformità PDF e salvala.
1. Esporta l'immagine in PDF utilizzando il metodo [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Il campione di codice qui sotto mostra come convertire un file DWG in PDF/A e PDF/E.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-DWGToCompliancePDF-DWGToCompliancePDF.cs" >}}

## **Supporto per linee nascoste arrotondate durante l'esportazione di DWG/DXF in BMP e PDF**

Questo approccio funziona come segue:

1. Carica un file DWG utilizzando il metodo factory [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Crea un'istanza della classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) e imposta l'altezza e la larghezza della pagina risultante.
1. Crea un'istanza della classe [**PdfOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/pdfoptions) e imposta la sua proprietà [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/index).
1. Esporta l'immagine in PDF utilizzando il metodo [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Il campione di codice qui sotto mostra come implementare questa funzionalità.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-SupportForHiddenLines-SupportForHiddenLines.cs" >}}

## **Supporto per impostare l'area di stampa per l'immagine DWG nel PDF esportato**

Aspose.CAD per .NET API può caricare disegni AutoCAD in formato DWG e convertirli in PDF. Questo argomento spiega l'uso dell'API Aspose.CAD per ottenere il supporto per impostare un'area di stampa per l'immagine DWG nel PDF esportato.

Il campione di codice qui sotto mostra come implementare questa funzionalità.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportSpecificLayoutToPDF-ExportSpecificLayoutToPDF.cs" >}}

## **Supporto per la lettura dei metadati XREF per il file DWG**

1. Carica un file DWG utilizzando il metodo factory [**Aspose.CAD.Image.Load**](https://reference.aspose.com/cad/net/aspose.cad.image/load/methods/2).
1. Traversare ogni entità immagine.
1. Se un'entità è CadUnderlay, quindi entità XREF con metadati.

Il campione di codice qui sotto mostra come ottenere questa funzionalità.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-ReadXREEFMetaData-ReadXREEFMetaData.cs" >}}

La proprietà [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts) è di tipo array di stringhe, quindi puoi specificare più layout contemporaneamente per la possibile conversione in formato PDF. Quando specifichi più layout per la proprietà [**CadRasterizationOptions.Layouts**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/properties/layouts), il PDF risultante avrà più pagine, dove ogni pagina rappresenta un layout AutoCAD individuale.

### **Elenca tutti i Layout**

Puoi elencare tutti i layout presenti in un disegno AutoCAD utilizzando il seguente frammento di codice.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-ListLayouts-ListLayouts.cs" >}}

### **Accesso ai Flag di sottostrato per il formato DWG**

Aspose.CAD per .NET ha implementato i flag di sottostrato per il formato DWG e consente agli sviluppatori di accedervi. Di seguito è riportata la semplice dimostrazione del codice.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-AccessingUnderlayFlagsofDWG-AccessingUnderlayFlagsofDWG.cs" >}}

## **Supporto per Entità DWG**

Aspose.CAD per .NET API può caricare disegni AutoCAD in formato DWG e supportare diverse entità da utilizzare.

### **Supporto per l'Entità MLeader**

Un DWG è un file binario che contiene dati di immagine vettoriale e metadati. Ci sono diverse entità in un file DWG. La seguente sezione descrive un esempio di utilizzo dell'entità MLeader all'interno del file DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-SupportMLeaderEntityForDWGFormat-SupportMLeaderEntityForDWGFormat.cs" >}}

### **Supporto per l'Esportazione di un'Entità DWG in Immagine**

Un DWG è un file binario che contiene dati di immagine vettoriale e metadati. Ci sono diverse entità in un file DWG. La seguente sezione descrive un esempio di esportazione di una particolare entità DWG in un'immagine.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ParticularDWGToImage-ParticularDWGToImage.cs" >}}

## **Supporto per Aggiungere Testo in DWG**

Aspose.CAD per .NET API può caricare disegni AutoCAD in formato DWG e supportare diverse entità da utilizzare. Un DWG è un file binario che contiene dati di immagine vettoriale e metadati. Ci sono diverse entità in un file DWG. La seguente sezione descrive come possiamo aggiungere testo all'interno del file DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-AddTextInDWG-AddTextInDWG.cs" >}}

## **Supporto per Importare Immagini nel File DWG**

Aspose.CAD per .NET API può caricare disegni AutoCAD in formato DWG e supportare diverse entità da utilizzare. Un DWG è un file binario che contiene dati di immagine vettoriale e metadati. Ci sono diverse entità in un file DWG. La seguente sezione descrive come possiamo importare immagini all'interno del file DWG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-Src-DWG-Drawings-ImportImageToDWG-ImportImageToDWG.cs" >}}

## **Supporto per Mesh in DWG**

Aspose.CAD per .NET API può ora accedere alle entità che supportano mesh, che includono i tipi [**CadPolyFaceMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolyfacemesh) e [**CadPolygonMesh**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects.polylines/cadpolygonmesh). Il seguente esempio descrive come possiamo accedere ai tipi di mesh.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-MeshSupportForDWG-MeshSupportForDWG.cs" >}}

## **Convertire Disegni DWG in DXF**

Aspose.CAD fornisce la funzionalità per caricare file DWG di AutoCAD ed esportarli in formato DXF. L'approccio da DWG a DXF funziona come segue:

1. Carica il file del disegno DWG utilizzando il metodo factory [**Image.Load**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/load/index).
1. Esporta il disegno DWG in DXF utilizzando il metodo [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Il campione di codice qui sotto mostra come convertire un file DWG in un formato DXF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-DWGToDXF-DWGToDXF.cs" >}}

## **Convertire Disegni DWG in SVG**

Aspose.CAD per .NET API può caricare disegni AutoCAD in formato DWG e convertirli in SVG. Questo argomento spiega l'uso dell'API Aspose.CAD per ottenere la conversione da DWG a formato SVG attraverso semplici passaggi definiti di seguito.

1. Carica il file DWG in un'istanza di [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Crea un oggetto della classe [**SvgOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/svgoptions) e imposta le proprietà richieste.
1. Esporta il disegno DWG in SVG utilizzando il metodo [**Image.Save()**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save/index).

Il campione di codice qui sotto mostra come convertire un file DWG in formato SVG.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-DWG-Drawings-ExportToSVG-ExportToSVG.cs" >}}

## **Caricare File DWG di Grandi Dimensioni**

Aspose.CAD per .NET fornisce la possibilità di aprire file DWG molto grandi utilizzando la classe [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image). Ora puoi aprire facilmente file di grandi dimensioni con l'aiuto del codice di esempio fornito di seguito.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-DWG-Drawings-LargeDWGToPDF-LargeDWGToPDF.cs" >}}
