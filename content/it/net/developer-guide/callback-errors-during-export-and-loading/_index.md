---
title: Errori di callback durante l'esportazione e il caricamento
type: docs
weight: 40
url: /it/net/developer-guide/callback-errors-during-export-and-loading/
---

## **Panoramica degli errori di callback durante l'esportazione e il caricamento**

È possibile che durante l'esportazione o il caricamento del disegno si possano verificare errori legati alla struttura del file 
(ad es. alcune sezioni nel file sono ora richieste ma non lo erano prima). 
Alcuni di essi sono critici e in questi casi viene generata un'eccezione, ma possiamo anche ignorarne alcuni internamente e segnalarlo utilizzando messaggi di callback.
Comunque, tutti questi messaggi richiedono attenzione perché possono spiegare ad es. entità mancanti nei risultati dell'esportazione o altri effetti.

### **Errori durante l'esportazione**

C'è un campo RenderResult in [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/),
che include IsRenderComplete per verificare se ci sono stati errori durante l'esportazione e stampare informazioni su di essi:

{{< gist aspose-com-gists 90b8a0a5ce7d0fc5d8d9a8c5bf4b816d "Render-result-error-messages.cs">}}

### **Errori durante il caricamento**

Alcuni problemi con i disegni possono essere osservati anche prima dell'inizio del processo di esportazione. 
La proprietà [**Errors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/errors/) nell'oggetto 
[**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/) viene utilizzata per memorizzare messaggi su di essi.
La proprietà [**IgnoreErrors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/ignoreerrors/) è utile per decidere se
è necessario generare un'eccezione sugli errori di caricamento o meno. 

Ecco un esempio dell'uso della proprietà Errors:

{{< gist aspose-com-gists b4f8af514a57a37e260cf1128011d34d "Errors-in-load-options.cs">}}
