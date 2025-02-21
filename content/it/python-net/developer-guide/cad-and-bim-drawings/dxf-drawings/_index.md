---
title: Disegni DXF
type: docs
weight: 10
url: /it/python-net/developer-guide/cad-and-bim-drawings/dxf-drawings/
---

## **Esportazione dei Disegni DXF in PDF**

Aspose.CAD fornisce la funzionalità di caricare le entità di disegno DXF di AutoCAD e renderle come un intero disegno in formato PDF. L'approccio di conversione da DXF a PDF funziona come segue:

1. Carica il file di disegno DXF utilizzando il metodo di fabbrica **Image.load**.
1. Crea un oggetto della classe **CadRasterizationOptions** e imposta le proprietà **page_height** e **page_width**.
1. Crea un oggetto della classe **PdfOptions** e imposta la proprietà **VectorRasterizationOptions**.
1. Chiama **Image.save** passando un oggetto di **PdfOptions** come secondo parametro.

Il campione di codice qui sotto mostra come convertire un file utilizzando le impostazioni predefinite.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Convert-DXF-to-PDF-Export.py" >}}

### **Formati Supportati**

Al momento supportiamo completamente i formati di file AutoCAD DXF 2010. Le versioni DXF precedenti non sono garantite per essere valide al 100%. Abbiamo in programma di includere ulteriori formati e funzionalità nelle future versioni di Aspose.CAD.

### **Entità Supportate**

Al momento supportiamo tutte le entità 2D diffuse e i loro principali parametri predefiniti come segue:

1. Dimensione allineata
1. Dimensione angolare
1. Arco
1. Attributo
1. Riferimento al blocco
1. Cerchio
1. Dimensione del diametro
1. Ellisse
1. Rete
1. Linea
1. Testo multilinea
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

Se durante l'analisi incontriamo un'entità o una proprietà che non supportiamo, l'entità o la proprietà verranno ignorate silenziosamente.

{{% /alert %}}

## **Esportazione del sottofondo DGN incorporato per il formato DXF**

Aspose.CAD fornisce la funzionalità di caricare file DXF di AutoCAD e esportare sottofondi DGN incorporati per il formato DXF.

Il campione di codice qui sotto mostra come raggiungere i requisiti specificati.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "ExportEmbeddedDGN.py" >}}

## **Supporto per il Salvataggio di File DXF**

Aspose.CAD fornisce la funzionalità di caricare file DXF di AutoCAD, apportare modifiche e salvarli nuovamente come file DXF.

Il campione di codice qui sotto mostra come raggiungere i requisiti specificati.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-Drawings-SaveDXFFiles.py" >}}

## **Esportazione DXF in WMF**

Questo approccio funziona come segue:

1. Carica il file di disegno DXF utilizzando il metodo di fabbrica **Image.load**.
1. Crea un oggetto della classe **CadRasterizationOptions** e carica i file PDF.
1. imposta le proprietà **page_height** e **page_width**.
1. Chiama **Image.save** e salva il file.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "DXF-to-WMF-Export.py" >}}
