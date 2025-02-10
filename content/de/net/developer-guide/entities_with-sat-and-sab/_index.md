---
title: Entities with SAT/SAB structure
type: docs
weight: 40
url: /de/net/support-sat-sab/
---

## **Entitäten mit SAT/SAB-Struktur**

Bestimmte Entitäten speichern ihre strukturellen Daten im ACIS SAT/SAB-Format. Diese Entitäten können teilweise im 2D-Drahtmodellmodus exportiert werden. Die unterstützten Entitäten umfassen:

*	3DSOLID-Objekte: Box, Kugel, Pyramide, Keil, Kegel, Zylinder, Torus, Polysolid
*	OBERFLÄCHE: planar, extrudiert, rotiert, gefegt
*	REGION

Im Folgenden sehen Sie ein Beispiel für das Exportergebnis (DWG-Datei auf der linken Seite, PDF-Ergebnis auf der rechten Seite).

![Export von Kegel und Kugeln](/_assets/coneAndSpheres.png)

Der Export von ACIS-Entitäten erfordert keine besonderen Optionen. Um die Zeichnungsgröße zu optimieren, insbesondere wenn die Zeichnung ausschließlich ACIS-Entitäten enthält, sollten Sie die Funktion cadImage.UpdateSize() verwenden, um die ursprünglichen Zeichnungsdimensionen genau anzupassen.

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
