---
title: Entiteiten met SAT/SAB-structuur
type: docs
weight: 40
url: /nl/net/developer-guide/entities_with-sat-and-sab/
---

## **Entiteiten met SAT/SAB-structuur**

Bepaalde entiteiten slaan hun structurele gegevens op in het ACIS SAT/SAB-formaat. Deze entiteiten kunnen gedeeltelijk worden geëxporteerd in 2D-draadmodelmodus. De ondersteunde entiteiten omvatten:

*	3DSOLID-objecten: doos, bol, piramide, wig, kegel, cilinder, torus, polysolid
*	OPPERVLAKTE: vlak, geëxtrudeerd, gedraaid, geveegd
*	REGIO

Hieronder is een voorbeeld van het exportresultaat (DWG-bestand aan de linkerkant, PDF-resultaat aan de rechterkant).

![Export van kegel en bollen](/_assets/guide/coneAndSpheres.png)

Het exporteren van ACIS-entiteiten vereist geen speciale opties. Om de grootte van de tekening te optimaliseren, vooral wanneer de tekening uitsluitend ACIS-entiteiten bevat, overweeg dan het gebruik van de cadImage.UpdateSize() functie om de beginafmetingen van de tekening nauwkeurig aan te passen.

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
