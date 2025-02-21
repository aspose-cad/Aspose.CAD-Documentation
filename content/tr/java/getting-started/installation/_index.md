---
title: Kurulum
type: docs
weight: 30
url: /tr/java/getting-started/installation/
---

## **Maven Deposundan Aspose.CAD for Java’ı Yükleme**

Aspose, tüm Java API'lerini [Maven deposunda](https://releases.aspose.com/java/repo/com/aspose/) barındırmaktadır. Basit konfigürasyonlarla [Aspose.CAD for Java](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/) API'sini Maven Projelerinizde kolayca kullanabilirsiniz.

### **Maven Deposu Konfigürasyonunu Belirleyin**

Öncelikle, Maven pom.xml dosyanızda Aspose Maven Deposu konfigürasyonunu/konumunu aşağıdaki gibi belirtmelisiniz:

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

### **Aspose.CAD for Java API Bağımlılığını Tanımlayın**

Ardından, pom.xml dosyanızda Aspose.CAD for Java API bağımlılığını aşağıdaki gibi tanımlayın:

{{< highlight java >}}

 <dependencies>

    <dependency>

        <groupId>com.aspose</groupId>

        <artifactId>aspose-cad</artifactId>

        <version>24.3</version>        

   </dependency>

</dependencies>

{{< /highlight >}}

Yukarıdaki adımları gerçekleştirdikten sonra, Aspose.CAD for Java bağımlılığı sonunda Maven Projenizde tanımlanmış olacaktır.

## **Desteklenen Platformlar**

Aspose.CAD for Java, en popüler geliştirme ve dağıtım platformlarını destekler.

|**Özellik**|**Açıklama**|
| :- | :- |
|Masaüstü Uygulamaları|Aspose.CAD for Java, MS Windows'ta Masaüstü uygulamaları geliştirmek için kullanılabilir.|
|Kurumsal Web Uygulamaları|Aspose.CAD for Java, Web uygulamalarını tamamen destekler.|
|Linux/Unix|Aspose.CAD for Java, platformdan bağımsız bir API'dir ve Linux ve Unix ortamında çalışabilir.|

## **Desteklenen Java Sürümleri**

- J2SE 6.0 (1.6)
- J2SE 7.0 (1.7)
- J2SE 8.0 (1.8)
