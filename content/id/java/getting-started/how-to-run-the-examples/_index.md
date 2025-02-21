---
title: Cara Menjalankan Contoh
type: docs
weight: 70
url: /id/java/getting-started/how-to-run-the-examples/
---

## **Unduh dari GitHub**

Semua contoh Aspose.CAD untuk Java dihosting di [Github](https://github.com/aspose-cad/Aspose.CAD-for-Java). Anda dapat meng-clone repositori menggunakan klien Github favorit Anda atau mengunduh file ZIP dari [sini](https://github.com/aspose-cad/Aspose.CAD-for-Java/archive/master.zip).

Ekstrak konten file ZIP ke folder mana pun di komputer Anda. Semua contoh terletak di folder **Examples**.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**Gambar: Direktori Contoh Aspose.CAD**|

## **Impor contoh ke dalam IDE**

Proyek ini menggunakan sistem build Maven. IDE modern mana pun dapat dengan mudah membuka atau mengimpor proyek dan dependensinya. Di bawah ini kami menunjukkan kepada Anda cara menggunakan IDE populer untuk membangun dan menjalankan contoh.

### **IntelliJ IDEA**

Klik menu **File** dan pilih **Open**. Telusuri ke folder proyek dan pilih file **pom.xml**.

|![todo:image_alt_text](https://i.imgur.com/nPfCrsR.png)|
| :- |
|**Gambar: Pilih File atau Direktori untuk Diimpor**|
Ini akan membuka proyek dan mengunduh dependensi secara otomatis. Dari tab Proyek, telusuri contoh di folder **src/main/java**. Untuk menjalankan contoh, cukup klik kanan pada file dan pilih "Run ..", contoh akan dieksekusi dan output akan ditampilkan di jendela output konsol bawaan.

|![todo:image_alt_text](https://i.imgur.com/nMaSTiG.png)|
| :- |
|**Gambar: Jalankan Contoh**|

### **Eclipse**

Klik pada menu **File** dan pilih **Import**. Pilih **Maven** - Proyek Maven yang Ada.

|![todo:image_alt_text](https://i.imgur.com/Ca0cHFr.png)|
| :- |
|**Gambar: Impor**|
Telusuri ke folder yang Anda clone atau unduh dari GitHub dan pilih file **pom.xml**. Ini akan membuka proyek dan mengunduh dependensi secara otomatis. Dari tab Package Explorer, telusuri contoh di folder **src/main/java**. Untuk menjalankan contoh, cukup klik kanan pada file dan pilih **Run As** - **Java Application**, contoh akan dieksekusi dan output akan ditunjukkan di jendela output konsol bawaan.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**Gambar: Jalankan Contoh**|

### **NetBeans**

Klik pada menu **File** dan pilih **Open Project**. Telusuri ke folder yang Anda clone atau unduh dari GitHub. Ikon folder **Examples** akan menunjukkan bahwa itu adalah proyek Maven. Pilih Examples dan buka.

|![todo:image_alt_text](https://i.imgur.com/KOcP5Z2.png)|
| :- |
|**Gambar: Buka Proyek**|
Ini akan membuka proyek dan mengunduh dependensinya secara otomatis. Dari tab Projects, telusuri contoh di **source packages**. Untuk menjalankan contoh, cukup klik kanan pada file dan pilih **Run File**, contoh akan dieksekusi dan output akan ditunjukkan di jendela output konsol bawaan.

|![todo:image_alt_text](https://i.imgur.com/VUUU4BD.png)|
| :- |
|**Gambar: Jalankan Contoh**|

## **Menambahkan Library Aspose.CAD ke dalam Repository Lokal Maven**

Ketika Anda mengimpor proyek **Contoh Aspose.CAD** ke dalam IDE, Maven secara otomatis mengunduh file JAR aspose.cad dari [Aspose Maven Repository](https://releases.aspose.com/java/repo/). Jika Anda tidak memiliki akses ke internet, Anda dapat menambahkan JAR secara manual ke dalam repository lokal Anda.

### **mvn install**

Unduh [aspose.cad](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/), ekstrak, dan salin aspose.cad-version.jar ke tempat lain, misalnya, drive C. Jalankan perintah berikut:

{{< highlight java >}}

 mvn install:install-file

    -Dfile=c:\aspose.cad-version.jar

    -DgroupId=com.aspose

    -DartifactId=aspose-cad

    -Dversion={version}

    -Dpackaging=jar

{{< /highlight >}}

Sekarang, JAR **aspose.cad** telah disalin ke repository lokal Maven Anda.

### **pom.xml**

Setelah diinstal, cukup deklarasikan koordinator **aspose.cad** di pom.xml.

{{< highlight java >}}

 <dependency>

    <groupId>com.aspose</groupId>

    <artifactId>aspose-cad</artifactId>

    <version>17.11</version>

    <classifier>jdk16</classifier>

 </dependency>

{{< /highlight >}}

### **Selesai**

Buat sekarang, JAR **aspose.cad** dapat diambil dari repository lokal Maven Anda.

## **Berkontribusi**

Jika Anda ingin menambahkan atau meningkatkan sebuah contoh, kami mendorong Anda untuk berkontribusi pada proyek. Semua contoh dan proyek showcase di repositori ini bersifat open source dan dapat digunakan secara bebas dalam aplikasi Anda sendiri.

Untuk berkontribusi, Anda dapat fork repositori, edit kode sumber dan dapat mengajukan Pull Request. Kami akan meninjau perubahan dan menyertakannya dalam repositori jika dianggap bermanfaat.
