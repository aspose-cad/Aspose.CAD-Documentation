---
title: Instalace
type: docs
weight: 30
url: /cs/java/getting-started/installation/
---

## **Instalace Aspose.CAD pro Java z repozitáře Maven**

Aspose hostuje všechny Java API na [Maven repozitáři](https://releases.aspose.com/java/repo/com/aspose/). Můžete snadno používat [Aspose.CAD pro Java](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/) API přímo ve svých Maven projektech s jednoduchými konfiguracemi.

### **Specifikace konfigurace Maven repozitáře**

Nejprve je třeba specifikovat konfiguraci/umístění Aspose Maven repozitáře ve vašem Maven souboru pom.xml následovně:

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

### **Definice závislosti Aspose.CAD pro Java API**

Poté definujte závislost Aspose.CAD pro Java API ve vašem souboru pom.xml následovně:

{{< highlight java >}}

 <dependencies>

    <dependency>

        <groupId>com.aspose</groupId>

        <artifactId>aspose-cad</artifactId>

        <version>24.3</version>        

   </dependency>

</dependencies>

{{< /highlight >}}

Po provedení výše uvedených kroků bude konečně definována závislost na Aspose.CAD pro Java ve vašem Maven projektu.

## **Podporované platformy**

Aspose.CAD pro Java podporuje nejpopulárnější vývojové a nasazovací platformy.

|**Funkce**|**Popis**|
| :- | :- |
|Aplikace pro PC|Aspose.CAD pro Java může být použito k vývoji desktopových aplikací v MS Windows.|
|Podnikové webové aplikace|Aspose.CAD pro Java kompletně podporuje webové aplikace.|
|Linux/Unix|Aspose.CAD pro Java je platformně nezávislé API a může pracovat v prostředí Linuxu a Unixu.|

## **Podporované verze Javy**

- J2SE 6.0 (1.6)
- J2SE 7.0 (1.7)
- J2SE 8.0 (1.8)
