---
title: Spiegazione del comportamento della cache di Aspose.CAD
type: docs
weight: 20
url: /it/common/caching-behaviour-explanation/
---


## **Come Aspose.CAD memorizza nella cache i dati**

Tutta la cache effettuata da Aspose.CAD è completamente automatica, senza necessità o possibilità di input da parte dell'utente. Ci sono fondamentalmente tre tipi di cache, tutti relativi ai font.

### **Cache dei nomi dei font**

La cache dei nomi dei font viene utilizzata per facilitare un avvio più veloce elaborando in anticipo tutti i file di font trovati e compilandone l'elenco dei nomi presenti in questi file, poiché un file di font può contenere più di un font. Viene memorizzata come un file temporaneo e di solito ha una dimensione di alcune decine di kilobyte per la maggior parte dei sistemi.

### **Cache dei dati dei glifi dei font**

Una cache in memoria di tutti i glifi utilizzati durante la vita dell'applicazione per ridurre la necessità di leggere nuovamente i file di font su disco durante le esportazioni successive. Pertanto, porterebbe a un aumento costante del consumo di memoria se le esportazioni successive avessero file che fanno riferimento a nuovi font e/o contengono caratteri non incontrati prima. Tuttavia, in pratica, anche sull'intera suite di test di Aspose.CAD, con migliaia di file, inclusi file in diverse lingue, il suo consumo di memoria è di circa 200 megabyte, il che non è molto significativo per un sistema moderno.

### **Cache di fallback dei font per carattere**

Una cache in memoria che memorizza i font che contengono un dato carattere per tutti i caratteri Unicode al fine di facilitare la selezione di un font sostitutivo nel caso in cui un font fornito da un'entità di testo in un disegno non contenga un carattere nel contenuto di testo di quell'entità. Viene costruita alla prima operazione di esportazione durante la vita dell'applicazione e rimane fino all'interruzione dell'applicazione. Sui nostri relativamente modesti macchine di test con vaste collezioni di font utilizzati nelle suite di test, la cache impiega circa 30 secondi per essere costruita e richiede 70 megabyte. Una volta costruita, non richiede più tempo e non cresce.
