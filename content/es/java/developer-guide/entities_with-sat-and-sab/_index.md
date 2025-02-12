---
title: Entidades con estructura SAT/SAB
type: docs
weight: 40
url: /es/java/developer-guide/entities_with-sat-and-sab/
---

## **Entidades con estructura SAT/SAB**

Ciertas entidades almacenan sus datos estructurales en el formato ACIS SAT/SAB. Estas entidades se pueden exportar parcialmente en modo de wireframe 2D. Las entidades soportadas incluyen:

* objetos 3DSOLID: caja, esfera, pirámide, cuña, cono, cilindro, toro, polisólido
* SUPERFICIE: plana, extruida, revolucionada, barrida
* REGIÓN

A continuación se muestra un ejemplo del resultado de la exportación (archivo DWG en la parte izquierda, resultado en PDF en la parte derecha).

![Exportación de cono y esferas](/_assets/guide/coneAndSpheres.png)

La exportación de entidades ACIS no requiere opciones especiales. Para optimizar el tamaño del dibujo, especialmente cuando el dibujo contiene exclusivamente entidades ACIS, considere usar la función cadImage.updateSize() para ajustar las dimensiones iniciales del dibujo con precisión.

```java
CadImage cadImage = (CadImage)Image.load(sourceFilePath);

cadImage.updateSize();
	
CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
rasterizationOptions.setLayouts(new String[]{"Model"});

PdfOptions pdfOptions = new PdfOptions();
pdfOptions.setVectorRasterizationOptions(rasterizationOptions);

cadImage.save("output.pdf", pdfOptions);
```
