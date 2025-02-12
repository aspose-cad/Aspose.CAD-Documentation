---
title: Entidades con estructura SAT/SAB
type: docs
weight: 40
url: /es/net/support-sat-sab/
---

## **Entidades con estructura SAT/SAB**

Ciertas entidades almacenan sus datos estructurales en el formato ACIS SAT/SAB. Estas entidades pueden ser exportadas parcialmente en modo de alambre 2D. Las entidades soportadas incluyen:

* objetos 3DSOLID: caja, esfera, pirámide, cuña, cono, cilindro, toro, polysolid
* SUPERFICIE: plana, extruida, revolucionada, barrida
* REGIÓN

A continuación se muestra un ejemplo del resultado de la exportación (archivo DWG en la parte izquierda, resultado PDF en la parte derecha).

![Exportación de cono y esferas](/_assets/guide/coneAndSpheres.png)

La exportación de entidades ACIS no requiere opciones especiales. Para optimizar el tamaño del dibujo, especialmente cuando el dibujo contiene exclusivamente entidades ACIS, considere utilizar la función cadImage.UpdateSize() para ajustar con precisión las dimensiones iniciales del dibujo.

```csharp
using (CadImage cadImage = (CadImage)Image.Load(sourceFilePath))
{
	cadImage.UpdateSize();
	
	CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
	rasterizationOptions.Layouts = new string[] { "Modelo" };

	PdfOptions pdfOptions = new PdfOptions
	{
		VectorRasterizationOptions = rasterizationOptions
	};
	cadImage.Save("output.pdf", pdfOptions);
}
```
