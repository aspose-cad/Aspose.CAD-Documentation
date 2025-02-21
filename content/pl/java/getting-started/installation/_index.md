---
title: Instalacja
type: docs
weight: 30
url: /pl/java/getting-started/installation/
---

## **Instalacja Aspose.CAD dla Javy z repozytorium Maven**

Aspose hostuje wszystkie API Javy w [repozytorium Maven](https://releases.aspose.com/java/repo/com/aspose/). Możesz łatwo używać [Aspose.CAD dla Javy](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/) API bezpośrednio w swoich projektach Maven z prostymi konfiguracjami.

### **Określenie konfiguracji repozytorium Maven**

Najpierw musisz określić konfigurację/lokalizację repozytorium Aspose Maven w swoim pliku pom.xml w następujący sposób:

{{< highlight java >}}

<repositories>
    <repository>
        <id>asposeJavaAPI</id>
        <name>API Aspose Java</name>
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

### **Zdefiniowanie zależności API Aspose.CAD dla Javy**

Następnie zdefiniuj zależność API Aspose.CAD dla Javy w swoim pliku pom.xml w następujący sposób:

{{< highlight java >}}

 <dependencies>

    <dependency>

        <groupId>com.aspose</groupId>

        <artifactId>aspose-cad</artifactId>

        <version>24.3</version>        

   </dependency>

</dependencies>

{{< /highlight >}}

Po wykonaniu powyższych kroków, zależność Aspose.CAD dla Javy zostanie ostatecznie zdefiniowana w Twoim projekcie Maven.

## **Obsługiwane platformy**

Aspose.CAD dla Javy obsługuje najpopularniejsze platformy deweloperskie i wdrożeniowe.

|**Funkcja**|**Opis**|
| :- | :- |
|Aplikacje desktopowe|Aspose.CAD dla Javy może być używane do rozwijania aplikacji desktopowych w systemie MS Windows.|
|Aplikacje internetowe dla przedsiębiorstw|Aspose.CAD dla Javy całkowicie obsługuje aplikacje internetowe.|
|Linux/Unix|Aspose.CAD dla Javy jest API niezależnym od platformy i może działać w środowisku Linux i Unix.|

## **Obsługiwane wersje Javy**

- J2SE 6.0 (1.6)
- J2SE 7.0 (1.7)
- J2SE 8.0 (1.8)
