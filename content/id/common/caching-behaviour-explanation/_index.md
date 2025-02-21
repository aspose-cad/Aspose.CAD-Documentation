---
title: Menjelaskan perilaku caching dari Aspose.CAD
type: docs
weight: 20
url: /id/common/caching-behaviour-explanation/
---


## **Bagaimana Aspose.CAD menyimpan data dalam cache**

Semua caching yang dilakukan oleh Aspose.CAD sepenuhnya otomatis, tanpa perlu atau mungkin adanya input dari pengguna. Pada dasarnya ada tiga jenis caching, semuanya terkait dengan font.

### **Cache nama font**

Cache nama font digunakan untuk memfasilitasi waktu startup yang lebih cepat dengan memproses sebelumnya semua file font yang ditemukan dan menyusun daftar nama font yang ada dalam file-file ini, karena satu file font dapat berisi lebih dari satu font. Ini disimpan sebagai file sementara dan biasanya berukuran beberapa puluh kilobyte untuk sebagian besar sistem.

### **Cache data glyph font**

Cache dalam memori dari semua glyph yang telah digunakan selama masa aplikasi untuk mengurangi pembacaan ulang file font yang sebenarnya di disk selama ekspor berikutnya. Dengan demikian, ini akan menyebabkan peningkatan konsumsi memori jika ekspor berikutnya memiliki file yang merujuk kepada font baru dan/atau mengandung karakter yang belum ditemukan sebelumnya. Namun, dalam praktiknya, bahkan pada seluruh 
suite uji Aspose.CAD, dengan ribuan file termasuk file dalam berbagai bahasa, konsumsi memorinya sekitar 200 megabyte, yang tidak signifikan untuk sistem modern.

### **Cache fallback font per karakter**

Cache dalam memori yang menyimpan font yang mengandung karakter tertentu untuk semua karakter Unicode agar memudahkan pemilihan font pengganti jika font yang disuplai oleh entitas teks dalam gambar tidak mengandung karakter dalam konten teks entitas tersebut. Cache ini dibangun pada operasi ekspor pertama selama masa aplikasi dan ada sampai aplikasi dihentikan. Pada mesin uji kami yang relatif sederhana dengan koleksi font besar yang digunakan dalam suite uji, cache ini membutuhkan waktu sekitar 30 detik untuk dibangun dan mengambil 70 megabyte. Setelah dibangun, cache ini tidak lagi memakan waktu dan tidak berkembang.
