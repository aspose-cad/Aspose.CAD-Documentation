---
title: Installation
type: docs
weight: 30
url: /sv/java/getting-started/installation/
---

## **Installera Aspose.CAD för Java från Maven Repository**

Aspose hostar alla Java-APIs på [Maven-repositoriet](https://releases.aspose.com/java/repo/com/aspose/). Du kan enkelt använda [Aspose.CAD för Java](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/) API direkt i dina Maven-projekt med enkla konfigurationer.

### **Ange Maven Repository-konfiguration**

Först måste du ange Aspose Maven Repository-konfiguration/plats i din Maven pom.xml enligt följande:

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

### **Definiera Aspose.CAD för Java API-beroende**

Därefter definierar du Aspose.CAD för Java API-beroendet i din pom.xml enligt följande:

{{< highlight java >}}

 <dependencies>

    <dependency>

        <groupId>com.aspose</groupId>

        <artifactId>aspose-cad</artifactId>

        <version>24.3</version>        

   </dependency>

</dependencies>

{{< /highlight >}}

Efter att ha utfört ovanstående steg kommer Aspose.CAD för Java-beroendet slutligen att vara definierat i ditt Maven-projekt.

## **Stödda plattformar**

Aspose.CAD för Java stödjer de mest populära utvecklings- och distributionsplattformarna.

|**Funktion**|**Beskrivning**|
| :- | :- |
|Skrivbordsapplikationer|Aspose.CAD för Java kan användas för att utveckla skrivbordsapplikationer i MS Windows.|
|Företagswebbapplikationer|Aspose.CAD för Java stöder helt webbapplikationer.|
|Linux/Unix|Aspose.CAD för Java är en plattformsoberoende API och kan fungera i en Linux- och Unix-miljö.|

## **Stödda Java-versioner**

- J2SE 6.0 (1.6)
- J2SE 7.0 (1.7)
- J2SE 8.0 (1.8)
