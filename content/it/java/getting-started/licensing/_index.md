---
title: Licenza
type: docs
weight: 50
url: /it/java/getting-started/licensing/
---

{{% alert color="primary" %}}

Puoi scaricare una versione di valutazione di **Aspose.CAD** per Java dalla [sua pagina di download](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/). La versione di valutazione fornisce esattamente le stesse capacità della versione con licenza del prodotto. Inoltre, la versione di valutazione diventa semplicemente con licenza quando acquisti una licenza e aggiungi un paio di righe di codice per applicare la licenza.

Una volta che sei soddisfatto della tua valutazione di **Aspose.CAD**, puoi [acquistare una licenza](https://purchase.aspose.com/buy) sul sito web di Aspose. Familiarizzati con i diversi tipi di abbonamento offerti. Se hai domande, non esitare a contattare il team vendite di Aspose.

Ogni licenza Aspose include un abbonamento di un anno per aggiornamenti gratuiti a qualsiasi nuova versione o correzione che viene rilasciata durante questo periodo. Il supporto tecnico è gratuito e illimitato e fornito sia agli utenti con licenza che a quelli di valutazione.

{{% /alert %}}

Se desideri testare **Aspose.CAD** senza limitazioni della versione di valutazione, richiedi una licenza temporanea di 30 giorni. Si prega di fare riferimento a [Come ottenere una licenza temporanea?](https://purchase.aspose.com/temporary-license) per ulteriori informazioni.

## **Impostare una Licenza**

La licenza è un file XML in testo semplice che contiene dettagli come il nome del prodotto, il numero di sviluppatori a cui è concessa la licenza, la data di scadenza dell'abbonamento e così via. Il file è firmato digitalmente, quindi non modificare il file; anche l'aggiunta involontaria di un'interruzione di riga extra nel file lo invaliderà.

È necessario impostare una licenza prima di eseguire qualsiasi operazione con i file AutoCAD. È richiesto di impostare una licenza una sola volta per applicazione o processo.

La licenza può essere caricata da uno stream o file nelle seguenti posizioni:

1. Percorso esplicito.
1. La cartella che contiene l'Aspose.CAD.jar.

Utilizza il metodo License.setLicense() per concedere la licenza al componente. Spesso il modo più semplice per impostare una licenza è mettere il file di licenza nella stessa cartella di Aspose.CAD.jar e specificare solo il nome del file senza percorso, come mostrato nel seguente esempio:

### **Esempio 1**

In questo esempio, **Aspose.CAD** tenterà di trovare il file di licenza nella cartella che contiene i JAR della tua applicazione.

{{< highlight java >}}

com.aspose.cad.License license = new com.aspose.cad.License();

license.setLicense("Aspose.CAD.Java.lic");

{{< /highlight >}}

### **Esempio 2**

Inizializza una licenza da uno stream.

{{< highlight java >}}

com.aspose.cad.License license = new com.aspose.cad.License();

license.setLicense(new java.io.FileInputStream("Aspose.CAD.Java.lic"));

{{< /highlight >}}

## **Convalidare la Licenza**

È possibile convalidare se la licenza è stata impostata correttamente o meno. La classe License ha il campo isLicensed che restituirà true se la licenza è stata impostata correttamente.

{{< highlight java >}}

License license = new License();

license.setLicense("Aspose.CAD.Java.lic");

if (License.isLicensed()) {

    System.out.println("Licenza impostata!");

}

{{< /highlight >}}
