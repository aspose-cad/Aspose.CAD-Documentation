---
title: Entitáty se strukturou SAT/SAB
type: docs
weight: 40
url: /cs/java/podpora-sat-sab/
---

## **Entitáty se strukturou SAT/SAB**

Některé entitáty ukládají svá strukturální data ve formátu ACIS SAT/SAB. Tyto entity lze částečně exportovat v režimu 2D drátěného modelu. Podporované entity zahrnují:

*	objekty 3DSOLID: box, sphere, pyramid, wedge, cone, cylinder, torus, polysolid
*	SURFACE: planární, extrudovaná, rotována, vytlačovaná
*	REGION

Níže je příklad exportního výsledku (soubor DWG v levé části, výsledek PDF v pravé části).

![Export kuželu a sfér](/_assets/coneAndSpheres.png)

Exportování entit ACIS nevyžaduje žádné speciální možnosti. Pro optimalizaci velikosti výkresu, zejména pokud výkres obsahuje výhradně entity ACIS, zvažte použití funkce cadImage.updateSize() k přesnému nastavení počátečních rozměrů výkresu.

```java
CadImage cadImage = (CadImage)Image.load(sourceFilePath);

cadImage.updateSize();
	
CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
rasterizationOptions.setLayouts(new String[]{"Model"});

PdfOptions pdfOptions = new PdfOptions();
pdfOptions.setVectorRasterizationOptions(rasterizationOptions);

cadImage.save("output.pdf", pdfOptions);
```
