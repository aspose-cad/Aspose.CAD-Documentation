---
title: Entitas dengan struktur SAT/SAB
type: docs
weight: 40
url: /id/net/developer-guide/entities_with-sat-and-sab/
---

## **Entitas dengan struktur SAT/SAB**

Entitas tertentu menyimpan data strukturnya dalam format ACIS SAT/SAB. Entitas ini dapat diekspor sebagian dalam mode wireframe 2D. Entitas yang didukung meliputi:

*	Objek 3DSOLID: kotak, bola, piramida, baji, kerucut, silinder, torus, polysolid
*	PERMUKAAN: datar, ekstrusi, diputar, disapu
*	AREA

Berikut adalah contoh hasil ekspor (file DWG di bagian kiri, hasil PDF di bagian kanan).

![Export of cone and spheres](/_assets/guide/coneAndSpheres.png)

Mengekspor entitas ACIS tidak memerlukan opsi khusus. Untuk mengoptimalkan ukuran gambar, terutama ketika gambar hanya mengandung entitas ACIS, pertimbangkan untuk menggunakan fungsi cadImage.UpdateSize() untuk menyesuaikan dimensi gambar awal secara akurat.

```csharp
using (CadImage cadImage = (CadImage)Image.Load(sourceFilePath))
{
	cadImage.UpdateSize();
	
	CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
	rasterizationOptions.Layouts = new string[] { "Model" };

	PdfOptions pdfOptions = new PdfOptions
	{
		VectorRasterizationOptions = rasterizationOptions
	};
	cadImage.Save("output.pdf", pdfOptions);
}
```
