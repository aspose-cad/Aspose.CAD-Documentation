---
title: Entities with SAT/SAB structure
type: docs
weight: 40
url: /java/support-sat-sab/
---

## **Entities with SAT/SAB structure**

Certain entities store their structural data in the ACIS SAT/SAB format. These entities can be partially exported in 2D wireframe mode. The supported entities include:

*	3DSOLID objects: box, sphere, pyramid, wedge, cone, cylinder, torus, polysolid
*	SURFACE: planar, extruded, revolved, swept
*	REGION

Below is the example of export result (DWG file on the left part, PDF result on the right).

![Export of cone and spheres](/_assets/coneAndSpheres.png)

Exporting ACIS entities does not require any special options. To optimize drawing size, especially when drawing contains ACIS entities exclusively, consider using the cadImage.updateSize() function to adjust the initial drawing dimensions accurately.

```java
CadImage cadImage = (CadImage)Image.load(sourceFilePath);

cadImage.updateSize();
	
CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
rasterizationOptions.setLayouts(new String[]{"Model"});

PdfOptions pdfOptions = new PdfOptions();
pdfOptions.setVectorRasterizationOptions(rasterizationOptions);

cadImage.save("output.pdf", pdfOptions);
```
