---
title: Kesalahan callback selama ekspor dan pemuatan
type: docs
weight: 40
url: /id/net/developer-guide/callback-errors-during-export-and-loading/
---

## **Tinjauan kesalahan callback selama ekspor dan pemuatan**

Mungkin selama ekspor atau pemuatan gambar kita mengalami kesalahan yang terkait dengan struktur berkas 
(misalnya, bagian-bagian dalam berkas sekarang diperlukan tetapi tidak sebelumnya). 
Beberapa di antaranya bersifat kritis dan dalam kasus seperti itu pengecualian akan dilemparkan, tetapi kita juga bisa mengabaikan beberapa di antaranya secara internal dan memberi tahu tentangnya menggunakan pesan callback.
Bagaimanapun, semua pesan ini membutuhkan perhatian karena mereka dapat menjelaskan misalnya entitas yang hilang dalam hasil ekspor atau efek lainnya.


### **Kesalahan selama ekspor**

Ada field RenderResult dalam [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/),
yang mencakup IsRenderComplete untuk mendapatkan apakah ada kesalahan selama ekspor dan mencetak informasi tentang mereka:

{{< gist aspose-com-gists 90b8a0a5ce7d0fc5d8d9a8c5bf4b816d "Render-result-error-messages.cs">}}

### **Kesalahan selama pemuatan**

Beberapa masalah dengan gambar mungkin dapat diamati lebih awal sebelum proses ekspor dimulai. 
Properti [**Errors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/errors/) dalam
 objek [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/) digunakan untuk menyimpan pesan tentang mereka.
Properti [**IgnoreErrors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/ignoreerrors/) berguna untuk memutuskan apakah 
diperlukan untuk melempar pengecualian pada kesalahan pemuatan atau tidak. 

Berikut adalah contoh penggunaan properti Errors:

{{< gist aspose-com-gists b4f8af514a57a37e260cf1128011d34d "Errors-in-load-options.cs">}}
