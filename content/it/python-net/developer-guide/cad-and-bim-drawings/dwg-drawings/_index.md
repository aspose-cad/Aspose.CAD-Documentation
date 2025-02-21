---
title: Disegni DWG
type: docs
weight: 70
url: /it/python-net/developer-guide/cad-and-bim-drawings/dwg-drawings/
---

## **Esportazione di Disegni DWG in PDF**

Aspose.CAD per Python API può caricare disegni AutoCAD in formato [DWG](https://docs.fileformat.com/cad/dwg/) e convertirli in [PDF](https://docs.fileformat.com/pdf/). Questo argomento spiega l'uso dell'API Aspose.CAD per ottenere la conversione da DWG a PDF attraverso semplici passaggi come definiti di seguito.

{{% alert color="primary" %}}

L'API supporta le seguenti revisioni DWG di AutoCAD:

- Versione DWG 2004 versione 16.0 rilascio 18
- Versione DWG 2005 versione 16.1
- Versione DWG 2010 versione 18.0
- Versione DWG 2013 versione 19.0

{{% /alert %}}

### **Formato File DWG**

Un [DWG](https://docs.fileformat.com/cad/dwg/) è un file binario che contiene dati di immagini vettoriali e metadati. I dati dell'immagine vettoriale forniscono istruzioni all'applicazione CAD su come visualizzare il DWG; i metadati possono contenere una varietà di informazioni sul file, inclusi dati specifici per la posizione e anche dati dei clienti. Le Specifiche Aperte per il formato file DWG possono essere trovate [in questo PDF](http://opendesign.com/files/guestdownloads/OpenDesign_Specification_for_.dwg_files.pdf)

### **Convertire File DWG in PDF**

I seguenti semplici passaggi sono necessari per convertire [DWG](https://docs.fileformat.com/cad/dwg/) in [PDF](https://docs.fileformat.com/pdf/).

1. Carica il file DWG in un'istanza di **Image**.
1. Crea un oggetto della classe **CadRasterizationOptions** e imposta le proprietà **page_height** e **page_width**.
1. Crea un oggetto della classe **PdfOptions** e imposta la proprietà **VectorRasterizationOptions**.
1. Chiama **Image.save** passando un oggetto di **PdfOptions** come secondo parametro.

Il campione di codice qui sotto mostra come esportare Disegni DWG in PDF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-PDF-Export.py" >}}


### **Primitivi AutoCAD Supportati**

I seguenti primitivi AutoCAD sono supportati.

- TESTO
- MTEXT
- ATTDEF
- ATTRIB
- ARCO
- ELLISSE
- RITAGLIO
- LEADER
- PUNTO
- VERTICE 2D
- VERTICE 3D
- POLILINEA 2D
- LWPOLYLINE
- RAGGIO
- CERCHIO
- DIMENSIONE ORDINATE
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

1. Carica un file DWG utilizzando il metodo factory **Aspose.CAD.Image.load**.
1. Crea un'istanza della classe **CadRasterizationOptions** e imposta l'altezza e la larghezza della pagina risultante.
1. Imposta la proprietà **Layouts** per l'oggetto **CadRasterizationOptions**.
1. Crea un'istanza della classe **PdfOptions** e imposta la sua proprietà **VectorRasterizationOptions**.
1. Esporta l'immagine in PDF utilizzando il metodo **Image.save()**.

Il campione di codice qui sotto mostra come convertire un layout specifico di DWG in PDF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-Drawings-ExportSpecificLayoutToPDF.py" >}}


## **Esportazione di DWG in PDF/A e PDF/E**

Questo approccio funziona come segue:

1. Carica un file DWG utilizzando il metodo factory **Image.load**.
1. Crea un'istanza della classe **CadRasterizationOptions**.
1. Crea un'istanza della classe **PdfOptions** e imposta la sua proprietà **VectorRasterizationOptions**.
1. Imposta la proprietà di conformità PDF e salvala.
1. Esporta l'immagine in PDF utilizzando il metodo **Image.save()**.

Il campione di codice qui sotto mostra come convertire un file DWG in PDF/A e PDF/E.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DWG-to-Compliance-PDF.py" >}}

## **Convertire Disegni DWG in DXF**

Aspose.CAD fornisce la funzionalità di caricare un file DWG di AutoCAD ed esportarlo in formato DXF. L'approccio di conversione da DWG a DXF funziona come segue:

1. Carica il file di disegno DWG utilizzando il metodo factory **Image.load**.
1. Esporta il disegno DWG in DXF utilizzando il metodo **Image.save()**.

Il campione di codice qui sotto mostra come convertire un file DWG in formato DXF.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-DXF.py" >}}

## **Convertire Disegni DWG in SVG**

Aspose.CAD per Python API può caricare disegni AutoCAD in formato DWG e convertirli in SVG. Questo argomento spiega l'uso dell'API Aspose.CAD per ottenere la conversione da DWG a formato SVG attraverso semplici passaggi come definiti di seguito.

1. Carica il file DWG in un'istanza di **Image**.
1. Crea un oggetto della classe **SvgOptions** e imposta le proprietà richieste.
1. Esporta il disegno DWG in SVG utilizzando il metodo **Image.save()**.

Il campione di codice qui sotto mostra come convertire un file DWG in formato SVG.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DWG-to-SVG.py" >}}
