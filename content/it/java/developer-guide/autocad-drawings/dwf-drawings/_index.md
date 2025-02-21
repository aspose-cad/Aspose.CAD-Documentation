---
title: Disegni DWF
type: docs
weight: 20
url: /it/java/developer-guide/autocad-drawings/dwf-drawings/
---

## **Esportare Disegni DWF in PDF**

Aspose.CAD per l'API Java può caricare disegni AutoCAD in formato DWF e convertirli in PDF. Questo argomento spiega l'uso dell'API Aspose.CAD per ottenere la conversione da DWF a formato PDF attraverso semplici passaggi come definito di seguito.

### **Convertire File DWF in PDF**

I seguenti semplici passaggi sono necessari per convertire DWF in PDF.

1. Carica il file DWF in un'istanza di [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Crea un oggetto della classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) e imposta le proprietà [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-) e [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-).
1. Crea un oggetto della classe [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) e imposta la proprietà [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions).
1. Chiama [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) passando un oggetto di [**PdfOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/PdfOptions) come secondo parametro.

Il campione di codice sottostante mostra come esportare un Disegno DWF in PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToPDF-ExportToPDF.java" >}}

### **Supporto dei Layer in DWF**

Aspose.CAD fornisce la funzione di caricare entità di disegno DWF di AutoCAD e renderle come un intero disegno in formato JPG.

1. Carica il file di disegno DWF usando il metodo fabbrica [**Image.load**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#load-java.io.InputStream-).
1. Crea un oggetto della classe [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).
1. Aggiungi i layer desiderati.
1. Chiama [**Image.save**](https://reference.aspose.com/cad/java/com.aspose.cad/Image#save--) passando un oggetto di [**JPEGOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/JpegOptions) come secondo parametro.

Il campione di codice sottostante mostra come convertire un file utilizzando le impostazioni predefinite.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DWFDrawings-SupportOfLayers-SupportOfLayers.java" >}}
