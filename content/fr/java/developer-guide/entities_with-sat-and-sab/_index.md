---
title: Entités avec structure SAT/SAB
type: docs
weight: 40
url: /fr/java/developer-guide/entities_with-sat-and-sab/
---

## **Entités avec structure SAT/SAB**

Certaines entités stockent leurs données structurelles au format ACIS SAT/SAB. Ces entités peuvent être partiellement exportées en mode filaire 2D. Les entités prises en charge comprennent :

* objets 3DSOLID : boîte, sphère, pyramide, cale, cône, cylindre, tore, polysolid
* SURFACE : planaire, extrudée, révolutionnée, balayée
* RÉGION

Ci-dessous se trouve un exemple de résultat d'exportation (fichier DWG sur la partie gauche, résultat PDF sur la droite).

![Exportation de cône et de sphères](/fr/_assets/guide/coneAndSpheres.png)

L'exportation d'entités ACIS ne nécessite aucune option spéciale. Pour optimiser la taille du dessin, surtout lorsque le dessin contient exclusivement des entités ACIS, envisagez d'utiliser la fonction cadImage.updateSize() pour ajuster avec précision les dimensions initiales du dessin.

```java
CadImage cadImage = (CadImage)Image.load(sourceFilePath);

cadImage.updateSize();
	
CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
rasterizationOptions.setLayouts(new String[]{"Modèle"});

PdfOptions pdfOptions = new PdfOptions();
pdfOptions.setVectorRasterizationOptions(rasterizationOptions);

cadImage.save("output.pdf", pdfOptions);
```
