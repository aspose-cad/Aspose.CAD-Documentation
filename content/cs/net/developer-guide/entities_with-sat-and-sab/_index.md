---
title: Entitáty s SAT/SAB strukturou
type: docs
weight: 40
url: /cs/net/support-sat-sab/
---

## **Entitáty s SAT/SAB strukturou**

Určité entitáty ukládají svá strukturální data ve formátu ACIS SAT/SAB. Tyto entitáty lze částečně exportovat v režimu 2D drátěného modelu. Podporované entitáty zahrnují:

*	objekty 3DSOLID: box, sphere, pyramid, wedge, cone, cylinder, torus, polysolid
*	SURFACE: planární, extrudované, rotované, swept
*	REGION

Níže je příklad výsledku exportu (soubor DWG na levé straně, výsledek PDF na pravé straně).

![Export kuželů a sfér](/_assets/guide/coneAndSpheres.png)

Exportování entit ACIS nevyžaduje žádné speciální možnosti. Pro optimalizaci velikosti kresby, zejména pokud kresba obsahuje výhradně entity ACIS, zvažte použití funkce cadImage.UpdateSize() k přesné úpravě počátečních rozměrů kresby.

```csharp
using (CadImage cadImage = (CadImage)Image.Load(zdrojovySoubor))
{
	cadImage.UpdateSize();
	
	CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
	rasterizationOptions.Layouts = new string[] { "Model" };

	PdfOptions pdfOptions = new PdfOptions
	{
		VectorRasterizationOptions = rasterizationOptions
	};
	cadImage.Save("vystup.pdf", pdfOptions);
}
```
