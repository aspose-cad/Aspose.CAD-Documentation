---
title: Lisensi
type: docs
weight: 50
url: /id/java/getting-started/licensing/
---

{{% alert color="primary" %}}

Anda dapat mengunduh versi evaluasi dari **Aspose.CAD** untuk Java dari [halaman unduhnya](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/). Versi evaluasi menyediakan kemampuan yang sama persis dengan versi berlisensi dari produk. Selain itu, versi evaluasi secara otomatis menjadi berlisensi ketika Anda membeli lisensi dan menambahkan beberapa baris kode untuk menerapkan lisensi tersebut.

Setelah Anda puas dengan evaluasi **Aspose.CAD** Anda, Anda dapat [membeli lisensi](https://purchase.aspose.com/buy) di situs web Aspose. Kenali berbagai jenis langganan yang ditawarkan. Jika Anda memiliki pertanyaan, jangan ragu untuk menghubungi tim penjualan Aspose.

Setiap lisensi Aspose membawa langganan satu tahun untuk upgrade gratis ke versi baru atau perbaikan yang dirilis selama waktu ini. Dukungan teknis gratis dan tidak terbatas diberikan baik untuk pengguna berlisensi maupun evaluasi.

{{% /alert %}}

Jika Anda ingin menguji **Aspose.CAD** tanpa batasan versi evaluasi, minta lisensi sementara selama 30 hari. Silakan rujuk ke [Cara mendapatkan Lisensi Sementara?](https://purchase.aspose.com/temporary-license) untuk informasi lebih lanjut.

## **Menetapkan Lisensi**

Lisensi adalah file XML teks biasa yang berisi rincian seperti nama produk, jumlah pengembang yang dilisensikan, tanggal kedaluwarsa langganan, dan sebagainya. File ini ditandatangani secara digital, jadi jangan mengubah file tersebut; bahkan penambahan baris kosong tambahan yang tidak disengaja di dalam file akan membuatnya menjadi tidak valid.

Anda perlu menetapkan lisensi sebelum melakukan operasi apa pun dengan file AutoCAD. Anda hanya diminta untuk menetapkan lisensi sekali per aplikasi atau proses.

Lisensi dapat dimuat dari aliran atau file di lokasi berikut:

1. Jalur eksplisit.
1. Folder yang berisi Aspose.CAD.jar.

Gunakan metode License.setLicense() untuk melisensikan komponen. Sering kali cara termudah untuk menetapkan lisensi adalah dengan menempatkan file lisensi di folder yang sama dengan Aspose.CAD.jar dan hanya menyebutkan nama file tanpa jalur seperti yang ditunjukkan dalam contoh berikut:

### **Contoh 1**

Dalam contoh ini, **Aspose.CAD** akan mencoba menemukan file lisensi di folder yang berisi JAR aplikasi Anda.

{{< highlight java >}}

com.aspose.cad.License license = new com.aspose.cad.License();

license.setLicense("Aspose.CAD.Java.lic");

{{< /highlight >}}

### **Contoh 2**

Menginisialisasi lisensi dari aliran.

{{< highlight java >}}

com.aspose.cad.License license = new com.aspose.cad.License();

license.setLicense(new java.io.FileInputStream("Aspose.CAD.Java.lic"));

{{< /highlight >}}

## **Memvalidasi Lisensi**

Dimungkinkan untuk memvalidasi apakah lisensi telah ditetapkan dengan benar atau tidak. Kelas License memiliki field isLicensed yang akan mengembalikan true jika lisensi telah ditetapkan dengan benar.

{{< highlight java >}}

License license = new License();

license.setLicense("Aspose.CAD.Java.lic");

if (License.isLicensed()) {

    System.out.println("Lisensi Telah Ditetapkan!");

}

{{< /highlight >}}
