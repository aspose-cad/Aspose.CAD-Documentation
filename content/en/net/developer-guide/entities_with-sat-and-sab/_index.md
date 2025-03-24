---
title: Entities with SAT/SAB structure
type: docs
weight: 40
url: /net/developer-guide/entities_with-sat-and-sab/
---

## **Entities with SAT/SAB structure**

Certain entities store their structural data in the ACIS SAT/SAB format. These entities can be partially exported in 2D wireframe mode. The supported entities include:

*	3DSOLID objects: box, sphere, pyramid, wedge, cone, cylinder, torus, polysolid
*	SURFACE: planar, extruded, revolved, swept
*	REGION

Below is the example of export result (DWG file on the left part, PDF result on the right).

![Export of cone and spheres](/cad/_assets/guide/coneAndSpheres.png)

Exporting ACIS entities does not require any special options. To optimize drawing size, especially when drawing contains ACIS entities exclusively, consider using the cadImage.UpdateSize() function to adjust the initial drawing dimensions accurately.

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
