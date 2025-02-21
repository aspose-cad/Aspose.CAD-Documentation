---
title: Entiteiten met SAT/SAB-structuur
type: docs
weight: 40
url: /nl/java/developer-guide/entities_with-sat-and-sab/
---

## **Entiteiten met SAT/SAB-structuur**

Bepaalde entiteiten slaan hun structurele gegevens op in het ACIS SAT/SAB-formaat. Deze entiteiten kunnen gedeeltelijk worden geëxporteerd in 2D-wireframe modus. De ondersteunde entiteiten zijn onder andere:

*	3DSOLID-objecten: box, bol, piramide, wig, kegel, cilinder, torus, polysolid
*	VLAK: vlak, geëxtrudeerd, gedraaid, geveegd
*	REGIO

Hieronder is een voorbeeld van het exportresultaat (DWG-bestand aan de linkerkant, PDF-resultaat aan de rechterkant).

![Export van kegel en bollen](/_assets/guide/coneAndSpheres.png)

Het exporteren van ACIS-entiteiten vereist geen speciale opties. Om de tekenafmetingen te optimaliseren, vooral wanneer de tekening uitsluitend ACIS-entiteiten bevat, overweeg dan om de functie cadImage.updateSize() te gebruiken om de beginafmetingen van de tekening nauwkeurig aan te passen.

```java
CadImage cadImage = (CadImage)Image.load(sourceFilePath);

cadImage.updateSize();
	
CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
rasterizationOptions.setLayouts(new String[]{"Model"});

PdfOptions pdfOptions = new PdfOptions();
pdfOptions.setVectorRasterizationOptions(rasterizationOptions);

cadImage.save("output.pdf", pdfOptions);
```
