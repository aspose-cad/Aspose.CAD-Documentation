---
title: SAT/SAB yapısına sahip Varlıklar
type: docs
weight: 40
url: /tr/net/developer-guide/entities_with-sat-and-sab/
---

## **SAT/SAB yapısına sahip Varlıklar**

Belirli varlıklar, yapısal verilerini ACIS SAT/SAB formatında saklar. Bu varlıklar, 2D tel çerçeve modunda kısmen dışa aktarılabilir. Desteklenen varlıklar şunları içerir:

*	3DSOLID nesneleri: kutu, küre, piramit, kama, koni, silindir, torus, polisolidi
*	YÜZEY: düz, ektrüde, döner, taranmış
*	BÖLGE

Aşağıda dışa aktarma sonucunun bir örneği bulunmaktadır (sol tarafta DWG dosyası, sağ tarafta PDF sonucu).

![Koni ve kürelerin dışa aktarımı](/_assets/guide/coneAndSpheres.png)

ACIS varlıklarını dışa aktarmak için özel bir seçenek gerekmemektedir. Özellikle çizim yalnızca ACIS varlıklarını içeriyorsa, başlangıç çizim boyutlarını doğru bir şekilde ayarlamak için cadImage.UpdateSize() işlevini kullanmayı düşünün.

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
