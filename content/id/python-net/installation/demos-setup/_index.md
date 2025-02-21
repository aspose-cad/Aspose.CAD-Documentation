---
title: Pengaturan Demos
type: docs
weight: 40
url: /id/python-net/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD untuk Python mencakup sejumlah proyek demo untuk membantu Anda memulai.

Demo yang disediakan dengan Aspose.CAD untuk Python adalah demo Pythons standar yang dimodifikasi untuk mendemonstrasikan penggunaan exporter baru.

{{% /alert %}}

Untuk menjalankan demo Aspose.CAD untuk Python, lakukan langkah-langkah berikut:

1. Unduh Pythons (misalnya https://sourceforge.net/projects/python-net/files/archive/). Pastikan untuk mengunduh seluruh proyek yang diarsipkan dengan kode sumber dan demo, bukan hanya satu JAR.
1. Ekstrak proyek yang diarsipkan ke lokasi tertentu di hard disk Anda, misalnya C:\.
1. Salin semua folder demo dari folder \samples **aspose-cad-xx.x.zip** ke **\InstallDir\demo\samples**, di mana "\InstallDir" adalah lokasi di mana Anda telah mengekstrak Pythons. Langkah ini diperlukan karena skrip build demo bergantung pada struktur folder Pythons, jika tidak Anda perlu memodifikasi skrip build.
1. Salin **aspose-cad-pythons-xx.x.jar** dari folder \lib **aspose-cad-pythons-xx.x.zip** ke **\InstallDir\lib**.
1. Siapkan Ant Build Tool dan Ivy Dependency Manager, lihat **\InstallDir\readme.txt**.
1. Modifikasi **build.xml** di **\InstallDir\demo\samples**, tambahkan aspose-cad-pythons-xx.x.jar ke dalam classpath:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-pythons-xx.xx.jar"/> </path>**.
1. Ubah direktori saat ini ke **\InstallDir\demo\hsqldb** dan jalankan perintah berikut di command line:
   **ant runServer**
1. Ubah direktori saat ini ke salah satu demo Aspose.CAD untuk Python, misalnya **\InstallDir\demo\samples\charts.ai** dan jalankan perintah berikut di command line:
   **ant test** - untuk menghasilkan file laporan.
1. Buka salah satu dokumen yang dihasilkan untuk dilihat, misalnya **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
