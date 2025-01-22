---
title: Installation
type: docs
weight: 30
url: /de/java/installation/
---

## **Aspose.CAD für Java aus dem Maven-Repository installieren**

Aspose hostet alle Java-APIs im [Maven-Repository](https://releases.aspose.com/java/repo/com/aspose/). Sie können die [Aspose.CAD für Java](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/) API ganz einfach in Ihren Maven-Projekten mit einfachen Konfigurationen verwenden.

### **Maven-Repository-Konfiguration definieren**

Zuerst müssen Sie die Konfiguration/den Speicherort des Aspose Maven-Repository in Ihrer Maven pom.xml wie folgt angeben:

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

### **Abhängigkeit von Aspose.CAD für Java API definieren**

Dann definieren Sie die Abhängigkeit von Aspose.CAD für Java API in Ihrer pom.xml wie folgt:

{{< highlight java >}}
 <dependencies>
    <dependency>
        <groupId>com.aspose</groupId>
        <artifactId>aspose-cad</artifactId>
        <version>24.3</version>        
   </dependency>
</dependencies>
{{< /highlight >}}

Nach Ausführung der obigen Schritte wird die Aspose.CAD für Java-Abhängigkeit schließlich in Ihrem Maven-Projekt definiert.

## **Unterstützte Plattformen**

Aspose.CAD für Java unterstützt die beliebtesten Entwicklungs- und Bereitstellungsplattformen.

|**Feature**|**Beschreibung**|
| :- | :- |
|Desktop-Anwendungen|Aspose.CAD für Java kann zur Entwicklung von Desktop-Anwendungen in MS Windows verwendet werden.|
|Enterprise-Webanwendungen|Aspose.CAD für Java unterstützt vollständig Webanwendungen.|
|Linux/Unix|Aspose.CAD für Java ist eine plattformunabhängige API und kann in einer Linux- und Unix-Umgebung arbeiten.|

## **Unterstützte Java-Versionen**

- J2SE 6.0 (1.6)
- J2SE 7.0 (1.7)
- J2SE 8.0 (1.8)
