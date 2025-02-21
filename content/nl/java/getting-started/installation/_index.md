---
title: Installatie
type: docs
weight: 30
url: /nl/java/getting-started/installation/
---

## **Aspose.CAD voor Java installeren vanuit Maven Repository**

Aspose host alle Java API's op de [Maven repository](https://releases.aspose.com/java/repo/com/aspose/). U kunt de [Aspose.CAD voor Java](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/) API eenvoudig gebruiken in uw Maven projecten met eenvoudige configuraties.

### **Maven Repository Configuratie Opgeven**

Eerst moet u de configuratie/lokatie van de Aspose Maven Repository in uw Maven pom.xml opgeven als volgt:

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

### **Afhankelijkheid van Aspose.CAD voor Java API Definiëren**

Definieer vervolgens de afhankelijkheid van Aspose.CAD voor Java API in uw pom.xml als volgt:

{{< highlight java >}}

 <dependencies>

    <dependency>

        <groupId>com.aspose</groupId>

        <artifactId>aspose-cad</artifactId>

        <version>24.3</version>        

   </dependency>

</dependencies>

{{< /highlight >}}

Na het uitvoeren van bovenstaande stappen, zal de afhankelijkheid van Aspose.CAD voor Java uiteindelijk gedefinieerd zijn in uw Maven project.

## **Ondersteunde Platforms**

Aspose.CAD voor Java ondersteunt de meest populaire ontwikkelings- en implementatieplatforms.

|**Kenmerk**|**Beschrijving**|
| :- | :- |
|Desktoptoepassingen|Aspose.CAD voor Java kan worden gebruikt om desktoptoepassingen in MS Windows te ontwikkelen.|
|Enterprise Webtoepassingen|Aspose.CAD voor Java ondersteunt volledig webtoepassingen.|
|Linux/Unix|Aspose.CAD voor Java is een platformonafhankelijke API en kan werken in een Linux- en Unix-omgeving.|

## **Ondersteunde Java Versies**

- J2SE 6.0 (1.6)
- J2SE 7.0 (1.7)
- J2SE 8.0 (1.8)
