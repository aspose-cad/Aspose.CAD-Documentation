---
title: Come Eseguire gli Esempi
type: docs
weight: 70
url: /it/java/getting-started/how-to-run-the-examples/
---

## **Scarica da GitHub**

Tutti gli esempi di Aspose.CAD per Java sono ospitati su [Github](https://github.com/aspose-cad/Aspose.CAD-for-Java). Puoi clona il repository utilizzando il tuo client Github preferito o scaricare il file ZIP da [qui](https://github.com/aspose-cad/Aspose.CAD-for-Java/archive/master.zip).

Estrai il contenuto del file ZIP in una qualsiasi cartella nel tuo computer. Tutti gli esempi si trovano nella cartella **Examples**.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**Figura: Directory degli Esempi di Aspose.CAD**|

## **Importa esempi nell'IDE**

Il progetto utilizza il sistema di build Maven. Qualsiasi IDE moderno può facilmente aprire o importare il progetto e le sue dipendenze. Qui sotto ti mostriamo come utilizzare IDE popolari per compilare ed eseguire gli esempi.

### **IntelliJ IDEA**

Clicca sul menu **File** e scegli **Open**. Naviga fino alla cartella del progetto e seleziona il file **pom.xml**.

|![todo:image_alt_text](https://i.imgur.com/nPfCrsR.png)|
| :- |
|**Figura: Seleziona File o Directory da Importare**|
Si aprirà il progetto e scaricherà automaticamente le dipendenze. Dalla scheda Progetto, naviga negli esempi nella cartella **src/main/java**. Per eseguire un esempio, fai clic con il tasto destro sul file e scegli "Run ..", l'esempio verrà eseguito e l'output verrà mostrato nella finestra di output della console integrata.

|![todo:image_alt_text](https://i.imgur.com/nMaSTiG.png)|
| :- |
|**Figura: Esegui Esempio**|

### **Eclipse**

Clicca sul menu **File** e scegli **Import**. Seleziona **Maven** - Progetti Maven Esistenti.

|![todo:image_alt_text](https://i.imgur.com/Ca0cHFr.png)|
| :- |
|**Figura: Importa**|
Naviga fino alla cartella che hai clonato o scaricato da GitHub e seleziona il file **pom.xml**. Si aprirà il progetto e scaricherà automaticamente le dipendenze. Dalla scheda Package Explorer, naviga negli esempi nella cartella **src/main/java**. Per eseguire un esempio, fai clic con il tasto destro sul file e scegli **Run As** - **Java Application**, l'esempio verrà eseguito e l'output verrà mostrato nella finestra di output della console integrata.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**Figura: Esegui Esempio**|

### **NetBeans**

Clicca sul menu **File** e scegli **Open Project**. Naviga fino alla cartella che hai clonato o scaricato da GitHub. L'icona della cartella **Examples** mostrerà che è un progetto Maven. Seleziona Examples e aprila.

|![todo:image_alt_text](https://i.imgur.com/KOcP5Z2.png)|
| :- |
|**Figura: Apri Progetto**|
Si aprirà il progetto e scaricherà automaticamente le dipendenze. Dalla scheda Progetti, naviga negli esempi nei **pacchetti sorgente**. Per eseguire un esempio, fai clic con il tasto destro sul file e scegli **Run File**, l'esempio verrà eseguito e l'output verrà mostrato nella finestra di output della console integrata.

|![todo:image_alt_text](https://i.imgur.com/VUUU4BD.png)|
| :- |
|**Figura: Esegui Esempio**|

## **Aggiunta della Libreria Aspose.CAD nel Repository Locale di Maven**

Quando importi il progetto **Esempi di Aspose.CAD** nell'IDE, Maven scarica automaticamente il file JAR aspose.cad dal [Repository Maven di Aspose](https://releases.aspose.com/java/repo/). Nel caso in cui tu non abbia accesso a Internet, puoi aggiungere manualmente il JAR nel tuo repository locale.

### **mvn install**

Scarica il [aspose.cad](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/), estrailo e copia il aspose.cad-version.jar in un'altra posizione, ad esempio, sul disco C. Esegui il seguente comando:

{{< highlight java >}}

 mvn install:install-file

    -Dfile=c:\aspose.cad-version.jar

    -DgroupId=com.aspose

    -DartifactId=aspose-cad

    -Dversion={version}

    -Dpackaging=jar

{{< /highlight >}}

Ora, il JAR **aspose.cad** è copiato nel tuo repository locale di Maven.

### **pom.xml**

Dopo l'installazione, dichiara le coordinate **aspose.cad** in pom.xml.

{{< highlight java >}}

 <dependency>

    <groupId>com.aspose</groupId>

    <artifactId>aspose-cad</artifactId>

    <version>17.11</version>

    <classifier>jdk16</classifier>

 </dependency>

{{< /highlight >}}

### **Fatto**

Compilalo, ora il JAR **aspose.cad** è in grado di essere recuperato dal tuo repository locale di Maven.

## **Contribuisci**

Se vuoi aggiungere o migliorare un esempio, ti incoraggiamo a contribuire al progetto. Tutti gli esempi e i progetti dimostrativi in questo repository sono open source e possono essere utilizzati liberamente nelle tue applicazioni.

Per contribuire, puoi fare un fork del repository, modificare il codice sorgente e inviare una Pull Request. Esamineremo le modifiche e le includeremo nel repository se ritenute utili.
