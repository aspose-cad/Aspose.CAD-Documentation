---
title: Entità con struttura SAT/SAB
type: docs
weight: 40
url: /it/java/developer-guide/entities_with-sat-and-sab/
---

## **Entità con struttura SAT/SAB**

Alcune entità memorizzano i loro dati strutturali nel formato ACIS SAT/SAB. Queste entità possono essere esportate parzialmente in modalità wireframe 2D. Le entità supportate includono:

*	oggetti 3DSOLID: scatola, sfera, piramide, cuneo, cono, cilindro, toro, polysolid
*	SUPERFICIE: piana, estrusa, ruotata, spazzata
*	REGIONE

Di seguito è riportato un esempio del risultato dell'esportazione (file DWG nella parte sinistra, risultato PDF nella parte destra).

![Export of cone and spheres](/_assets/guide/coneAndSpheres.png)

L'esportazione delle entità ACIS non richiede opzioni speciali. Per ottimizzare le dimensioni del disegno, soprattutto quando il disegno contiene esclusivamente entità ACIS, considera di utilizzare la funzione cadImage.updateSize() per regolare accuratamente le dimensioni iniziali del disegno.

```java
CadImage cadImage = (CadImage)Image.load(sourceFilePath);

cadImage.updateSize();
	
CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
rasterizationOptions.setLayouts(new String[]{"Model"});

PdfOptions pdfOptions = new PdfOptions();
pdfOptions.setVectorRasterizationOptions(rasterizationOptions);

cadImage.save("output.pdf", pdfOptions);
```
