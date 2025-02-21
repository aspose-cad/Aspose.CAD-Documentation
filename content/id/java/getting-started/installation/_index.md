---
title: Instalasi
type: docs
weight: 30
url: /id/java/getting-started/installation/
---

## **Menginstal Aspose.CAD untuk Java dari Repositori Maven**

Aspose menyimpan semua API Java di [repositori Maven](https://releases.aspose.com/java/repo/com/aspose/). Anda dapat dengan mudah menggunakan API [Aspose.CAD untuk Java](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/) langsung di Proyek Maven Anda dengan konfigurasi yang sederhana.

### **Tentukan Konfigurasi Repositori Maven**

Pertama, Anda perlu menentukan konfigurasi/lokasi Repositori Maven Aspose di pom.xml Maven Anda sebagai berikut:

{{< highlight java >}}

<repositories>
    <repository>
        <id>asposeJavaAPI</id>
        <name>API Java Aspose</name>
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

### **Tentukan Ketergantungan API Aspose.CAD untuk Java**

Kemudian tentukan ketergantungan API Aspose.CAD untuk Java di pom.xml Anda sebagai berikut:

{{< highlight java >}}

 <dependencies>

    <dependency>

        <groupId>com.aspose</groupId>

        <artifactId>aspose-cad</artifactId>

        <version>24.3</version>        

   </dependency>

</dependencies>

{{< /highlight >}}

Setelah melakukan langkah-langkah di atas, ketergantungan Aspose.CAD untuk Java akhirnya akan didefinisikan dalam Proyek Maven Anda.

## **Platform yang Didukung**

Aspose.CAD untuk Java mendukung platform pengembangan dan penerapan yang paling populer.

|**Fitur**|**Deskripsi**|
| :- | :- |
|Aplikasi Desktop|Aspose.CAD untuk Java dapat digunakan untuk mengembangkan aplikasi Desktop di MS Windows.|
|Aplikasi Web Perusahaan|Aspose.CAD untuk Java sepenuhnya mendukung aplikasi Web.|
|Linux/Unix|Aspose.CAD untuk Java adalah API yang independen platform dan dapat bekerja di lingkungan Linux dan Unix.|

## **Versi Java yang Didukung**

- J2SE 6.0 (1.6)
- J2SE 7.0 (1.7)
- J2SE 8.0 (1.8)
