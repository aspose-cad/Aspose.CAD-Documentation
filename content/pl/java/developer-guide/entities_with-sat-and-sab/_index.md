---
title: Encje z strukturą SAT/SAB
type: docs
weight: 40
url: /pl/java/developer-guide/entities_with-sat-and-sab/
---

## **Encje z strukturą SAT/SAB**

Niektóre encje przechowują swoje dane strukturalne w formacie ACIS SAT/SAB. Te encje mogą być częściowo eksportowane w trybie siatki 2D. Obsługiwane encje obejmują:

*	Obiekty 3DSOLID: pudełko, kula, piramida, klin, stożek, cylinder, torus, polisolida
*	Powierzchnie: płaska, wyciągnięta, obrócona, przesunięta
*	Region

Poniżej znajduje się przykład wyniku eksportu (plik DWG po lewej stronie, wynik PDF po prawej).

![Export stożka i kul](/_assets/guide/coneAndSpheres.png)

Eksportowanie encji ACIS nie wymaga żadnych specjalnych opcji. Aby zoptymalizować rozmiar rysunku, szczególnie gdy rysunek zawiera wyłącznie encje ACIS, rozważ użycie funkcji cadImage.updateSize() w celu dokładnego dostosowania początkowych wymiarów rysunku.

```java
CadImage cadImage = (CadImage)Image.load(sourceFilePath);

cadImage.updateSize();
	
CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
rasterizationOptions.setLayouts(new String[]{"Model"});

PdfOptions pdfOptions = new PdfOptions();
pdfOptions.setVectorRasterizationOptions(rasterizationOptions);

cadImage.save("output.pdf", pdfOptions);
```
