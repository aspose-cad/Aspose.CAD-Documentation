---
title: Licenze
type: docs
weight: 50
url: /it/net/getting-started/licensing/
---

{{% alert color="primary" %}}

Una volta che sei soddisfatto della tua valutazione di Aspose.CAD per .NET, acquista una licenza sul sito web di Aspose: [Portale Acquisti](https://purchase.aspose.com/buy). Familiarizzati con i diversi tipi di licenze disponibili. Se hai domande, [contatta il team vendite di Aspose](https://about.aspose.com/contact) e saranno felici di aiutarti.

Ogni licenza di Aspose include un abbonamento di un anno per aggiornamenti gratuiti a qualsiasi nuova versione o correzione che verrà rilasciata durante questo periodo. Offriamo supporto tecnico gratuito e illimitato sia agli utenti con licenza che a quelli in valutazione.

La licenza è un file XML di testo semplice che contiene dettagli come il nome del prodotto, il numero di sviluppatori autorizzati, la data di scadenza dell'abbonamento e così via. Il file è firmato digitalmente, quindi non modificare il file: anche aggiungere un'interruzione di riga extra invalida il file.

{{% /alert %}}

## **Quando Applicare una Licenza**

Segui queste semplici regole:

- La licenza deve essere impostata solo una volta per dominio dell'applicazione.
- È necessario impostare la licenza prima di utilizzare qualsiasi altra classe Aspose.CAD.
- Chiamare SetLicense più volte non è dannoso, ma spreca tempo di elaborazione.
- Se stai sviluppando un'applicazione Windows Forms o console, chiama SetLicense nel codice di avvio, prima di utilizzare le classi Aspose.CAD.
- Quando sviluppi un'applicazione ASP.NET, chiama SetLicense dal file Global.asax.cs (Global.asax.vb), nel metodo protetto Application_Start. Viene chiamato una sola volta quando l'applicazione viene avviata.
- Non chiamare SetLicense all'interno dei metodi Page_Load poiché significa che la licenza verrà caricata ogni volta che viene caricata una pagina web.
- Se stai sviluppando una libreria di classi, chiama SetLicense da un costruttore statico della classe che utilizza Aspose.CAD. Il costruttore statico viene eseguito prima che venga creata un'istanza della tua classe, assicurando che la licenza di Aspose.CAD sia impostata correttamente.

## **Applica Licenza utilizzando un File o un Oggetto Stream**

Usa il **[License.SetLicense](https://reference.aspose.com/cad/net/aspose.cad.license/setlicense/methods/1)** metodo per licenziare il componente. Il modo più semplice per impostare una licenza è mettere il file di licenza nella stessa cartella di Aspose.CAD.dll e specificare il nome del file, senza un percorso, come mostrato di seguito.

### **Caricamento di una Licenza da un File**

Questo frammento di codice inizializza una licenza memorizzata in un file o in una risorsa incorporata.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-ApplyLicenseByPath-ApplyLicenseByPath.cs" >}}

### **Caricamento di una Licenza da un Oggetto Stream**

Questo frammento di codice inizializza la licenza dallo stream.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-ApplyLicenseUsingFileStream-ApplyLicenseUsingFileStream.cs" >}}
