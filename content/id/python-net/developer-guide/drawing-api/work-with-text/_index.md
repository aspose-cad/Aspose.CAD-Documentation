---
title: Bekerja dengan Teks
type: docs
weight: 40
url: /id/python-net/developer-guide/drawing-api/work-with-text/
---

## **Bekerja dengan Teks**

Hampir semua gambar mengandung objek teks dan contoh ini menunjukkan cara melakukan operasi dengan mereka. 
Ada berbagai jenis entitas untuk DWG/DXF yang dapat menyimpan teks, yaitu **CadText**, **CadMText**, CadAttDef, CadAttrib. Dua jenis terakhir biasanya terkait 
dengan **CadInsertObject** dan disimpan di dalamnya atau di blok yang sesuai.

Berikut adalah beberapa contoh yang menggambarkan operasi dengan teks.

### **Mencari teks**

Contoh ini menunjukkan cara menemukan nilai teks dalam file DWG/DXF dan juga dapat digunakan untuk mengganti nilai teks.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Search-for-text.py">}}
