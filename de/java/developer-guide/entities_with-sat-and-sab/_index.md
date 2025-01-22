---
title: Entitäten mit SAT/SAB-Struktur
type: docs
weight: 40
url: /de/java/support-sat-sab/
---

## **Entitäten mit SAT/SAB-Struktur**

Bestimmte Entitäten speichern ihre Strukturdaten im ACIS SAT/SAB-Format. Diese Entitäten können teilweise im 2D-Drahtgittermodus exportiert werden. Die unterstützten Entitäten umfassen:

* 3DSOLID-Objekte: Kasten, Kugel, Pyramide, Keil, Kegel, Zylinder, Torus, Polyeder
* FLÄCHE: eben, extrudiert, rotiert, geschoben
* REGION

Im Folgenden finden Sie ein Beispiel für das Exportergebnis (DWG-Datei auf dem linken Teil, PDF-Ergebnis auf der rechten Seite).

![Export von Kegel und Kugeln](coneAndSpheres.png)

Die Exportierung von ACIS-Entitäten erfordert keine speziellen Optionen. Um die Zeichnungsgröße zu optimieren, insbesondere wenn die Zeichnung ausschließlich ACIS-Entitäten enthält, sollten Sie die Funktion cadImage.updateSize() verwenden, um die anfänglichen Zeichnungsabmessungen genau anzupassen.

```java
CadImage cadImage = (CadImage)Image.load(sourceFilePath);

cadImage.updateSize();

CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
rasterizationOptions.setLayouts(new String[]{"Model"});

PdfOptions pdfOptions = new PdfOptions();
pdfOptions.setVectorRasterizationOptions(rasterizationOptions);

cadImage.save("output.pdf", pdfOptions);
```
