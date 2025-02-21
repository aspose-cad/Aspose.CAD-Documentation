---
title: Impostazione Demos
type: docs
weight: 40
url: /it/jasperreports/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD per JasperReports include una serie di progetti demo per aiutarti a iniziare.

Le demo fornite con Aspose.CAD per JasperReports sono demo standard di JasperReports modificate per dimostrare l'uso dei nuovi esportatori.

{{% /alert %}}

Per eseguire le demo di Aspose.CAD per JasperReports, segui i seguenti passaggi:

1. Scarica JasperReports (ad esempio https://sourceforge.net/projects/jasperreports/files/archive/). Assicurati di scaricare l'intero progetto archiviato con il codice sorgente e le demo, non solo un singolo JAR.
1. Estrai il progetto archiviato in una posizione sul tuo disco rigido, ad esempio C:\.
1. Copia tutte le cartelle demo dalla cartella \samples di **aspose-cad-xx.x.zip** in **\InstallDir\demo\samples**, dove "\InstallDir" è la posizione in cui hai estratto JasperReports. Questo passaggio è necessario perché gli script di build demo si basano sulla struttura delle cartelle di JasperReports, altrimenti dovrai modificare gli script di build.
1. Copia **aspose-cad-jasperreports-xx.x.jar** dalla cartella \lib di **aspose-cad-jasperreports-xx.x.zip** in **\InstallDir\lib**.
1. Prepara Ant Build Tool e Ivy Dependency Manager, vedi **\InstallDir\readme.txt**.
1. Modifica il **build.xml** in **\InstallDir\demo\samples**, aggiungi aspose-cad-jasperreports-xx.x.jar nel classpath:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-jasperreports-xx.xx.jar"/> </path>**.
1. Cambia la directory corrente in **\InstallDir\demo\hsqldb** ed esegui il seguente comando:
   **Ant runServer**
1. Cambia la directory corrente in una delle demo di Aspose.CAD per JasperReports, ad esempio **\InstallDir\demo\samples\charts.ai** ed esegui i seguenti comandi nel terminale:
   **ant test** - per produrre i file report.
1. Apri uno dei documenti risultanti per visualizzare, ad esempio **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
