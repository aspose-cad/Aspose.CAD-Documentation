---
title: Entitások SAT/SAB struktúrával
type: docs
weight: 40
url: /hu/java/developer-guide/entities_with-sat-and-sab/
---

## **Entitások SAT/SAB struktúrával**

Bizonyos entitások az ACIS SAT/SAB formátumban tárolják struktúrájuk adatait. Ezek az entitások részben exportálhatók 2D drótvázas módban. A támogatott entitások közé tartoznak:

*	3DSOLID objektumok: doboz, gömb, piramis, ék, kúp, henger, torusz, polysolid
*	FELÜLET: sík, extrudált, forogtatott, átfúvatott
*	REGION

Alább látható az exportálási eredmény példája (DWG fájl a bal oldalon, PDF eredmény a jobb oldalon).

![Kúp és gömbök exportálása](/cad/_assets/guide/coneAndSpheres.png)

Az ACIS entitások exportálása nem igényel különálló beállításokat. A rajz méretének optimalizálása érdekében, különösen ha a rajz kizárólag ACIS entitásokat tartalmaz, érdemes megfontolni a cadImage.updateSize() függvény használatát a kezdeti rajzdimenziók pontos beállításához.

```java
CadImage cadImage = (CadImage)Image.load(sourceFilePath);

cadImage.updateSize();
	
CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
rasterizationOptions.setLayouts(new String[]{"Model"});

PdfOptions pdfOptions = new PdfOptions();
pdfOptions.setVectorRasterizationOptions(rasterizationOptions);

cadImage.save("output.pdf", pdfOptions);
```
