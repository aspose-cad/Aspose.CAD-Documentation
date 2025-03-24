---
title: Entiteter med SAT/SAB-struktur
type: docs
weight: 40
url: /sv/java/developer-guide/entities_with-sat-and-sab/
---

## **Entiteter med SAT/SAB-struktur**

Vissa entiteter lagrar sina strukturella data i ACIS SAT/SAB-formatet. Dessa entiteter kan delvis exporteras i 2D-wireframe-läge. De stödda entiteterna inkluderar:

*	3DSOLID-objekt: box, sfär, pyramid, kil, kon, cylinder, torus, polysolid
*	YTA: plan, extruderad, roterad, svept
*	REGION

Nedan är ett exempel på exportresultatet (DWG-fil till vänster, PDF-resultat till höger).

![Export av kon och sfärer](/cad/_assets/guide/coneAndSpheres.png)

Export av ACIS-entiteter kräver inga speciella alternativ. För att optimera ritningens storlek, särskilt när ritningen endast innehåller ACIS-entiteter, överväg att använda funktionen cadImage.updateSize() för att justera de initiala ritningsmåtten korrekt.

```java
CadImage cadImage = (CadImage)Image.load(sourceFilePath);

cadImage.updateSize();
	
CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
rasterizationOptions.setLayouts(new String[]{"Model"});

PdfOptions pdfOptions = new PdfOptions();
pdfOptions.setVectorRasterizationOptions(rasterizationOptions);

cadImage.save("output.pdf", pdfOptions);
```
