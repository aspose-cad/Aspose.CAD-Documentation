---
title: Instalasi
type: docs
weight: 30
url: /id/net/getting-started/installation/
---

## **Menginstal Aspose.CAD untuk .NET melalui NuGet**

NuGet adalah cara termudah untuk mengunduh dan menginstal Aspose API untuk .NET. Buka Microsoft Visual Studio dan manajer paket NuGet. Cari "aspose" untuk menemukan Aspose API yang diinginkan. Klik pada "Instal", API yang dipilih akan diunduh dan direferensikan dalam proyek Anda.

![todo:image_alt_text](/_assets/install/installation_1.png)

## **Mereferensikan Aspose.CAD dari Proyek .NET**

Ikuti langkah-langkah ini (dengan asumsi Anda menggunakan Microsoft Visual Studio):

1. Di **Solution Explorer**, kembangkan node proyek yang ingin Anda tambahkan referensinya.
1. Klik kanan pada node **References** untuk proyek dan pilih **Add Reference** dari menu pintas.
1. Dalam kotak dialog **Add Reference** dan telusuri lokasi file DLL.
1. Pilih file DLL *Aspose.CAD* dan klik tombol **OK**.
1. Referensi *Aspose.CAD* akan muncul di bawah node **References** proyek Anda.

![todo:image_alt_text](/_assets/install/installation_2.png)

### **Instal atau Perbarui Aspose.CAD menggunakan Konsol Manajer Paket**

Anda dapat mengikuti langkah-langkah di bawah ini untuk mereferensikan [API Aspose.CAD](https://www.nuget.org/packages/Aspose.CAD/) menggunakan konsol manajer paket:

1. Buka solusi/proyek Anda di Visual Studio.
1. Pilih Alat -> Manajer Paket Perpustakaan -> Konsol Manajer Paket dari menu untuk membuka konsol manajer paket.

![todo:image_alt_text](/_assets/install/installation_3.png)

Ketik perintah “**Install-Package Aspose.CAD**” dan tekan enter untuk menginstal rilis penuh terbaru ke dalam aplikasi Anda. Sebagai alternatif, Anda dapat menambahkan sufiks "**-prerelease**" ke perintah untuk menentukan bahwa rilis terbaru termasuk perbaikan darurat juga harus diinstal.

![todo:image_alt_text](/_assets/install/installation_4.png)

Anda akan melihat bahwa tip "Mengunduh Aspose.CAD..." muncul di bagian bawah kiri jendela yang menunjukkan bahwa proses pengunduhan sedang berlangsung.

![todo:image_alt_text](/_assets/install/installation_5.png)

Setelah diunduh Anda akan melihat pesan konfirmasi berikut. Jika Anda tidak terbiasa dengan [EULA Aspose](https://about.aspose.com/legal/eula), maka merupakan ide yang baik untuk membaca lisensi yang dirujuk dalam URL tersebut.

![todo:image_alt_text](/_assets/install/installation_6.png)

Kini Anda harus menemukan bahwa Aspose.CAD telah berhasil ditambahkan dan direferensikan dalam aplikasi Anda.

![todo:image_alt_text](/_assets/install/installation_7.png)

Di konsol manajer paket, Anda juga dapat menggunakan perintah “**Update-Package Aspose.CAD**” dan tekan enter untuk memeriksa pembaruan untuk paket Aspose.CAD dan menginstalnya jika ada. Anda juga dapat menambahkan sufiks "-prerelease" untuk memperbarui rilis terbaru.

## **Pertimbangan Saat Berjalan di Lingkungan Server Bersama**

Semua komponen Aspose .NET disarankan untuk dijalankan dengan set izin Full Trust. Ini karena komponen Aspose .NET kadang-kadang perlu mengakses pengaturan registry dan file yang terletak di tempat lain selain direktori virtual, misalnya untuk membaca font, dll. Selain itu, komponen Aspose.NET didasarkan pada kelas sistem .NET inti, beberapa di antaranya juga memerlukan izin Full Trust untuk berjalan dalam beberapa kasus.

Penyedia Layanan Internet yang menghosting beberapa aplikasi dari berbagai perusahaan umumnya menerapkan tingkat keamanan Medium Trust. Dalam kasus .NET 2.0, tingkat keamanan tersebut dapat menetapkan batasan berikut yang dapat memengaruhi kemampuan Aspose.CAD untuk berfungsi dengan baik.

- **RegistryPermission** tidak tersedia. Ini berarti Anda tidak dapat mengakses registry, yang diperlukan untuk enumerasi font yang terinstal saat merender dokumen.
- **FileIOPermission** dibatasi. Ini berarti Anda hanya dapat mengakses file dalam hierarki direktori virtual aplikasi Anda. Ini berpotensi berarti font tidak dapat dibaca selama ekspor.

Oleh karena alasan yang disebutkan di atas, disarankan agar Aspose.CAD dijalankan dengan izin Full Trust. Anda mungkin menemukan bahwa beberapa fitur dari perpustakaan akan berfungsi saat melakukan tugas yang berbeda dalam Medium Trust sementara beberapa tidak (seperti rendering) yang mungkin disebabkan oleh panggilan ke pemrosesan gambar GDI+.

## **Persyaratan Sistem**

### **Sistem Operasi**

Aspose.CAD untuk .NET mendukung sistem operasi 32-bit atau 64-bit di mana kerangka kerja .NET atau Mono diinstal termasuk, tetapi tidak terbatas pada:

- Microsoft Windows desktop (XP, Vista, 7, 8, 10) dan sistem operasi server (2003, 2008, 2012)
- Windows Azure
- Linux (Ubuntu, openSUSE, CentOS dan lainnya)
- Mac OS X

### **Kerangka Kerja**

Aspose.CAD untuk .NET mendukung:

- Versi .NET Framework dari 2.0 hingga 4.5 termasuk versi Client Profile
- .NET Core
- Mono 2.6.7 atau yang lebih baru

### **Lingkungan Pengembangan**

Anda dapat menggunakan Aspose.CAD untuk .NET untuk mengembangkan aplikasi di lingkungan pengembangan apa pun yang menargetkan platform .NET, tetapi lingkungan berikut secara eksplisit didukung:

- Microsoft Visual Studio 2010 atau lebih tinggi
- MonoDevelop 2.4 dan yang lebih baru
