---
title: Telepítés
type: docs
weight: 30
url: /hu/java/getting-started/installation/
---

## **Aspose.CAD telepítése Java számára a Maven tárolóból**

Az Aspose minden Java API-t a [Maven tárolóban](https://releases.aspose.com/java/repo/com/aspose/) tárol. Az [Aspose.CAD for Java](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/) API-t könnyedén használhatja a Maven projekteken belül egyszerű konfigurációkkal.

### **Adja meg a Maven tároló konfigurációját**

Először meg kell adnia az Aspose Maven tároló konfigurációját/helyét a Maven pom.xml fájlban a következőképpen:

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

### **Határozza meg az Aspose.CAD for Java API függőséget**

Ezután határozza meg az Aspose.CAD for Java API függőséget a pom.xml fájlban a következőképpen:

{{< highlight java >}}

 <dependencies>

    <dependency>

        <groupId>com.aspose</groupId>

        <artifactId>aspose-cad</artifactId>

        <version>24.3</version>        

   </dependency>

</dependencies>

{{< /highlight >}}

A fenti lépések elvégzése után végül az Aspose.CAD for Java függőség definiálva lesz a Maven projektjében.

## **Támogatott platformok**

Az Aspose.CAD for Java támogatja a legnépszerűbb fejlesztési és telepítési platformokat.

|**Jellemző**|**Leírás**|
| :- | :- |
|Asztali alkalmazások|Az Aspose.CAD for Java használható asztali alkalmazások fejlesztésére MS Windows környezetben.|
|Vállalati webalkalmazások|Az Aspose.CAD for Java teljes mértékben támogatja a webalkalmazásokat.|
|Linux/Unix|Az Aspose.CAD for Java platformfüggetlen API, és működhet Linux és Unix környezetben.|

## **Támogatott Java verziók**

- J2SE 6.0 (1.6)
- J2SE 7.0 (1.7)
- J2SE 8.0 (1.8)
