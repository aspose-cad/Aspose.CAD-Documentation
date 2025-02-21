---
title: Encje z strukturą SAT/SAB
type: docs
weight: 40
url: /pl/net/developer-guide/entities_with-sat-and-sab/
---

## **Encje z strukturą SAT/SAB**

Niektóre encje przechowują swoje dane strukturalne w formacie ACIS SAT/SAB. Te encje mogą być częściowo eksportowane w trybie 2D wireframe. Obsługiwane encje obejmują:

*	Obiekty 3DSOLID: skrzynka, kula, piramida, klocek, stożek, cylinder, torus, poligonalny
*	POWIERZCHNIA: płaska, wyciągnięta, obrócona, przetransportowana
*	OBSZAR

Poniżej znajduje się przykład wyniku eksportu (plik DWG po lewej stronie, wynik PDF po prawej stronie).

![Eksport stożka i kul](/_assets/guide/coneAndSpheres.png)

Eksportowanie encji ACIS nie wymaga żadnych specjalnych opcji. Aby zoptymalizować rozmiar rysunku, zwłaszcza gdy rysunek zawiera wyłącznie encje ACIS, warto rozważyć użycie funkcji cadImage.UpdateSize(), aby dokładnie dostosować początkowe wymiary rysunku.

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
