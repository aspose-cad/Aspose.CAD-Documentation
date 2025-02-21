---
title: Configurazione dei Demos
type: docs
weight: 40
url: /it/python-net/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD per Python include una serie di progetti demo per aiutarti a iniziare.

I demo forniti con Aspose.CAD per Python sono demo standard di Python modificati per dimostrare l'uso dei nuovi esportatori.

{{% /alert %}}

Per eseguire i demo di Aspose.CAD per Python, esegui i seguenti passi:

1. Scarica Python (ad es. https://sourceforge.net/projects/python-net/files/archive/). Assicurati di scaricare l'intero progetto archiviato con il codice sorgente e i demo, non solo un singolo JAR.
1. Estrai il progetto archiviato in una posizione sul tuo disco rigido, ad esempio C:\.
1. Copia tutte le cartelle demo dalla cartella \samples di **aspose-cad-xx.x.zip** in **\InstallDir\demo\samples**, dove "\InstallDir" è la posizione in cui hai estratto Python. Questo passaggio è necessario perché gli script di build dei demo si basano sulla struttura delle cartelle di Python, altrimenti dovrai modificare gli script di build.
1. Copia **aspose-cad-pythons-xx.x.jar** dalla cartella \lib di **aspose-cad-pythons-xx.x.zip** in **\InstallDir\lib**.
1. Prepara Ant Build Tool e Ivy Dependency Manager, vedere **\InstallDir\readme.txt**.
1. Modifica il **build.xml** in **\InstallDir\demo\samples**, aggiungi aspose-cad-pythons-xx.x.jar nel classpath:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-pythons-xx.xx.jar"/> </path>**.
1. Cambia la directory corrente in **\InstallDir\demo\hsqldb** ed esegui il seguente comando:
   **ant runServer**
1. Cambia la directory corrente in uno dei demo di Aspose.CAD per Python, ad esempio **\InstallDir\demo\samples\charts.ai** e esegui i seguenti comandi nella riga di comando:
   **ant test** - per produrre file di rapporto.
1. Apri uno dei documenti risultanti per visualizzarlo, ad esempio **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
