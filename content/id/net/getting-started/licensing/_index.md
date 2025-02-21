---
title: Lisensi
type: docs
weight: 50
url: /id/net/getting-started/licensing/
---

{{% alert color="primary" %}}

Setelah Anda puas dengan evaluasi Anda terhadap Aspose.CAD untuk .NET, beli lisensi di situs web Aspose: [Portal Pembelian](https://purchase.aspose.com/buy). Kenali berbagai jenis lisensi yang tersedia. Jika Anda memiliki pertanyaan, [hubungi tim penjualan Aspose](https://about.aspose.com/contact) dan mereka akan dengan senang hati membantu Anda.

Setiap lisensi Aspose berlaku untuk satu tahun berlangganan untuk upgrade gratis ke versi atau perbaikan baru yang keluar selama periode ini. Kami menyediakan dukungan teknis gratis dan tidak terbatas untuk pengguna yang memiliki lisensi maupun pengguna evaluasi.

Lisensi adalah file XML berformat teks biasa yang berisi rincian seperti nama produk, jumlah pengembang berlisensi, tanggal kadaluarsa langganan, dan lain-lain. File tersebut ditandatangani secara digital, jadi jangan ubah file tersebut: bahkan menambahkan satu baris kosong tambahan ke file akan membuatnya tidak valid.

{{% /alert %}}

## **Kapan Mengajukan Lisensi**

Ikuti aturan sederhana ini:

- Lisensi hanya perlu diatur sekali per domain aplikasi.
- Anda perlu menetapkan lisensi sebelum menggunakan kelas Aspose.CAD lainnya.
- Memanggil SetLicense beberapa kali tidak berbahaya, tetapi membuang-buang waktu prosesor.
- Jika Anda sedang mengembangkan aplikasi Windows Forms atau konsol, panggil SetLicense dalam kode startup, sebelum menggunakan kelas Aspose.CAD.
- Saat mengembangkan aplikasi ASP.NET, panggil SetLicense dari file Global.asax.cs (Global.asax.vb), dalam metode terlindungi Application_Start. Ini dipanggil sekali saat aplikasi dimulai.
- Jangan panggil SetLicense dari dalam metode Page_Load karena itu berarti lisensi akan dimuat setiap kali halaman web dimuat.
- Jika Anda mengembangkan pustaka kelas, panggil SetLicense dari konstruktor statis kelas yang menggunakan Aspose.CAD. Konstruktor statis dieksekusi sebelum instance kelas Anda dibuat untuk memastikan lisensi Aspose.CAD diatur dengan benar.

## **Terapkan Lisensi menggunakan File atau Objek Stream**

Gunakan metode **[License.SetLicense](https://reference.aspose.com/cad/net/aspose.cad.license/setlicense/methods/1)** untuk melisensikan komponen. Cara termudah untuk menetapkan lisensi adalah dengan menempatkan file lisensi dalam folder yang sama dengan Aspose.CAD.dll dan menyebutkan nama file, tanpa jalur, seperti yang ditunjukkan di bawah ini.

### **Memuat Lisensi dari File**

Cuplikan kode ini menginisialisasi lisensi yang disimpan dalam file atau dalam sumber daya terbenam.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-ApplyLicenseByPath-ApplyLicenseByPath.cs" >}}

### **Memuat Lisensi dari Objek Stream**

Cuplikan kode ini menginisialisasi lisensi dari stream.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-ApplyLicenseUsingFileStream-ApplyLicenseUsingFileStream.cs" >}}
