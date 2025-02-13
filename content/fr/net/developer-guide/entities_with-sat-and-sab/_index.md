---
title: Entités avec une structure SAT/SAB
type: docs
weight: 40
url: /fr/net/developer-guide/entities_with-sat-and-sab/
---

## **Entités avec une structure SAT/SAB**

Certaines entités stockent leurs données structurelles dans le format ACIS SAT/SAB. Ces entités peuvent être partiellement exportées en mode filaire 2D. Les entités prises en charge incluent :

* objets 3DSOLID : boîte, sphère, pyramide, coin, cône, cylindre, tore, polysolid
* SURFACE : plane, extrudée, révolutionnée, balayée
* RÉGION

Voici un exemple du résultat d'exportation (fichier DWG sur la partie gauche, résultat PDF sur la partie droite).

![Export de cône et de sphères](/_assets/guide/coneAndSpheres.png)

Exporter des entités ACIS ne nécessite aucune option spéciale. Pour optimiser la taille du dessin, en particulier lorsque le dessin contient exclusivement des entités ACIS, envisagez d'utiliser la fonction cadImage.UpdateSize() pour ajuster avec précision les dimensions initiales du dessin.

```csharp
using (CadImage cadImage = (CadImage)Image.Load(sourceFilePath))
{
	cadImage.UpdateSize();
	
	CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
	rasterizationOptions.Layouts = new string[] { "Modèle" };

	PdfOptions pdfOptions = new PdfOptions
	{
		VectorRasterizationOptions = rasterizationOptions
	};
	cadImage.Save("output.pdf", pdfOptions);
}
```
