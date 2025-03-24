---
title: SAT/SAB yapısına sahip Varlıklar
type: docs
weight: 40
url: /tr/java/developer-guide/entities_with-sat-and-sab/
---

## **SAT/SAB yapısına sahip Varlıklar**

Bazı varlıklar, yapısal verilerini ACIS SAT/SAB formatında saklar. Bu varlıklar, 2D tel kafes modunda kısmen dışa aktarılabilir. Desteklenen varlıklar şunları içerir:

*	3DSOLID nesneleri: kutu, küre, piramit, yastık, koni, silindir, torus, polisolidi
*	YÜZEY: düzlem, çıkarılmış, döndürülmüş, taranmış
*	BÖLGE

Aşağıda dışa aktarma sonucunun bir örneği bulunmaktadır (sol tarafta DWG dosyası, sağ tarafta PDF sonucu).

![Koni ve kürelerin dışa aktarımı](/cad/_assets/guide/coneAndSpheres.png)

ACIS varlıklarını dışa aktarmak için herhangi bir özel seçenek gerekmemektedir. Özellikle çizim yalnızca ACIS varlıklarını içeriyorsa, başlangıç çizim boyutlarını doğru bir şekilde ayarlamak için cadImage.updateSize() fonksiyonunu kullanmayı düşünün.

```java
CadImage cadImage = (CadImage)Image.load(sourceFilePath);

cadImage.updateSize();
	
CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
rasterizationOptions.setLayouts(new String[]{"Model"});

PdfOptions pdfOptions = new PdfOptions();
pdfOptions.setVectorRasterizationOptions(rasterizationOptions);

cadImage.save("output.pdf", pdfOptions);
```
