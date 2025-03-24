---
title: SAT/SAB struktúrájú entitások
type: docs
weight: 40
url: /hu/net/developer-guide/entities_with-sat-and-sab/
---

## **SAT/SAB struktúrájú entitások**

Bizonyos entitások a szerkezeti adataikat ACIS SAT/SAB formátumban tárolják. Ezek az entitások részben exportálhatók 2D drótváz módban. A támogatott entitások a következők:

*	3DSOLID objektumok: doboz, gömb, piramis, ék, kúp, hengert, torus, poliszolid
*	FELÜLET: sík, kiemelt, forgatott, átsöpört
*	REGION

Az alábbiakban a példa az exportálás eredményéről (DWG fájl a bal oldalon, PDF eredmény a jobb oldalon).

![Kúp és gömbök exportálása](/cad/_assets/guide/coneAndSpheres.png)

Az ACIS entitások exportálása nem igényel különleges beállításokat. A rajzméret optimalizálása érdekében, különösen akkor, ha a rajz kizárólag ACIS entitásokat tartalmaz, érdemes használni a cadImage.UpdateSize() függvényt a kezdeti rajzméretek pontos beállításához.

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
