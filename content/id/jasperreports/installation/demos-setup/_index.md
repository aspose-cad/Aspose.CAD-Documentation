---
title: Pengaturan Demos
type: docs
weight: 40
url: /id/jasperreports/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD untuk JasperReports mencakup sejumlah proyek demo untuk membantu Anda memulai.

Demo yang disediakan dengan Aspose.CAD untuk JasperReports adalah demo JasperReports standar yang dimodifikasi untuk menunjukkan penggunaan pemuat baru.

{{% /alert %}}

Untuk menjalankan demo Aspose.CAD untuk JasperReports, lakukan langkah-langkah berikut:

1. Unduh JasperReports (misalnya https://sourceforge.net/projects/jasperreports/files/archive/). Pastikan untuk mengunduh seluruh proyek arsip dengan kode sumber dan demo, bukan hanya satu JAR.
1. Ekstrak proyek arsip ke lokasi di hard disk Anda, misalnya C:\.
1. Salin semua folder demo dari folder \samples dari **aspose-cad-xx.x.zip** ke **\InstallDir\demo\samples**, di mana "\InstallDir" adalah lokasi di mana Anda mengekstrak JasperReports. Langkah ini diperlukan karena skrip build demo bergantung pada struktur folder JasperReports, jika tidak, Anda perlu memodifikasi skrip build.
1. Salin **aspose-cad-jasperreports-xx.x.jar** dari folder \lib dari **aspose-cad-jasperreports-xx.x.zip** ke **\InstallDir\lib**.
1. Siapkan Ant Build Tool dan Ivy Dependency Manager, lihat **\InstallDir\readme.txt**.
1. Modifikasi **build.xml** di **\InstallDir\demo\samples**, tambahkan aspose-cad-jasperreports-xx.x.jar ke dalam classpath:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-jasperreports-xx.xx.jar"/> </path>**.
1. Ubah direktori saat ini ke **\InstallDir\demo\hsqldb** dan jalankan perintah berikut di baris perintah:
   **Ant runServer**
1. Ubah direktori saat ini ke salah satu demo Aspose.CAD untuk JasperReports, misalnya **\InstallDir\demo\samples\charts.ai** dan jalankan perintah berikut di baris perintah:
   **ant test** - untuk menghasilkan file laporan.
1. Buka salah satu dokumen hasil untuk melihat, misalnya **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
