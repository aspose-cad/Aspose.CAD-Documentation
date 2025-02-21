---
title: Installazione
type: docs
weight: 30
url: /it/java/getting-started/installation/
---

## **Installare Aspose.CAD per Java dal Maven Repository**

Aspose ospita tutte le API Java nel [Maven repository](https://releases.aspose.com/java/repo/com/aspose/). Puoi usare facilmente l'API [Aspose.CAD per Java](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/) direttamente nei tuoi progetti Maven con semplici configurazioni.

### **Specifica la configurazione del Maven Repository**

Prima di tutto, devi specificare la configurazione/localizzazione del Maven Repository di Aspose nel tuo pom.xml Maven come segue:

{{< highlight java >}}

<repositories>
    <repository>
        <id>asposeJavaAPI</id>
        <name>Aspose Java API</name>
        <url>https://releases.aspose.cloud/java/repo/</url>
        <snapshots>
            <enabled>false</enabled>
        </snapshots>
        <releases>
            <enabled>true</enabled>
        </releases>
    </repository>
</repositories>

{{< /highlight >}}

### **Definire la dipendenza dell'API Aspose.CAD per Java**

Poi definisci la dipendenza dell'API Aspose.CAD per Java nel tuo pom.xml come segue:

{{< highlight java >}}

 <dependencies>

    <dependency>

        <groupId>com.aspose</groupId>

        <artifactId>aspose-cad</artifactId>

        <version>24.3</version>        

   </dependency>

</dependencies>

{{< /highlight >}}

Dopo aver eseguito i passaggi sopra, la dipendenza di Aspose.CAD per Java sarà finalmente definita nel tuo progetto Maven.

## **Piattaforme supportate**

Aspose.CAD per Java supporta le piattaforme di sviluppo e distribuzione più popolari.

|**Caratteristica**|**Descrizione**|
| :- | :- |
|Applicazioni Desktop|Aspose.CAD per Java può essere utilizzato per sviluppare applicazioni Desktop in MS Windows.|
|Applicazioni Web Aziendali|Aspose.CAD per Java supporta completamente le applicazioni Web.|
|Linux/Unix|Aspose.CAD per Java è un'API indipendente dalla piattaforma e può funzionare in un ambiente Linux e Unix.|

## **Versioni Java supportate**

- J2SE 6.0 (1.6)
- J2SE 7.0 (1.7)
- J2SE 8.0 (1.8)
