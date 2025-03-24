---
title: Installazione
type: docs
weight: 30
url: /it/net/getting-started/installation/
---

## **Installazione di Aspose.CAD per .NET tramite NuGet**

NuGet è il modo più semplice per scaricare e installare le API Aspose per .NET. Apri Microsoft Visual Studio e il gestore pacchetti NuGet. Cerca "aspose" per trovare l'API Aspose desiderata. Fai clic su "Installa", l'API selezionata verrà scaricata e referenziata nel tuo progetto.

![todo:image_alt_text](/cad/_assets/install/installation_1.png)

## **Riferimento a Aspose.CAD da un Progetto .NET**

Segui questi passaggi (supponendo che tu stia utilizzando Microsoft Visual Studio):

1. In **Esplora Soluzioni**, espandi il nodo del progetto a cui desideri aggiungere un riferimento.
1. Fai clic destro sul nodo **Riferimenti** per il progetto e seleziona **Aggiungi Riferimento** dal menu di scelta rapida.
1. Nella finestra di dialogo **Aggiungi Riferimento**, sfoglia la posizione del file DLL.
1. Seleziona il file DLL *Aspose.CAD* e fai clic sul pulsante **OK**.
1. Il riferimento *Aspose.CAD* apparirà sotto il nodo **Riferimenti** del tuo progetto.

![todo:image_alt_text](/cad/_assets/install/installation_2.png)

### **Installa o Aggiorna Aspose.CAD utilizzando la Console del gestore pacchetti**

Puoi seguire i passaggi seguenti per fare riferimento all'[API Aspose.CAD](https://www.nuget.org/packages/Aspose.CAD/) utilizzando la console del gestore pacchetti:

1. Apri la tua soluzione/progetto in Visual Studio.
1. Seleziona Strumenti -> Gestore Pacchetti Library -> Console del Gestore Pacchetti dal menu per aprire la console del gestore pacchetti.

![todo:image_alt_text](/cad/_assets/install/installation_3.png)

Digita il comando “**Install-Package Aspose.CAD**” e premi invio per installare l'ultima versione completa nella tua applicazione. In alternativa, puoi aggiungere il suffisso "**-prerelease**" al comando per specificare che deve essere installata anche l'ultima versione comprensiva di hotfix.

![todo:image_alt_text](/cad/_assets/install/installation_4.png)

Vedrai che il messaggio "Downloading Aspose.CAD..." appare in basso a sinistra della finestra per indicare che il download è in corso. 

![todo:image_alt_text](/cad/_assets/install/installation_5.png)

Una volta scaricato, vedrai i seguenti messaggi di conferma. Se non sei familiare con l'[EULA di Aspose](https://about.aspose.com/legal/eula), è una buona idea leggere la licenza menzionata nell'URL.

![todo:image_alt_text](/cad/_assets/install/installation_6.png)

Dovresti ora trovare che Aspose.CAD è stato aggiunto e referenziato con successo nella tua applicazione.

![todo:image_alt_text](/cad/_assets/install/installation_7.png)

Nella console del gestore pacchetti, puoi anche utilizzare il comando “**Update-Package Aspose.CAD**” e premere invio per controllare eventuali aggiornamenti al pacchetto Aspose.CAD e installarli se presenti. Puoi anche aggiungere il suffisso "-prerelease" per aggiornare all'ultima versione.

## **Considerazioni Quando si Esegue in un Ambiente Server Condiviso**

Tutti i componenti Aspose .NET sono consigliati per essere eseguiti con un set di permessi Full Trust. Questo perché i componenti Aspose .NET a volte devono accedere alle impostazioni del registro e ai file situati in luoghi diversi dalla directory virtuale, ad esempio per leggere i font, ecc. Inoltre, i componenti Aspose.NET si basano su classi di sistema core .NET, alcune delle quali richiedono anche permessi Full Trust per funzionare in alcuni casi.

I fornitori di servizi Internet che ospitano più applicazioni di diverse aziende applicano principalmente un livello di sicurezza Medium Trust. Nel caso di .NET 2.0, tale livello di sicurezza potrebbe impostare i seguenti vincoli che potrebbero influenzare la capacità di Aspose.CAD di funzionare correttamente.

- **RegistryPermission** non è disponibile. Questo significa che non puoi accedere al registro, il che è necessario per enumerare i font installati durante il rendering dei documenti.
- **FileIOPermission** è ristretto. Questo significa che puoi accedere solo ai file nella gerarchia della directory virtuale della tua applicazione. Questo significa potenzialmente che i font non possono essere letti durante l'esportazione.

Per queste ragioni specificate sopra, si raccomanda che Aspose.CAD venga eseguito con permessi Full Trust. Potresti scoprire che alcune funzionalità della libreria funzionano quando si eseguono diversi compiti in Medium Trust mentre altre no (ad esempio il rendering) che potrebbe essere dovuto a chiamate al processamento delle immagini GDI+.

## **Requisiti di Sistema**

### **Sistemi Operativi**

Aspose.CAD per .NET supporta qualsiasi sistema operativo a 32 o 64 bit in cui è installato il framework .NET o Mono, inclusi, ma non limitati a:

- Microsoft Windows desktop (XP, Vista, 7, 8, 10) e sistemi operativi server (2003, 2008, 2012)
- Windows Azure
- Linux (Ubuntu, openSUSE, CentOS e altri)
- Mac OS X

### **Framework**

Aspose.CAD per .NET supporta:

- Versioni del .NET Framework da 2.0 a 4.5, comprese le versioni Client Profile
- .NET Core
- Mono 2.6.7 o successivo

### **Ambientazioni di Sviluppo**

Puoi utilizzare Aspose.CAD per .NET per sviluppare applicazioni in qualsiasi ambiente di sviluppo che targeting la piattaforma .NET, ma i seguenti ambienti sono esplicitamente supportati:

- Microsoft Visual Studio 2010 o superiore
- MonoDevelop 2.4 e successivi
