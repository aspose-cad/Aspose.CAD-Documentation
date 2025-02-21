---
title: Entitas dengan struktur SAT/SAB
type: docs
weight: 40
url: /id/java/developer-guide/entities_with-sat-and-sab/
---

## **Entitas dengan struktur SAT/SAB**

Entitas tertentu menyimpan data struktural mereka dalam format ACIS SAT/SAB. Entitas ini dapat diekspor sebagian dalam mode wireframe 2D. Entitas yang didukung meliputi:

*	Objek 3DSOLID: kotak, bola, piramida, sumbat, kerucut, silinder, torus, polisolid
*	PERMUKAAN: datar, ekstrusi, dibalik, disapu
*	DAERAH

Berikut adalah contoh hasil ekspor (file DWG di sisi kiri, hasil PDF di sisi kanan).

![Ekspor kerucut dan bola](/_assets/guide/coneAndSpheres.png)

Mengekspor entitas ACIS tidak memerlukan opsi khusus. Untuk mengoptimalkan ukuran gambar, terutama ketika gambar hanya berisi entitas ACIS, pertimbangkan untuk menggunakan fungsi cadImage.updateSize() untuk menyesuaikan dimensi gambar awal dengan akurat.

```java
CadImage cadImage = (CadImage)Image.load(sourceFilePath);

cadImage.updateSize();
	
CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
rasterizationOptions.setLayouts(new String[]{"Model"});

PdfOptions pdfOptions = new PdfOptions();
pdfOptions.setVectorRasterizationOptions(rasterizationOptions);

cadImage.save("output.pdf", pdfOptions);
```
