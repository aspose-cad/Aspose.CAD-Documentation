---
title: Come Eseguire gli Esempi
type: docs
weight: 70
url: /it/net/showcases/how-to-run-the-examples/
---

## **Requisiti Software**

Assicurati di soddisfare i seguenti requisiti prima di scaricare ed eseguire gli esempi.

1. Visual Studio 2010 o superiore
1. NuGet Package Manager installato in Visual Studio. Assicurati che l'ultima versione dell'API di NuGet sia installata in Visual Studio. Per dettagli su come installare il gestore pacchetti NuGet, controlla https://docs.microsoft.com/en-gb/nuget/install-nuget-client-tools
1. Vai su Strumenti->Opzioni->NuGet Package Manager->Origini pacchetti e assicurati che l'opzione **nuget.org** sia selezionata
1. Il progetto di esempio utilizza la funzionalità NuGet Automatic Package Restore, quindi dovresti avere una connessione Internet attiva. Se non hai una connessione Internet attiva sulla macchina in cui gli esempi devono essere eseguiti, controlla [Installazione](/it/cad/net/installation/) per aggiungere il riferimento a Aspose.CAD.dll nel progetto di esempio.

## **Scarica da GitHub**

Tutti gli esempi di Aspose.CAD per .NET sono ospitati su [GitHub](https://github.com/aspose-cad/Aspose.CAD-for-.NET).

- Puoi clonare il repository usando il tuo client GitHub preferito o scaricare il file ZIP da [qui](https://github.com/aspose-cad/Aspose.CAD-for-.NET/archive/master.zip).
- Estrai il contenuto del file ZIP in una cartella qualsiasi sul tuo computer. Tutti gli esempi si trovano nella cartella **Examples**.
- C'è un file di soluzione di Visual Studio per C#.
- I progetti sono stati creati in Visual Studio 2013, ma i file di soluzione sono compatibili con Visual Studio 2010 SP1 e versioni successive.
- Apri il file di soluzione in Visual Studio e compila il progetto.
- Al primo avvio, le dipendenze verranno scaricate automaticamente tramite NuGet.
- La cartella **Data** nella cartella principale di **Examples** contiene i file di input utilizzati dagli esempi in CSharp. È obbligatorio scaricare la cartella **Data** insieme al progetto di esempio.
- Apri il file RunExamples.cs, tutti gli esempi sono chiamati da qui.
- Decommenta gli esempi che desideri eseguire all'interno del progetto.

Sentiti libero di contattarci attraverso i nostri Forum se hai problemi a impostare o eseguire gli esempi.

## **Contribuire**

Se desideri aggiungere o migliorare un esempio, ti incoraggiamo a contribuire al progetto. Tutti gli esempi e i progetti di showcase in questo repository sono open source e possono essere liberamente utilizzati nelle tue applicazioni.

Per contribuire, puoi forkare il repository, modificare il codice sorgente e creare una pull request. Esamineremo le modifiche e le includeremo nel repository se ritenute utili.
