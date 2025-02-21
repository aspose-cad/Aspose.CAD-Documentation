---
title: Entiteter med SAT/SAB-struktur
type: docs
weight: 40
url: /sv/net/developer-guide/entities_with-sat-and-sab/
---

## **Entiteter med SAT/SAB-struktur**

Vissa entiteter lagrar sin strukturella data i ACIS SAT/SAB-formatet. Dessa entiteter kan delvis exporteras i 2D wireframe-läge. De stödda entiteterna inkluderar:

*	3DSOLID-objekt: låda, sfär, pyramid, kil, kon, cylinder, torus, polysolid
*	YTA: plan, extruderad, roterad, svept
*	REGION

Nedan är ett exempel på exportresultat (DWG-fil på vänster sida, PDF-resultat på höger sida).

![Export av kon och sfärer](/_assets/guide/coneAndSpheres.png)

Export av ACIS-entiteter kräver inga speciella alternativ. För att optimera ritningsstorleken, särskilt när ritningen enbart innehåller ACIS-entiteter, överväg att använda funktionen cadImage.UpdateSize() för att justera de initiala ritningsdimensionerna korrekt.

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
